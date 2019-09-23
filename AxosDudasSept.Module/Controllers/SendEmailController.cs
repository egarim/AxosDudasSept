using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AxosDudasSept.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace AxosDudasSept.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class SendEmailController : ViewController
    {
        public SendEmailController()
        {
            InitializeComponent();
            this.TargetObjectType = typeof(ISendEmail);
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        SendEmailParams EmailParams;
        private void SendEmail_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace();
            EmailParams = objectSpace.CreateObject<SendEmailParams>();
            e.View = Application.CreateDetailView(objectSpace, EmailParams);
        }

        private void SendEmail_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            ISendEmail sendEmail = (ISendEmail)this.View.CurrentObject;

            sendEmail.SendEmail(EmailParams.To, EmailParams.Cc, EmailParams.Bcc, EmailParams.Subject, EmailParams.Body);
        }
    }
}
