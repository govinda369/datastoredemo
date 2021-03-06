using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_shipmethod", DwStyle.Grid)]
    [Table("ShipMethod", Schema = "Purchasing")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Purchasing.ShipMethod\" ) COLUMN(NAME=\"Purchasing.ShipMethod.ShipMethodID\") COLUMN(NAME=\"Purchasing.ShipMethod.Name\") COLUMN(NAME=\"Purchasing.ShipMethod.ShipBase\") COLUMN(NAME=\"Purchasing.ShipMethod.ShipRate\")) ")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Dddw_Shipmethod
    {
        [Identity]
        [Key]
        public int Shipmethodid { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0.00))")]
        public decimal Shipbase { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0.00))")]
        public decimal Shiprate { get; set; }

    }

}
