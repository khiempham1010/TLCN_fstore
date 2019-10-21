var productcontroller = function () {
    this.initialize = function () {
        loadCategories();
        loadData();
        registerEvents();
    }
    function registerEvents() {
        //todo: binding events to controls
        $('#ddlShowPage').on('change', function () {
            atom.configs.pageSize = $(this).val();
            atom.configs.pageIndex = 1;
            loadData(true);
        });
        $('#ddlCategorySearch').change(function () {
            loadData();
        });
        $('#btnSearch').on('click', function () {
            loadData();
        });
        $('#txtkeyword').on('keypress', function (e) {
            if (e.which === 13) {
                loadData();
            }
        })
    }
    function loadCategories(){
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAllCategories',
            dataType: 'json',
            success: function (response) {
                var render = "<option value=''>--Select category--</option>";
                $.each(response, function (i, item) {
                    render += "<option value='" + item.Id + "'>" + item.Name + "</option>"
                });
                $('#ddlCategorySearch').html(render);
            },
            error: function (status) {
                console.log(status);
                atom.notify('Cannot loading product category data', 'error');
            }
        });
    }
    function loadData(isPageChanged) {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            data: {
                categoryId: $('#ddlCategorySearch').val(),
                keyWord: $('#txtkeyword').val(),
                page: atom.configs.pageIndex,
                pageSize:atom.configs.pageSize
            },
            url: '/admin/product/GetAllPaging',
            DataType: 'json',
            success: function (response) {
                $.each(response.Results, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : 'm<img src="' + item.Image + '" width=25 />',
                        CategoryName: item.ProductCategory.Name,
                        Price: atom.formatNumber(item.Price,0),
                        CreatedDate: atom.dateTimeFormatJson(item.DateCreated),
                        Status: atom.getStatus(item.status)
                    });
                    $('#lblTotalRecords').text(response.RowCount);
                    if (render!=''){
                        $('#tbl-content').html(render);
                    }
                    wrapPaging(response.RowCount, function () {
                        loadData()
                    }, isPageChanged);
                });
            },
            error: function (status) {
                console.log(status);
                atom.notify('Cannot loading data', 'error');
            }
        })
    }

    function wrapPaging(RecordCount, callBack, changPageSize) {
        var totalSize = Math.ceil(RecordCount / atom.configs.pageSize);
        if ($('#paginationUL a').length === 0 || changPageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        $('#paginationUL').twbsPagination({
            totalPages: totalSize,
            visiblePages: 7,
            first: 'first',
            prev: 'prev',
            next: 'next',
            last: 'last',
            onPageClick: function (event, p) {
                atom.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}