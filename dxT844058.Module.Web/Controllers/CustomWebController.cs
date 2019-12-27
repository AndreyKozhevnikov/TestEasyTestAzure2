using DevExpress.ExpressApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Web;
using dxT844058.Module.BusinessObjects;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Web;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Web.Editors;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.SystemModule;
using DevExpress.Persistent.Base;
using System.IO;
using System.ComponentModel;
using DevExpress.ExpressApp.Web.Utils;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;
using System.Collections;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.Web.Layout;
using System.Web.UI;
using DevExpress.ExpressApp.Web.Controls;
using DevExpress.ExpressApp.DC;

namespace dxT844058.Module.Web.Controllers {
	
	
	
	//public class CustomWebController : ObjectViewController<ListView,Contact> {
    public class CustomWebController : ViewController {
        public CustomWebController() {
             var myAction1 = new SimpleAction(this, "MyWebAction1", null);
              myAction1.Execute += MyAction1_Execute;
            
        }
        //private void MyAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
        //    var os = Application.CreateObjectSpace(typeof(Contact));
        //    var obj = os.CreateObject<Contact>();
        //    var view = Application.CreateDetailView(os, obj);
        //    e.View = view;
        //}
        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {

        }

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
