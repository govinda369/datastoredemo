using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_subcategory", DwStyle.Grid)]
    [Table("ProductSubcategory", Schema = "Production")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.productsubcategory\" ) COLUMN(NAME=\"production.productsubcategory.productsubcategoryid\") COLUMN(NAME=\"production.productsubcategory.productcategoryid\") COLUMN(NAME=\"production.productsubcategory.name\")) ")]
    #endregion
    [DwSort("productcategoryid A productsubcategoryid A ")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Dddw_Subcategory
    {
        [Identity]
        [Key]
        public int Productsubcategoryid { get; set; }

        [ConcurrencyCheck]
        public int Productcategoryid { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

    }

}
