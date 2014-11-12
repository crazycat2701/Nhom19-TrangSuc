using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTrangsuc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAdmin" in both code and config file together.
    public class ServiceAdmin : IServiceAdmin
    {
        dewEntities db = new dewEntities();
        public List<admin> GetAdmin()
        {
            return db.admins.ToList();
        }
    }
}
