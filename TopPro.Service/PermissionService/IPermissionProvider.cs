using System.Collections.Generic;
using TopPro.Domain.Model;
namespace TopPro.Service.PermissionService
{
    public interface IPermissionProvider
    {
        /// <summary>
        /// Get permissions
        /// </summary>
        /// <returns>Permissions</returns>
        IEnumerable<PermissionRecord> GetPermissions();

        IEnumerable<PermissionAction> GetActionPermissions();

        /// <summary>
        /// Get default permissions
        /// </summary>
        /// <returns>Default permissions</returns>
    }
}
