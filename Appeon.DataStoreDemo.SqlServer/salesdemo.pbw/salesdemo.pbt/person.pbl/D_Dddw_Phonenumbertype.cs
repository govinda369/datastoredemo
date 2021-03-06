using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_phonenumbertype", DwStyle.Grid)]
    [Table("PhoneNumberType", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.PhoneNumberType\" ) COLUMN(NAME=\"Person.PhoneNumberType.PhoneNumberTypeID\") COLUMN(NAME=\"Person.PhoneNumberType.Name\")) ")]
    #endregion
    [DwSort("phonenumbertypeid A ")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Phonenumbertype
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Phonenumbertypeid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Name { get; set; }

    }

}
