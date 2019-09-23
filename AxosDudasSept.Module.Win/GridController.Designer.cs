namespace AxosDudasSept.Module.Win
{
    partial class GridController
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
            this.ShowColumnChooser = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ShowFilterEditor = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ShowFindPanel = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ShowColumnChooser
            // 
            this.ShowColumnChooser.Caption = "Show Column Chooser";
            this.ShowColumnChooser.ConfirmationMessage = null;
            this.ShowColumnChooser.Id = "5aa3db7b-921c-46ed-8c21-52d1d5edb706";
            this.ShowColumnChooser.ToolTip = null;
            this.ShowColumnChooser.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ShowColumnChooser_Execute);
            // 
            // ShowFilterEditor
            // 
            this.ShowFilterEditor.Caption = "Show Filter Editor";
            this.ShowFilterEditor.Category = "View";
            this.ShowFilterEditor.ConfirmationMessage = null;
            this.ShowFilterEditor.Id = "0594cd01-38d5-46fe-a75b-2dc9521b2ad8";
            this.ShowFilterEditor.ToolTip = null;
            this.ShowFilterEditor.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ShowFilterEditor_Execute);
            // 
            // ShowFindPanel
            // 
            this.ShowFindPanel.Caption = "Show find panel";
            this.ShowFindPanel.ConfirmationMessage = null;
            this.ShowFindPanel.Id = "29ecc307-d828-4a36-ab10-b949737972b3";
            this.ShowFindPanel.ToolTip = null;
            this.ShowFindPanel.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ShowFindPanel_Execute);
            // 
            // GridController
            // 
            this.Actions.Add(this.ShowColumnChooser);
            this.Actions.Add(this.ShowFilterEditor);
            this.Actions.Add(this.ShowFindPanel);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ShowColumnChooser;
        private DevExpress.ExpressApp.Actions.SimpleAction ShowFilterEditor;
        private DevExpress.ExpressApp.Actions.SimpleAction ShowFindPanel;
    }
}
