using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_salesterritory", DwStyle.Grid)]
    [Table("SalesTerritory", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SalesTerritory\" )  TABLE(NAME=\"Person.CountryRegion\" ) COLUMN(NAME=\"Sales.SalesTerritory.TerritoryID\") COLUMN(NAME=\"Sales.SalesTerritory.Name\") COLUMN(NAME=\"Sales.SalesTerritory.CountryRegionCode\") COLUMN(NAME=\"Sales.SalesTerritory.Group\") COLUMN(NAME=\"Person.CountryRegion.Name\")    JOIN (LEFT=\"Person.CountryRegion.CountryRegionCode\"    OP =\"=\"RIGHT=\"Sales.SalesTerritory.CountryRegionCode\" )) ")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Salesterritory
    {
        [Identity]
        [PropertySave(SaveStrategy.Ignore)]
        public int Salesterritory_Territoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Salesterritory_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Salesterritory_Countryregioncode { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Salesterritory_Group { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Countryregion_Name { get; set; }

    }

}
