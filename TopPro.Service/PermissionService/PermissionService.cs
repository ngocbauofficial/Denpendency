/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopPro.Domain;
using TopPro.Domain.Model;
using TopPro.Service.MA002Service;
using TopPro.Service.MA003Service;

namespace TopPro.Service.PermissionService
{

   partial class PermissionService : IPermissionService
   {
       private readonly IRepository<PermissionRecord> _permissionRecord;
       private readonly IMA002Service _ma002Service;
       private readonly IMA003Service _ma003Service;
       private readonly IRoleService _rolerService;
       public PermissionService(
       IRepository<PermissionRecord> permissionRecord,
       IMA002Service ma002Service,
       IMA003Service ma003Service,
       IRoleService rolerService
       )
       {
           this._permissionRecord = permissionRecord;
           this._ma002Service = ma002Service;
           this._ma003Service = ma003Service;
           this._rolerService = rolerService;
       }

       public bool Authorize(PermissionRecord permission, PermissionAction permissionAction)
       {
           if (permissionAction != null)
           {


               var data = _ma002Service.GetByMBUSRCD(HttpContext.Current.User.Identity.Name).MA003.MCSCTLV;
               var role = db.SecurityLevels.First(x => x.Id == data).Name;

               if (String.IsNullOrEmpty(permission.SystemName))
                   return false;
               var permission_Id = db.PermissionRecords.Where(x => x.SystemName == permission.SystemName).First().Id;
               var permissionAction_Id = db.PermissionActions.Where(x => x.Name == permissionAction.Name).First().Id;
               var role_Id = db.SecurityLevels.Where(x => x.Name == role).First().Id;
               var mapping = db.Role_Mapping.Where(x => x.CustomerRole_Id == role_Id && x.PermissionRecord_Id == permission_Id).FirstOrDefault();
               var mappingAction = db.Role_Mapping_Action.Where(x => x.CustomerRole_Id == role_Id && x.PermissionRecord_Id == permission_Id && x.Action_Id == permissionAction_Id).FirstOrDefault();
               if (mapping != null && mappingAction != null)
                   return true;
               else
                   return false;
           }

           else
           {
               DbSalesPurchase db = new DbSalesPurchase();
               var data = db.MA002.FirstOrDefault(x => x.MBUSRNM == HttpContext.Current.User.Identity.Name).MA003.MCSCTLV;
               var role = db.SecurityLevels.First(x => x.Id == data).Name;
               if (String.IsNullOrEmpty(permission.SystemName))
                   return false;
               var permission_Id = db.PermissionRecords.Where(x => x.SystemName == permission.SystemName).First().Id;

               var role_Id = db.SecurityLevels.Where(x => x.Name == role).First().Id;
               var mapping = db.Role_Mapping.Where(x => x.CustomerRole_Id == role_Id && x.PermissionRecord_Id == permission_Id).FirstOrDefault();

               if (mapping != null)
                   return true;
               else
                   return false;

           }
       }
       public virtual void DeletePermissionRecord(PermissionRecord permission)
       {
           if (permission == null)
               throw new ArgumentNullException("permission");
           db.PermissionRecords.Remove(permission);
           db.SaveChanges();
       }

       public virtual PermissionRecord GetPermissionRecordById(int permissionId)
       {
           if (permissionId == 0)
               return null;
           var permission = db.PermissionRecords.Find(permissionId);
           return permission;
       }

       public virtual PermissionRecord GetPermissionRecordBySystemName(string systemName)
       {
           if (String.IsNullOrWhiteSpace(systemName))
               return null;
           var query = from pr in db.PermissionRecords
                       where pr.SystemName == systemName
                       orderby pr.Id
                       select pr;
           var permissionRecord = query.FirstOrDefault();
           return permissionRecord;
       }

       public virtual IList<PermissionRecord> GetAllPermissionRecords()
       {
           var query = from pr in db.PermissionRecords
                       orderby pr.Name
                       select pr;
           var permissions = query.ToList();
           return permissions;
       }
       public virtual void InsertPermissionRecord(PermissionRecord permission)
       {
           if (permission == null)
               throw new ArgumentNullException("permission");
           db.PermissionRecords.Add(permission);
           db.SaveChanges();
       }

       public virtual void UpdatePermissionRecord(PermissionRecord permission)
       {
           if (permission == null)
               throw new ArgumentNullException("permission");
           var permissions = db.PermissionRecords.Find(permission.Id);
           permissions.Category = permission.Category;
           permissions.SystemName = permission.SystemName;
           permissions.Name = permission.Name;
           db.SaveChanges();
       }
   }
}
*/