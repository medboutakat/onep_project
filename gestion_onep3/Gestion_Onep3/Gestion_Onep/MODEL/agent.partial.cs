using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Onep.MODEL
{
    enum RoleEnum { AdminId=1, User }
    partial class agent
    {
        public bool IsAdmin
        {
            get
            {
                return this.Role_Id.Equals((int)RoleEnum.AdminId);
            }
        }
    }
}
