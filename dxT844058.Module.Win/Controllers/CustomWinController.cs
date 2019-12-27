using DevExpress.ExpressApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.XtraLayout;
using DevExpress.ExpressApp.Actions;
using dxT844058.Module.BusinessObjects;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Editors;
using DevExpress.XtraEditors;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using System.IO;
using System.ComponentModel;
using System.Collections;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Win;
namespace dxT844058.Module.Win.Controllers {
	
	
	
	//public class CustomWinController : ObjectViewController<ListView,Contact> {
    public class CustomWinController : ViewController {
        public CustomWinController() {
             var myAction1 = new SimpleAction(this, "MyWinAction1", null);
              myAction1.Execute += MyAction1_Execute;
            
        }

        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {

        }
        //private void MyAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
        //    var os = Application.CreateObjectSpace(typeof(Contact));
        //    var obj = os.CreateObject<Contact>();
        //    var view = Application.CreateDetailView(os, obj);
        //    e.View = view;
        //}
        protected override void OnActivated() {
            base.OnActivated();
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
        }
    }
}
