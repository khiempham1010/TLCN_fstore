#pragma checksum "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f9c3c96143486b79107d1f9bfcf2b6f21d6607"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\_ViewImports.cshtml"
using AtomStore.Models;

#line default
#line hidden
#line 3 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\_ViewImports.cshtml"
using AtomStore.Models.AccountViewModels;

#line default
#line hidden
#line 4 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\_ViewImports.cshtml"
using AtomStore.Models.ManageViewModels;

#line default
#line hidden
#line 5 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\_ViewImports.cshtml"
using AtomStore.Data.Entities;

#line default
#line hidden
#line 6 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\_ViewImports.cshtml"
using AtomStore.Application.ViewModels.System;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f9c3c96143486b79107d1f9bfcf2b6f21d6607", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682dea3694fb3b9a428ecb56788b7747d83ae178", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FunctionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 156, true);
            WriteLiteral("\r\n<div class=\"collapse navbar-collapse\" id=\"bs-example-navbar-collapse-1\">\r\n    <ul class=\"sidebar-menu\">\r\n        <li class=\"header\">MAIN NAVIGATION</li>\r\n");
            EndContext();
#line 6 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
         foreach (var item in Model.Where(x => string.IsNullOrEmpty(x.ParentId)))
        {

#line default
#line hidden
            BeginContext(282, 87, true);
            WriteLiteral("            <li class=\"treeview\">\r\n                <a href=\"#\">\r\n                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 369, "\"", 393, 2);
            WriteAttributeValue("", 377, "fa", 377, 2, true);
#line 10 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue(" ", 379, item.IconCss, 380, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(394, 33, true);
            WriteLiteral("></i>\r\n                    <span>");
            EndContext();
            BeginContext(428, 9, false);
#line 11 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(437, 97, true);
            WriteLiteral(" </span>\r\n                    <i class=\"fa fa-angle-left pull-right\"></i>\r\n                </a>\r\n");
            EndContext();
#line 14 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                 if (Model.Any(x => x.ParentId == item.Id))
                {

#line default
#line hidden
            BeginContext(614, 48, true);
            WriteLiteral("                    <ul class=\"treeview-menu\">\r\n");
            EndContext();
#line 17 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                         foreach (var jitem in Model.Where(x => x.ParentId == item.Id))
                        {

#line default
#line hidden
            BeginContext(778, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 812, "\"", 829, 1);
#line 19 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 819, jitem.URL, 819, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(830, 35, true);
            WriteLiteral("><i class=\"fa fa-angle-right\"></i> ");
            EndContext();
            BeginContext(866, 10, false);
#line 19 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                                                  Write(jitem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(876, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 20 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(914, 31, true);
            WriteLiteral("\r\n\r\n                    </ul>\r\n");
            EndContext();
#line 24 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(964, 19, true);
            WriteLiteral("            </li>\r\n");
            EndContext();
#line 26 "E:\TLCN\git\TLCN_fstore\AtomStore\AtomStore\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(994, 17, true);
            WriteLiteral("    </ul>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FunctionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591