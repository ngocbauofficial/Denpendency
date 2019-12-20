using System.Collections.Generic;
using TopPro.Domain.Model;
namespace TopPro.Service.PermissionService
{
    public partial class StandardPermissionProvider : IPermissionProvider
    {
        public static readonly PermissionRecord Master = new PermissionRecord { Name = "Master area", SystemName = "AccessMaster", Category = "Area" };
        public static readonly PermissionRecord SalePurchaseMaster = new PermissionRecord { Name = "Master area. SalePurchaseMaster", SystemName = "SalePurchaseMaster", Category = "Master" };
        public static readonly PermissionRecord UserMaster = new PermissionRecord { Name = "Master area. Manage UserMaster", SystemName = "UserMaster", Category = "Master" };
        public static readonly PermissionRecord UserIdMaster = new PermissionRecord { Name = "Master area. Manage UserIdMaster", SystemName = "UserIdMaster", Category = "Master" };
        public static readonly PermissionRecord LocationMaster = new PermissionRecord { Name = "Master area. Manage LocationMaster", SystemName = "LocationMaster", Category = "Master" };
        public static readonly PermissionRecord CoatingMaster = new PermissionRecord { Name = "Master area. Manage CoatingMaster", SystemName = "CoatingMaster", Category = "Master" };
        public static readonly PermissionRecord SpecMaster = new PermissionRecord { Name = "Master area. Manage SpecMaster", SystemName = "SpecMaster", Category = "Master" };
        public static readonly PermissionRecord ClosingDateMaster = new PermissionRecord { Name = "Master area. Manage ClosingDateMaster", SystemName = "ClosingDateMaster", Category = "Master" };
        public static readonly PermissionRecord ProductMaster = new PermissionRecord { Name = "Master area. Manage ProductMaster", SystemName = "ProductMaster", Category = "Master" };
        public static readonly PermissionRecord ExchangeRateMaster = new PermissionRecord { Name = "Master area. Manage ExchangeRateMaster", SystemName = "ExchangeRateMaster", Category = "Master" };
        public static readonly PermissionRecord TaxMaster = new PermissionRecord { Name = "Master area. Manage TaxMaster", SystemName = "TaxMaster", Category = "Master" };
        public static readonly PermissionRecord CreditMaster = new PermissionRecord { Name = "Master area. Manage CreditMaster", SystemName = "CreditMaster", Category = "Master" };
        public static readonly PermissionRecord DueDayTypeMaster = new PermissionRecord { Name = "Master area. Manage DueDayTypeMaster", SystemName = "DueDayTypeMaster", Category = "Master" };
        //action
        public static readonly PermissionAction List = new PermissionAction { Name = "List", Action = "List" };
        public static readonly PermissionAction Add = new PermissionAction { Name = "Add", Action = "Add" };
        public static readonly PermissionAction Edit = new PermissionAction { Name = "Edit", Action = "Edit" };
        public static readonly PermissionAction Delete = new PermissionAction { Name = "Delete", Action = "Delete" };
        public virtual IEnumerable<PermissionRecord> GetPermissions()
        {
            return new[]
            {
                Master,
                SalePurchaseMaster,
                UserMaster,
                UserIdMaster,
                LocationMaster,
                CoatingMaster,
                SpecMaster,
                ClosingDateMaster,
                ProductMaster,
                ExchangeRateMaster,
                TaxMaster,
                CreditMaster,
                DueDayTypeMaster
            };
        }
        public virtual IEnumerable<PermissionAction> GetActionPermissions()
        {
            return new[]
            {
              List,
              Add,
              Edit,
              Delete
            };
        }
    }
}
