namespace Master.Forms
{
    partial class frmChequeBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeBooks));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllChequeBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsChequeBooks = new Master.Class.DataSet.dsChequeBooks();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChequeBookNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIssued = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CountryCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectChequeBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BankCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BranchCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AccNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ChequeBookNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FirstChequeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LastChequeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DateIssuedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCountryCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBankCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranchCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForChequeBookNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFirstCheque = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastCheque = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDateIssued = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectChequeBooksTableAdapter = new Master.Class.DataSet.dsChequeBooksTableAdapters.spSelectChequeBooksTableAdapter();
            this.spSelectAllChequeBooksTableAdapter = new Master.Class.DataSet.dsChequeBooksTableAdapters.spSelectAllChequeBooksTableAdapter();
            this.spgetAllCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetAllCountriesTableAdapter = new Master.Class.DataSet.dsChequeBooksTableAdapters.spgetAllCountriesTableAdapter();
            this.spgetAllBanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetAllBanksTableAdapter = new Master.Class.DataSet.dsChequeBooksTableAdapters.spgetAllBanksTableAdapter();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsChequeBooksTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spgetBankBranchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetBankBranchesTableAdapter = new Master.Class.DataSet.dsChequeBooksTableAdapters.spgetBankBranchesTableAdapter();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
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
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllChequeBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChequeBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectChequeBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequeBookNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChequeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastChequeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIssuedDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIssuedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForChequeBookNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateIssued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllBanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetBankBranchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CountryCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BankCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BranchCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AccNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ChequeBookNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FirstChequeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LastChequeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DateIssuedDateEdit);
            this.dataLayoutControl1.DataSource = this.spSelectChequeBooksBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(926, 430);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllChequeBooksBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 198);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(902, 220);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllChequeBooksBindingSource
            // 
            this.spSelectAllChequeBooksBindingSource.DataMember = "spSelectAllChequeBooks";
            this.spSelectAllChequeBooksBindingSource.DataSource = this.dsChequeBooks;
            // 
            // dsChequeBooks
            // 
            this.dsChequeBooks.DataSetName = "dsChequeBooks";
            this.dsChequeBooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCountryCode,
            this.colCostCenter,
            this.colBankCode,
            this.colBankName,
            this.colBranchCode,
            this.colBranchName,
            this.colAccNumber,
            this.colAccName,
            this.colChequeBookNo,
            this.colFirstCheque,
            this.colLastCheque,
            this.colDateIssued});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.Visible = true;
            this.colCountryCode.VisibleIndex = 1;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 2;
            // 
            // colBankCode
            // 
            this.colBankCode.FieldName = "BankCode";
            this.colBankCode.Name = "colBankCode";
            this.colBankCode.Visible = true;
            this.colBankCode.VisibleIndex = 3;
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 4;
            // 
            // colBranchCode
            // 
            this.colBranchCode.FieldName = "BranchCode";
            this.colBranchCode.Name = "colBranchCode";
            this.colBranchCode.Visible = true;
            this.colBranchCode.VisibleIndex = 5;
            // 
            // colBranchName
            // 
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 6;
            // 
            // colAccNumber
            // 
            this.colAccNumber.FieldName = "AccNumber";
            this.colAccNumber.Name = "colAccNumber";
            this.colAccNumber.Visible = true;
            this.colAccNumber.VisibleIndex = 7;
            // 
            // colAccName
            // 
            this.colAccName.FieldName = "AccName";
            this.colAccName.Name = "colAccName";
            this.colAccName.Visible = true;
            this.colAccName.VisibleIndex = 8;
            // 
            // colChequeBookNo
            // 
            this.colChequeBookNo.FieldName = "ChequeBookNo";
            this.colChequeBookNo.Name = "colChequeBookNo";
            this.colChequeBookNo.Visible = true;
            this.colChequeBookNo.VisibleIndex = 9;
            // 
            // colFirstCheque
            // 
            this.colFirstCheque.FieldName = "FirstCheque";
            this.colFirstCheque.Name = "colFirstCheque";
            this.colFirstCheque.Visible = true;
            this.colFirstCheque.VisibleIndex = 10;
            // 
            // colLastCheque
            // 
            this.colLastCheque.FieldName = "LastCheque";
            this.colLastCheque.Name = "colLastCheque";
            this.colLastCheque.Visible = true;
            this.colLastCheque.VisibleIndex = 11;
            // 
            // colDateIssued
            // 
            this.colDateIssued.FieldName = "DateIssued";
            this.colDateIssued.Name = "colDateIssued";
            this.colDateIssued.Visible = true;
            this.colDateIssued.VisibleIndex = 12;
            // 
            // CountryCodeGridLookUpEdit
            // 
            this.CountryCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "CountryCode", true));
            this.CountryCodeGridLookUpEdit.Location = new System.Drawing.Point(106, 66);
            this.CountryCodeGridLookUpEdit.Name = "CountryCodeGridLookUpEdit";
            this.CountryCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryCodeGridLookUpEdit.Properties.DataSource = this.spgetAllCountriesBindingSource;
            this.CountryCodeGridLookUpEdit.Properties.DisplayMember = "CountryName";
            this.CountryCodeGridLookUpEdit.Properties.NullText = "";
            this.CountryCodeGridLookUpEdit.Properties.ValueMember = "CountryCode";
            this.CountryCodeGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CountryCodeGridLookUpEdit.Size = new System.Drawing.Size(356, 20);
            this.CountryCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CountryCodeGridLookUpEdit.TabIndex = 4;
            // 
            // spSelectChequeBooksBindingSource
            // 
            this.spSelectChequeBooksBindingSource.DataMember = "spSelectChequeBooks";
            this.spSelectChequeBooksBindingSource.DataSource = this.dsChequeBooks;
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
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(548, 66);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridView1;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(354, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BankCodeGridLookUpEdit
            // 
            this.BankCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "BankCode", true));
            this.BankCodeGridLookUpEdit.Location = new System.Drawing.Point(106, 90);
            this.BankCodeGridLookUpEdit.Name = "BankCodeGridLookUpEdit";
            this.BankCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BankCodeGridLookUpEdit.Properties.DataSource = this.spgetAllBanksBindingSource;
            this.BankCodeGridLookUpEdit.Properties.DisplayMember = "BankName";
            this.BankCodeGridLookUpEdit.Properties.NullText = "";
            this.BankCodeGridLookUpEdit.Properties.ValueMember = "BankCode";
            this.BankCodeGridLookUpEdit.Properties.View = this.gridView2;
            this.BankCodeGridLookUpEdit.Size = new System.Drawing.Size(356, 20);
            this.BankCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BankCodeGridLookUpEdit.TabIndex = 6;
            this.BankCodeGridLookUpEdit.EditValueChanged += new System.EventHandler(this.BankCodeGridLookUpEdit_EditValueChanged);
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
            // BranchCodeGridLookUpEdit
            // 
            this.BranchCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "BranchCode", true));
            this.BranchCodeGridLookUpEdit.Location = new System.Drawing.Point(548, 90);
            this.BranchCodeGridLookUpEdit.Name = "BranchCodeGridLookUpEdit";
            this.BranchCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranchCodeGridLookUpEdit.Properties.DataSource = this.spgetBankBranchesBindingSource;
            this.BranchCodeGridLookUpEdit.Properties.DisplayMember = "BranchName";
            this.BranchCodeGridLookUpEdit.Properties.NullText = "";
            this.BranchCodeGridLookUpEdit.Properties.ValueMember = "BranchCode";
            this.BranchCodeGridLookUpEdit.Properties.View = this.gridView3;
            this.BranchCodeGridLookUpEdit.Size = new System.Drawing.Size(354, 20);
            this.BranchCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BranchCodeGridLookUpEdit.TabIndex = 7;
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
            // AccNumberTextEdit
            // 
            this.AccNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "AccNumber", true));
            this.AccNumberTextEdit.Location = new System.Drawing.Point(106, 114);
            this.AccNumberTextEdit.Name = "AccNumberTextEdit";
            this.AccNumberTextEdit.Size = new System.Drawing.Size(356, 20);
            this.AccNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNumberTextEdit.TabIndex = 8;
            // 
            // AccNameTextEdit
            // 
            this.AccNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "AccName", true));
            this.AccNameTextEdit.Location = new System.Drawing.Point(548, 114);
            this.AccNameTextEdit.Name = "AccNameTextEdit";
            this.AccNameTextEdit.Size = new System.Drawing.Size(354, 20);
            this.AccNameTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNameTextEdit.TabIndex = 9;
            // 
            // ChequeBookNoTextEdit
            // 
            this.ChequeBookNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "ChequeBookNo", true));
            this.ChequeBookNoTextEdit.Location = new System.Drawing.Point(106, 138);
            this.ChequeBookNoTextEdit.Name = "ChequeBookNoTextEdit";
            this.ChequeBookNoTextEdit.Size = new System.Drawing.Size(356, 20);
            this.ChequeBookNoTextEdit.StyleController = this.dataLayoutControl1;
            this.ChequeBookNoTextEdit.TabIndex = 10;
            // 
            // FirstChequeTextEdit
            // 
            this.FirstChequeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "FirstCheque", true));
            this.FirstChequeTextEdit.Location = new System.Drawing.Point(548, 138);
            this.FirstChequeTextEdit.Name = "FirstChequeTextEdit";
            this.FirstChequeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.FirstChequeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FirstChequeTextEdit.Properties.Mask.EditMask = "N0";
            this.FirstChequeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.FirstChequeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.FirstChequeTextEdit.Size = new System.Drawing.Size(354, 20);
            this.FirstChequeTextEdit.StyleController = this.dataLayoutControl1;
            this.FirstChequeTextEdit.TabIndex = 11;
            // 
            // LastChequeTextEdit
            // 
            this.LastChequeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "LastCheque", true));
            this.LastChequeTextEdit.Location = new System.Drawing.Point(106, 162);
            this.LastChequeTextEdit.Name = "LastChequeTextEdit";
            this.LastChequeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.LastChequeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LastChequeTextEdit.Properties.Mask.EditMask = "N0";
            this.LastChequeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.LastChequeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.LastChequeTextEdit.Size = new System.Drawing.Size(356, 20);
            this.LastChequeTextEdit.StyleController = this.dataLayoutControl1;
            this.LastChequeTextEdit.TabIndex = 12;
            // 
            // DateIssuedDateEdit
            // 
            this.DateIssuedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectChequeBooksBindingSource, "DateIssued", true));
            this.DateIssuedDateEdit.EditValue = null;
            this.DateIssuedDateEdit.Location = new System.Drawing.Point(548, 162);
            this.DateIssuedDateEdit.Name = "DateIssuedDateEdit";
            this.DateIssuedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateIssuedDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateIssuedDateEdit.Size = new System.Drawing.Size(354, 20);
            this.DateIssuedDateEdit.StyleController = this.dataLayoutControl1;
            this.DateIssuedDateEdit.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(926, 430);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(906, 410);
            // 
            // ItemForCountryCode
            // 
            this.ItemForCountryCode.Control = this.CountryCodeGridLookUpEdit;
            this.ItemForCountryCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCountryCode.Name = "ItemForCountryCode";
            this.ItemForCountryCode.Size = new System.Drawing.Size(442, 24);
            this.ItemForCountryCode.Text = "Country Code";
            this.ItemForCountryCode.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(442, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(440, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForBankCode
            // 
            this.ItemForBankCode.Control = this.BankCodeGridLookUpEdit;
            this.ItemForBankCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForBankCode.Name = "ItemForBankCode";
            this.ItemForBankCode.Size = new System.Drawing.Size(442, 24);
            this.ItemForBankCode.Text = "Bank Code";
            this.ItemForBankCode.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForBranchCode
            // 
            this.ItemForBranchCode.Control = this.BranchCodeGridLookUpEdit;
            this.ItemForBranchCode.Location = new System.Drawing.Point(442, 24);
            this.ItemForBranchCode.Name = "ItemForBranchCode";
            this.ItemForBranchCode.Size = new System.Drawing.Size(440, 24);
            this.ItemForBranchCode.Text = "Branch Code";
            this.ItemForBranchCode.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForAccNumber
            // 
            this.ItemForAccNumber.Control = this.AccNumberTextEdit;
            this.ItemForAccNumber.Location = new System.Drawing.Point(0, 48);
            this.ItemForAccNumber.Name = "ItemForAccNumber";
            this.ItemForAccNumber.Size = new System.Drawing.Size(442, 24);
            this.ItemForAccNumber.Text = "Acc Number";
            this.ItemForAccNumber.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForAccName
            // 
            this.ItemForAccName.Control = this.AccNameTextEdit;
            this.ItemForAccName.Location = new System.Drawing.Point(442, 48);
            this.ItemForAccName.Name = "ItemForAccName";
            this.ItemForAccName.Size = new System.Drawing.Size(440, 24);
            this.ItemForAccName.Text = "Acc Name";
            this.ItemForAccName.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForChequeBookNo
            // 
            this.ItemForChequeBookNo.Control = this.ChequeBookNoTextEdit;
            this.ItemForChequeBookNo.Location = new System.Drawing.Point(0, 72);
            this.ItemForChequeBookNo.Name = "ItemForChequeBookNo";
            this.ItemForChequeBookNo.Size = new System.Drawing.Size(442, 24);
            this.ItemForChequeBookNo.Text = "Cheque Book No";
            this.ItemForChequeBookNo.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForFirstCheque
            // 
            this.ItemForFirstCheque.Control = this.FirstChequeTextEdit;
            this.ItemForFirstCheque.Location = new System.Drawing.Point(442, 72);
            this.ItemForFirstCheque.Name = "ItemForFirstCheque";
            this.ItemForFirstCheque.Size = new System.Drawing.Size(440, 24);
            this.ItemForFirstCheque.Text = "First Cheque";
            this.ItemForFirstCheque.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForLastCheque
            // 
            this.ItemForLastCheque.Control = this.LastChequeTextEdit;
            this.ItemForLastCheque.Location = new System.Drawing.Point(0, 96);
            this.ItemForLastCheque.Name = "ItemForLastCheque";
            this.ItemForLastCheque.Size = new System.Drawing.Size(442, 24);
            this.ItemForLastCheque.Text = "Last Cheque";
            this.ItemForLastCheque.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForDateIssued
            // 
            this.ItemForDateIssued.Control = this.DateIssuedDateEdit;
            this.ItemForDateIssued.Location = new System.Drawing.Point(442, 96);
            this.ItemForDateIssued.Name = "ItemForDateIssued";
            this.ItemForDateIssued.Size = new System.Drawing.Size(440, 24);
            this.ItemForDateIssued.Text = "Date Issued";
            this.ItemForDateIssued.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(906, 224);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectChequeBooksTableAdapter
            // 
            this.spSelectChequeBooksTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllChequeBooksTableAdapter
            // 
            this.spSelectAllChequeBooksTableAdapter.ClearBeforeFill = true;
            // 
            // spgetAllCountriesBindingSource
            // 
            this.spgetAllCountriesBindingSource.DataMember = "spgetAllCountries";
            this.spgetAllCountriesBindingSource.DataSource = this.dsChequeBooks;
            // 
            // spgetAllCountriesTableAdapter
            // 
            this.spgetAllCountriesTableAdapter.ClearBeforeFill = true;
            // 
            // spgetAllBanksBindingSource
            // 
            this.spgetAllBanksBindingSource.DataMember = "spgetAllBanks";
            this.spgetAllBanksBindingSource.DataSource = this.dsChequeBooks;
            // 
            // spgetAllBanksTableAdapter
            // 
            this.spgetAllBanksTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsChequeBooks;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetBankBranchesBindingSource
            // 
            this.spgetBankBranchesBindingSource.DataMember = "spgetBankBranches";
            this.spgetBankBranchesBindingSource.DataSource = this.dsChequeBooks;
            // 
            // spgetBankBranchesTableAdapter
            // 
            this.spgetBankBranchesTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCountryCode,
            this.ItemForBankCode,
            this.ItemForAccNumber,
            this.ItemForChequeBookNo,
            this.ItemForLastCheque,
            this.ItemForDateIssued,
            this.ItemForFirstCheque,
            this.ItemForAccName,
            this.ItemForBranchCode,
            this.ItemForCostCenter});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(906, 162);
            this.layoutControlGroup3.Text = "Cheque Books";
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
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(906, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmChequeBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 430);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmChequeBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Books";
            this.Load += new System.EventHandler(this.frmChequeBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllChequeBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChequeBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectChequeBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequeBookNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChequeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastChequeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIssuedDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIssuedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForChequeBookNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateIssued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllBanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetBankBranchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllChequeBooksBindingSource;
        private Class.DataSet.dsChequeBooks dsChequeBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colBankCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAccName;
        private DevExpress.XtraGrid.Columns.GridColumn colChequeBookNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIssued;
        private DevExpress.XtraEditors.GridLookUpEdit CountryCodeGridLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectChequeBooksBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit BankCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit BranchCodeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.TextEdit AccNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit AccNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ChequeBookNoTextEdit;
        private DevExpress.XtraEditors.TextEdit FirstChequeTextEdit;
        private DevExpress.XtraEditors.TextEdit LastChequeTextEdit;
        private DevExpress.XtraEditors.DateEdit DateIssuedDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountryCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBankCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForChequeBookNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstCheque;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastCheque;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDateIssued;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsChequeBooksTableAdapters.spSelectChequeBooksTableAdapter spSelectChequeBooksTableAdapter;
        private Class.DataSet.dsChequeBooksTableAdapters.spSelectAllChequeBooksTableAdapter spSelectAllChequeBooksTableAdapter;
        private System.Windows.Forms.BindingSource spgetAllCountriesBindingSource;
        private Class.DataSet.dsChequeBooksTableAdapters.spgetAllCountriesTableAdapter spgetAllCountriesTableAdapter;
        private System.Windows.Forms.BindingSource spgetAllBanksBindingSource;
        private Class.DataSet.dsChequeBooksTableAdapters.spgetAllBanksTableAdapter spgetAllBanksTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsChequeBooksTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spgetBankBranchesBindingSource;
        private Class.DataSet.dsChequeBooksTableAdapters.spgetBankBranchesTableAdapter spgetBankBranchesTableAdapter;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
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