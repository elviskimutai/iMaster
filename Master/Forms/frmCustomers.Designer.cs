namespace Master.Forms
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCustomers = new Master.Class.DataSet.dsCustomers();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTerms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebURL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysicalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPINNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSince = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PaymentTermsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WebURLTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FaxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhysicalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PINNOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustStatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CountryGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerSinceDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.IDNOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCustCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaymentTerms = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelephone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWebURL = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFax = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhysicalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPINNO = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerSince = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIDNO = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectCustomersTableAdapter = new Master.Class.DataSet.dsCustomersTableAdapters.spSelectCustomersTableAdapter();
            this.spSelectAllCustomersTableAdapter = new Master.Class.DataSet.dsCustomersTableAdapters.spSelectAllCustomersTableAdapter();
            this.spgetAllCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetAllCountriesTableAdapter = new Master.Class.DataSet.dsCustomersTableAdapters.spgetAllCountriesTableAdapter();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsCustomersTableAdapters.spGetCompanyCostCentersTableAdapter();
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
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTermsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebURLTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PINNOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustStatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSinceDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSinceDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPINNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerSince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CustCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PaymentTermsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MobileTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelephoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WebURLTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FaxTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhysicalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.PINNOTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustStatusComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomerSinceDateEdit);
            this.dataLayoutControl1.Controls.Add(this.IDNOTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCustomersBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(966, 480);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllCustomersBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 270);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(942, 198);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllCustomersBindingSource
            // 
            this.spSelectAllCustomersBindingSource.DataMember = "spSelectAllCustomers";
            this.spSelectAllCustomersBindingSource.DataSource = this.dsCustomers;
            // 
            // dsCustomers
            // 
            this.dsCustomers.DataSetName = "dsCustomers";
            this.dsCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustCode,
            this.colCustName,
            this.colPaymentTerms,
            this.colEmail,
            this.colMobile,
            this.colTelephone,
            this.colWebURL,
            this.colFax,
            this.colPhysicalAddress,
            this.colPostalAddress,
            this.colCompCode,
            this.colCostCenter,
            this.colPINNO,
            this.colCustStatus,
            this.colCountry,
            this.colCustomerSince,
            this.colIDNO});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCustCode
            // 
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 0;
            // 
            // colCustName
            // 
            this.colCustName.FieldName = "CustName";
            this.colCustName.Name = "colCustName";
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 1;
            // 
            // colPaymentTerms
            // 
            this.colPaymentTerms.FieldName = "PaymentTerms";
            this.colPaymentTerms.Name = "colPaymentTerms";
            this.colPaymentTerms.Visible = true;
            this.colPaymentTerms.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 4;
            // 
            // colTelephone
            // 
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 5;
            // 
            // colWebURL
            // 
            this.colWebURL.FieldName = "WebURL";
            this.colWebURL.Name = "colWebURL";
            this.colWebURL.Visible = true;
            this.colWebURL.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colPhysicalAddress
            // 
            this.colPhysicalAddress.FieldName = "PhysicalAddress";
            this.colPhysicalAddress.Name = "colPhysicalAddress";
            this.colPhysicalAddress.Visible = true;
            this.colPhysicalAddress.VisibleIndex = 8;
            // 
            // colPostalAddress
            // 
            this.colPostalAddress.FieldName = "PostalAddress";
            this.colPostalAddress.Name = "colPostalAddress";
            this.colPostalAddress.Visible = true;
            this.colPostalAddress.VisibleIndex = 9;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 10;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 11;
            // 
            // colPINNO
            // 
            this.colPINNO.FieldName = "PINNO";
            this.colPINNO.Name = "colPINNO";
            this.colPINNO.Visible = true;
            this.colPINNO.VisibleIndex = 12;
            // 
            // colCustStatus
            // 
            this.colCustStatus.FieldName = "CustStatus";
            this.colCustStatus.Name = "colCustStatus";
            this.colCustStatus.Visible = true;
            this.colCustStatus.VisibleIndex = 13;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 14;
            // 
            // colCustomerSince
            // 
            this.colCustomerSince.FieldName = "CustomerSince";
            this.colCustomerSince.Name = "colCustomerSince";
            this.colCustomerSince.Visible = true;
            this.colCustomerSince.VisibleIndex = 15;
            // 
            // colIDNO
            // 
            this.colIDNO.FieldName = "IDNO";
            this.colIDNO.Name = "colIDNO";
            this.colIDNO.Visible = true;
            this.colIDNO.VisibleIndex = 16;
            // 
            // CustCodeTextEdit
            // 
            this.CustCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "CustCode", true));
            this.CustCodeTextEdit.Location = new System.Drawing.Point(107, 66);
            this.CustCodeTextEdit.Name = "CustCodeTextEdit";
            this.CustCodeTextEdit.Size = new System.Drawing.Size(374, 20);
            this.CustCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CustCodeTextEdit.TabIndex = 4;
            // 
            // spSelectCustomersBindingSource
            // 
            this.spSelectCustomersBindingSource.DataMember = "spSelectCustomers";
            this.spSelectCustomersBindingSource.DataSource = this.dsCustomers;
            // 
            // CustNameTextEdit
            // 
            this.CustNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "CustName", true));
            this.CustNameTextEdit.Location = new System.Drawing.Point(568, 66);
            this.CustNameTextEdit.Name = "CustNameTextEdit";
            this.CustNameTextEdit.Size = new System.Drawing.Size(374, 20);
            this.CustNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CustNameTextEdit.TabIndex = 5;
            // 
            // PaymentTermsTextEdit
            // 
            this.PaymentTermsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "PaymentTerms", true));
            this.PaymentTermsTextEdit.Location = new System.Drawing.Point(107, 90);
            this.PaymentTermsTextEdit.Name = "PaymentTermsTextEdit";
            this.PaymentTermsTextEdit.Size = new System.Drawing.Size(374, 20);
            this.PaymentTermsTextEdit.StyleController = this.dataLayoutControl1;
            this.PaymentTermsTextEdit.TabIndex = 6;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(568, 90);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(374, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 7;
            // 
            // MobileTextEdit
            // 
            this.MobileTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "Mobile", true));
            this.MobileTextEdit.Location = new System.Drawing.Point(107, 114);
            this.MobileTextEdit.Name = "MobileTextEdit";
            this.MobileTextEdit.Size = new System.Drawing.Size(374, 20);
            this.MobileTextEdit.StyleController = this.dataLayoutControl1;
            this.MobileTextEdit.TabIndex = 8;
            // 
            // TelephoneTextEdit
            // 
            this.TelephoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "Telephone", true));
            this.TelephoneTextEdit.Location = new System.Drawing.Point(568, 114);
            this.TelephoneTextEdit.Name = "TelephoneTextEdit";
            this.TelephoneTextEdit.Size = new System.Drawing.Size(374, 20);
            this.TelephoneTextEdit.StyleController = this.dataLayoutControl1;
            this.TelephoneTextEdit.TabIndex = 9;
            // 
            // WebURLTextEdit
            // 
            this.WebURLTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "WebURL", true));
            this.WebURLTextEdit.Location = new System.Drawing.Point(107, 138);
            this.WebURLTextEdit.Name = "WebURLTextEdit";
            this.WebURLTextEdit.Size = new System.Drawing.Size(374, 20);
            this.WebURLTextEdit.StyleController = this.dataLayoutControl1;
            this.WebURLTextEdit.TabIndex = 10;
            // 
            // FaxTextEdit
            // 
            this.FaxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "Fax", true));
            this.FaxTextEdit.Location = new System.Drawing.Point(568, 138);
            this.FaxTextEdit.Name = "FaxTextEdit";
            this.FaxTextEdit.Size = new System.Drawing.Size(374, 20);
            this.FaxTextEdit.StyleController = this.dataLayoutControl1;
            this.FaxTextEdit.TabIndex = 11;
            // 
            // PhysicalAddressTextEdit
            // 
            this.PhysicalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "PhysicalAddress", true));
            this.PhysicalAddressTextEdit.Location = new System.Drawing.Point(107, 162);
            this.PhysicalAddressTextEdit.Name = "PhysicalAddressTextEdit";
            this.PhysicalAddressTextEdit.Size = new System.Drawing.Size(374, 20);
            this.PhysicalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PhysicalAddressTextEdit.TabIndex = 12;
            // 
            // PostalAddressTextEdit
            // 
            this.PostalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "PostalAddress", true));
            this.PostalAddressTextEdit.Location = new System.Drawing.Point(568, 162);
            this.PostalAddressTextEdit.Name = "PostalAddressTextEdit";
            this.PostalAddressTextEdit.Size = new System.Drawing.Size(374, 20);
            this.PostalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalAddressTextEdit.TabIndex = 13;
            // 
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(107, 186);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(374, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 14;
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
            // PINNOTextEdit
            // 
            this.PINNOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "PINNO", true));
            this.PINNOTextEdit.Location = new System.Drawing.Point(568, 186);
            this.PINNOTextEdit.Name = "PINNOTextEdit";
            this.PINNOTextEdit.Size = new System.Drawing.Size(374, 20);
            this.PINNOTextEdit.StyleController = this.dataLayoutControl1;
            this.PINNOTextEdit.TabIndex = 15;
            // 
            // CustStatusComboBoxEdit
            // 
            this.CustStatusComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "CustStatus", true));
            this.CustStatusComboBoxEdit.Location = new System.Drawing.Point(107, 210);
            this.CustStatusComboBoxEdit.Name = "CustStatusComboBoxEdit";
            this.CustStatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustStatusComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.CustStatusComboBoxEdit.Size = new System.Drawing.Size(374, 20);
            this.CustStatusComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.CustStatusComboBoxEdit.TabIndex = 16;
            // 
            // CountryGridLookUpEdit
            // 
            this.CountryGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "Country", true));
            this.CountryGridLookUpEdit.Location = new System.Drawing.Point(568, 210);
            this.CountryGridLookUpEdit.Name = "CountryGridLookUpEdit";
            this.CountryGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryGridLookUpEdit.Properties.DataSource = this.spgetAllCountriesBindingSource;
            this.CountryGridLookUpEdit.Properties.DisplayMember = "CountryName";
            this.CountryGridLookUpEdit.Properties.NullText = "";
            this.CountryGridLookUpEdit.Properties.ValueMember = "CountryCode";
            this.CountryGridLookUpEdit.Properties.View = this.gridView1;
            this.CountryGridLookUpEdit.Size = new System.Drawing.Size(374, 20);
            this.CountryGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CountryGridLookUpEdit.TabIndex = 17;
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
            // CustomerSinceDateEdit
            // 
            this.CustomerSinceDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "CustomerSince", true));
            this.CustomerSinceDateEdit.EditValue = null;
            this.CustomerSinceDateEdit.Location = new System.Drawing.Point(107, 234);
            this.CustomerSinceDateEdit.Name = "CustomerSinceDateEdit";
            this.CustomerSinceDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerSinceDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerSinceDateEdit.Size = new System.Drawing.Size(374, 20);
            this.CustomerSinceDateEdit.StyleController = this.dataLayoutControl1;
            this.CustomerSinceDateEdit.TabIndex = 18;
            // 
            // IDNOTextEdit
            // 
            this.IDNOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCustomersBindingSource, "IDNO", true));
            this.IDNOTextEdit.Location = new System.Drawing.Point(568, 234);
            this.IDNOTextEdit.Name = "IDNOTextEdit";
            this.IDNOTextEdit.Size = new System.Drawing.Size(374, 20);
            this.IDNOTextEdit.StyleController = this.dataLayoutControl1;
            this.IDNOTextEdit.TabIndex = 19;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(966, 480);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(946, 460);
            // 
            // ItemForCustCode
            // 
            this.ItemForCustCode.Control = this.CustCodeTextEdit;
            this.ItemForCustCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustCode.Name = "ItemForCustCode";
            this.ItemForCustCode.Size = new System.Drawing.Size(461, 24);
            this.ItemForCustCode.Text = "Cust Code";
            this.ItemForCustCode.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCustName
            // 
            this.ItemForCustName.Control = this.CustNameTextEdit;
            this.ItemForCustName.Location = new System.Drawing.Point(461, 0);
            this.ItemForCustName.Name = "ItemForCustName";
            this.ItemForCustName.Size = new System.Drawing.Size(461, 24);
            this.ItemForCustName.Text = "Cust Name";
            this.ItemForCustName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPaymentTerms
            // 
            this.ItemForPaymentTerms.Control = this.PaymentTermsTextEdit;
            this.ItemForPaymentTerms.Location = new System.Drawing.Point(0, 24);
            this.ItemForPaymentTerms.Name = "ItemForPaymentTerms";
            this.ItemForPaymentTerms.Size = new System.Drawing.Size(461, 24);
            this.ItemForPaymentTerms.Text = "Payment Terms";
            this.ItemForPaymentTerms.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(461, 24);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(461, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForMobile
            // 
            this.ItemForMobile.Control = this.MobileTextEdit;
            this.ItemForMobile.Location = new System.Drawing.Point(0, 48);
            this.ItemForMobile.Name = "ItemForMobile";
            this.ItemForMobile.Size = new System.Drawing.Size(461, 24);
            this.ItemForMobile.Text = "Mobile";
            this.ItemForMobile.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForTelephone
            // 
            this.ItemForTelephone.Control = this.TelephoneTextEdit;
            this.ItemForTelephone.Location = new System.Drawing.Point(461, 48);
            this.ItemForTelephone.Name = "ItemForTelephone";
            this.ItemForTelephone.Size = new System.Drawing.Size(461, 24);
            this.ItemForTelephone.Text = "Telephone";
            this.ItemForTelephone.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForWebURL
            // 
            this.ItemForWebURL.Control = this.WebURLTextEdit;
            this.ItemForWebURL.Location = new System.Drawing.Point(0, 72);
            this.ItemForWebURL.Name = "ItemForWebURL";
            this.ItemForWebURL.Size = new System.Drawing.Size(461, 24);
            this.ItemForWebURL.Text = "Web URL";
            this.ItemForWebURL.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForFax
            // 
            this.ItemForFax.Control = this.FaxTextEdit;
            this.ItemForFax.Location = new System.Drawing.Point(461, 72);
            this.ItemForFax.Name = "ItemForFax";
            this.ItemForFax.Size = new System.Drawing.Size(461, 24);
            this.ItemForFax.Text = "Fax";
            this.ItemForFax.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPhysicalAddress
            // 
            this.ItemForPhysicalAddress.Control = this.PhysicalAddressTextEdit;
            this.ItemForPhysicalAddress.Location = new System.Drawing.Point(0, 96);
            this.ItemForPhysicalAddress.Name = "ItemForPhysicalAddress";
            this.ItemForPhysicalAddress.Size = new System.Drawing.Size(461, 24);
            this.ItemForPhysicalAddress.Text = "Physical Address";
            this.ItemForPhysicalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPostalAddress
            // 
            this.ItemForPostalAddress.Control = this.PostalAddressTextEdit;
            this.ItemForPostalAddress.Location = new System.Drawing.Point(461, 96);
            this.ItemForPostalAddress.Name = "ItemForPostalAddress";
            this.ItemForPostalAddress.Size = new System.Drawing.Size(461, 24);
            this.ItemForPostalAddress.Text = "Postal Address";
            this.ItemForPostalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 120);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(461, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPINNO
            // 
            this.ItemForPINNO.Control = this.PINNOTextEdit;
            this.ItemForPINNO.Location = new System.Drawing.Point(461, 120);
            this.ItemForPINNO.Name = "ItemForPINNO";
            this.ItemForPINNO.Size = new System.Drawing.Size(461, 24);
            this.ItemForPINNO.Text = "PINNO";
            this.ItemForPINNO.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCustStatus
            // 
            this.ItemForCustStatus.Control = this.CustStatusComboBoxEdit;
            this.ItemForCustStatus.Location = new System.Drawing.Point(0, 144);
            this.ItemForCustStatus.Name = "ItemForCustStatus";
            this.ItemForCustStatus.Size = new System.Drawing.Size(461, 24);
            this.ItemForCustStatus.Text = "Cust Status";
            this.ItemForCustStatus.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCountry
            // 
            this.ItemForCountry.Control = this.CountryGridLookUpEdit;
            this.ItemForCountry.Location = new System.Drawing.Point(461, 144);
            this.ItemForCountry.Name = "ItemForCountry";
            this.ItemForCountry.Size = new System.Drawing.Size(461, 24);
            this.ItemForCountry.Text = "Country";
            this.ItemForCountry.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCustomerSince
            // 
            this.ItemForCustomerSince.Control = this.CustomerSinceDateEdit;
            this.ItemForCustomerSince.Location = new System.Drawing.Point(0, 168);
            this.ItemForCustomerSince.Name = "ItemForCustomerSince";
            this.ItemForCustomerSince.Size = new System.Drawing.Size(461, 24);
            this.ItemForCustomerSince.Text = "Customer Since";
            this.ItemForCustomerSince.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForIDNO
            // 
            this.ItemForIDNO.Control = this.IDNOTextEdit;
            this.ItemForIDNO.Location = new System.Drawing.Point(461, 168);
            this.ItemForIDNO.Name = "ItemForIDNO";
            this.ItemForIDNO.Size = new System.Drawing.Size(461, 24);
            this.ItemForIDNO.Text = "IDNO";
            this.ItemForIDNO.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 258);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(946, 202);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectCustomersTableAdapter
            // 
            this.spSelectCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllCustomersTableAdapter
            // 
            this.spSelectAllCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // spgetAllCountriesBindingSource
            // 
            this.spgetAllCountriesBindingSource.DataMember = "spgetAllCountries";
            this.spgetAllCountriesBindingSource.DataSource = this.dsCustomers;
            // 
            // spgetAllCountriesTableAdapter
            // 
            this.spgetAllCountriesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsCustomers;
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
            this.toolStrip1.TabIndex = 29;
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
            this.layoutControlItem2.Size = new System.Drawing.Size(946, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCustCode,
            this.ItemForPaymentTerms,
            this.ItemForMobile,
            this.ItemForWebURL,
            this.ItemForPhysicalAddress,
            this.ItemForCostCenter,
            this.ItemForCustStatus,
            this.ItemForCustomerSince,
            this.ItemForIDNO,
            this.ItemForCountry,
            this.ItemForPINNO,
            this.ItemForPostalAddress,
            this.ItemForFax,
            this.ItemForTelephone,
            this.ItemForEmail,
            this.ItemForCustName});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(946, 234);
            this.layoutControlGroup3.Text = "Customers";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 480);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTermsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebURLTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PINNOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustStatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSinceDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSinceDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPINNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerSince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetAllCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit CustCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectCustomersBindingSource;
        private Class.DataSet.dsCustomers dsCustomers;
        private DevExpress.XtraEditors.TextEdit CustNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PaymentTermsTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit MobileTextEdit;
        private DevExpress.XtraEditors.TextEdit TelephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit WebURLTextEdit;
        private DevExpress.XtraEditors.TextEdit FaxTextEdit;
        private DevExpress.XtraEditors.TextEdit PhysicalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalAddressTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit PINNOTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit CustStatusComboBoxEdit;
        private DevExpress.XtraEditors.GridLookUpEdit CountryGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit CustomerSinceDateEdit;
        private DevExpress.XtraEditors.TextEdit IDNOTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaymentTerms;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelephone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebURL;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFax;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhysicalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPINNO;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustStatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountry;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerSince;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIDNO;
        private Class.DataSet.dsCustomersTableAdapters.spSelectCustomersTableAdapter spSelectCustomersTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource spSelectAllCustomersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTerms;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colWebURL;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysicalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colPINNO;
        private DevExpress.XtraGrid.Columns.GridColumn colCustStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSince;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNO;
        private Class.DataSet.dsCustomersTableAdapters.spSelectAllCustomersTableAdapter spSelectAllCustomersTableAdapter;
        private System.Windows.Forms.BindingSource spgetAllCountriesBindingSource;
        private Class.DataSet.dsCustomersTableAdapters.spgetAllCountriesTableAdapter spgetAllCountriesTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsCustomersTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
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
    }
}