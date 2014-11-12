using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceAdmin" in both code and config file together.
    [ServiceContract]
    public interface IServiceAdmin
    {
        [OperationContract]
        List<admin> GetAdmin();
    }
}
