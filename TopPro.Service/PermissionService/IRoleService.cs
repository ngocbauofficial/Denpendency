using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain.Model;

namespace TopPro.Service.PermissionService
{
   partial interface IRoleService
    {
        SecurityLevel GetRoleById(string Id);
    }
}
