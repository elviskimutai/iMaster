namespace Master.Forms
{
    partial class frmCostCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCostCenter));
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
            this.spSelectAllCostCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCostCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCostCenter = new Master.Class.DataSet.dsCostCenter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCCCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysicalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CCCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectCostCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CCNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhysicalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WebUrlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StatusCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.CompCodeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCCCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelephone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWebUrl = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCCName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhysicalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectCostCenterTableAdapter = new Master.Class.DataSet.dsCostCenterTableAdapters.spSelectCostCenterTableAdapter();
            this.spSelectAllCostCenterTableAdapter = new Master.Class.DataSet.dsCostCenterTableAdapters.spSelectAllCostCenterTableAdapter();
            this.companiesTableAdapter = new Master.Class.DataSet.dsCostCenterTableAdapters.CompaniesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCostCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCostCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebUrlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCCCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCCName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CCCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CCNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelephoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MobileTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhysicalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WebUrlTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StatusCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.CompCodeTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCostCenterBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(758, 442);
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
            this.toolStrip1.Size = new System.Drawing.Size(734, 24);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 21);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 21);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 21);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 21);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 21);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllCostCenterBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 202);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(734, 228);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllCostCenterBindingSource
            // 
            this.spSelectAllCostCenterBindingSource.DataMember = "spSelectAllCostCenter";
            this.spSelectAllCostCenterBindingSource.DataSource = this.dsCostCenterBindingSource;
            // 
            // dsCostCenterBindingSource
            // 
            this.dsCostCenterBindingSource.DataSource = this.dsCostCenter;
            this.dsCostCenterBindingSource.Position = 0;
            // 
            // dsCostCenter
            // 
            this.dsCostCenter.DataSetName = "dsCostCenter";
            this.dsCostCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCCCode,
            this.colCCName,
            this.colCompCode,
            this.colEmail,
            this.colTelephone,
            this.colMobile,
            this.colPostalAddress,
            this.colPhysicalAddress,
            this.colWebUrl,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colCCCode
            // 
            this.colCCCode.FieldName = "CCCode";
            this.colCCCode.Name = "colCCCode";
            this.colCCCode.Visible = true;
            this.colCCCode.VisibleIndex = 0;
            // 
            // colCCName
            // 
            this.colCCName.FieldName = "CCName";
            this.colCCName.Name = "colCCName";
            this.colCCName.Visible = true;
            this.colCCName.VisibleIndex = 1;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colTelephone
            // 
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 4;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 5;
            // 
            // colPostalAddress
            // 
            this.colPostalAddress.FieldName = "PostalAddress";
            this.colPostalAddress.Name = "colPostalAddress";
            this.colPostalAddress.Visible = true;
            this.colPostalAddress.VisibleIndex = 6;
            // 
            // colPhysicalAddress
            // 
            this.colPhysicalAddress.FieldName = "PhysicalAddress";
            this.colPhysicalAddress.Name = "colPhysicalAddress";
            this.colPhysicalAddress.Visible = true;
            this.colPhysicalAddress.VisibleIndex = 7;
            // 
            // colWebUrl
            // 
            this.colWebUrl.FieldName = "WebUrl";
            this.colWebUrl.Name = "colWebUrl";
            this.colWebUrl.Visible = true;
            this.colWebUrl.VisibleIndex = 8;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "isActive";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 9;
            // 
            // CCCodeTextEdit
            // 
            this.CCCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "CCCode", true));
            this.CCCodeTextEdit.Location = new System.Drawing.Point(107, 70);
            this.CCCodeTextEdit.Name = "CCCodeTextEdit";
            this.CCCodeTextEdit.Size = new System.Drawing.Size(271, 20);
            this.CCCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CCCodeTextEdit.TabIndex = 4;
            // 
            // spSelectCostCenterBindingSource
            // 
            this.spSelectCostCenterBindingSource.DataMember = "spSelectCostCenter";
            this.spSelectCostCenterBindingSource.DataSource = this.dsCostCenterBindingSource;
            // 
            // CCNameTextEdit
            // 
            this.CCNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "CCName", true));
            this.CCNameTextEdit.Location = new System.Drawing.Point(465, 70);
            this.CCNameTextEdit.Name = "CCNameTextEdit";
            this.CCNameTextEdit.Size = new System.Drawing.Size(269, 20);
            this.CCNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CCNameTextEdit.TabIndex = 5;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(465, 94);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(269, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 7;
            // 
            // TelephoneTextEdit
            // 
            this.TelephoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "Telephone", true));
            this.TelephoneTextEdit.Location = new System.Drawing.Point(107, 118);
            this.TelephoneTextEdit.Name = "TelephoneTextEdit";
            this.TelephoneTextEdit.Size = new System.Drawing.Size(271, 20);
            this.TelephoneTextEdit.StyleController = this.dataLayoutControl1;
            this.TelephoneTextEdit.TabIndex = 8;
            // 
            // MobileTextEdit
            // 
            this.MobileTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "Mobile", true));
            this.MobileTextEdit.Location = new System.Drawing.Point(465, 118);
            this.MobileTextEdit.Name = "MobileTextEdit";
            this.MobileTextEdit.Size = new System.Drawing.Size(269, 20);
            this.MobileTextEdit.StyleController = this.dataLayoutControl1;
            this.MobileTextEdit.TabIndex = 9;
            // 
            // PostalAddressTextEdit
            // 
            this.PostalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "PostalAddress", true));
            this.PostalAddressTextEdit.Location = new System.Drawing.Point(107, 142);
            this.PostalAddressTextEdit.Name = "PostalAddressTextEdit";
            this.PostalAddressTextEdit.Size = new System.Drawing.Size(271, 20);
            this.PostalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalAddressTextEdit.TabIndex = 10;
            // 
            // PhysicalAddressTextEdit
            // 
            this.PhysicalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "PhysicalAddress", true));
            this.PhysicalAddressTextEdit.Location = new System.Drawing.Point(465, 142);
            this.PhysicalAddressTextEdit.Name = "PhysicalAddressTextEdit";
            this.PhysicalAddressTextEdit.Size = new System.Drawing.Size(269, 20);
            this.PhysicalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PhysicalAddressTextEdit.TabIndex = 11;
            // 
            // WebUrlTextEdit
            // 
            this.WebUrlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "WebUrl", true));
            this.WebUrlTextEdit.Location = new System.Drawing.Point(107, 166);
            this.WebUrlTextEdit.Name = "WebUrlTextEdit";
            this.WebUrlTextEdit.Size = new System.Drawing.Size(271, 20);
            this.WebUrlTextEdit.StyleController = this.dataLayoutControl1;
            this.WebUrlTextEdit.TabIndex = 12;
            // 
            // StatusCheckEdit
            // 
            this.StatusCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "Status", true));
            this.StatusCheckEdit.Location = new System.Drawing.Point(465, 166);
            this.StatusCheckEdit.Name = "StatusCheckEdit";
            this.StatusCheckEdit.Properties.Caption = "Status";
            this.StatusCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StatusCheckEdit.Size = new System.Drawing.Size(269, 19);
            this.StatusCheckEdit.StyleController = this.dataLayoutControl1;
            this.StatusCheckEdit.TabIndex = 13;
            // 
            // CompCodeTextEdit
            // 
            this.CompCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCostCenterBindingSource, "CompCode", true));
            this.CompCodeTextEdit.Location = new System.Drawing.Point(107, 94);
            this.CompCodeTextEdit.Name = "CompCodeTextEdit";
            this.CompCodeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CompCodeTextEdit.Properties.DataSource = this.companiesBindingSource;
            this.CompCodeTextEdit.Properties.DisplayMember = "CompName";
            this.CompCodeTextEdit.Properties.NullText = "";
            this.CompCodeTextEdit.Properties.ValueMember = "CompCode";
            this.CompCodeTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.CompCodeTextEdit.Size = new System.Drawing.Size(271, 20);
            this.CompCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CompCodeTextEdit.TabIndex = 6;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.dsCostCenterBindingSource;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(758, 442);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(738, 422);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 190);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(738, 232);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCCCode,
            this.ItemForCompCode,
            this.ItemForTelephone,
            this.ItemForPostalAddress,
            this.ItemForWebUrl,
            this.ItemForCCName,
            this.ItemForEmail,
            this.ItemForMobile,
            this.ItemForPhysicalAddress,
            this.ItemForStatus});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(738, 162);
            this.layoutControlGroup3.Text = "CostCenter Information";
            // 
            // ItemForCCCode
            // 
            this.ItemForCCCode.Control = this.CCCodeTextEdit;
            this.ItemForCCCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCCCode.Name = "ItemForCCCode";
            this.ItemForCCCode.Size = new System.Drawing.Size(358, 24);
            this.ItemForCCCode.Text = "CC Code";
            this.ItemForCCCode.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCompCode
            // 
            this.ItemForCompCode.Control = this.CompCodeTextEdit;
            this.ItemForCompCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForCompCode.Name = "ItemForCompCode";
            this.ItemForCompCode.Size = new System.Drawing.Size(358, 24);
            this.ItemForCompCode.Text = "Comp Code";
            this.ItemForCompCode.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForTelephone
            // 
            this.ItemForTelephone.Control = this.TelephoneTextEdit;
            this.ItemForTelephone.Location = new System.Drawing.Point(0, 48);
            this.ItemForTelephone.Name = "ItemForTelephone";
            this.ItemForTelephone.Size = new System.Drawing.Size(358, 24);
            this.ItemForTelephone.Text = "Telephone";
            this.ItemForTelephone.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPostalAddress
            // 
            this.ItemForPostalAddress.Control = this.PostalAddressTextEdit;
            this.ItemForPostalAddress.Location = new System.Drawing.Point(0, 72);
            this.ItemForPostalAddress.Name = "ItemForPostalAddress";
            this.ItemForPostalAddress.Size = new System.Drawing.Size(358, 24);
            this.ItemForPostalAddress.Text = "Postal Address";
            this.ItemForPostalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForWebUrl
            // 
            this.ItemForWebUrl.Control = this.WebUrlTextEdit;
            this.ItemForWebUrl.Location = new System.Drawing.Point(0, 96);
            this.ItemForWebUrl.Name = "ItemForWebUrl";
            this.ItemForWebUrl.Size = new System.Drawing.Size(358, 24);
            this.ItemForWebUrl.Text = "Web Url";
            this.ItemForWebUrl.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForCCName
            // 
            this.ItemForCCName.Control = this.CCNameTextEdit;
            this.ItemForCCName.Location = new System.Drawing.Point(358, 0);
            this.ItemForCCName.Name = "ItemForCCName";
            this.ItemForCCName.Size = new System.Drawing.Size(356, 24);
            this.ItemForCCName.Text = "CC Name";
            this.ItemForCCName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(358, 24);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(356, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForMobile
            // 
            this.ItemForMobile.Control = this.MobileTextEdit;
            this.ItemForMobile.Location = new System.Drawing.Point(358, 48);
            this.ItemForMobile.Name = "ItemForMobile";
            this.ItemForMobile.Size = new System.Drawing.Size(356, 24);
            this.ItemForMobile.Text = "Mobile";
            this.ItemForMobile.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForPhysicalAddress
            // 
            this.ItemForPhysicalAddress.Control = this.PhysicalAddressTextEdit;
            this.ItemForPhysicalAddress.Location = new System.Drawing.Point(358, 72);
            this.ItemForPhysicalAddress.Name = "ItemForPhysicalAddress";
            this.ItemForPhysicalAddress.Size = new System.Drawing.Size(356, 24);
            this.ItemForPhysicalAddress.Text = "Physical Address";
            this.ItemForPhysicalAddress.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusCheckEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(358, 96);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(356, 24);
            this.ItemForStatus.Text = "isActive";
            this.ItemForStatus.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(738, 28);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectCostCenterTableAdapter
            // 
            this.spSelectCostCenterTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllCostCenterTableAdapter
            // 
            this.spSelectAllCostCenterTableAdapter.ClearBeforeFill = true;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // frmCostCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 442);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCostCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostCenter";
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCostCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCostCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebUrlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCCCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCCName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllCostCenterBindingSource;
        private System.Windows.Forms.BindingSource dsCostCenterBindingSource;
        private Class.DataSet.dsCostCenter dsCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCCCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCCName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysicalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colWebUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.TextEdit CCCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectCostCenterBindingSource;
        private DevExpress.XtraEditors.TextEdit CCNameTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit TelephoneTextEdit;
        private DevExpress.XtraEditors.TextEdit MobileTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PhysicalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit WebUrlTextEdit;
        private DevExpress.XtraEditors.CheckEdit StatusCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCCCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelephone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebUrl;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCCName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhysicalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private Class.DataSet.dsCostCenterTableAdapters.spSelectCostCenterTableAdapter spSelectCostCenterTableAdapter;
        private Class.DataSet.dsCostCenterTableAdapters.spSelectAllCostCenterTableAdapter spSelectAllCostCenterTableAdapter;
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
        private DevExpress.XtraEditors.GridLookUpEdit CompCodeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private Class.DataSet.dsCostCenterTableAdapters.CompaniesTableAdapter companiesTableAdapter;
    }
}