namespace Master.Forms
{
    partial class frmBeneficiaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficiaries));
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
            this.spSelectAllBeneficiariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBeneficiaries = new Master.Class.DataSet.dsBeneficiaries();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenefNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDependName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysicalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRelationship = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPortion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpNoLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spSelectBeneficiariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BenefNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DependNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhysicalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IDNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RelationshipTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhotoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.PortionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CountryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBeneficiaries1 = new Master.Class.DataSet.dsBeneficiaries();
            this.BranchLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.bankBranchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDependName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhysicalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRelationship = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBenefNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelephone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIDNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPortion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranch = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBank = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPhoto = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectBeneficiariesTableAdapter = new Master.Class.DataSet.dsBeneficiariesTableAdapters.spSelectBeneficiariesTableAdapter();
            this.spSelectAllBeneficiariesTableAdapter = new Master.Class.DataSet.dsBeneficiariesTableAdapters.spSelectAllBeneficiariesTableAdapter();
            this.employeesMasterTableAdapter = new Master.Class.DataSet.dsBeneficiariesTableAdapters.EmployeesMasterTableAdapter();
            this.countriesTableAdapter = new Master.Class.DataSet.dsBeneficiariesTableAdapters.CountriesTableAdapter();
            this.banksTableAdapter = new Master.Class.DataSet.dsBeneficiariesTableAdapters.BanksTableAdapter();
            this.bankBranchesTableAdapter = new Master.Class.DataSet.dsBeneficiariesTableAdapters.BankBranchesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllBeneficiariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeneficiaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectBeneficiariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BenefNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DependNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelationshipTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeneficiaries1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBranchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDependName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRelationship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBenefNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.EmpNoLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BenefNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DependNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhysicalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelephoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IDNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RelationshipTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhotoPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.PortionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BankLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.BranchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AccNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectBeneficiariesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(746, 422);
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
            this.toolStrip1.Size = new System.Drawing.Size(722, 20);
            this.toolStrip1.TabIndex = 19;
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
            this.gridControl1.DataSource = this.spSelectAllBeneficiariesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 202);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(722, 208);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllBeneficiariesBindingSource
            // 
            this.spSelectAllBeneficiariesBindingSource.DataMember = "spSelectAllBeneficiaries";
            this.spSelectAllBeneficiariesBindingSource.DataSource = this.dsBeneficiaries;
            // 
            // dsBeneficiaries
            // 
            this.dsBeneficiaries.DataSetName = "dsBeneficiaries";
            this.dsBeneficiaries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colBenefNo,
            this.colDependName,
            this.colPostalAddress,
            this.colPhysicalAddress,
            this.colTelephone,
            this.colEmail,
            this.colIDNo,
            this.colRelationship,
            this.colPortion,
            this.colCountry,
            this.colBank,
            this.colBranch,
            this.colAccNo,
            this.colAccName,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colEmpNo
            // 
            this.colEmpNo.FieldName = "EmpNo";
            this.colEmpNo.Name = "colEmpNo";
            this.colEmpNo.Visible = true;
            this.colEmpNo.VisibleIndex = 0;
            // 
            // colBenefNo
            // 
            this.colBenefNo.FieldName = "BenefNo";
            this.colBenefNo.Name = "colBenefNo";
            this.colBenefNo.Visible = true;
            this.colBenefNo.VisibleIndex = 1;
            // 
            // colDependName
            // 
            this.colDependName.FieldName = "DependName";
            this.colDependName.Name = "colDependName";
            this.colDependName.Visible = true;
            this.colDependName.VisibleIndex = 2;
            // 
            // colPostalAddress
            // 
            this.colPostalAddress.FieldName = "PostalAddress";
            this.colPostalAddress.Name = "colPostalAddress";
            this.colPostalAddress.Visible = true;
            this.colPostalAddress.VisibleIndex = 3;
            // 
            // colPhysicalAddress
            // 
            this.colPhysicalAddress.FieldName = "PhysicalAddress";
            this.colPhysicalAddress.Name = "colPhysicalAddress";
            this.colPhysicalAddress.Visible = true;
            this.colPhysicalAddress.VisibleIndex = 4;
            // 
            // colTelephone
            // 
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colIDNo
            // 
            this.colIDNo.FieldName = "IDNo";
            this.colIDNo.Name = "colIDNo";
            this.colIDNo.Visible = true;
            this.colIDNo.VisibleIndex = 7;
            // 
            // colRelationship
            // 
            this.colRelationship.FieldName = "Relationship";
            this.colRelationship.Name = "colRelationship";
            this.colRelationship.Visible = true;
            this.colRelationship.VisibleIndex = 8;
            // 
            // colPortion
            // 
            this.colPortion.FieldName = "Portion";
            this.colPortion.Name = "colPortion";
            this.colPortion.Visible = true;
            this.colPortion.VisibleIndex = 9;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 10;
            // 
            // colBank
            // 
            this.colBank.FieldName = "Bank";
            this.colBank.Name = "colBank";
            this.colBank.Visible = true;
            this.colBank.VisibleIndex = 11;
            // 
            // colBranch
            // 
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            this.colBranch.Visible = true;
            this.colBranch.VisibleIndex = 12;
            // 
            // colAccNo
            // 
            this.colAccNo.FieldName = "AccNo";
            this.colAccNo.Name = "colAccNo";
            this.colAccNo.Visible = true;
            this.colAccNo.VisibleIndex = 13;
            // 
            // colAccName
            // 
            this.colAccName.FieldName = "AccName";
            this.colAccName.Name = "colAccName";
            this.colAccName.Visible = true;
            this.colAccName.VisibleIndex = 14;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 15;
            // 
            // EmpNoLookUpEdit
            // 
            this.EmpNoLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "EmpNo", true));
            this.EmpNoLookUpEdit.Location = new System.Drawing.Point(107, 70);
            this.EmpNoLookUpEdit.Name = "EmpNoLookUpEdit";
            this.EmpNoLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpNoLookUpEdit.Properties.DataSource = this.employeesMasterBindingSource;
            this.EmpNoLookUpEdit.Properties.DisplayMember = "EmpNames";
            this.EmpNoLookUpEdit.Properties.NullText = "";
            this.EmpNoLookUpEdit.Properties.ValueMember = "EmpNo";
            this.EmpNoLookUpEdit.Size = new System.Drawing.Size(265, 20);
            this.EmpNoLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoLookUpEdit.TabIndex = 4;
            // 
            // spSelectBeneficiariesBindingSource
            // 
            this.spSelectBeneficiariesBindingSource.DataMember = "spSelectBeneficiaries";
            this.spSelectBeneficiariesBindingSource.DataSource = this.dsBeneficiaries;
            // 
            // employeesMasterBindingSource
            // 
            this.employeesMasterBindingSource.DataMember = "EmployeesMaster";
            this.employeesMasterBindingSource.DataSource = this.dsBeneficiaries;
            // 
            // BenefNoTextEdit
            // 
            this.BenefNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "BenefNo", true));
            this.BenefNoTextEdit.Location = new System.Drawing.Point(459, 70);
            this.BenefNoTextEdit.Name = "BenefNoTextEdit";
            this.BenefNoTextEdit.Size = new System.Drawing.Size(263, 20);
            this.BenefNoTextEdit.StyleController = this.dataLayoutControl1;
            this.BenefNoTextEdit.TabIndex = 5;
            // 
            // DependNameTextEdit
            // 
            this.DependNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "DependName", true));
            this.DependNameTextEdit.Location = new System.Drawing.Point(107, 94);
            this.DependNameTextEdit.Name = "DependNameTextEdit";
            this.DependNameTextEdit.Size = new System.Drawing.Size(265, 20);
            this.DependNameTextEdit.StyleController = this.dataLayoutControl1;
            this.DependNameTextEdit.TabIndex = 6;
            // 
            // PostalAddressTextEdit
            // 
            this.PostalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "PostalAddress", true));
            this.PostalAddressTextEdit.Location = new System.Drawing.Point(459, 94);
            this.PostalAddressTextEdit.Name = "PostalAddressTextEdit";
            this.PostalAddressTextEdit.Size = new System.Drawing.Size(263, 20);
            this.PostalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalAddressTextEdit.TabIndex = 7;
            // 
            // PhysicalAddressTextEdit
            // 
            this.PhysicalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "PhysicalAddress", true));
            this.PhysicalAddressTextEdit.Location = new System.Drawing.Point(107, 118);
            this.PhysicalAddressTextEdit.Name = "PhysicalAddressTextEdit";
            this.PhysicalAddressTextEdit.Size = new System.Drawing.Size(265, 20);
            this.PhysicalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PhysicalAddressTextEdit.TabIndex = 8;
            // 
            // TelephoneTextEdit
            // 
            this.TelephoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Telephone", true));
            this.TelephoneTextEdit.Location = new System.Drawing.Point(459, 118);
            this.TelephoneTextEdit.Name = "TelephoneTextEdit";
            this.TelephoneTextEdit.Size = new System.Drawing.Size(263, 20);
            this.TelephoneTextEdit.StyleController = this.dataLayoutControl1;
            this.TelephoneTextEdit.TabIndex = 9;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(107, 142);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(265, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 10;
            // 
            // IDNoTextEdit
            // 
            this.IDNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "IDNo", true));
            this.IDNoTextEdit.Location = new System.Drawing.Point(459, 142);
            this.IDNoTextEdit.Name = "IDNoTextEdit";
            this.IDNoTextEdit.Size = new System.Drawing.Size(263, 20);
            this.IDNoTextEdit.StyleController = this.dataLayoutControl1;
            this.IDNoTextEdit.TabIndex = 11;
            // 
            // RelationshipTextEdit
            // 
            this.RelationshipTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Relationship", true));
            this.RelationshipTextEdit.Location = new System.Drawing.Point(107, 166);
            this.RelationshipTextEdit.Name = "RelationshipTextEdit";
            this.RelationshipTextEdit.Size = new System.Drawing.Size(263, 20);
            this.RelationshipTextEdit.StyleController = this.dataLayoutControl1;
            this.RelationshipTextEdit.TabIndex = 12;
            // 
            // PhotoPictureEdit
            // 
            this.PhotoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Photo", true));
            this.PhotoPictureEdit.Location = new System.Drawing.Point(107, 70);
            this.PhotoPictureEdit.Name = "PhotoPictureEdit";
            this.PhotoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.PhotoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PhotoPictureEdit.Size = new System.Drawing.Size(615, 116);
            this.PhotoPictureEdit.StyleController = this.dataLayoutControl1;
            this.PhotoPictureEdit.TabIndex = 13;
            // 
            // PortionTextEdit
            // 
            this.PortionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Portion", true));
            this.PortionTextEdit.Location = new System.Drawing.Point(107, 70);
            this.PortionTextEdit.Name = "PortionTextEdit";
            this.PortionTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PortionTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PortionTextEdit.Properties.Mask.EditMask = "F";
            this.PortionTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PortionTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PortionTextEdit.Size = new System.Drawing.Size(263, 20);
            this.PortionTextEdit.StyleController = this.dataLayoutControl1;
            this.PortionTextEdit.TabIndex = 14;
            // 
            // CountryLookUpEdit
            // 
            this.CountryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Country", true));
            this.CountryLookUpEdit.Location = new System.Drawing.Point(457, 166);
            this.CountryLookUpEdit.Name = "CountryLookUpEdit";
            this.CountryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryLookUpEdit.Properties.DataSource = this.countriesBindingSource;
            this.CountryLookUpEdit.Properties.DisplayMember = "CountryName";
            this.CountryLookUpEdit.Properties.NullText = "";
            this.CountryLookUpEdit.Properties.ValueMember = "CountryCode";
            this.CountryLookUpEdit.Size = new System.Drawing.Size(265, 20);
            this.CountryLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CountryLookUpEdit.TabIndex = 15;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.dsBeneficiaries;
            // 
            // BankLookUpEdit
            // 
            this.BankLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Bank", true));
            this.BankLookUpEdit.Location = new System.Drawing.Point(457, 70);
            this.BankLookUpEdit.Name = "BankLookUpEdit";
            this.BankLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BankLookUpEdit.Properties.DataSource = this.banksBindingSource;
            this.BankLookUpEdit.Properties.DisplayMember = "BankName";
            this.BankLookUpEdit.Properties.NullText = "";
            this.BankLookUpEdit.Properties.ValueMember = "BankCode";
            this.BankLookUpEdit.Size = new System.Drawing.Size(265, 20);
            this.BankLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BankLookUpEdit.TabIndex = 16;
            this.BankLookUpEdit.EditValueChanged += new System.EventHandler(this.BankLookUpEdit_EditValueChanged);
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataMember = "Banks";
            this.banksBindingSource.DataSource = this.dsBeneficiaries1;
            // 
            // dsBeneficiaries1
            // 
            this.dsBeneficiaries1.DataSetName = "dsBeneficiaries";
            this.dsBeneficiaries1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BranchLookUpEdit
            // 
            this.BranchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Branch", true));
            this.BranchLookUpEdit.Location = new System.Drawing.Point(107, 94);
            this.BranchLookUpEdit.Name = "BranchLookUpEdit";
            this.BranchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BranchLookUpEdit.Properties.DataSource = this.bankBranchesBindingSource;
            this.BranchLookUpEdit.Properties.DisplayMember = "BranchName";
            this.BranchLookUpEdit.Properties.NullText = "";
            this.BranchLookUpEdit.Properties.ValueMember = "BranchCode";
            this.BranchLookUpEdit.Size = new System.Drawing.Size(263, 20);
            this.BranchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BranchLookUpEdit.TabIndex = 17;
            // 
            // bankBranchesBindingSource
            // 
            this.bankBranchesBindingSource.DataMember = "BankBranches";
            this.bankBranchesBindingSource.DataSource = this.dsBeneficiaries1;
            // 
            // AccNoTextEdit
            // 
            this.AccNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "AccNo", true));
            this.AccNoTextEdit.Location = new System.Drawing.Point(457, 94);
            this.AccNoTextEdit.Name = "AccNoTextEdit";
            this.AccNoTextEdit.Size = new System.Drawing.Size(265, 20);
            this.AccNoTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNoTextEdit.TabIndex = 18;
            // 
            // AccNameTextEdit
            // 
            this.AccNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "AccName", true));
            this.AccNameTextEdit.Location = new System.Drawing.Point(107, 118);
            this.AccNameTextEdit.Name = "AccNameTextEdit";
            this.AccNameTextEdit.Size = new System.Drawing.Size(263, 20);
            this.AccNameTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNameTextEdit.TabIndex = 19;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBeneficiariesBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(457, 118);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(265, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 20;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(746, 422);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.tabbedControlGroup1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(726, 402);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 190);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(726, 212);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 24);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(726, 166);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmpNo,
            this.ItemForDependName,
            this.ItemForPhysicalAddress,
            this.ItemForEmail,
            this.ItemForRelationship,
            this.ItemForBenefNo,
            this.ItemForPostalAddress,
            this.ItemForTelephone,
            this.ItemForIDNo,
            this.ItemForCountry});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(702, 120);
            this.layoutControlGroup3.Text = "Basic Information";
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoLookUpEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(352, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForDependName
            // 
            this.ItemForDependName.Control = this.DependNameTextEdit;
            this.ItemForDependName.Location = new System.Drawing.Point(0, 24);
            this.ItemForDependName.Name = "ItemForDependName";
            this.ItemForDependName.Size = new System.Drawing.Size(352, 24);
            this.ItemForDependName.Text = "Depend Name";
            this.ItemForDependName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPhysicalAddress
            // 
            this.ItemForPhysicalAddress.Control = this.PhysicalAddressTextEdit;
            this.ItemForPhysicalAddress.Location = new System.Drawing.Point(0, 48);
            this.ItemForPhysicalAddress.Name = "ItemForPhysicalAddress";
            this.ItemForPhysicalAddress.Size = new System.Drawing.Size(352, 24);
            this.ItemForPhysicalAddress.Text = "Physical Address";
            this.ItemForPhysicalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 72);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(352, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForRelationship
            // 
            this.ItemForRelationship.Control = this.RelationshipTextEdit;
            this.ItemForRelationship.Location = new System.Drawing.Point(0, 96);
            this.ItemForRelationship.Name = "ItemForRelationship";
            this.ItemForRelationship.Size = new System.Drawing.Size(350, 24);
            this.ItemForRelationship.Text = "Relationship";
            this.ItemForRelationship.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForBenefNo
            // 
            this.ItemForBenefNo.Control = this.BenefNoTextEdit;
            this.ItemForBenefNo.Location = new System.Drawing.Point(352, 0);
            this.ItemForBenefNo.Name = "ItemForBenefNo";
            this.ItemForBenefNo.Size = new System.Drawing.Size(350, 24);
            this.ItemForBenefNo.Text = "Benef No";
            this.ItemForBenefNo.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPostalAddress
            // 
            this.ItemForPostalAddress.Control = this.PostalAddressTextEdit;
            this.ItemForPostalAddress.Location = new System.Drawing.Point(352, 24);
            this.ItemForPostalAddress.Name = "ItemForPostalAddress";
            this.ItemForPostalAddress.Size = new System.Drawing.Size(350, 24);
            this.ItemForPostalAddress.Text = "Postal Address";
            this.ItemForPostalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForTelephone
            // 
            this.ItemForTelephone.Control = this.TelephoneTextEdit;
            this.ItemForTelephone.Location = new System.Drawing.Point(352, 48);
            this.ItemForTelephone.Name = "ItemForTelephone";
            this.ItemForTelephone.Size = new System.Drawing.Size(350, 24);
            this.ItemForTelephone.Text = "Telephone";
            this.ItemForTelephone.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForIDNo
            // 
            this.ItemForIDNo.Control = this.IDNoTextEdit;
            this.ItemForIDNo.Location = new System.Drawing.Point(352, 72);
            this.ItemForIDNo.Name = "ItemForIDNo";
            this.ItemForIDNo.Size = new System.Drawing.Size(350, 24);
            this.ItemForIDNo.Text = "IDNo";
            this.ItemForIDNo.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCountry
            // 
            this.ItemForCountry.Control = this.CountryLookUpEdit;
            this.ItemForCountry.Location = new System.Drawing.Point(350, 96);
            this.ItemForCountry.Name = "ItemForCountry";
            this.ItemForCountry.Size = new System.Drawing.Size(352, 24);
            this.ItemForCountry.Text = "Country";
            this.ItemForCountry.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPortion,
            this.ItemForBranch,
            this.ItemForAccName,
            this.ItemForBank,
            this.ItemForAccNo,
            this.ItemForNarration});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(702, 120);
            this.layoutControlGroup4.Text = "Other Information";
            // 
            // ItemForPortion
            // 
            this.ItemForPortion.Control = this.PortionTextEdit;
            this.ItemForPortion.Location = new System.Drawing.Point(0, 0);
            this.ItemForPortion.Name = "ItemForPortion";
            this.ItemForPortion.Size = new System.Drawing.Size(350, 24);
            this.ItemForPortion.Text = "Portion(%)";
            this.ItemForPortion.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForBranch
            // 
            this.ItemForBranch.Control = this.BranchLookUpEdit;
            this.ItemForBranch.Location = new System.Drawing.Point(0, 24);
            this.ItemForBranch.Name = "ItemForBranch";
            this.ItemForBranch.Size = new System.Drawing.Size(350, 24);
            this.ItemForBranch.Text = "Branch";
            this.ItemForBranch.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForAccName
            // 
            this.ItemForAccName.Control = this.AccNameTextEdit;
            this.ItemForAccName.Location = new System.Drawing.Point(0, 48);
            this.ItemForAccName.Name = "ItemForAccName";
            this.ItemForAccName.Size = new System.Drawing.Size(350, 72);
            this.ItemForAccName.Text = "Acc Name";
            this.ItemForAccName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForBank
            // 
            this.ItemForBank.Control = this.BankLookUpEdit;
            this.ItemForBank.Location = new System.Drawing.Point(350, 0);
            this.ItemForBank.Name = "ItemForBank";
            this.ItemForBank.Size = new System.Drawing.Size(352, 24);
            this.ItemForBank.Text = "Bank";
            this.ItemForBank.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForAccNo
            // 
            this.ItemForAccNo.Control = this.AccNoTextEdit;
            this.ItemForAccNo.Location = new System.Drawing.Point(350, 24);
            this.ItemForAccNo.Name = "ItemForAccNo";
            this.ItemForAccNo.Size = new System.Drawing.Size(352, 24);
            this.ItemForAccNo.Text = "Acc No";
            this.ItemForAccNo.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(350, 48);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(352, 72);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPhoto});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(702, 120);
            this.layoutControlGroup5.Text = "PassPort";
            // 
            // ItemForPhoto
            // 
            this.ItemForPhoto.Control = this.PhotoPictureEdit;
            this.ItemForPhoto.Location = new System.Drawing.Point(0, 0);
            this.ItemForPhoto.Name = "ItemForPhoto";
            this.ItemForPhoto.Size = new System.Drawing.Size(702, 120);
            this.ItemForPhoto.StartNewLine = true;
            this.ItemForPhoto.Text = "Photo";
            this.ItemForPhoto.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(726, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectBeneficiariesTableAdapter
            // 
            this.spSelectBeneficiariesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllBeneficiariesTableAdapter
            // 
            this.spSelectAllBeneficiariesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesMasterTableAdapter
            // 
            this.employeesMasterTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // banksTableAdapter
            // 
            this.banksTableAdapter.ClearBeforeFill = true;
            // 
            // bankBranchesTableAdapter
            // 
            this.bankBranchesTableAdapter.ClearBeforeFill = true;
            // 
            // frmBeneficiaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 422);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmBeneficiaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiaries";
            this.Load += new System.EventHandler(this.frmBeneficiaries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllBeneficiariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeneficiaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectBeneficiariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BenefNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DependNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelationshipTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBeneficiaries1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBranchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDependName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRelationship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBenefNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllBeneficiariesBindingSource;
        private Class.DataSet.dsBeneficiaries dsBeneficiaries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDependName;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysicalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRelationship;
        private DevExpress.XtraGrid.Columns.GridColumn colPortion;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colBank;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colAccNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAccName;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraEditors.LookUpEdit EmpNoLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectBeneficiariesBindingSource;
        private DevExpress.XtraEditors.TextEdit BenefNoTextEdit;
        private DevExpress.XtraEditors.TextEdit DependNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PhysicalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit TelephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit IDNoTextEdit;
        private DevExpress.XtraEditors.TextEdit RelationshipTextEdit;
        private DevExpress.XtraEditors.PictureEdit PhotoPictureEdit;
        private DevExpress.XtraEditors.TextEdit PortionTextEdit;
        private DevExpress.XtraEditors.LookUpEdit CountryLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit BankLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit BranchLookUpEdit;
        private DevExpress.XtraEditors.TextEdit AccNoTextEdit;
        private DevExpress.XtraEditors.TextEdit AccNameTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDependName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhysicalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRelationship;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBenefNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelephone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIDNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountry;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPortion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranch;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBank;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoto;
        private Class.DataSet.dsBeneficiariesTableAdapters.spSelectBeneficiariesTableAdapter spSelectBeneficiariesTableAdapter;
        private Class.DataSet.dsBeneficiariesTableAdapters.spSelectAllBeneficiariesTableAdapter spSelectAllBeneficiariesTableAdapter;
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
        private System.Windows.Forms.BindingSource employeesMasterBindingSource;
        private Class.DataSet.dsBeneficiariesTableAdapters.EmployeesMasterTableAdapter employeesMasterTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Class.DataSet.dsBeneficiariesTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private Class.DataSet.dsBeneficiaries dsBeneficiaries1;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private Class.DataSet.dsBeneficiariesTableAdapters.BanksTableAdapter banksTableAdapter;
        private System.Windows.Forms.BindingSource bankBranchesBindingSource;
        private Class.DataSet.dsBeneficiariesTableAdapters.BankBranchesTableAdapter bankBranchesTableAdapter;
    }
}