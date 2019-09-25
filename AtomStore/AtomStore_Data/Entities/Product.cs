using AtomStore.Data.Enums;
using AtomStore.Data.Interfaces;
using AtomStore.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtomStore.Data.Entities
{
    public class Product : DomainEntity<int>, ISwitchable, IHasSoftDelete, IHasSeoMetaData, IDateTracking
    {
        public string Name { get; set; }
        public int Categoryid { get; set; }
        public decimal Price { get; set; }
        public Status Status { set; get; }
        public bool IsDeleted { set; get; }
        public string SeoPageTitle { set; get; }
        public string SelAlias { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModifiled { set; get; }
    }
}
