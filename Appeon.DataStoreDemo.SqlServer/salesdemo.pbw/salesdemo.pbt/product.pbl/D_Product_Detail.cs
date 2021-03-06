using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_product_detail", DwStyle.Default)]
    [Table("Product", Schema = "Production")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.product\" ) COLUMN(NAME=\"production.product.productid\") COLUMN(NAME=\"production.product.name\") COLUMN(NAME=\"production.product.productnumber\") COLUMN(NAME=\"production.product.makeflag\") COLUMN(NAME=\"production.product.color\") COLUMN(NAME=\"production.product.safetystocklevel\") COLUMN(NAME=\"production.product.reorderpoint\") COLUMN(NAME=\"production.product.standardcost\") COLUMN(NAME=\"production.product.listprice\") COLUMN(NAME=\"production.product.size\") COLUMN(NAME=\"production.product.sizeunitmeasurecode\") COLUMN(NAME=\"production.product.weightunitmeasurecode\") COLUMN(NAME=\"production.product.weight\") COLUMN(NAME=\"production.product.daystomanufacture\") COLUMN(NAME=\"production.product.productline\") COLUMN(NAME=\"production.product.class\") COLUMN(NAME=\"production.product.style\") COLUMN(NAME=\"production.product.productsubcategoryid\") COLUMN(NAME=\"production.product.productmodelid\") COLUMN(NAME=\"production.product.sellstartdate\") COLUMN(NAME=\"production.product.sellenddate\") COLUMN(NAME=\"production.product.modifieddate\") COLUMN(NAME=\"production.product.finishedgoodsflag\")WHERE(    EXP1 =\"production.product.productid\"   OP =\"=\"    EXP2 =\":al_productid\" ) ) ARG(NAME = \"al_productid\" TYPE = number) ")]
    #endregion
    [DwParameter("al_productid", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Product_Detail
    {
        [Identity]
        [Key]
        [DefaultValue("0")]
        public int Productid { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

        [ConcurrencyCheck]
        public string Productnumber { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((1))")]
        public bool Makeflag { get; set; }

        [ConcurrencyCheck]
        public string Color { get; set; }

        [ConcurrencyCheck]
        [DefaultValue("10")]
        public int Safetystocklevel { get; set; }

        [ConcurrencyCheck]
        [DefaultValue("10")]
        public int Reorderpoint { get; set; }

        [ConcurrencyCheck]
        public decimal Standardcost { get; set; }

        [ConcurrencyCheck]
        public decimal Listprice { get; set; }

        [ConcurrencyCheck]
        public string Size { get; set; }

        [ConcurrencyCheck]
        [DwChild("Unitmeasurecode", "Name", typeof(D_Dddw_Unit))]
        public string Sizeunitmeasurecode { get; set; }

        [ConcurrencyCheck]
        [DwChild("Unitmeasurecode", "Name", typeof(D_Dddw_Unit))]
        public string Weightunitmeasurecode { get; set; }

        [ConcurrencyCheck]
        public decimal? Weight { get; set; }

        [ConcurrencyCheck]
        public int Daystomanufacture { get; set; }

        [ConcurrencyCheck]
        public string Productline { get; set; }

        [ConcurrencyCheck]
        public string Class { get; set; }

        [ConcurrencyCheck]
        public string Style { get; set; }

        [ConcurrencyCheck]
        [DwChild("Productsubcategoryid", "Name", typeof(D_Dddw_Subcategory))]
        public int? Productsubcategoryid { get; set; }

        [ConcurrencyCheck]
        public int? Productmodelid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public DateTime Sellstartdate { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public DateTime? Sellenddate { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("0")]
        public bool Finishedgoodsflag { get; set; }

    }

}
