using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_person_filter", DwStyle.Default)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Person_Filter
    {
        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Persontype", "Typedesc", typeof(D_Dddw_Persontype))]
        public string Persontype { get; set; }

    }

}
