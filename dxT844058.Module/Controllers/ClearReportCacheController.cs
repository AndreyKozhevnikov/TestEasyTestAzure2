using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.ReportsV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dxT844058.Module.Controllers {
    public class ClearReportCacheController : ViewController {
        public ClearReportCacheController() {
            var myAction1 = new SimpleAction(this, "MyClearReportCache", null);
            myAction1.Execute += MyAction1_Execute;
        }
        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            var repModule = this.Application.Modules.FindModule<ReportsModuleV2>();
            repModule.InplaceReportsCacheHelper.ClearInplaceReportsCache();
        }
    }
}
