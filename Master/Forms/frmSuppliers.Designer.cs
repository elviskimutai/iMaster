namespace Master.Forms
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
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
            this.spSelectAllSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSuppliers = new Master.Class.DataSet.dsSuppliers();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTerms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuppCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuppNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CostCenterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PaymentTermsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BranchCodeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spgetBankBranchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankAccNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BusinessNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CurrencyLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetCurrenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BankCodeLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetAllBanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CountryCodeLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spgetAllCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForSuppCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForServiceType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaymentTerms = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranchCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBusinessNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBankAccNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBankCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountryCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelephone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSuppName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectSupplierTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spSelectSupplierTableAdapter();
            this.spSelectAllSupplierTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spSelectAllSupplierTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spgetBankBranchesTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spgetBankBranchesTableAdapter();
            this.spgetAllBanksTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spgetAllBanksTableAdapter();
            this.spgetAllCountriesTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spgetAllCountriesTableAdapter();
            this.spgetCurrenciesTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spgetCurrenciesTableAdapter();
            this.ServiceTypeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spgetUDCByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetUDCByCategoryTableAdapter = new Master.Class.DataSet.dsSuppliersTableAdapters.spgetUDCByCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTermsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCodeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetBankBranchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankCodeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllBanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCodeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuppCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBusinessNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuppName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.SuppCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SuppNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelephoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MobileTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PaymentTermsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BranchCodeLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BankAccNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BusinessNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrencyLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BankCodeLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryCodeLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ServiceTypeTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectSupplierBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(918, 404);
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
            this.toolStrip1.TabIndex = 27;
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
            this.gridControl1.DataSource = this.spSelectAllSupplierBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 270);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(894, 122);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllSupplierBindingSource
            // 
            this.spSelectAllSupplierBindingSource.DataMember = "spSelectAllSupplier";
            this.spSelectAllSupplierBindingSource.DataSource = this.dsSuppliers;
            // 
            // dsSuppliers
            // 
            this.dsSuppliers.DataSetName = "dsSuppliers";
            this.dsSuppliers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSuppCode,
            this.colSuppName,
            this.colServiceType,
            this.colCostCenter,
            this.colEmail,
            this.colTelephone,
            this.colMobile,
            this.colPostalAddress,
            this.colPaymentTerms,
            this.colCountryCode,
            this.colCurrency,
            this.colBankCode,
            this.colBranchCode,
            this.colBankAccNo,
            this.colBusinessNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSuppCode
            // 
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.Visible = true;
            this.colSuppCode.VisibleIndex = 0;
            // 
            // colSuppName
            // 
            this.colSuppName.FieldName = "SuppName";
            this.colSuppName.Name = "colSuppName";
            this.colSuppName.Visible = true;
            this.colSuppName.VisibleIndex = 1;
            // 
            // colServiceType
            // 
            this.colServiceType.FieldName = "ServiceType";
            this.colServiceType.Name = "colServiceType";
            this.colServiceType.Visible = true;
            this.colServiceType.VisibleIndex = 2;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colTelephone
            // 
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 5;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 6;
            // 
            // colPostalAddress
            // 
            this.colPostalAddress.FieldName = "PostalAddress";
            this.colPostalAddress.Name = "colPostalAddress";
            this.colPostalAddress.Visible = true;
            this.colPostalAddress.VisibleIndex = 7;
            // 
            // colPaymentTerms
            // 
            this.colPaymentTerms.FieldName = "PaymentTerms";
            this.colPaymentTerms.Name = "colPaymentTerms";
            this.colPaymentTerms.Visible = true;
            this.colPaymentTerms.VisibleIndex = 8;
            // 
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.Visible = true;
            this.colCountryCode.VisibleIndex = 9;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 10;
            // 
            // colBankCode
            // 
            this.colBankCode.FieldName = "BankCode";
            this.colBankCode.Name = "colBankCode";
            this.colBankCode.Visible = true;
            this.colBankCode.VisibleIndex = 11;
            // 
            // colBranchCode
            // 
            this.colBranchCode.FieldName = "BranchCode";
            this.colBranchCode.Name = "colBranchCode";
            this.colBranchCode.Visible = true;
            this.colBranchCode.VisibleIndex = 12;
            // 
            // colBankAccNo
            // 
            this.colBankAccNo.FieldName = "BankAccNo";
            this.colBankAccNo.Name = "colBankAccNo";
            this.colBankAccNo.Visible = true;
            this.colBankAccNo.VisibleIndex = 13;
            // 
            // colBusinessNo
            // 
            this.colBusinessNo.FieldName = "BusinessNo";
            this.colBusinessNo.Name = "colBusinessNo";
            this.colBusinessNo.Visible = true;
            this.colBusinessNo.VisibleIndex = 14;
            // 
            // SuppCodeTextEdit
            // 
            this.SuppCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "SuppCode", true));
            this.SuppCodeTextEdit.Enabled = false;
            this.SuppCodeTextEdit.Location = new System.Drawing.Point(101, 66);
            this.SuppCodeTextEdit.Name = "SuppCodeTextEdit";
            this.SuppCodeTextEdit.Size = new System.Drawing.Size(356, 20);
            this.SuppCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.SuppCodeTextEdit.TabIndex = 4;
            // 
            // spSelectSupplierBindingSource
            // 
            this.spSelectSupplierBindingSource.DataMember = "spSelectSupplier";
            this.spSelectSupplierBindingSource.DataSource = this.dsSuppliers;
            // 
            // SuppNameTextEdit
            // 
            this.SuppNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "SuppName", true));
            this.SuppNameTextEdit.Location = new System.Drawing.Point(538, 66);
            this.SuppNameTextEdit.Name = "SuppNameTextEdit";
            this.SuppNameTextEdit.Size = new System.Drawing.Size(356, 20);
            this.SuppNameTextEdit.StyleController = this.dataLayoutControl1;
            this.SuppNameTextEdit.TabIndex = 5;
            // 
            // CostCenterLookUpEdit
            // 
            this.CostCenterLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "CostCenter", true));
            this.CostCenterLookUpEdit.Location = new System.Drawing.Point(538, 90);
            this.CostCenterLookUpEdit.Name = "CostCenterLookUpEdit";
            this.CostCenterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterLookUpEdit.Properties.NullText = "";
            this.CostCenterLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterLookUpEdit.Size = new System.Drawing.Size(356, 20);
            this.CostCenterLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterLookUpEdit.TabIndex = 7;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsSuppliers;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(101, 114);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(356, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 8;
            // 
            // TelephoneTextEdit
            // 
            this.TelephoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "Telephone", true));
            this.TelephoneTextEdit.Location = new System.Drawing.Point(538, 114);
            this.TelephoneTextEdit.Name = "TelephoneTextEdit";
            this.TelephoneTextEdit.Size = new System.Drawing.Size(356, 20);
            this.TelephoneTextEdit.StyleController = this.dataLayoutControl1;
            this.TelephoneTextEdit.TabIndex = 9;
            // 
            // MobileTextEdit
            // 
            this.MobileTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "Mobile", true));
            this.MobileTextEdit.Location = new System.Drawing.Point(101, 138);
            this.MobileTextEdit.Name = "MobileTextEdit";
            this.MobileTextEdit.Size = new System.Drawing.Size(356, 20);
            this.MobileTextEdit.StyleController = this.dataLayoutControl1;
            this.MobileTextEdit.TabIndex = 10;
            // 
            // PostalAddressTextEdit
            // 
            this.PostalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "PostalAddress", true));
            this.PostalAddressTextEdit.Location = new System.Drawing.Point(538, 138);
            this.PostalAddressTextEdit.Name = "PostalAddressTextEdit";
            this.PostalAddressTextEdit.Size = new System.Drawing.Size(356, 20);
            this.PostalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalAddressTextEdit.TabIndex = 11;
            // 
            // PaymentTermsTextEdit
            // 
            this.PaymentTermsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "PaymentTerms", true));
            this.PaymentTermsTextEdit.Location = new System.Drawing.Point(101, 162);
            this.PaymentTermsTextEdit.Name = "PaymentTermsTextEdit";
            this.PaymentTermsTextEdit.Size = new System.Drawing.Size(356, 20);
            this.PaymentTermsTextEdit.StyleController = this.dataLayoutControl1;
            this.PaymentTermsTextEdit.TabIndex = 12;
            // 
            // BranchCodeLookUpEdit
            // 
            this.BranchCodeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "BranchCode", true));
            this.BranchCodeLookUpEdit.Location = new System.Drawing.Point(101, 210);
            this.BranchCodeLookUpEdit.Name = "BranchCodeLookUpEdit";
            this.BranchCodeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranchCodeLookUpEdit.Properties.DataSource = this.spgetBankBranchesBindingSource;
            this.BranchCodeLookUpEdit.Properties.DisplayMember = "BranchName";
            this.BranchCodeLookUpEdit.Properties.NullText = "";
            this.BranchCodeLookUpEdit.Properties.ValueMember = "BranchCode";
            this.BranchCodeLookUpEdit.Size = new System.Drawing.Size(356, 20);
            this.BranchCodeLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BranchCodeLookUpEdit.TabIndex = 16;
            // 
            // spgetBankBranchesBindingSource
            // 
            this.spgetBankBranchesBindingSource.DataMember = "spgetBankBranches";
            this.spgetBankBranchesBindingSource.DataSource = this.dsSuppliers;
            // 
            // BankAccNoTextEdit
            // 
            this.BankAccNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "BankAccNo", true));
            this.BankAccNoTextEdit.Location = new System.Drawing.Point(538, 210);
            this.BankAccNoTextEdit.Name = "BankAccNoTextEdit";
            this.BankAccNoTextEdit.Size = new System.Drawing.Size(356, 20);
            this.BankAccNoTextEdit.StyleController = this.dataLayoutControl1;
            this.BankAccNoTextEdit.TabIndex = 17;
            // 
            // BusinessNoTextEdit
            // 
            this.BusinessNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "BusinessNo", true));
            this.BusinessNoTextEdit.Location = new System.Drawing.Point(101, 234);
            this.BusinessNoTextEdit.Name = "BusinessNoTextEdit";
            this.BusinessNoTextEdit.Size = new System.Drawing.Size(356, 20);
            this.BusinessNoTextEdit.StyleController = this.dataLayoutControl1;
            this.BusinessNoTextEdit.TabIndex = 18;
            // 
            // CurrencyLookUpEdit
            // 
            this.CurrencyLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "Currency", true));
            this.CurrencyLookUpEdit.Location = new System.Drawing.Point(101, 186);
            this.CurrencyLookUpEdit.Name = "CurrencyLookUpEdit";
            this.CurrencyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CurrencyLookUpEdit.Properties.DataSource = this.spgetCurrenciesBindingSource;
            this.CurrencyLookUpEdit.Properties.DisplayMember = "CurrDesc";
            this.CurrencyLookUpEdit.Properties.NullText = "";
            this.CurrencyLookUpEdit.Properties.ValueMember = "CurrCode";
            this.CurrencyLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CurrencyLookUpEdit.Size = new System.Drawing.Size(356, 20);
            this.CurrencyLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CurrencyLookUpEdit.TabIndex = 14;
            // 
            // spgetCurrenciesBindingSource
            // 
            this.spgetCurrenciesBindingSource.DataMember = "spgetCurrencies";
            this.spgetCurrenciesBindingSource.DataSource = this.dsSuppliers;
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
            // BankCodeLookUpEdit
            // 
            this.BankCodeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "BankCode", true));
            this.BankCodeLookUpEdit.Location = new System.Drawing.Point(538, 186);
            this.BankCodeLookUpEdit.Name = "BankCodeLookUpEdit";
            this.BankCodeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BankCodeLookUpEdit.Properties.DataSource = this.spgetAllBanksBindingSource;
            this.BankCodeLookUpEdit.Properties.DisplayMember = "BankName";
            this.BankCodeLookUpEdit.Properties.NullText = "";
            this.BankCodeLookUpEdit.Properties.ValueMember = "BankCode";
            this.BankCodeLookUpEdit.Properties.View = this.gridView2;
            this.BankCodeLookUpEdit.Size = new System.Drawing.Size(356, 20);
            this.BankCodeLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BankCodeLookUpEdit.TabIndex = 15;
            this.BankCodeLookUpEdit.EditValueChanged += new System.EventHandler(this.BankCodeLookUpEdit_EditValueChanged);
            // 
            // spgetAllBanksBindingSource
            // 
            this.spgetAllBanksBindingSource.DataMember = "spgetAllBanks";
            this.spgetAllBanksBindingSource.DataSource = this.dsSuppliers;
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
            // CountryCodeLookUpEdit
            // 
            this.CountryCodeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "CountryCode", true));
            this.CountryCodeLookUpEdit.Location = new System.Drawing.Point(538, 162);
            this.CountryCodeLookUpEdit.Name = "CountryCodeLookUpEdit";
            this.CountryCodeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryCodeLookUpEdit.Properties.DataSource = this.spgetAllCountriesBindingSource;
            this.CountryCodeLookUpEdit.Properties.DisplayMember = "CountryName";
            this.CountryCodeLookUpEdit.Properties.NullText = "";
            this.CountryCodeLookUpEdit.Properties.ValueMember = "CountryCode";
            this.CountryCodeLookUpEdit.Properties.View = this.gridView3;
            this.CountryCodeLookUpEdit.Size = new System.Drawing.Size(356, 20);
            this.CountryCodeLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CountryCodeLookUpEdit.TabIndex = 13;
            // 
            // spgetAllCountriesBindingSource
            // 
            this.spgetAllCountriesBindingSource.DataMember = "spgetAllCountries";
            this.spgetAllCountriesBindingSource.DataSource = this.dsSuppliers;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(918, 404);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(898, 384);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 258);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(898, 126);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSuppCode,
            this.ItemForServiceType,
            this.ItemForEmail,
            this.ItemForPaymentTerms,
            this.ItemForMobile,
            this.ItemForCurrency,
            this.ItemForBranchCode,
            this.ItemForBusinessNo,
            this.ItemForBankAccNo,
            this.ItemForBankCode,
            this.ItemForCountryCode,
            this.ItemForPostalAddress,
            this.ItemForTelephone,
            this.ItemForCostCenter,
            this.ItemForSuppName});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(898, 234);
            this.layoutControlGroup3.Text = "Suppliers";
            // 
            // ItemForSuppCode
            // 
            this.ItemForSuppCode.Control = this.SuppCodeTextEdit;
            this.ItemForSuppCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForSuppCode.Name = "ItemForSuppCode";
            this.ItemForSuppCode.Size = new System.Drawing.Size(437, 24);
            this.ItemForSuppCode.Text = "Supp Code";
            this.ItemForSuppCode.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForServiceType
            // 
            this.ItemForServiceType.Control = this.ServiceTypeTextEdit;
            this.ItemForServiceType.Location = new System.Drawing.Point(0, 24);
            this.ItemForServiceType.Name = "ItemForServiceType";
            this.ItemForServiceType.Size = new System.Drawing.Size(437, 24);
            this.ItemForServiceType.Text = "Service Type";
            this.ItemForServiceType.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(437, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForPaymentTerms
            // 
            this.ItemForPaymentTerms.Control = this.PaymentTermsTextEdit;
            this.ItemForPaymentTerms.Location = new System.Drawing.Point(0, 96);
            this.ItemForPaymentTerms.Name = "ItemForPaymentTerms";
            this.ItemForPaymentTerms.Size = new System.Drawing.Size(437, 24);
            this.ItemForPaymentTerms.Text = "Payment Terms";
            this.ItemForPaymentTerms.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForMobile
            // 
            this.ItemForMobile.Control = this.MobileTextEdit;
            this.ItemForMobile.Location = new System.Drawing.Point(0, 72);
            this.ItemForMobile.Name = "ItemForMobile";
            this.ItemForMobile.Size = new System.Drawing.Size(437, 24);
            this.ItemForMobile.Text = "Mobile";
            this.ItemForMobile.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCurrency
            // 
            this.ItemForCurrency.Control = this.CurrencyLookUpEdit;
            this.ItemForCurrency.Location = new System.Drawing.Point(0, 120);
            this.ItemForCurrency.Name = "ItemForCurrency";
            this.ItemForCurrency.Size = new System.Drawing.Size(437, 24);
            this.ItemForCurrency.Text = "Currency";
            this.ItemForCurrency.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForBranchCode
            // 
            this.ItemForBranchCode.Control = this.BranchCodeLookUpEdit;
            this.ItemForBranchCode.Location = new System.Drawing.Point(0, 144);
            this.ItemForBranchCode.Name = "ItemForBranchCode";
            this.ItemForBranchCode.Size = new System.Drawing.Size(437, 24);
            this.ItemForBranchCode.Text = "Branch Code";
            this.ItemForBranchCode.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForBusinessNo
            // 
            this.ItemForBusinessNo.Control = this.BusinessNoTextEdit;
            this.ItemForBusinessNo.Location = new System.Drawing.Point(0, 168);
            this.ItemForBusinessNo.Name = "ItemForBusinessNo";
            this.ItemForBusinessNo.Size = new System.Drawing.Size(437, 24);
            this.ItemForBusinessNo.Text = "Business No";
            this.ItemForBusinessNo.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForBankAccNo
            // 
            this.ItemForBankAccNo.Control = this.BankAccNoTextEdit;
            this.ItemForBankAccNo.Location = new System.Drawing.Point(437, 144);
            this.ItemForBankAccNo.Name = "ItemForBankAccNo";
            this.ItemForBankAccNo.Size = new System.Drawing.Size(437, 48);
            this.ItemForBankAccNo.Text = "Bank Acc No";
            this.ItemForBankAccNo.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForBankCode
            // 
            this.ItemForBankCode.Control = this.BankCodeLookUpEdit;
            this.ItemForBankCode.Location = new System.Drawing.Point(437, 120);
            this.ItemForBankCode.Name = "ItemForBankCode";
            this.ItemForBankCode.Size = new System.Drawing.Size(437, 24);
            this.ItemForBankCode.Text = "Bank Code";
            this.ItemForBankCode.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCountryCode
            // 
            this.ItemForCountryCode.Control = this.CountryCodeLookUpEdit;
            this.ItemForCountryCode.Location = new System.Drawing.Point(437, 96);
            this.ItemForCountryCode.Name = "ItemForCountryCode";
            this.ItemForCountryCode.Size = new System.Drawing.Size(437, 24);
            this.ItemForCountryCode.Text = "Country Code";
            this.ItemForCountryCode.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForPostalAddress
            // 
            this.ItemForPostalAddress.Control = this.PostalAddressTextEdit;
            this.ItemForPostalAddress.Location = new System.Drawing.Point(437, 72);
            this.ItemForPostalAddress.Name = "ItemForPostalAddress";
            this.ItemForPostalAddress.Size = new System.Drawing.Size(437, 24);
            this.ItemForPostalAddress.Text = "Postal Address";
            this.ItemForPostalAddress.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForTelephone
            // 
            this.ItemForTelephone.Control = this.TelephoneTextEdit;
            this.ItemForTelephone.Location = new System.Drawing.Point(437, 48);
            this.ItemForTelephone.Name = "ItemForTelephone";
            this.ItemForTelephone.Size = new System.Drawing.Size(437, 24);
            this.ItemForTelephone.Text = "Telephone";
            this.ItemForTelephone.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(437, 24);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(437, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForSuppName
            // 
            this.ItemForSuppName.Control = this.SuppNameTextEdit;
            this.ItemForSuppName.Location = new System.Drawing.Point(437, 0);
            this.ItemForSuppName.Name = "ItemForSuppName";
            this.ItemForSuppName.Size = new System.Drawing.Size(437, 24);
            this.ItemForSuppName.Text = "Supp Name";
            this.ItemForSuppName.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(898, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectSupplierTableAdapter
            // 
            this.spSelectSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllSupplierTableAdapter
            // 
            this.spSelectAllSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetBankBranchesTableAdapter
            // 
            this.spgetBankBranchesTableAdapter.ClearBeforeFill = true;
            // 
            // spgetAllBanksTableAdapter
            // 
            this.spgetAllBanksTableAdapter.ClearBeforeFill = true;
            // 
            // spgetAllCountriesTableAdapter
            // 
            this.spgetAllCountriesTableAdapter.ClearBeforeFill = true;
            // 
            // spgetCurrenciesTableAdapter
            // 
            this.spgetCurrenciesTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceTypeTextEdit
            // 
            this.ServiceTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSupplierBindingSource, "ServiceType", true));
            this.ServiceTypeTextEdit.Location = new System.Drawing.Point(101, 90);
            this.ServiceTypeTextEdit.Name = "ServiceTypeTextEdit";
            this.ServiceTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ServiceTypeTextEdit.Properties.DataSource = this.spgetUDCByCategoryBindingSource;
            this.ServiceTypeTextEdit.Properties.DisplayMember = "Description";
            this.ServiceTypeTextEdit.Properties.NullText = "";
            this.ServiceTypeTextEdit.Properties.ValueMember = "Code";
            this.ServiceTypeTextEdit.Properties.View = this.gridView4;
            this.ServiceTypeTextEdit.Size = new System.Drawing.Size(356, 20);
            this.ServiceTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.ServiceTypeTextEdit.TabIndex = 6;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // spgetUDCByCategoryBindingSource
            // 
            this.spgetUDCByCategoryBindingSource.DataMember = "spgetUDCByCategory";
            this.spgetUDCByCategoryBindingSource.DataSource = this.dsSuppliers;
            // 
            // spgetUDCByCategoryTableAdapter
            // 
            this.spgetUDCByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 404);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTermsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchCodeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetBankBranchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusinessNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetCurrenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankCodeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllBanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCodeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuppCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBusinessNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuppName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource spSelectSupplierBindingSource;
        private Class.DataSet.dsSuppliers dsSuppliers;
        private Class.DataSet.dsSuppliersTableAdapters.spSelectSupplierTableAdapter spSelectSupplierTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllSupplierBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppName;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTerms;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colBankCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessNo;
        private DevExpress.XtraEditors.TextEdit SuppCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit SuppNameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit CostCenterLookUpEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit TelephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit MobileTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PaymentTermsTextEdit;
        private DevExpress.XtraEditors.LookUpEdit BranchCodeLookUpEdit;
        private DevExpress.XtraEditors.TextEdit BankAccNoTextEdit;
        private DevExpress.XtraEditors.TextEdit BusinessNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSuppCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSuppName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForServiceType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelephone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaymentTerms;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountryCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrency;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBankCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBankAccNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBusinessNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsSuppliersTableAdapters.spSelectAllSupplierTableAdapter spSelectAllSupplierTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsSuppliersTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        
  
        private System.Windows.Forms.BindingSource spgetBankBranchesBindingSource;
        private Class.DataSet.dsSuppliersTableAdapters.spgetBankBranchesTableAdapter spgetBankBranchesTableAdapter;
        private System.Windows.Forms.BindingSource spgetAllBanksBindingSource;
        private Class.DataSet.dsSuppliersTableAdapters.spgetAllBanksTableAdapter spgetAllBanksTableAdapter;
        private System.Windows.Forms.BindingSource spgetAllCountriesBindingSource;
        private Class.DataSet.dsSuppliersTableAdapters.spgetAllCountriesTableAdapter spgetAllCountriesTableAdapter;
        private System.Windows.Forms.BindingSource spgetCurrenciesBindingSource;
        private Class.DataSet.dsSuppliersTableAdapters.spgetCurrenciesTableAdapter spgetCurrenciesTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit CurrencyLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit BankCodeLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit CountryCodeLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.GridLookUpEdit ServiceTypeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource spgetUDCByCategoryBindingSource;
        private Class.DataSet.dsSuppliersTableAdapters.spgetUDCByCategoryTableAdapter spgetUDCByCategoryTableAdapter;
    }
}