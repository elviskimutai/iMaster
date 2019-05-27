namespace Master.Forms
{
    partial class frmCompanies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanies));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompanies = new Master.Class.DataSet.dsCompanies();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCounty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPINNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHIFNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSSFNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseCurr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FaxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WebsiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StreetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PINNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NHIFNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NSSFNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LogoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.CountryTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CountyTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BaseCurrTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCompCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelephone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPINNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNSSFNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWebsite = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFax = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStreet = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCounty = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNHIFNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBaseCurr = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectCompaniesTableAdapter = new Master.Class.DataSet.dsCompaniesTableAdapters.spSelectCompaniesTableAdapter();
            this.spSelectAllCompaniesTableAdapter = new Master.Class.DataSet.dsCompaniesTableAdapters.spSelectAllCompaniesTableAdapter();
            this.countriesTableAdapter = new Master.Class.DataSet.dsCompaniesTableAdapters.CountriesTableAdapter();
            this.countiesTableAdapter = new Master.Class.DataSet.dsCompaniesTableAdapters.CountiesTableAdapter();
            this.currenciesTableAdapter = new Master.Class.DataSet.dsCompaniesTableAdapters.CurrenciesTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PINNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHIFNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSSFNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseCurrTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPINNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNSSFNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCounty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNHIFNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBaseCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.cutToolStripButton,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 22);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 19);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 22);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 19);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 22);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 19);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 22);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 19);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 22);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 19);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.CompCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CompNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelephoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FaxTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WebsiteTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StreetTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PINNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NHIFNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NSSFNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LogoPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BaseCurrTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCompaniesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(876, 479);
            this.dataLayoutControl1.TabIndex = 18;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllCompaniesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(36, 286);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(804, 157);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllCompaniesBindingSource
            // 
            this.spSelectAllCompaniesBindingSource.DataMember = "spSelectAllCompanies";
            this.spSelectAllCompaniesBindingSource.DataSource = this.dsCompanies;
            // 
            // dsCompanies
            // 
            this.dsCompanies.DataSetName = "dsCompanies";
            this.dsCompanies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCompName,
            this.colTelephone,
            this.colFax,
            this.colEmail,
            this.colWebsite,
            this.colPostalAddress,
            this.colStreet,
            this.colCountry,
            this.colCounty,
            this.colPINNo,
            this.colNHIFNo,
            this.colNSSFNo,
            this.colBaseCurr});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colCompName
            // 
            this.colCompName.FieldName = "CompName";
            this.colCompName.Name = "colCompName";
            this.colCompName.Visible = true;
            this.colCompName.VisibleIndex = 1;
            // 
            // colTelephone
            // 
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 2;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 5;
            // 
            // colPostalAddress
            // 
            this.colPostalAddress.FieldName = "PostalAddress";
            this.colPostalAddress.Name = "colPostalAddress";
            this.colPostalAddress.Visible = true;
            this.colPostalAddress.VisibleIndex = 6;
            // 
            // colStreet
            // 
            this.colStreet.FieldName = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.Visible = true;
            this.colStreet.VisibleIndex = 7;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 8;
            // 
            // colCounty
            // 
            this.colCounty.FieldName = "County";
            this.colCounty.Name = "colCounty";
            this.colCounty.Visible = true;
            this.colCounty.VisibleIndex = 9;
            // 
            // colPINNo
            // 
            this.colPINNo.FieldName = "PINNo";
            this.colPINNo.Name = "colPINNo";
            this.colPINNo.Visible = true;
            this.colPINNo.VisibleIndex = 10;
            // 
            // colNHIFNo
            // 
            this.colNHIFNo.FieldName = "NHIFNo";
            this.colNHIFNo.Name = "colNHIFNo";
            this.colNHIFNo.Visible = true;
            this.colNHIFNo.VisibleIndex = 11;
            // 
            // colNSSFNo
            // 
            this.colNSSFNo.FieldName = "NSSFNo";
            this.colNSSFNo.Name = "colNSSFNo";
            this.colNSSFNo.Visible = true;
            this.colNSSFNo.VisibleIndex = 12;
            // 
            // colBaseCurr
            // 
            this.colBaseCurr.FieldName = "BaseCurr";
            this.colBaseCurr.Name = "colBaseCurr";
            this.colBaseCurr.Visible = true;
            this.colBaseCurr.VisibleIndex = 13;
            // 
            // CompCodeTextEdit
            // 
            this.CompCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "CompCode", true));
            this.CompCodeTextEdit.Location = new System.Drawing.Point(143, 102);
            this.CompCodeTextEdit.Name = "CompCodeTextEdit";
            this.CompCodeTextEdit.Size = new System.Drawing.Size(292, 20);
            this.CompCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CompCodeTextEdit.TabIndex = 4;
            // 
            // spSelectCompaniesBindingSource
            // 
            this.spSelectCompaniesBindingSource.DataMember = "spSelectCompanies";
            this.spSelectCompaniesBindingSource.DataSource = this.dsCompanies;
            // 
            // CompNameTextEdit
            // 
            this.CompNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "CompName", true));
            this.CompNameTextEdit.Location = new System.Drawing.Point(546, 102);
            this.CompNameTextEdit.Name = "CompNameTextEdit";
            this.CompNameTextEdit.Size = new System.Drawing.Size(294, 20);
            this.CompNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CompNameTextEdit.TabIndex = 5;
            // 
            // TelephoneTextEdit
            // 
            this.TelephoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "Telephone", true));
            this.TelephoneTextEdit.Location = new System.Drawing.Point(143, 126);
            this.TelephoneTextEdit.Name = "TelephoneTextEdit";
            this.TelephoneTextEdit.Size = new System.Drawing.Size(292, 20);
            this.TelephoneTextEdit.StyleController = this.dataLayoutControl1;
            this.TelephoneTextEdit.TabIndex = 6;
            // 
            // FaxTextEdit
            // 
            this.FaxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "Fax", true));
            this.FaxTextEdit.Location = new System.Drawing.Point(546, 126);
            this.FaxTextEdit.Name = "FaxTextEdit";
            this.FaxTextEdit.Size = new System.Drawing.Size(294, 20);
            this.FaxTextEdit.StyleController = this.dataLayoutControl1;
            this.FaxTextEdit.TabIndex = 7;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(143, 150);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(292, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 8;
            // 
            // WebsiteTextEdit
            // 
            this.WebsiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "Website", true));
            this.WebsiteTextEdit.Location = new System.Drawing.Point(546, 150);
            this.WebsiteTextEdit.Name = "WebsiteTextEdit";
            this.WebsiteTextEdit.Size = new System.Drawing.Size(294, 20);
            this.WebsiteTextEdit.StyleController = this.dataLayoutControl1;
            this.WebsiteTextEdit.TabIndex = 9;
            // 
            // PostalAddressTextEdit
            // 
            this.PostalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "PostalAddress", true));
            this.PostalAddressTextEdit.Location = new System.Drawing.Point(143, 174);
            this.PostalAddressTextEdit.Name = "PostalAddressTextEdit";
            this.PostalAddressTextEdit.Size = new System.Drawing.Size(292, 20);
            this.PostalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalAddressTextEdit.TabIndex = 10;
            // 
            // StreetTextEdit
            // 
            this.StreetTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "Street", true));
            this.StreetTextEdit.Location = new System.Drawing.Point(546, 174);
            this.StreetTextEdit.Name = "StreetTextEdit";
            this.StreetTextEdit.Size = new System.Drawing.Size(294, 20);
            this.StreetTextEdit.StyleController = this.dataLayoutControl1;
            this.StreetTextEdit.TabIndex = 11;
            // 
            // PINNoTextEdit
            // 
            this.PINNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "PINNo", true));
            this.PINNoTextEdit.Location = new System.Drawing.Point(143, 222);
            this.PINNoTextEdit.Name = "PINNoTextEdit";
            this.PINNoTextEdit.Size = new System.Drawing.Size(292, 20);
            this.PINNoTextEdit.StyleController = this.dataLayoutControl1;
            this.PINNoTextEdit.TabIndex = 14;
            // 
            // NHIFNoTextEdit
            // 
            this.NHIFNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "NHIFNo", true));
            this.NHIFNoTextEdit.Location = new System.Drawing.Point(546, 222);
            this.NHIFNoTextEdit.Name = "NHIFNoTextEdit";
            this.NHIFNoTextEdit.Size = new System.Drawing.Size(294, 20);
            this.NHIFNoTextEdit.StyleController = this.dataLayoutControl1;
            this.NHIFNoTextEdit.TabIndex = 15;
            // 
            // NSSFNoTextEdit
            // 
            this.NSSFNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "NSSFNo", true));
            this.NSSFNoTextEdit.Location = new System.Drawing.Point(143, 246);
            this.NSSFNoTextEdit.Name = "NSSFNoTextEdit";
            this.NSSFNoTextEdit.Size = new System.Drawing.Size(292, 20);
            this.NSSFNoTextEdit.StyleController = this.dataLayoutControl1;
            this.NSSFNoTextEdit.TabIndex = 16;
            // 
            // LogoPictureEdit
            // 
            this.LogoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "Logo", true));
            this.LogoPictureEdit.Location = new System.Drawing.Point(24, 88);
            this.LogoPictureEdit.Name = "LogoPictureEdit";
            this.LogoPictureEdit.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.LogoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.LogoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.LogoPictureEdit.Size = new System.Drawing.Size(828, 367);
            this.LogoPictureEdit.StyleController = this.dataLayoutControl1;
            this.LogoPictureEdit.TabIndex = 17;
            // 
            // CountryTextEdit
            // 
            this.CountryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "Country", true));
            this.CountryTextEdit.Location = new System.Drawing.Point(143, 198);
            this.CountryTextEdit.Name = "CountryTextEdit";
            this.CountryTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryTextEdit.Properties.DataSource = this.countriesBindingSource;
            this.CountryTextEdit.Properties.DisplayMember = "CountryName";
            this.CountryTextEdit.Properties.NullText = "";
            this.CountryTextEdit.Properties.ValueMember = "CountryCode";
            this.CountryTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.CountryTextEdit.Size = new System.Drawing.Size(292, 20);
            this.CountryTextEdit.StyleController = this.dataLayoutControl1;
            this.CountryTextEdit.TabIndex = 12;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.dsCompanies;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // CountyTextEdit
            // 
            this.CountyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "County", true));
            this.CountyTextEdit.Location = new System.Drawing.Point(546, 198);
            this.CountyTextEdit.Name = "CountyTextEdit";
            this.CountyTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountyTextEdit.Properties.DataSource = this.countiesBindingSource;
            this.CountyTextEdit.Properties.DisplayMember = "CountyName";
            this.CountyTextEdit.Properties.NullText = "";
            this.CountyTextEdit.Properties.ValueMember = "CountyCode";
            this.CountyTextEdit.Properties.View = this.gridView2;
            this.CountyTextEdit.Size = new System.Drawing.Size(294, 20);
            this.CountyTextEdit.StyleController = this.dataLayoutControl1;
            this.CountyTextEdit.TabIndex = 13;
            // 
            // countiesBindingSource
            // 
            this.countiesBindingSource.DataMember = "Counties";
            this.countiesBindingSource.DataSource = this.dsCompanies;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // BaseCurrTextEdit
            // 
            this.BaseCurrTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCompaniesBindingSource, "BaseCurr", true));
            this.BaseCurrTextEdit.Location = new System.Drawing.Point(546, 246);
            this.BaseCurrTextEdit.Name = "BaseCurrTextEdit";
            this.BaseCurrTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BaseCurrTextEdit.Properties.DataSource = this.currenciesBindingSource;
            this.BaseCurrTextEdit.Properties.DisplayMember = "CurrDesc";
            this.BaseCurrTextEdit.Properties.NullText = "";
            this.BaseCurrTextEdit.Properties.ValueMember = "CurrCode";
            this.BaseCurrTextEdit.Properties.View = this.gridView3;
            this.BaseCurrTextEdit.Size = new System.Drawing.Size(294, 20);
            this.BaseCurrTextEdit.StyleController = this.dataLayoutControl1;
            this.BaseCurrTextEdit.TabIndex = 18;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.dsCompanies;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(876, 479);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(856, 459);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 26);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(856, 433);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForLogo});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(832, 387);
            this.layoutControlGroup4.Text = "Logo";
            // 
            // ItemForLogo
            // 
            this.ItemForLogo.Control = this.LogoPictureEdit;
            this.ItemForLogo.Location = new System.Drawing.Point(0, 0);
            this.ItemForLogo.Name = "ItemForLogo";
            this.ItemForLogo.Size = new System.Drawing.Size(832, 387);
            this.ItemForLogo.StartNewLine = true;
            this.ItemForLogo.Text = "Logo";
            this.ItemForLogo.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForLogo.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(832, 387);
            this.layoutControlGroup3.Text = "Basic Information";
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCompCode,
            this.ItemForTelephone,
            this.ItemForEmail,
            this.ItemForPostalAddress,
            this.ItemForCountry,
            this.ItemForPINNo,
            this.ItemForNSSFNo,
            this.layoutControlItem1,
            this.ItemForCompName,
            this.ItemForWebsite,
            this.ItemForFax,
            this.ItemForStreet,
            this.ItemForCounty,
            this.ItemForNHIFNo,
            this.ItemForBaseCurr});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(832, 387);
            this.layoutControlGroup5.Text = "Company Information";
            // 
            // ItemForCompCode
            // 
            this.ItemForCompCode.Control = this.CompCodeTextEdit;
            this.ItemForCompCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompCode.Name = "ItemForCompCode";
            this.ItemForCompCode.Size = new System.Drawing.Size(403, 24);
            this.ItemForCompCode.Text = "Comp Code";
            this.ItemForCompCode.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForTelephone
            // 
            this.ItemForTelephone.Control = this.TelephoneTextEdit;
            this.ItemForTelephone.Location = new System.Drawing.Point(0, 24);
            this.ItemForTelephone.Name = "ItemForTelephone";
            this.ItemForTelephone.Size = new System.Drawing.Size(403, 24);
            this.ItemForTelephone.Text = "Telephone";
            this.ItemForTelephone.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(403, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForPostalAddress
            // 
            this.ItemForPostalAddress.Control = this.PostalAddressTextEdit;
            this.ItemForPostalAddress.Location = new System.Drawing.Point(0, 72);
            this.ItemForPostalAddress.Name = "ItemForPostalAddress";
            this.ItemForPostalAddress.Size = new System.Drawing.Size(403, 24);
            this.ItemForPostalAddress.Text = "Postal Address";
            this.ItemForPostalAddress.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForCountry
            // 
            this.ItemForCountry.Control = this.CountryTextEdit;
            this.ItemForCountry.Location = new System.Drawing.Point(0, 96);
            this.ItemForCountry.Name = "ItemForCountry";
            this.ItemForCountry.Size = new System.Drawing.Size(403, 24);
            this.ItemForCountry.Text = "Country";
            this.ItemForCountry.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForPINNo
            // 
            this.ItemForPINNo.Control = this.PINNoTextEdit;
            this.ItemForPINNo.Location = new System.Drawing.Point(0, 120);
            this.ItemForPINNo.Name = "ItemForPINNo";
            this.ItemForPINNo.Size = new System.Drawing.Size(403, 24);
            this.ItemForPINNo.Text = "PINNo";
            this.ItemForPINNo.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForNSSFNo
            // 
            this.ItemForNSSFNo.Control = this.NSSFNoTextEdit;
            this.ItemForNSSFNo.Location = new System.Drawing.Point(0, 144);
            this.ItemForNSSFNo.Name = "ItemForNSSFNo";
            this.ItemForNSSFNo.Size = new System.Drawing.Size(403, 24);
            this.ItemForNSSFNo.Text = "NSSFNo";
            this.ItemForNSSFNo.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(808, 177);
            this.layoutControlItem1.Text = "Company Information";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForCompName
            // 
            this.ItemForCompName.Control = this.CompNameTextEdit;
            this.ItemForCompName.Location = new System.Drawing.Point(403, 0);
            this.ItemForCompName.Name = "ItemForCompName";
            this.ItemForCompName.Size = new System.Drawing.Size(405, 24);
            this.ItemForCompName.Text = "Comp Name";
            this.ItemForCompName.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForWebsite
            // 
            this.ItemForWebsite.Control = this.WebsiteTextEdit;
            this.ItemForWebsite.Location = new System.Drawing.Point(403, 48);
            this.ItemForWebsite.Name = "ItemForWebsite";
            this.ItemForWebsite.Size = new System.Drawing.Size(405, 24);
            this.ItemForWebsite.Text = "Website";
            this.ItemForWebsite.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForFax
            // 
            this.ItemForFax.Control = this.FaxTextEdit;
            this.ItemForFax.Location = new System.Drawing.Point(403, 24);
            this.ItemForFax.Name = "ItemForFax";
            this.ItemForFax.Size = new System.Drawing.Size(405, 24);
            this.ItemForFax.Text = "Fax";
            this.ItemForFax.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForStreet
            // 
            this.ItemForStreet.Control = this.StreetTextEdit;
            this.ItemForStreet.Location = new System.Drawing.Point(403, 72);
            this.ItemForStreet.Name = "ItemForStreet";
            this.ItemForStreet.Size = new System.Drawing.Size(405, 24);
            this.ItemForStreet.Text = "Street";
            this.ItemForStreet.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForCounty
            // 
            this.ItemForCounty.Control = this.CountyTextEdit;
            this.ItemForCounty.Location = new System.Drawing.Point(403, 96);
            this.ItemForCounty.Name = "ItemForCounty";
            this.ItemForCounty.Size = new System.Drawing.Size(405, 24);
            this.ItemForCounty.Text = "County";
            this.ItemForCounty.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForNHIFNo
            // 
            this.ItemForNHIFNo.Control = this.NHIFNoTextEdit;
            this.ItemForNHIFNo.Location = new System.Drawing.Point(403, 120);
            this.ItemForNHIFNo.Name = "ItemForNHIFNo";
            this.ItemForNHIFNo.Size = new System.Drawing.Size(405, 24);
            this.ItemForNHIFNo.Text = "NHIFNo";
            this.ItemForNHIFNo.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForBaseCurr
            // 
            this.ItemForBaseCurr.Control = this.BaseCurrTextEdit;
            this.ItemForBaseCurr.Location = new System.Drawing.Point(403, 144);
            this.ItemForBaseCurr.Name = "ItemForBaseCurr";
            this.ItemForBaseCurr.Size = new System.Drawing.Size(405, 24);
            this.ItemForBaseCurr.Text = "Base Curr";
            this.ItemForBaseCurr.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(856, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectCompaniesTableAdapter
            // 
            this.spSelectCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllCompaniesTableAdapter
            // 
            this.spSelectAllCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // countiesTableAdapter
            // 
            this.countiesTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // frmCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 479);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCompanies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.frmCompanies_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebsiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PINNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHIFNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSSFNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseCurrTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPINNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNSSFNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCounty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNHIFNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBaseCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllCompaniesBindingSource;
        private Class.DataSet.dsCompanies dsCompanies;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCompName;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCounty;
        private DevExpress.XtraGrid.Columns.GridColumn colPINNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNHIFNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNSSFNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseCurr;
        private DevExpress.XtraEditors.TextEdit CompCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectCompaniesBindingSource;
        private DevExpress.XtraEditors.TextEdit CompNameTextEdit;
        private DevExpress.XtraEditors.TextEdit TelephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit FaxTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit WebsiteTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit StreetTextEdit;
        private DevExpress.XtraEditors.TextEdit PINNoTextEdit;
        private DevExpress.XtraEditors.TextEdit NHIFNoTextEdit;
        private DevExpress.XtraEditors.TextEdit NSSFNoTextEdit;
        private DevExpress.XtraEditors.PictureEdit LogoPictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelephone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFax;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebsite;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStreet;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountry;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCounty;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPINNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNHIFNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNSSFNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBaseCurr;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLogo;
        private Class.DataSet.dsCompaniesTableAdapters.spSelectCompaniesTableAdapter spSelectCompaniesTableAdapter;
        private Class.DataSet.dsCompaniesTableAdapters.spSelectAllCompaniesTableAdapter spSelectAllCompaniesTableAdapter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.GridLookUpEdit CountryTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Class.DataSet.dsCompaniesTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit CountyTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private Class.DataSet.dsCompaniesTableAdapters.CountiesTableAdapter countiesTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit BaseCurrTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private Class.DataSet.dsCompaniesTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
    }
}