using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.XtraGrid.Views.Grid;

namespace AxosDudasSept.Module.Win
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class GridController : ViewController
    {
        public GridController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            FindPanelActive = false;
            // Perform various tasks depending on the target View.
        }
        GridView gridView;
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            GridListEditor listEditor = ((ListView)View).Editor as GridListEditor;
            if (listEditor != null)
            {
                gridView = listEditor.GridView;
                gridView.OptionsView.EnableAppearanceOddRow = true;
                gridView.Appearance.OddRow.BackColor = Color.FromArgb(244, 244, 244);
            }
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void ShowColumnChooser_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            gridView.ShowCustomization();
        }

        private void ShowFilterEditor_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            gridView.ShowFilterEditor(gridView.Columns[0]);
        }
        public bool FindPanelActive { get; set; }
        private void ShowFindPanel_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            if(!FindPanelActive)
            {
                gridView.ShowFindPanel();
                FindPanelActive = true;
            }
            else
            {
                gridView.HideFindPanel();
                FindPanelActive = false;
            }
                
        }
    }
}
