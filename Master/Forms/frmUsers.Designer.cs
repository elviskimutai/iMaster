namespace Master.Forms
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
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
            this.spSelectAllUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsers = new Master.Class.DataSet.dsUsers();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConfirmPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuperUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FullNamesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConfirmPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelephoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ExpiryDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.SuperUserCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CCCodeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExpiryDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSuperUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFullNames = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForConfirmPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelephone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCCCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectUsersTableAdapter = new Master.Class.DataSet.dsUsersTableAdapters.spSelectUsersTableAdapter();
            this.spSelectAllUsersTableAdapter = new Master.Class.DataSet.dsUsersTableAdapters.spSelectAllUsersTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.costCenterTableAdapter = new Master.Class.DataSet.dsUsersTableAdapters.CostCenterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNamesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperUserCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpiryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuperUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCCCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.UserNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FullNamesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PasswordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ConfirmPasswordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelephoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ExpiryDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.SuperUserCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CCCodeTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectUsersBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(759, 441);
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
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllUsersBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 239);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(735, 190);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllUsersBindingSource
            // 
            this.spSelectAllUsersBindingSource.DataMember = "spSelectAllUsers";
            this.spSelectAllUsersBindingSource.DataSource = this.dsUsers;
            // 
            // dsUsers
            // 
            this.dsUsers.DataSetName = "dsUsers";
            this.dsUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colFullNames,
            this.colPassword,
            this.colConfirmPassword,
            this.colEmail,
            this.colTelephone,
            this.colExpiryDate,
            this.colIsActive,
            this.colSuperUser,
            this.colCCCode,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colFullNames
            // 
            this.colFullNames.FieldName = "FullNames";
            this.colFullNames.Name = "colFullNames";
            this.colFullNames.Visible = true;
            this.colFullNames.VisibleIndex = 1;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            // 
            // colConfirmPassword
            // 
            this.colConfirmPassword.FieldName = "ConfirmPassword";
            this.colConfirmPassword.Name = "colConfirmPassword";
            this.colConfirmPassword.Visible = true;
            this.colConfirmPassword.VisibleIndex = 3;
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
            // colExpiryDate
            // 
            this.colExpiryDate.FieldName = "ExpiryDate";
            this.colExpiryDate.Name = "colExpiryDate";
            this.colExpiryDate.Visible = true;
            this.colExpiryDate.VisibleIndex = 6;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 7;
            // 
            // colSuperUser
            // 
            this.colSuperUser.FieldName = "SuperUser";
            this.colSuperUser.Name = "colSuperUser";
            this.colSuperUser.Visible = true;
            this.colSuperUser.VisibleIndex = 8;
            // 
            // colCCCode
            // 
            this.colCCCode.FieldName = "CCCode";
            this.colCCCode.Name = "colCCCode";
            this.colCCCode.Visible = true;
            this.colCCCode.VisibleIndex = 9;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 10;
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "UserName", true));
            this.UserNameTextEdit.EditValue = "";
            this.UserNameTextEdit.Location = new System.Drawing.Point(113, 72);
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Size = new System.Drawing.Size(264, 20);
            this.UserNameTextEdit.StyleController = this.dataLayoutControl1;
            this.UserNameTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.UserNameTextEdit, conditionValidationRule1);
            // 
            // spSelectUsersBindingSource
            // 
            this.spSelectUsersBindingSource.DataMember = "spSelectUsers";
            this.spSelectUsersBindingSource.DataSource = this.dsUsers;
            // 
            // FullNamesTextEdit
            // 
            this.FullNamesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "FullNames", true));
            this.FullNamesTextEdit.Location = new System.Drawing.Point(470, 72);
            this.FullNamesTextEdit.Name = "FullNamesTextEdit";
            this.FullNamesTextEdit.Size = new System.Drawing.Size(265, 20);
            this.FullNamesTextEdit.StyleController = this.dataLayoutControl1;
            this.FullNamesTextEdit.TabIndex = 5;
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "Password", true));
            this.PasswordTextEdit.Location = new System.Drawing.Point(113, 96);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Size = new System.Drawing.Size(264, 20);
            this.PasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.PasswordTextEdit.TabIndex = 6;
            // 
            // ConfirmPasswordTextEdit
            // 
            this.ConfirmPasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "ConfirmPassword", true));
            this.ConfirmPasswordTextEdit.Location = new System.Drawing.Point(470, 96);
            this.ConfirmPasswordTextEdit.Name = "ConfirmPasswordTextEdit";
            this.ConfirmPasswordTextEdit.Size = new System.Drawing.Size(265, 20);
            this.ConfirmPasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.ConfirmPasswordTextEdit.TabIndex = 7;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(113, 120);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(264, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 8;
            // 
            // TelephoneTextEdit
            // 
            this.TelephoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "Telephone", true));
            this.TelephoneTextEdit.Location = new System.Drawing.Point(470, 120);
            this.TelephoneTextEdit.Name = "TelephoneTextEdit";
            this.TelephoneTextEdit.Size = new System.Drawing.Size(265, 20);
            this.TelephoneTextEdit.StyleController = this.dataLayoutControl1;
            this.TelephoneTextEdit.TabIndex = 9;
            // 
            // ExpiryDateDateEdit
            // 
            this.ExpiryDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "ExpiryDate", true));
            this.ExpiryDateDateEdit.EditValue = null;
            this.ExpiryDateDateEdit.Location = new System.Drawing.Point(113, 144);
            this.ExpiryDateDateEdit.Name = "ExpiryDateDateEdit";
            this.ExpiryDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpiryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpiryDateDateEdit.Size = new System.Drawing.Size(264, 20);
            this.ExpiryDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ExpiryDateDateEdit.TabIndex = 10;
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "IsActive", true));
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(470, 144);
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "Is Active";
            this.IsActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(265, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsActiveCheckEdit.TabIndex = 11;
            // 
            // SuperUserCheckEdit
            // 
            this.SuperUserCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "SuperUser", true));
            this.SuperUserCheckEdit.Location = new System.Drawing.Point(113, 168);
            this.SuperUserCheckEdit.Name = "SuperUserCheckEdit";
            this.SuperUserCheckEdit.Properties.Caption = "Super User";
            this.SuperUserCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SuperUserCheckEdit.Size = new System.Drawing.Size(264, 19);
            this.SuperUserCheckEdit.StyleController = this.dataLayoutControl1;
            this.SuperUserCheckEdit.TabIndex = 12;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(113, 191);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(264, 16);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 14;
            // 
            // CCCodeTextEdit
            // 
            this.CCCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUsersBindingSource, "CCCode", true));
            this.CCCodeTextEdit.Location = new System.Drawing.Point(470, 168);
            this.CCCodeTextEdit.Name = "CCCodeTextEdit";
            this.CCCodeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CCCodeTextEdit.Properties.DataSource = this.costCenterBindingSource;
            this.CCCodeTextEdit.Properties.DisplayMember = "CCName";
            this.CCCodeTextEdit.Properties.NullText = "";
            this.CCCodeTextEdit.Properties.ValueMember = "CCCode";
            this.CCCodeTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.CCCodeTextEdit.Size = new System.Drawing.Size(265, 20);
            this.CCCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CCCodeTextEdit.TabIndex = 13;
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataMember = "CostCenter";
            this.costCenterBindingSource.DataSource = this.dsUsers;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(759, 441);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(739, 421);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 211);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(739, 210);
            this.layoutControlItem1.Text = "user Information";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUserName,
            this.ItemForPassword,
            this.ItemForEmail,
            this.ItemForExpiryDate,
            this.ItemForSuperUser,
            this.ItemForFullNames,
            this.ItemForConfirmPassword,
            this.ItemForTelephone,
            this.ItemForIsActive,
            this.ItemForCCCode,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 29);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(739, 182);
            this.layoutControlGroup3.Text = "Users";
            // 
            // ItemForUserName
            // 
            this.ItemForUserName.Control = this.UserNameTextEdit;
            this.ItemForUserName.Location = new System.Drawing.Point(0, 0);
            this.ItemForUserName.Name = "ItemForUserName";
            this.ItemForUserName.Size = new System.Drawing.Size(357, 24);
            this.ItemForUserName.Text = "User Name";
            this.ItemForUserName.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForPassword
            // 
            this.ItemForPassword.Control = this.PasswordTextEdit;
            this.ItemForPassword.Location = new System.Drawing.Point(0, 24);
            this.ItemForPassword.Name = "ItemForPassword";
            this.ItemForPassword.Size = new System.Drawing.Size(357, 24);
            this.ItemForPassword.Text = "Password";
            this.ItemForPassword.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(357, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForExpiryDate
            // 
            this.ItemForExpiryDate.Control = this.ExpiryDateDateEdit;
            this.ItemForExpiryDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForExpiryDate.Name = "ItemForExpiryDate";
            this.ItemForExpiryDate.Size = new System.Drawing.Size(357, 24);
            this.ItemForExpiryDate.Text = "Expiry Date";
            this.ItemForExpiryDate.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForSuperUser
            // 
            this.ItemForSuperUser.Control = this.SuperUserCheckEdit;
            this.ItemForSuperUser.Location = new System.Drawing.Point(0, 96);
            this.ItemForSuperUser.Name = "ItemForSuperUser";
            this.ItemForSuperUser.Size = new System.Drawing.Size(357, 23);
            this.ItemForSuperUser.Text = "Super User";
            this.ItemForSuperUser.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForFullNames
            // 
            this.ItemForFullNames.Control = this.FullNamesTextEdit;
            this.ItemForFullNames.Location = new System.Drawing.Point(357, 0);
            this.ItemForFullNames.Name = "ItemForFullNames";
            this.ItemForFullNames.Size = new System.Drawing.Size(358, 24);
            this.ItemForFullNames.Text = "Full Names";
            this.ItemForFullNames.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForConfirmPassword
            // 
            this.ItemForConfirmPassword.Control = this.ConfirmPasswordTextEdit;
            this.ItemForConfirmPassword.Location = new System.Drawing.Point(357, 24);
            this.ItemForConfirmPassword.Name = "ItemForConfirmPassword";
            this.ItemForConfirmPassword.Size = new System.Drawing.Size(358, 24);
            this.ItemForConfirmPassword.Text = "Confirm Password";
            this.ItemForConfirmPassword.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForTelephone
            // 
            this.ItemForTelephone.Control = this.TelephoneTextEdit;
            this.ItemForTelephone.Location = new System.Drawing.Point(357, 48);
            this.ItemForTelephone.Name = "ItemForTelephone";
            this.ItemForTelephone.Size = new System.Drawing.Size(358, 24);
            this.ItemForTelephone.Text = "Telephone";
            this.ItemForTelephone.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.Location = new System.Drawing.Point(357, 72);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(358, 24);
            this.ItemForIsActive.Text = "Is Active";
            this.ItemForIsActive.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForCCCode
            // 
            this.ItemForCCCode.Control = this.CCCodeTextEdit;
            this.ItemForCCCode.Location = new System.Drawing.Point(357, 96);
            this.ItemForCCCode.Name = "ItemForCCCode";
            this.ItemForCCCode.Size = new System.Drawing.Size(358, 43);
            this.ItemForCCCode.Text = "CC Code";
            this.ItemForCCCode.TextSize = new System.Drawing.Size(86, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(0, 119);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(357, 20);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(739, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectUsersTableAdapter
            // 
            this.spSelectUsersTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllUsersTableAdapter
            // 
            this.spSelectAllUsersTableAdapter.ClearBeforeFill = true;
            // 
            // costCenterTableAdapter
            // 
            this.costCenterTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 441);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNamesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperUserCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpiryDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSuperUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCCCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectUsersBindingSource;
        private Class.DataSet.dsUsers dsUsers;
        private DevExpress.XtraEditors.TextEdit FullNamesTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit ConfirmPasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit TelephoneTextEdit;
        private DevExpress.XtraEditors.DateEdit ExpiryDateDateEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraEditors.CheckEdit SuperUserCheckEdit;
        private DevExpress.XtraEditors.MemoEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExpiryDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSuperUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFullNames;
        private DevExpress.XtraLayout.LayoutControlItem ItemForConfirmPassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelephone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCCCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsUsersTableAdapters.spSelectUsersTableAdapter spSelectUsersTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllUsersBindingSource;
        private Class.DataSet.dsUsersTableAdapters.spSelectAllUsersTableAdapter spSelectAllUsersTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.GridLookUpEdit CCCodeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private Class.DataSet.dsUsersTableAdapters.CostCenterTableAdapter costCenterTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullNames;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colConfirmPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colSuperUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCCCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
    }
}