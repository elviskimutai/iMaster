namespace Master.Forms
{
    partial class frmPriceBands
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPriceBands));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Submit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllPriceBandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPriceBands = new Master.Class.DataSet.dsPriceBands();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPriceBand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinimum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaximum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecomended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriceBandTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectPriceBandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MinimumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MaximumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RecomendedTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMinimum = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMaximum = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRecomended = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPriceBand = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectPriceBandsTableAdapter = new Master.Class.DataSet.dsPriceBandsTableAdapters.spSelectPriceBandsTableAdapter();
            this.spSelectAllPriceBandsTableAdapter = new Master.Class.DataSet.dsPriceBandsTableAdapters.spSelectAllPriceBandsTableAdapter();
            this.spGetItemsTableAdapter = new Master.Class.DataSet.dsPriceBandsTableAdapters.spGetItemsTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsPriceBandsTableAdapters.spGetCompanyCostCentersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPriceBandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPriceBands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBandTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPriceBandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecomendedTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRecomended)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.PriceBandTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.MinimumTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MaximumTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RecomendedTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectPriceBandsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(901, 402);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.Submit,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(584, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 20);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 17);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 20);
            // 
            // Submit
            // 
            this.Submit.Image = ((System.Drawing.Image)(resources.GetObject("Submit.Image")));
            this.Submit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(47, 17);
            this.Submit.Text = "Edit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 20);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 17);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 17);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 17);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllPriceBandsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(877, 216);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllPriceBandsBindingSource
            // 
            this.spSelectAllPriceBandsBindingSource.DataMember = "spSelectAllPriceBands";
            this.spSelectAllPriceBandsBindingSource.DataSource = this.dsPriceBands;
            // 
            // dsPriceBands
            // 
            this.dsPriceBands.DataSetName = "dsPriceBands";
            this.dsPriceBands.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriceBand,
            this.colCompany,
            this.colCostCenter,
            this.colItemCode,
            this.colItemDescription,
            this.colMinimum,
            this.colMaximum,
            this.colRecomended,
            this.colNarration});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // colPriceBand
            // 
            this.colPriceBand.FieldName = "PriceBand";
            this.colPriceBand.Name = "colPriceBand";
            this.colPriceBand.Visible = true;
            this.colPriceBand.VisibleIndex = 0;
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 1;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 2;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 3;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 4;
            // 
            // colMinimum
            // 
            this.colMinimum.FieldName = "Minimum";
            this.colMinimum.Name = "colMinimum";
            this.colMinimum.Visible = true;
            this.colMinimum.VisibleIndex = 5;
            // 
            // colMaximum
            // 
            this.colMaximum.FieldName = "Maximum";
            this.colMaximum.Name = "colMaximum";
            this.colMaximum.Visible = true;
            this.colMaximum.VisibleIndex = 6;
            // 
            // colRecomended
            // 
            this.colRecomended.FieldName = "Recomended";
            this.colRecomended.Name = "colRecomended";
            this.colRecomended.Visible = true;
            this.colRecomended.VisibleIndex = 7;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 8;
            // 
            // PriceBandTextEdit
            // 
            this.PriceBandTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPriceBandsBindingSource, "PriceBand", true));
            this.PriceBandTextEdit.Location = new System.Drawing.Point(89, 66);
            this.PriceBandTextEdit.Name = "PriceBandTextEdit";
            this.PriceBandTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.PriceBandTextEdit.Properties.Mask.EditMask = "^$";
            this.PriceBandTextEdit.Size = new System.Drawing.Size(360, 20);
            this.PriceBandTextEdit.StyleController = this.dataLayoutControl1;
            this.PriceBandTextEdit.TabIndex = 4;
            // 
            // spSelectPriceBandsBindingSource
            // 
            this.spSelectPriceBandsBindingSource.DataMember = "spSelectPriceBands";
            this.spSelectPriceBandsBindingSource.DataSource = this.dsPriceBands;
            // 
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPriceBandsBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(518, 66);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(359, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 5;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsPriceBands;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ItemCodeGridLookUpEdit
            // 
            this.ItemCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPriceBandsBindingSource, "ItemCode", true));
            this.ItemCodeGridLookUpEdit.Location = new System.Drawing.Point(89, 90);
            this.ItemCodeGridLookUpEdit.Name = "ItemCodeGridLookUpEdit";
            this.ItemCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemCodeGridLookUpEdit.Properties.DataSource = this.spGetItemsBindingSource;
            this.ItemCodeGridLookUpEdit.Properties.DisplayMember = "ItemDescription";
            this.ItemCodeGridLookUpEdit.Properties.NullText = "";
            this.ItemCodeGridLookUpEdit.Properties.ValueMember = "ItemCode";
            this.ItemCodeGridLookUpEdit.Properties.View = this.gridView1;
            this.ItemCodeGridLookUpEdit.Size = new System.Drawing.Size(360, 20);
            this.ItemCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ItemCodeGridLookUpEdit.TabIndex = 6;
            // 
            // spGetItemsBindingSource
            // 
            this.spGetItemsBindingSource.DataMember = "spGetItems";
            this.spGetItemsBindingSource.DataSource = this.dsPriceBands;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MinimumTextEdit
            // 
            this.MinimumTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPriceBandsBindingSource, "Minimum", true));
            this.MinimumTextEdit.Location = new System.Drawing.Point(518, 90);
            this.MinimumTextEdit.Name = "MinimumTextEdit";
            this.MinimumTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MinimumTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MinimumTextEdit.Properties.Mask.EditMask = "G";
            this.MinimumTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MinimumTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MinimumTextEdit.Size = new System.Drawing.Size(359, 20);
            this.MinimumTextEdit.StyleController = this.dataLayoutControl1;
            this.MinimumTextEdit.TabIndex = 7;
            // 
            // MaximumTextEdit
            // 
            this.MaximumTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPriceBandsBindingSource, "Maximum", true));
            this.MaximumTextEdit.Location = new System.Drawing.Point(89, 114);
            this.MaximumTextEdit.Name = "MaximumTextEdit";
            this.MaximumTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MaximumTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MaximumTextEdit.Properties.Mask.EditMask = "G";
            this.MaximumTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MaximumTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MaximumTextEdit.Size = new System.Drawing.Size(360, 20);
            this.MaximumTextEdit.StyleController = this.dataLayoutControl1;
            this.MaximumTextEdit.TabIndex = 8;
            // 
            // RecomendedTextEdit
            // 
            this.RecomendedTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPriceBandsBindingSource, "Recomended", true));
            this.RecomendedTextEdit.Location = new System.Drawing.Point(518, 114);
            this.RecomendedTextEdit.Name = "RecomendedTextEdit";
            this.RecomendedTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.RecomendedTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RecomendedTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.RecomendedTextEdit.Properties.Mask.BeepOnError = true;
            this.RecomendedTextEdit.Properties.Mask.IgnoreMaskBlank = false;
            this.RecomendedTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.RecomendedTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.RecomendedTextEdit.Size = new System.Drawing.Size(359, 20);
            this.RecomendedTextEdit.StyleController = this.dataLayoutControl1;
            this.RecomendedTextEdit.TabIndex = 9;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPriceBandsBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(89, 138);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(360, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(901, 402);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup3,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(881, 382);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(881, 220);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNarration,
            this.ItemForMinimum,
            this.ItemForCostCenter,
            this.ItemForMaximum,
            this.ItemForItemCode,
            this.ItemForRecomended,
            this.ItemForPriceBand});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(881, 138);
            this.layoutControlGroup3.Text = "Price Bands";
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(0, 72);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(429, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForMinimum
            // 
            this.ItemForMinimum.Control = this.MinimumTextEdit;
            this.ItemForMinimum.Location = new System.Drawing.Point(429, 24);
            this.ItemForMinimum.Name = "ItemForMinimum";
            this.ItemForMinimum.Size = new System.Drawing.Size(428, 24);
            this.ItemForMinimum.Text = "Minimum";
            this.ItemForMinimum.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(429, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(428, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForMaximum
            // 
            this.ItemForMaximum.Control = this.MaximumTextEdit;
            this.ItemForMaximum.Location = new System.Drawing.Point(0, 48);
            this.ItemForMaximum.Name = "ItemForMaximum";
            this.ItemForMaximum.Size = new System.Drawing.Size(429, 24);
            this.ItemForMaximum.Text = "Maximum";
            this.ItemForMaximum.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeGridLookUpEdit;
            this.ItemForItemCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Size = new System.Drawing.Size(429, 24);
            this.ItemForItemCode.Text = "Item Code";
            this.ItemForItemCode.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForRecomended
            // 
            this.ItemForRecomended.Control = this.RecomendedTextEdit;
            this.ItemForRecomended.Location = new System.Drawing.Point(429, 48);
            this.ItemForRecomended.Name = "ItemForRecomended";
            this.ItemForRecomended.Size = new System.Drawing.Size(428, 48);
            this.ItemForRecomended.Text = "Recomended";
            this.ItemForRecomended.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForPriceBand
            // 
            this.ItemForPriceBand.Control = this.PriceBandTextEdit;
            this.ItemForPriceBand.Location = new System.Drawing.Point(0, 0);
            this.ItemForPriceBand.Name = "ItemForPriceBand";
            this.ItemForPriceBand.Size = new System.Drawing.Size(429, 24);
            this.ItemForPriceBand.Text = "Price Band";
            this.ItemForPriceBand.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(881, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectPriceBandsTableAdapter
            // 
            this.spSelectPriceBandsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllPriceBandsTableAdapter
            // 
            this.spSelectAllPriceBandsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetItemsTableAdapter
            // 
            this.spGetItemsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // frmPriceBands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 402);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmPriceBands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Bands";
            this.Load += new System.EventHandler(this.frmPriceBands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPriceBandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPriceBands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBandTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPriceBandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecomendedTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRecomended)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit PriceBandTextEdit;
        private System.Windows.Forms.BindingSource spSelectPriceBandsBindingSource;
        private Class.DataSet.dsPriceBands dsPriceBands;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit ItemCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit MinimumTextEdit;
        private DevExpress.XtraEditors.TextEdit MaximumTextEdit;
        private DevExpress.XtraEditors.TextEdit RecomendedTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private Class.DataSet.dsPriceBandsTableAdapters.spSelectPriceBandsTableAdapter spSelectPriceBandsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllPriceBandsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceBand;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMinimum;
        private DevExpress.XtraGrid.Columns.GridColumn colMaximum;
        private DevExpress.XtraGrid.Columns.GridColumn colRecomended;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsPriceBandsTableAdapters.spSelectAllPriceBandsTableAdapter spSelectAllPriceBandsTableAdapter;
        private System.Windows.Forms.BindingSource spGetItemsBindingSource;
        private Class.DataSet.dsPriceBandsTableAdapters.spGetItemsTableAdapter spGetItemsTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsPriceBandsTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMinimum;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaximum;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRecomended;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPriceBand;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Submit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}