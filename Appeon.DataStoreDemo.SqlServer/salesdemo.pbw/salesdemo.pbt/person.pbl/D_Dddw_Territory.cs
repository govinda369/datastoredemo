using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_territory", DwStyle.Grid)]
    [Table("SalesTerritory", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SalesTerritory\" ) COLUMN(NAME=\"Sales.SalesTerritory.TerritoryID\") COLUMN(NAME=\"Sales.SalesTerritory.Name\")) ")]
    #endregion
    [DwSort("territoryid A ")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Territory
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Territoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Name { get; set; }

    }

}
