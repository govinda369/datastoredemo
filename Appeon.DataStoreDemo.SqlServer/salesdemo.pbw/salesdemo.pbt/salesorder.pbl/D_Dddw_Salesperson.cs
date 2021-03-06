using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_salesperson", DwStyle.Grid)]
    [Table("SalesPerson", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("SELECT Sales.SalesPerson.businessentityid, "
                  + "Person.Person.title, "
                  + "Person.Person.firstname, "
                  + "Person.Person.middlename, "
                  + "Person.Person.lastname, "
                  + "Person.Person.suffix "
                  + "FROM Sales.SalesPerson  , "
                  + "Person.Person "
                  + "WHERE ( Sales.SalesPerson.BusinessEntityID = Person.Person.BusinessEntityID )")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Salesperson
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Salesperson_Businessentityid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Firstname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Middlename { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Lastname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Suffix { get; set; }

        [DwCompute(" person_lastname + \" \" +  person_middlename  + \" \" +  person_firstname ")]
        public object Full_Name { get; set; }

    }

}
