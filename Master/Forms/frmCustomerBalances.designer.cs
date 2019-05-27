namespace Master.Forms
{
    partial class frmCustomerBalances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerBalances));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dsCustomerBalances = new Master.Class.DataSet.dsCustomerBalances();
            this.spSelectCustomerBalancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectCustomerBalancesTableAdapter = new Master.Class.DataSet.dsCustomerBalancesTableAdapters.spSelectCustomerBalancesTableAdapter();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.BalanceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForBalance = new DevExpress.XtraLayout.LayoutControlItem();
            this.BalanceDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForBalanceDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CustCodeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CostCenterTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.spGetCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCustomersTableAdapter = new Master.Class.DataSet.dsCustomerBalancesTableAdapters.spGetCustomersTableAdapter();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsCustomerBalancesTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectAllCustomerBalancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectAllCustomerBalancesTableAdapter = new Master.Class.DataSet.dsCustomerBalancesTableAdapters.spSelectAllCustomerBalancesTableAdapter();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalanceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerminus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCustomerBalancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalanceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCustomerBalancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.BalanceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BalanceDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCustomerBalancesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(949, 358);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(949, 358);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dsCustomerBalances
            // 
            this.dsCustomerBalances.DataSetName = "dsCustomerBalances";
            this.dsCustomerBalances.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSelectCustomerBalancesBindingSource
            // 
            this.spSelectCustomerBalancesBindingSource.DataMember = "spSelectCustomerBalances";
            this.spSelectCustomerBalancesBindingSource.DataSource = this.dsCustomerBalances;
            // 
            // spSelectCustomerBalancesTableAdapter
            // 
            this.spSelectCustomerBalancesTableAdapter.ClearBeforeFill = true;
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(929, 338);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterTextEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(452, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForCustCode
            // 
            this.ItemForCustCode.Control = this.CustCodeTextEdit;
            this.ItemForCustCode.Location = new System.Drawing.Point(452, 0);
            this.ItemForCustCode.Name = "ItemForCustCode";
            this.ItemForCustCode.Size = new System.Drawing.Size(453, 24);
            this.ItemForCustCode.Text = "Cust Code";
            this.ItemForCustCode.TextSize = new System.Drawing.Size(63, 13);
            // 
            // BalanceTextEdit
            // 
            this.BalanceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomerBalancesBindingSource, "Balance", true));
            this.BalanceTextEdit.Location = new System.Drawing.Point(91, 90);
            this.BalanceTextEdit.Name = "BalanceTextEdit";
            this.BalanceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BalanceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BalanceTextEdit.Properties.Mask.EditMask = "G";
            this.BalanceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BalanceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BalanceTextEdit.Size = new System.Drawing.Size(381, 20);
            this.BalanceTextEdit.StyleController = this.dataLayoutControl1;
            this.BalanceTextEdit.TabIndex = 6;
            // 
            // ItemForBalance
            // 
            this.ItemForBalance.Control = this.BalanceTextEdit;
            this.ItemForBalance.Location = new System.Drawing.Point(0, 24);
            this.ItemForBalance.Name = "ItemForBalance";
            this.ItemForBalance.Size = new System.Drawing.Size(452, 24);
            this.ItemForBalance.Text = "Balance";
            this.ItemForBalance.TextSize = new System.Drawing.Size(63, 13);
            // 
            // BalanceDateDateEdit
            // 
            this.BalanceDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomerBalancesBindingSource, "BalanceDate", true));
            this.BalanceDateDateEdit.EditValue = null;
            this.BalanceDateDateEdit.Location = new System.Drawing.Point(543, 90);
            this.BalanceDateDateEdit.Name = "BalanceDateDateEdit";
            this.BalanceDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BalanceDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BalanceDateDateEdit.Size = new System.Drawing.Size(382, 20);
            this.BalanceDateDateEdit.StyleController = this.dataLayoutControl1;
            this.BalanceDateDateEdit.TabIndex = 7;
            // 
            // ItemForBalanceDate
            // 
            this.ItemForBalanceDate.Control = this.BalanceDateDateEdit;
            this.ItemForBalanceDate.Location = new System.Drawing.Point(452, 24);
            this.ItemForBalanceDate.Name = "ItemForBalanceDate";
            this.ItemForBalanceDate.Size = new System.Drawing.Size(453, 48);
            this.ItemForBalanceDate.Text = "Balance Date";
            this.ItemForBalanceDate.TextSize = new System.Drawing.Size(63, 13);
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomerBalancesBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(91, 114);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(381, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 8;
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 48);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(452, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(63, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllCustomerBalancesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(925, 196);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCostCenter,
            this.colCustCode,
            this.colCustName,
            this.colBalance,
            this.colCurrency,
            this.colBalanceDate,
            this.colRemarks,
            this.colCreatedDate,
            this.colCreatedUser,
            this.colUpdatedDate,
            this.colUpdatedUser,
            this.colTerminus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(929, 200);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CustCodeTextEdit
            // 
            this.CustCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomerBalancesBindingSource, "CustCode", true));
            this.CustCodeTextEdit.Location = new System.Drawing.Point(543, 66);
            this.CustCodeTextEdit.Name = "CustCodeTextEdit";
            this.CustCodeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustCodeTextEdit.Properties.DataSource = this.spGetCustomersBindingSource;
            this.CustCodeTextEdit.Properties.DisplayMember = "CustName";
            this.CustCodeTextEdit.Properties.NullText = "";
            this.CustCodeTextEdit.Properties.ValueMember = "CustCode";
            this.CustCodeTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.CustCodeTextEdit.Size = new System.Drawing.Size(382, 20);
            this.CustCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CustCodeTextEdit.TabIndex = 5;
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
            // CostCenterTextEdit
            // 
            this.CostCenterTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomerBalancesBindingSource, "CostCenter", true));
            this.CostCenterTextEdit.Location = new System.Drawing.Point(91, 66);
            this.CostCenterTextEdit.Name = "CostCenterTextEdit";
            this.CostCenterTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterTextEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterTextEdit.Properties.DisplayMember = "ccname";
            this.CostCenterTextEdit.Properties.NullText = "";
            this.CostCenterTextEdit.Properties.ValueMember = "cccode";
            this.CostCenterTextEdit.Properties.View = this.gridView2;
            this.CostCenterTextEdit.Size = new System.Drawing.Size(381, 20);
            this.CostCenterTextEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterTextEdit.TabIndex = 4;
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
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForRemarks,
            this.ItemForBalance,
            this.ItemForCostCenter,
            this.ItemForCustCode,
            this.ItemForBalanceDate});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(929, 114);
            this.layoutControlGroup3.Text = "Customer Balances";
            // 
            // spGetCustomersBindingSource
            // 
            this.spGetCustomersBindingSource.DataMember = "spGetCustomers";
            this.spGetCustomersBindingSource.DataSource = this.dsCustomerBalances;
            // 
            // spGetCustomersTableAdapter
            // 
            this.spGetCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsCustomerBalances;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 20);
            this.toolStrip1.TabIndex = 21;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 17);
            this.toolStripButton1.Text = "Export";
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
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(929, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectAllCustomerBalancesBindingSource
            // 
            this.spSelectAllCustomerBalancesBindingSource.DataMember = "spSelectAllCustomerBalances";
            this.spSelectAllCustomerBalancesBindingSource.DataSource = this.dsCustomerBalances;
            // 
            // spSelectAllCustomerBalancesTableAdapter
            // 
            this.spSelectAllCustomerBalancesTableAdapter.ClearBeforeFill = true;
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
            // colCustCode
            // 
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 2;
            // 
            // colCustName
            // 
            this.colCustName.FieldName = "CustName";
            this.colCustName.Name = "colCustName";
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 3;
            // 
            // colBalance
            // 
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 4;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 5;
            // 
            // colBalanceDate
            // 
            this.colBalanceDate.FieldName = "BalanceDate";
            this.colBalanceDate.Name = "colBalanceDate";
            this.colBalanceDate.Visible = true;
            this.colBalanceDate.VisibleIndex = 6;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 7;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 8;
            // 
            // colCreatedUser
            // 
            this.colCreatedUser.FieldName = "CreatedUser";
            this.colCreatedUser.Name = "colCreatedUser";
            this.colCreatedUser.Visible = true;
            this.colCreatedUser.VisibleIndex = 9;
            // 
            // colUpdatedDate
            // 
            this.colUpdatedDate.FieldName = "UpdatedDate";
            this.colUpdatedDate.Name = "colUpdatedDate";
            this.colUpdatedDate.Visible = true;
            this.colUpdatedDate.VisibleIndex = 10;
            // 
            // colUpdatedUser
            // 
            this.colUpdatedUser.FieldName = "UpdatedUser";
            this.colUpdatedUser.Name = "colUpdatedUser";
            this.colUpdatedUser.Visible = true;
            this.colUpdatedUser.VisibleIndex = 11;
            // 
            // colTerminus
            // 
            this.colTerminus.FieldName = "Terminus";
            this.colTerminus.Name = "colTerminus";
            this.colTerminus.Visible = true;
            this.colTerminus.VisibleIndex = 12;
            // 
            // frmCustomerBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 358);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCustomerBalances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Balances";
            this.Load += new System.EventHandler(this.frmCustomerBalances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCustomerBalancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalanceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCustomerBalancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource spSelectCustomerBalancesBindingSource;
        private Class.DataSet.dsCustomerBalances dsCustomerBalances;
        private DevExpress.XtraEditors.TextEdit BalanceTextEdit;
        private DevExpress.XtraEditors.DateEdit BalanceDateDateEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBalance;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBalanceDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private Class.DataSet.dsCustomerBalancesTableAdapters.spSelectCustomerBalancesTableAdapter spSelectCustomerBalancesTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GridLookUpEdit CustCodeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource spGetCustomersBindingSource;
        private Class.DataSet.dsCustomerBalancesTableAdapters.spGetCustomersTableAdapter spGetCustomersTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsCustomerBalancesTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spSelectAllCustomerBalancesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedUser;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedUser;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminus;
        private Class.DataSet.dsCustomerBalancesTableAdapters.spSelectAllCustomerBalancesTableAdapter spSelectAllCustomerBalancesTableAdapter;
    }
}