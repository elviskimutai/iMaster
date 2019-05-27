namespace Master.Forms
{
    partial class frmPayOuts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayOuts));
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
            this.spSelectAllPayOutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPayOuts = new Master.Class.DataSet.dsPayOuts();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectPayOutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CostCenterTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CashierTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GLAccountTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetGlAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCashier = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGLAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectPayOutsTableAdapter = new Master.Class.DataSet.dsPayOutsTableAdapters.spSelectPayOutsTableAdapter();
            this.spSelectAllPayOutsTableAdapter = new Master.Class.DataSet.dsPayOutsTableAdapters.spSelectAllPayOutsTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsPayOutsTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spgetUsersTableAdapter = new Master.Class.DataSet.dsPayOutsTableAdapters.spgetUsersTableAdapter();
            this.spgetGlAccountsTableAdapter = new Master.Class.DataSet.dsPayOutsTableAdapters.spgetGlAccountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPayOutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayOuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPayOutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashierTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLAccountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetGlAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGLAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.DocNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CashierTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GLAccountTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectPayOutsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(940, 360);
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
            this.toolStrip1.TabIndex = 28;
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
            this.gridControl1.DataSource = this.spSelectAllPayOutsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(916, 198);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // spSelectAllPayOutsBindingSource
            // 
            this.spSelectAllPayOutsBindingSource.DataMember = "spSelectAllPayOuts";
            this.spSelectAllPayOutsBindingSource.DataSource = this.dsPayOuts;
            // 
            // dsPayOuts
            // 
            this.dsPayOuts.DataSetName = "dsPayOuts";
            this.dsPayOuts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCostCenter,
            this.colDocNo,
            this.colDocType,
            this.colCashier,
            this.colGLAccount,
            this.colAmount,
            this.colRemarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 1;
            // 
            // colDocNo
            // 
            this.colDocNo.FieldName = "DocNo";
            this.colDocNo.Name = "colDocNo";
            this.colDocNo.Visible = true;
            this.colDocNo.VisibleIndex = 2;
            // 
            // colDocType
            // 
            this.colDocType.FieldName = "DocType";
            this.colDocType.Name = "colDocType";
            this.colDocType.Visible = true;
            this.colDocType.VisibleIndex = 3;
            // 
            // colCashier
            // 
            this.colCashier.FieldName = "Cashier";
            this.colCashier.Name = "colCashier";
            this.colCashier.Visible = true;
            this.colCashier.VisibleIndex = 4;
            // 
            // colGLAccount
            // 
            this.colGLAccount.FieldName = "GLAccount";
            this.colGLAccount.Name = "colGLAccount";
            this.colGLAccount.Visible = true;
            this.colGLAccount.VisibleIndex = 5;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 7;
            // 
            // DocNoTextEdit
            // 
            this.DocNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPayOutsBindingSource, "DocNo", true));
            this.DocNoTextEdit.Location = new System.Drawing.Point(533, 66);
            this.DocNoTextEdit.Name = "DocNoTextEdit";
            this.DocNoTextEdit.Size = new System.Drawing.Size(383, 20);
            this.DocNoTextEdit.StyleController = this.dataLayoutControl1;
            this.DocNoTextEdit.TabIndex = 5;
            // 
            // spSelectPayOutsBindingSource
            // 
            this.spSelectPayOutsBindingSource.DataMember = "spSelectPayOuts";
            this.spSelectPayOutsBindingSource.DataSource = this.dsPayOuts;
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPayOutsBindingSource, "Amount", true));
            this.AmountTextEdit.Location = new System.Drawing.Point(85, 114);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "G";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(383, 20);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 8;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPayOutsBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(533, 114);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(383, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 9;
            // 
            // CostCenterTextEdit
            // 
            this.CostCenterTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPayOutsBindingSource, "CostCenter", true));
            this.CostCenterTextEdit.Location = new System.Drawing.Point(85, 66);
            this.CostCenterTextEdit.Name = "CostCenterTextEdit";
            this.CostCenterTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterTextEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterTextEdit.Properties.DisplayMember = "ccname";
            this.CostCenterTextEdit.Properties.NullText = "";
            this.CostCenterTextEdit.Properties.ValueMember = "cccode";
            this.CostCenterTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterTextEdit.Size = new System.Drawing.Size(383, 20);
            this.CostCenterTextEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterTextEdit.TabIndex = 4;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsPayOuts;
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
            // CashierTextEdit
            // 
            this.CashierTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPayOutsBindingSource, "Cashier", true));
            this.CashierTextEdit.Location = new System.Drawing.Point(85, 90);
            this.CashierTextEdit.Name = "CashierTextEdit";
            this.CashierTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CashierTextEdit.Properties.DataSource = this.spgetUsersBindingSource;
            this.CashierTextEdit.Properties.DisplayMember = "FullNames";
            this.CashierTextEdit.Properties.NullText = "";
            this.CashierTextEdit.Properties.ValueMember = "UserName";
            this.CashierTextEdit.Properties.View = this.gridView2;
            this.CashierTextEdit.Size = new System.Drawing.Size(383, 20);
            this.CashierTextEdit.StyleController = this.dataLayoutControl1;
            this.CashierTextEdit.TabIndex = 6;
            // 
            // spgetUsersBindingSource
            // 
            this.spgetUsersBindingSource.DataMember = "spgetUsers";
            this.spgetUsersBindingSource.DataSource = this.dsPayOuts;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // GLAccountTextEdit
            // 
            this.GLAccountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPayOutsBindingSource, "GLAccount", true));
            this.GLAccountTextEdit.Location = new System.Drawing.Point(533, 90);
            this.GLAccountTextEdit.Name = "GLAccountTextEdit";
            this.GLAccountTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GLAccountTextEdit.Properties.DataSource = this.spgetGlAccountsBindingSource;
            this.GLAccountTextEdit.Properties.DisplayMember = "AccName";
            this.GLAccountTextEdit.Properties.NullText = "";
            this.GLAccountTextEdit.Properties.ValueMember = "AccCode";
            this.GLAccountTextEdit.Properties.View = this.gridView3;
            this.GLAccountTextEdit.Size = new System.Drawing.Size(383, 20);
            this.GLAccountTextEdit.StyleController = this.dataLayoutControl1;
            this.GLAccountTextEdit.TabIndex = 7;
            // 
            // spgetGlAccountsBindingSource
            // 
            this.spgetGlAccountsBindingSource.DataMember = "spgetGlAccounts";
            this.spgetGlAccountsBindingSource.DataSource = this.dsPayOuts;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(940, 360);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(920, 340);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(920, 202);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(920, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCostCenter,
            this.ItemForCashier,
            this.ItemForAmount,
            this.ItemForRemarks,
            this.ItemForGLAccount,
            this.ItemForDocNo});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(920, 114);
            this.layoutControlGroup3.Text = "PayOuts";
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterTextEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(448, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForCashier
            // 
            this.ItemForCashier.Control = this.CashierTextEdit;
            this.ItemForCashier.Location = new System.Drawing.Point(0, 24);
            this.ItemForCashier.Name = "ItemForCashier";
            this.ItemForCashier.Size = new System.Drawing.Size(448, 24);
            this.ItemForCashier.Text = "Cashier";
            this.ItemForCashier.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 48);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(448, 24);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(448, 48);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(448, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForGLAccount
            // 
            this.ItemForGLAccount.Control = this.GLAccountTextEdit;
            this.ItemForGLAccount.Location = new System.Drawing.Point(448, 24);
            this.ItemForGLAccount.Name = "ItemForGLAccount";
            this.ItemForGLAccount.Size = new System.Drawing.Size(448, 24);
            this.ItemForGLAccount.Text = "GL Account";
            this.ItemForGLAccount.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForDocNo
            // 
            this.ItemForDocNo.Control = this.DocNoTextEdit;
            this.ItemForDocNo.Location = new System.Drawing.Point(448, 0);
            this.ItemForDocNo.Name = "ItemForDocNo";
            this.ItemForDocNo.Size = new System.Drawing.Size(448, 24);
            this.ItemForDocNo.Text = "Doc No";
            this.ItemForDocNo.TextSize = new System.Drawing.Size(58, 13);
            // 
            // spSelectPayOutsTableAdapter
            // 
            this.spSelectPayOutsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllPayOutsTableAdapter
            // 
            this.spSelectAllPayOutsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetUsersTableAdapter
            // 
            this.spgetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetGlAccountsTableAdapter
            // 
            this.spgetGlAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // frmPayOuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 360);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmPayOuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayOuts";
            this.Load += new System.EventHandler(this.frmPayOuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPayOutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayOuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPayOutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashierTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLAccountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetGlAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGLAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource spSelectPayOutsBindingSource;
        private Class.DataSet.dsPayOuts dsPayOuts;
        private DevExpress.XtraEditors.TextEdit DocNoTextEdit;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCashier;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGLAccount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private Class.DataSet.dsPayOutsTableAdapters.spSelectPayOutsTableAdapter spSelectPayOutsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource spSelectAllPayOutsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDocType;
        private DevExpress.XtraGrid.Columns.GridColumn colCashier;
        private DevExpress.XtraGrid.Columns.GridColumn colGLAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private Class.DataSet.dsPayOutsTableAdapters.spSelectAllPayOutsTableAdapter spSelectAllPayOutsTableAdapter;
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterTextEdit;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Class.DataSet.dsPayOutsTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit CashierTextEdit;
        private System.Windows.Forms.BindingSource spgetUsersBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit GLAccountTextEdit;
        private System.Windows.Forms.BindingSource spgetGlAccountsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private Class.DataSet.dsPayOutsTableAdapters.spgetUsersTableAdapter spgetUsersTableAdapter;
        private Class.DataSet.dsPayOutsTableAdapters.spgetGlAccountsTableAdapter spgetGlAccountsTableAdapter;
    }
}