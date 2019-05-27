namespace Master.Forms
{
    partial class frmSupplierBalances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierBalances));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllSupplierBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSupplierBalances = new Master.Class.DataSet.dsSupplierBalances();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalanceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectSupplierBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SuppCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BalanceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CurrencyGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BalanceDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ReferenceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForReference = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSuppCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBalanceDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBalance = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectSupplierBalanceTableAdapter = new Master.Class.DataSet.dsSupplierBalancesTableAdapters.spSelectSupplierBalanceTableAdapter();
            this.spSelectAllSupplierBalanceTableAdapter = new Master.Class.DataSet.dsSupplierBalancesTableAdapters.spSelectAllSupplierBalanceTableAdapter();
            this.spGetSuppliersTableAdapter = new Master.Class.DataSet.dsSupplierBalancesTableAdapters.spGetSuppliersTableAdapter();
            this.spgetCurrenciesTableAdapter = new Master.Class.DataSet.dsSupplierBalancesTableAdapters.spgetCurrenciesTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsSupplierBalancesTableAdapters.spGetCompanyCostCentersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuppCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalanceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.SuppCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BalanceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrencyGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BalanceDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ReferenceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectSupplierBalanceBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1075, 483);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1051, 20);
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
            this.gridControl1.DataSource = this.spSelectAllSupplierBalanceBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1051, 297);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // spSelectAllSupplierBalanceBindingSource
            // 
            this.spSelectAllSupplierBalanceBindingSource.DataMember = "spSelectAllSupplierBalance";
            this.spSelectAllSupplierBalanceBindingSource.DataSource = this.dsSupplierBalances;
            // 
            // dsSupplierBalances
            // 
            this.dsSupplierBalances.DataSetName = "dsSupplierBalances";
            this.dsSupplierBalances.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCostCenter,
            this.colSuppCode,
            this.colSuppName,
            this.colBalance,
            this.colCurrency,
            this.colBalanceDate,
            this.colReference,
            this.colRemarks});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
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
            // colSuppCode
            // 
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.Visible = true;
            this.colSuppCode.VisibleIndex = 2;
            // 
            // colSuppName
            // 
            this.colSuppName.FieldName = "SuppName";
            this.colSuppName.Name = "colSuppName";
            this.colSuppName.Visible = true;
            this.colSuppName.VisibleIndex = 3;
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
            // colReference
            // 
            this.colReference.FieldName = "Reference";
            this.colReference.Name = "colReference";
            this.colReference.Visible = true;
            this.colReference.VisibleIndex = 7;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 8;
            // 
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBalanceBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(90, 66);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(446, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 4;
            // 
            // spSelectSupplierBalanceBindingSource
            // 
            this.spSelectSupplierBalanceBindingSource.DataMember = "spSelectSupplierBalance";
            this.spSelectSupplierBalanceBindingSource.DataSource = this.dsSupplierBalances;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsSupplierBalances;
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
            // SuppCodeGridLookUpEdit
            // 
            this.SuppCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBalanceBindingSource, "SuppCode", true));
            this.SuppCodeGridLookUpEdit.Location = new System.Drawing.Point(606, 66);
            this.SuppCodeGridLookUpEdit.Name = "SuppCodeGridLookUpEdit";
            this.SuppCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SuppCodeGridLookUpEdit.Properties.DataSource = this.spGetSuppliersBindingSource;
            this.SuppCodeGridLookUpEdit.Properties.DisplayMember = "Supplier Name";
            this.SuppCodeGridLookUpEdit.Properties.NullText = "";
            this.SuppCodeGridLookUpEdit.Properties.ValueMember = "Supplier Code";
            this.SuppCodeGridLookUpEdit.Properties.View = this.gridView1;
            this.SuppCodeGridLookUpEdit.Size = new System.Drawing.Size(445, 20);
            this.SuppCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.SuppCodeGridLookUpEdit.TabIndex = 5;
            // 
            // spGetSuppliersBindingSource
            // 
            this.spGetSuppliersBindingSource.DataMember = "spGetSuppliers";
            this.spGetSuppliersBindingSource.DataSource = this.dsSupplierBalances;
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
            // BalanceTextEdit
            // 
            this.BalanceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBalanceBindingSource, "Balance", true));
            this.BalanceTextEdit.Location = new System.Drawing.Point(90, 90);
            this.BalanceTextEdit.Name = "BalanceTextEdit";
            this.BalanceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BalanceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BalanceTextEdit.Properties.Mask.EditMask = "G";
            this.BalanceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BalanceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BalanceTextEdit.Size = new System.Drawing.Size(446, 20);
            this.BalanceTextEdit.StyleController = this.dataLayoutControl1;
            this.BalanceTextEdit.TabIndex = 6;
            // 
            // CurrencyGridLookUpEdit
            // 
            this.CurrencyGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBalanceBindingSource, "Currency", true));
            this.CurrencyGridLookUpEdit.Location = new System.Drawing.Point(606, 90);
            this.CurrencyGridLookUpEdit.Name = "CurrencyGridLookUpEdit";
            this.CurrencyGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CurrencyGridLookUpEdit.Properties.DataSource = this.spgetCurrenciesBindingSource;
            this.CurrencyGridLookUpEdit.Properties.DisplayMember = "CurrCode";
            this.CurrencyGridLookUpEdit.Properties.NullText = "";
            this.CurrencyGridLookUpEdit.Properties.ValueMember = "CurrCode";
            this.CurrencyGridLookUpEdit.Properties.View = this.gridView2;
            this.CurrencyGridLookUpEdit.Size = new System.Drawing.Size(445, 20);
            this.CurrencyGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CurrencyGridLookUpEdit.TabIndex = 7;
            // 
            // spgetCurrenciesBindingSource
            // 
            this.spgetCurrenciesBindingSource.DataMember = "spgetCurrencies";
            this.spgetCurrenciesBindingSource.DataSource = this.dsSupplierBalances;
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
            // BalanceDateDateEdit
            // 
            this.BalanceDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBalanceBindingSource, "BalanceDate", true));
            this.BalanceDateDateEdit.EditValue = null;
            this.BalanceDateDateEdit.Location = new System.Drawing.Point(90, 114);
            this.BalanceDateDateEdit.Name = "BalanceDateDateEdit";
            this.BalanceDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BalanceDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BalanceDateDateEdit.Size = new System.Drawing.Size(446, 20);
            this.BalanceDateDateEdit.StyleController = this.dataLayoutControl1;
            this.BalanceDateDateEdit.TabIndex = 8;
            // 
            // ReferenceTextEdit
            // 
            this.ReferenceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBalanceBindingSource, "Reference", true));
            this.ReferenceTextEdit.Location = new System.Drawing.Point(606, 114);
            this.ReferenceTextEdit.Name = "ReferenceTextEdit";
            this.ReferenceTextEdit.Size = new System.Drawing.Size(445, 20);
            this.ReferenceTextEdit.StyleController = this.dataLayoutControl1;
            this.ReferenceTextEdit.TabIndex = 9;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBalanceBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(90, 138);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(446, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1075, 483);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(1055, 463);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1055, 301);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForReference,
            this.ItemForSuppCode,
            this.ItemForCurrency,
            this.ItemForCostCenter,
            this.ItemForBalanceDate,
            this.ItemForRemarks,
            this.ItemForBalance});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1055, 138);
            this.layoutControlGroup3.Text = "Supplier Balances";
            // 
            // ItemForReference
            // 
            this.ItemForReference.Control = this.ReferenceTextEdit;
            this.ItemForReference.Location = new System.Drawing.Point(516, 48);
            this.ItemForReference.Name = "ItemForReference";
            this.ItemForReference.Size = new System.Drawing.Size(515, 48);
            this.ItemForReference.Text = "Reference";
            this.ItemForReference.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForSuppCode
            // 
            this.ItemForSuppCode.Control = this.SuppCodeGridLookUpEdit;
            this.ItemForSuppCode.Location = new System.Drawing.Point(516, 0);
            this.ItemForSuppCode.Name = "ItemForSuppCode";
            this.ItemForSuppCode.Size = new System.Drawing.Size(515, 24);
            this.ItemForSuppCode.Text = "Supp Code";
            this.ItemForSuppCode.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForCurrency
            // 
            this.ItemForCurrency.Control = this.CurrencyGridLookUpEdit;
            this.ItemForCurrency.Location = new System.Drawing.Point(516, 24);
            this.ItemForCurrency.Name = "ItemForCurrency";
            this.ItemForCurrency.Size = new System.Drawing.Size(515, 24);
            this.ItemForCurrency.Text = "Currency";
            this.ItemForCurrency.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(516, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForBalanceDate
            // 
            this.ItemForBalanceDate.Control = this.BalanceDateDateEdit;
            this.ItemForBalanceDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForBalanceDate.Name = "ItemForBalanceDate";
            this.ItemForBalanceDate.Size = new System.Drawing.Size(516, 24);
            this.ItemForBalanceDate.Text = "Balance Date";
            this.ItemForBalanceDate.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 72);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(516, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForBalance
            // 
            this.ItemForBalance.Control = this.BalanceTextEdit;
            this.ItemForBalance.Location = new System.Drawing.Point(0, 24);
            this.ItemForBalance.Name = "ItemForBalance";
            this.ItemForBalance.Size = new System.Drawing.Size(516, 24);
            this.ItemForBalance.Text = "Balance";
            this.ItemForBalance.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1055, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectSupplierBalanceTableAdapter
            // 
            this.spSelectSupplierBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllSupplierBalanceTableAdapter
            // 
            this.spSelectAllSupplierBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // spGetSuppliersTableAdapter
            // 
            this.spGetSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCurrenciesTableAdapter
            // 
            this.spgetCurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // frmSupplierBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 483);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmSupplierBalances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Balances";
            this.Load += new System.EventHandler(this.frmSupplierBalances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplierBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuppCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalanceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectSupplierBalanceBindingSource;
        private Class.DataSet.dsSupplierBalances dsSupplierBalances;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit SuppCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit BalanceTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit CurrencyGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit BalanceDateDateEdit;
        private DevExpress.XtraEditors.TextEdit ReferenceTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSuppCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBalance;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrency;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBalanceDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReference;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private Class.DataSet.dsSupplierBalancesTableAdapters.spSelectSupplierBalanceTableAdapter spSelectSupplierBalanceTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spSelectAllSupplierBalanceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppName;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colBalanceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReference;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private Class.DataSet.dsSupplierBalancesTableAdapters.spSelectAllSupplierBalanceTableAdapter spSelectAllSupplierBalanceTableAdapter;
        private System.Windows.Forms.BindingSource spGetSuppliersBindingSource;
        private Class.DataSet.dsSupplierBalancesTableAdapters.spGetSuppliersTableAdapter spGetSuppliersTableAdapter;
        private System.Windows.Forms.BindingSource spgetCurrenciesBindingSource;
        private Class.DataSet.dsSupplierBalancesTableAdapters.spgetCurrenciesTableAdapter spgetCurrenciesTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsSupplierBalancesTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
    }
}