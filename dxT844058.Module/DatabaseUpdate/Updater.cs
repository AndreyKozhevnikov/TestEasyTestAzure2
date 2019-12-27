using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;

using dxT844058.Module.BusinessObjects;

namespace dxT844058.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            //string name = "MyName";
            //DomainObject1 theObject = ObjectSpace.FindObject<DomainObject1>(CriteriaOperator.Parse("Name=?", name));
            //if(theObject == null) {
            //    theObject = ObjectSpace.CreateObject<DomainObject1>();
            //    theObject.Name = name;
            //}

            for (int i = 0; i < 10; i++) {
                string contactName = "FirstName" + i;
                var contact = CreateObject<Contact>("FirstName", contactName);
                contact.LastName = "LastName" + i;
				contact.Age = i * 10;
                for(int j = 0; j < 5; j++) {
                    string taskName = "Subject" + i + " - " + j;
                    var task = CreateObject<MyTask>("Subject", taskName);
                    task.AssignedTo = contact;
                }
            }
            
   
            PermissionPolicyRole adminRole = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", SecurityStrategy.AdministratorRoleName));
            if(adminRole == null) {
                adminRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
                adminRole.Name = SecurityStrategy.AdministratorRoleName;
                adminRole.IsAdministrative = true;
            }

            PermissionPolicyRole userRole = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Users"));
            if(userRole == null) {
                userRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
                userRole.Name = "Users";
            }

            userRole.AddTypePermissionsRecursively<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
            userRole.AddTypePermissionsRecursively<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
            userRole.SetTypePermission<PermissionPolicyTypePermissionObject>(SecurityOperations.Read, SecurityPermissionState.Allow);
            userRole.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
            //  userRole.AddNavigationPermission("Application/NavigationItems/Items/Default/Items/Contact_ListView", SecurityPermissionState.Allow);
            userRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
            userRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
            userRole.AddTypePermissionsRecursively<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
            userRole.AddTypePermissionsRecursively<AuditDataItemPersistent>(SecurityOperations.CRUDAccess, SecurityPermissionState.Allow);
            // ... 
           
            PermissionPolicyUser user1 = ObjectSpace.FindObject<PermissionPolicyUser>(
              new BinaryOperator("UserName", "Admin"));
            if(user1 == null) {
                user1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                user1.UserName = "Admin";
                // Set a password if the standard authentication type is used. 
                user1.SetPassword("");
            }
            
            PermissionPolicyUser user2 = ObjectSpace.FindObject<PermissionPolicyUser>(
                 new BinaryOperator("UserName", "User"));
            if(user2 == null) {
                user2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                user2.UserName = "User";
                // Set a password if the standard authentication type is used. 
                user2.SetPassword("");
            }

            user1.Roles.Add(adminRole);
            user2.Roles.Add(userRole);
  
			ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).
        }

        T CreateObject<T>(string propertyName,string value) {
       
            T theObject = ObjectSpace.FindObject<T>(new OperandProperty(propertyName) == value);
            if (theObject == null){
                theObject = ObjectSpace.CreateObject<T>();
                ((BaseObject)(Object)theObject).SetMemberValue(propertyName, value);
            }
          
            return theObject;

        }

        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
