using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("DimSalesTerritory")]
    public class SalesTerritory
    {
       
        public int SalesTerritoryKey { set; get; }

        [Required(ErrorMessage = "This field is required")]
        public int SalesTerritoryAlternateKey { set; get; }

        [Required(ErrorMessage = "This field is required")]
        public string SalesTerritoryRegion { set; get; }

        [Required(ErrorMessage = "This field is required")]
        public string SalesTerritoryCountry { set; get; }

        [Required(ErrorMessage = "This field is required")]
        public string SalesTerritoryGroup { set; get; }
    }
}