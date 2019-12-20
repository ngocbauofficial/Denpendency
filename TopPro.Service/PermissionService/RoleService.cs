using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain;
using TopPro.Domain.Model;

namespace TopPro.Service.PermissionService
{
   partial class RoleService : IRoleService
    {
        private readonly IRepository<SecurityLevel> _rolerService;
        public RoleService(IRepository<SecurityLevel> rolerService)
        {
            this._rolerService = rolerService;
        }
        public virtual SecurityLevel GetRoleById(string id)
        {
            var model = from a in _rolerService.Table where a.Id == id select a;
            var securitylever = model.FirstOrDefault();
            return securitylever;
          }
    }
}
