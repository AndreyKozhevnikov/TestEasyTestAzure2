namespace dxT844058.Win {
    partial class dxT844058WindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new dxT844058.Module.dxT844058Module();
            this.module4 = new dxT844058.Module.Win.dxT844058WindowsFormsModule();
			
            this.securityStrategyComplex1 = new DevExpress.ExpressApp.Security.SecurityStrategyComplex();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.authenticationStandard1 = new DevExpress.ExpressApp.Security.AuthenticationStandard();

			
            this.reportsModuleV21 = new DevExpress.ExpressApp.ReportsV2.ReportsModuleV2();
            this.reportsWindowsFormsModuleV21 = new DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2();

			
  this.officeModule1 = new DevExpress.ExpressApp.Office.OfficeModule();
   this.officeWindowsFormsModule1 = new DevExpress.ExpressApp.Office.Win.OfficeWindowsFormsModule();
 
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			
             // 
            // securityStrategyComplex1
            // 
            this.securityStrategyComplex1.Authentication = this.authenticationStandard1;
            this.securityStrategyComplex1.RoleType = typeof(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyRole);
            this.securityStrategyComplex1.UsePermissionRequestProcessor = false;
            this.securityStrategyComplex1.UserType = typeof(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser);
            // 
            // authenticationStandard1
            //
            this.authenticationStandard1.LogonParametersType = typeof(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters);
            // 

			
            // 
            // reportsModuleV21
            // 
            this.reportsModuleV21.EnableInplaceReports = true;
            this.reportsModuleV21.ReportDataType = typeof(DevExpress.Persistent.BaseImpl.ReportDataV2);
			this.reportsModuleV21.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML;

			
     this.officeModule1.RichTextMailMergeDataType = typeof(DevExpress.Persistent.BaseImpl.RichTextMailMergeData);

            // 
            // dxT844058WindowsFormsApplication
            // 
            this.ApplicationName = "dxT844058";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
			
            this.Modules.Add(this.reportsModuleV21);
            this.Modules.Add(this.reportsWindowsFormsModuleV21);
 
			
 this.Modules.Add(this.officeModule1);
   this.Modules.Add(this.officeWindowsFormsModule1);
  
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
			
              this.Modules.Add(this.securityModule1);
            this.Security = this.securityStrategyComplex1;

            this.UseOldTemplates = false;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.dxT844058WindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.dxT844058WindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private dxT844058.Module.dxT844058Module module3;
        private dxT844058.Module.Win.dxT844058WindowsFormsModule module4;
		
        private DevExpress.ExpressApp.Security.SecurityStrategyComplex securityStrategyComplex1;
        private DevExpress.ExpressApp.Security.AuthenticationStandard authenticationStandard1;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;

		
        private DevExpress.ExpressApp.ReportsV2.ReportsModuleV2 reportsModuleV21;
        private DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2 reportsWindowsFormsModuleV21;

 
		
   private DevExpress.ExpressApp.Office.Win.OfficeWindowsFormsModule officeWindowsFormsModule1;
           private DevExpress.ExpressApp.Office.OfficeModule officeModule1;
 
    }
}
