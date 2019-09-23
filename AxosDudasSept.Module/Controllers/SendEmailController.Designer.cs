namespace AxosDudasSept.Module.Controllers
{
    partial class SendEmailController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendEmail = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // SendEmail
            // 
            this.SendEmail.AcceptButtonCaption = null;
            this.SendEmail.CancelButtonCaption = null;
            this.SendEmail.Caption = "Send Email";
            this.SendEmail.ConfirmationMessage = null;
            this.SendEmail.Id = "b626bf85-3418-49a6-8aa1-ecfbad0fd659";
            this.SendEmail.ToolTip = null;
            this.SendEmail.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.SendEmail_CustomizePopupWindowParams);
            this.SendEmail.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.SendEmail_Execute);
            // 
            // SendEmailController
            // 
            this.Actions.Add(this.SendEmail);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction SendEmail;
    }
}
