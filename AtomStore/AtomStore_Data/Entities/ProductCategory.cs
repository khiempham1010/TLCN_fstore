using AtomStore.Data.Enums;
using AtomStore.Data.Interfaces;
using AtomStore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtomStore.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable,ISortable,IDateTracking
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool HomeFlag { get; set; }
        public string SeoPageTitle { set; get; }
        public string SelAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public Status Status { set; get; }
        public int SortOder { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModifiled { set; get; }

    }
}
