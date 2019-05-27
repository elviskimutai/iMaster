namespace Master.Forms
{
    partial class frmbanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbanks));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllBanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBanks = new Master.Class.DataSet.dsBanks();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBankCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysicalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectBanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CountryCodeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContactDetailsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhysicalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBankCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountryCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBankName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContactDetails = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhysicalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectBanksTableAdapter = new Master.Class.DataSet.dsBanksTableAdapters.spSelectBanksTableAdapter();
            this.spSelectAllBanksTableAdapter = new Master.Class.DataSet.dsBanksTableAdapters.spSelectAllBanksTableAdapter();
            this.countriesTableAdapter = new Master.Class.DataSet.dsBanksTableAdapters.CountriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllBanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectBanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCodeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDetailsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.BankCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BankNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryCodeLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactDetailsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhysicalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectBanksBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(708, 483);
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
            this.cutToolStripButton,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 20);
            this.toolStrip1.TabIndex = 20;
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
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 17);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
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
            this.gridControl1.DataSource = this.spSelectAllBanksBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(684, 297);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllBanksBindingSource
            // 
            this.spSelectAllBanksBindingSource.DataMember = "spSelectAllBanks";
            this.spSelectAllBanksBindingSource.DataSource = this.dsBanks;
            // 
            // dsBanks
            // 
            this.dsBanks.DataSetName = "dsBanks";
            this.dsBanks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankCode,
            this.colBankName,
            this.colCountryCode,
            this.colContactDetails,
            this.colPostalAddress,
            this.colPhysicalAddress,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colBankCode
            // 
            this.colBankCode.FieldName = "BankCode";
            this.colBankCode.Name = "colBankCode";
            this.colBankCode.Visible = true;
            this.colBankCode.VisibleIndex = 0;
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 1;
            // 
            // colCountryCode
            // 
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.Visible = true;
            this.colCountryCode.VisibleIndex = 2;
            // 
            // colContactDetails
            // 
            this.colContactDetails.FieldName = "ContactDetails";
            this.colContactDetails.Name = "colContactDetails";
            this.colContactDetails.Visible = true;
            this.colContactDetails.VisibleIndex = 3;
            // 
            // colPostalAddress
            // 
            this.colPostalAddress.FieldName = "PostalAddress";
            this.colPostalAddress.Name = "colPostalAddress";
            this.colPostalAddress.Visible = true;
            this.colPostalAddress.VisibleIndex = 4;
            // 
            // colPhysicalAddress
            // 
            this.colPhysicalAddress.FieldName = "PhysicalAddress";
            this.colPhysicalAddress.Name = "colPhysicalAddress";
            this.colPhysicalAddress.Visible = true;
            this.colPhysicalAddress.VisibleIndex = 5;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 6;
            // 
            // BankCodeTextEdit
            // 
            this.BankCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBanksBindingSource, "BankCode", true));
            this.BankCodeTextEdit.Location = new System.Drawing.Point(107, 66);
            this.BankCodeTextEdit.Name = "BankCodeTextEdit";
            this.BankCodeTextEdit.Size = new System.Drawing.Size(245, 20);
            this.BankCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.BankCodeTextEdit.TabIndex = 4;
            // 
            // spSelectBanksBindingSource
            // 
            this.spSelectBanksBindingSource.DataMember = "spSelectBanks";
            this.spSelectBanksBindingSource.DataSource = this.dsBanks;
            // 
            // BankNameTextEdit
            // 
            this.BankNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBanksBindingSource, "BankName", true));
            this.BankNameTextEdit.Location = new System.Drawing.Point(439, 66);
            this.BankNameTextEdit.Name = "BankNameTextEdit";
            this.BankNameTextEdit.Size = new System.Drawing.Size(245, 20);
            this.BankNameTextEdit.StyleController = this.dataLayoutControl1;
            this.BankNameTextEdit.TabIndex = 5;
            // 
            // CountryCodeLookUpEdit
            // 
            this.CountryCodeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBanksBindingSource, "CountryCode", true));
            this.CountryCodeLookUpEdit.Location = new System.Drawing.Point(107, 90);
            this.CountryCodeLookUpEdit.Name = "CountryCodeLookUpEdit";
            this.CountryCodeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryCodeLookUpEdit.Properties.DataSource = this.countriesBindingSource;
            this.CountryCodeLookUpEdit.Properties.DisplayMember = "CountryName";
            this.CountryCodeLookUpEdit.Properties.NullText = "";
            this.CountryCodeLookUpEdit.Properties.ValueMember = "CountryCode";
            this.CountryCodeLookUpEdit.Size = new System.Drawing.Size(245, 20);
            this.CountryCodeLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CountryCodeLookUpEdit.TabIndex = 6;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.dsBanks;
            // 
            // ContactDetailsTextEdit
            // 
            this.ContactDetailsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBanksBindingSource, "ContactDetails", true));
            this.ContactDetailsTextEdit.Location = new System.Drawing.Point(439, 90);
            this.ContactDetailsTextEdit.Name = "ContactDetailsTextEdit";
            this.ContactDetailsTextEdit.Size = new System.Drawing.Size(245, 20);
            this.ContactDetailsTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactDetailsTextEdit.TabIndex = 7;
            // 
            // PostalAddressTextEdit
            // 
            this.PostalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBanksBindingSource, "PostalAddress", true));
            this.PostalAddressTextEdit.Location = new System.Drawing.Point(107, 114);
            this.PostalAddressTextEdit.Name = "PostalAddressTextEdit";
            this.PostalAddressTextEdit.Size = new System.Drawing.Size(245, 20);
            this.PostalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalAddressTextEdit.TabIndex = 8;
            // 
            // PhysicalAddressTextEdit
            // 
            this.PhysicalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBanksBindingSource, "PhysicalAddress", true));
            this.PhysicalAddressTextEdit.Location = new System.Drawing.Point(439, 114);
            this.PhysicalAddressTextEdit.Name = "PhysicalAddressTextEdit";
            this.PhysicalAddressTextEdit.Size = new System.Drawing.Size(245, 20);
            this.PhysicalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PhysicalAddressTextEdit.TabIndex = 9;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBanksBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(107, 138);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(577, 20);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(708, 483);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(688, 463);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(688, 301);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBankCode,
            this.ItemForCountryCode,
            this.ItemForBankName,
            this.ItemForContactDetails,
            this.ItemForPostalAddress,
            this.ItemForPhysicalAddress,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(688, 138);
            this.layoutControlGroup3.Text = "Basic Information";
            // 
            // ItemForBankCode
            // 
            this.ItemForBankCode.Control = this.BankCodeTextEdit;
            this.ItemForBankCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForBankCode.Name = "ItemForBankCode";
            this.ItemForBankCode.Size = new System.Drawing.Size(332, 24);
            this.ItemForBankCode.Text = "Bank Code";
            this.ItemForBankCode.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCountryCode
            // 
            this.ItemForCountryCode.Control = this.CountryCodeLookUpEdit;
            this.ItemForCountryCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForCountryCode.Name = "ItemForCountryCode";
            this.ItemForCountryCode.Size = new System.Drawing.Size(332, 24);
            this.ItemForCountryCode.Text = "Country Code";
            this.ItemForCountryCode.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForBankName
            // 
            this.ItemForBankName.Control = this.BankNameTextEdit;
            this.ItemForBankName.Location = new System.Drawing.Point(332, 0);
            this.ItemForBankName.Name = "ItemForBankName";
            this.ItemForBankName.Size = new System.Drawing.Size(332, 24);
            this.ItemForBankName.Text = "Bank Name";
            this.ItemForBankName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForContactDetails
            // 
            this.ItemForContactDetails.Control = this.ContactDetailsTextEdit;
            this.ItemForContactDetails.Location = new System.Drawing.Point(332, 24);
            this.ItemForContactDetails.Name = "ItemForContactDetails";
            this.ItemForContactDetails.Size = new System.Drawing.Size(332, 24);
            this.ItemForContactDetails.Text = "Contact Details";
            this.ItemForContactDetails.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPostalAddress
            // 
            this.ItemForPostalAddress.Control = this.PostalAddressTextEdit;
            this.ItemForPostalAddress.Location = new System.Drawing.Point(0, 48);
            this.ItemForPostalAddress.Name = "ItemForPostalAddress";
            this.ItemForPostalAddress.Size = new System.Drawing.Size(332, 24);
            this.ItemForPostalAddress.Text = "Postal Address";
            this.ItemForPostalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPhysicalAddress
            // 
            this.ItemForPhysicalAddress.Control = this.PhysicalAddressTextEdit;
            this.ItemForPhysicalAddress.Location = new System.Drawing.Point(332, 48);
            this.ItemForPhysicalAddress.Name = "ItemForPhysicalAddress";
            this.ItemForPhysicalAddress.Size = new System.Drawing.Size(332, 24);
            this.ItemForPhysicalAddress.Text = "Physical Address";
            this.ItemForPhysicalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(0, 72);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(664, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(688, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectBanksTableAdapter
            // 
            this.spSelectBanksTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllBanksTableAdapter
            // 
            this.spSelectAllBanksTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmbanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 483);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmbanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks";
            this.Load += new System.EventHandler(this.frmbanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllBanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectBanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryCodeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDetailsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit BankCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectBanksBindingSource;
        private Class.DataSet.dsBanks dsBanks;
        private DevExpress.XtraEditors.TextEdit BankNameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit CountryCodeLookUpEdit;
        private DevExpress.XtraEditors.TextEdit ContactDetailsTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PhysicalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBankCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBankName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountryCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactDetails;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhysicalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsBanksTableAdapters.spSelectBanksTableAdapter spSelectBanksTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spSelectAllBanksBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBankCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colContactDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysicalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private Class.DataSet.dsBanksTableAdapters.spSelectAllBanksTableAdapter spSelectAllBanksTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Class.DataSet.dsBanksTableAdapters.CountriesTableAdapter countriesTableAdapter;
    }
}