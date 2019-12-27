using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Office.Win;

namespace dxT999999.Module.Win.Controllers {

    public class ClearMailMergeCacheController : ViewController {
        public ClearMailMergeCacheController() {
            var myAction1 = new SimpleAction(this, "MyClearMailMergeCache", null);
            myAction1.Execute += MyAction1_Execute;
        }
        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            ShowInDocumentController.InplaceDocumentCache.ClearCache();

        }
    }
}
