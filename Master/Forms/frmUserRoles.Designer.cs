namespace Master.Forms
{
    partial class frmUserRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRoles));
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
            this.spSelectAllUserRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUserRoles = new Master.Class.DataSet.dsUserRoles();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecurityModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.ViewCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.spSelectUserRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.EditCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.DeleteCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ExportCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ImportCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ExpiryDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.UserGroupTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.securityGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SecurityModuleTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUserGroup = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSecurityModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExport = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForView = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForImport = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExpiryDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectUserRolesTableAdapter = new Master.Class.DataSet.dsUserRolesTableAdapters.spSelectUserRolesTableAdapter();
            this.spSelectAllUserRolesTableAdapter = new Master.Class.DataSet.dsUserRolesTableAdapters.spSelectAllUserRolesTableAdapter();
            this.rolesTableAdapter = new Master.Class.DataSet.dsUserRolesTableAdapters.RolesTableAdapter();
            this.securityGroupsTableAdapter = new Master.Class.DataSet.dsUserRolesTableAdapters.SecurityGroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUserRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectUserRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityModuleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSecurityModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpiryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.checkEdit1);
            this.dataLayoutControl1.Controls.Add(this.ViewCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.AddCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.EditCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.DeleteCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.ExportCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.ImportCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.ExpiryDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.UserGroupTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SecurityModuleTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectUserRolesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(570, 375);
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
            this.toolStrip1.Size = new System.Drawing.Size(546, 20);
            this.toolStrip1.TabIndex = 18;
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
            this.gridControl1.DataSource = this.spSelectAllUserRolesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 153);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 210);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllUserRolesBindingSource
            // 
            this.spSelectAllUserRolesBindingSource.DataMember = "spSelectAllUserRoles";
            this.spSelectAllUserRolesBindingSource.DataSource = this.dsUserRoles;
            // 
            // dsUserRoles
            // 
            this.dsUserRoles.DataSetName = "dsUserRoles";
            this.dsUserRoles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserGroup,
            this.colSecurityModule,
            this.colView,
            this.colAdd,
            this.colEdit,
            this.colDelete,
            this.colExport,
            this.colImport,
            this.colExpiryDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colUserGroup
            // 
            this.colUserGroup.FieldName = "UserGroup";
            this.colUserGroup.Name = "colUserGroup";
            this.colUserGroup.Visible = true;
            this.colUserGroup.VisibleIndex = 0;
            // 
            // colSecurityModule
            // 
            this.colSecurityModule.FieldName = "SecurityModule";
            this.colSecurityModule.Name = "colSecurityModule";
            this.colSecurityModule.Visible = true;
            this.colSecurityModule.VisibleIndex = 1;
            // 
            // colView
            // 
            this.colView.FieldName = "View";
            this.colView.Name = "colView";
            this.colView.Visible = true;
            this.colView.VisibleIndex = 2;
            // 
            // colAdd
            // 
            this.colAdd.FieldName = "Add";
            this.colAdd.Name = "colAdd";
            this.colAdd.Visible = true;
            this.colAdd.VisibleIndex = 3;
            // 
            // colEdit
            // 
            this.colEdit.FieldName = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 4;
            // 
            // colDelete
            // 
            this.colDelete.FieldName = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
            // 
            // colExport
            // 
            this.colExport.FieldName = "Export";
            this.colExport.Name = "colExport";
            this.colExport.Visible = true;
            this.colExport.VisibleIndex = 6;
            // 
            // colImport
            // 
            this.colImport.FieldName = "Import";
            this.colImport.Name = "colImport";
            this.colImport.Visible = true;
            this.colImport.VisibleIndex = 7;
            // 
            // colExpiryDate
            // 
            this.colExpiryDate.FieldName = "ExpiryDate";
            this.colExpiryDate.Name = "colExpiryDate";
            this.colExpiryDate.Visible = true;
            this.colExpiryDate.VisibleIndex = 8;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(91, 60);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "All Previlagies";
            this.checkEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkEdit1.Size = new System.Drawing.Size(192, 19);
            this.checkEdit1.StyleController = this.dataLayoutControl1;
            this.checkEdit1.TabIndex = 13;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // ViewCheckEdit
            // 
            this.ViewCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "View", true));
            this.ViewCheckEdit.Location = new System.Drawing.Point(366, 60);
            this.ViewCheckEdit.Name = "ViewCheckEdit";
            this.ViewCheckEdit.Properties.Caption = "View";
            this.ViewCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ViewCheckEdit.Size = new System.Drawing.Size(192, 19);
            this.ViewCheckEdit.StyleController = this.dataLayoutControl1;
            this.ViewCheckEdit.TabIndex = 6;
            // 
            // spSelectUserRolesBindingSource
            // 
            this.spSelectUserRolesBindingSource.DataMember = "spSelectUserRoles";
            this.spSelectUserRolesBindingSource.DataSource = this.dsUserRoles;
            // 
            // AddCheckEdit
            // 
            this.AddCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "Add", true));
            this.AddCheckEdit.Location = new System.Drawing.Point(91, 83);
            this.AddCheckEdit.Name = "AddCheckEdit";
            this.AddCheckEdit.Properties.Caption = "Add";
            this.AddCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AddCheckEdit.Size = new System.Drawing.Size(192, 19);
            this.AddCheckEdit.StyleController = this.dataLayoutControl1;
            this.AddCheckEdit.TabIndex = 7;
            // 
            // EditCheckEdit
            // 
            this.EditCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "Edit", true));
            this.EditCheckEdit.Location = new System.Drawing.Point(366, 83);
            this.EditCheckEdit.Name = "EditCheckEdit";
            this.EditCheckEdit.Properties.Caption = "Edit";
            this.EditCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EditCheckEdit.Size = new System.Drawing.Size(192, 19);
            this.EditCheckEdit.StyleController = this.dataLayoutControl1;
            this.EditCheckEdit.TabIndex = 8;
            // 
            // DeleteCheckEdit
            // 
            this.DeleteCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "Delete", true));
            this.DeleteCheckEdit.Location = new System.Drawing.Point(91, 106);
            this.DeleteCheckEdit.Name = "DeleteCheckEdit";
            this.DeleteCheckEdit.Properties.Caption = "Delete";
            this.DeleteCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DeleteCheckEdit.Size = new System.Drawing.Size(192, 19);
            this.DeleteCheckEdit.StyleController = this.dataLayoutControl1;
            this.DeleteCheckEdit.TabIndex = 9;
            // 
            // ExportCheckEdit
            // 
            this.ExportCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "Export", true));
            this.ExportCheckEdit.Location = new System.Drawing.Point(91, 129);
            this.ExportCheckEdit.Name = "ExportCheckEdit";
            this.ExportCheckEdit.Properties.Caption = "Export";
            this.ExportCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ExportCheckEdit.Size = new System.Drawing.Size(192, 19);
            this.ExportCheckEdit.StyleController = this.dataLayoutControl1;
            this.ExportCheckEdit.TabIndex = 10;
            // 
            // ImportCheckEdit
            // 
            this.ImportCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "Import", true));
            this.ImportCheckEdit.Location = new System.Drawing.Point(366, 106);
            this.ImportCheckEdit.Name = "ImportCheckEdit";
            this.ImportCheckEdit.Properties.Caption = "Import";
            this.ImportCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ImportCheckEdit.Size = new System.Drawing.Size(192, 19);
            this.ImportCheckEdit.StyleController = this.dataLayoutControl1;
            this.ImportCheckEdit.TabIndex = 11;
            // 
            // ExpiryDateDateEdit
            // 
            this.ExpiryDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "ExpiryDate", true));
            this.ExpiryDateDateEdit.EditValue = null;
            this.ExpiryDateDateEdit.Location = new System.Drawing.Point(366, 129);
            this.ExpiryDateDateEdit.Name = "ExpiryDateDateEdit";
            this.ExpiryDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpiryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpiryDateDateEdit.Size = new System.Drawing.Size(192, 20);
            this.ExpiryDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ExpiryDateDateEdit.TabIndex = 12;
            // 
            // UserGroupTextEdit
            // 
            this.UserGroupTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "UserGroup", true));
            this.UserGroupTextEdit.Location = new System.Drawing.Point(91, 36);
            this.UserGroupTextEdit.Name = "UserGroupTextEdit";
            this.UserGroupTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UserGroupTextEdit.Properties.DataSource = this.securityGroupsBindingSource;
            this.UserGroupTextEdit.Properties.DisplayMember = "GroupName";
            this.UserGroupTextEdit.Properties.NullText = "";
            this.UserGroupTextEdit.Properties.ValueMember = "GroupCode";
            this.UserGroupTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.UserGroupTextEdit.Size = new System.Drawing.Size(192, 20);
            this.UserGroupTextEdit.StyleController = this.dataLayoutControl1;
            this.UserGroupTextEdit.TabIndex = 4;
            // 
            // securityGroupsBindingSource
            // 
            this.securityGroupsBindingSource.DataMember = "SecurityGroups";
            this.securityGroupsBindingSource.DataSource = this.dsUserRoles;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // SecurityModuleTextEdit
            // 
            this.SecurityModuleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserRolesBindingSource, "SecurityModule", true));
            this.SecurityModuleTextEdit.Location = new System.Drawing.Point(366, 36);
            this.SecurityModuleTextEdit.Name = "SecurityModuleTextEdit";
            this.SecurityModuleTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SecurityModuleTextEdit.Properties.DataSource = this.rolesBindingSource;
            this.SecurityModuleTextEdit.Properties.DisplayMember = "RoleName";
            this.SecurityModuleTextEdit.Properties.NullText = "";
            this.SecurityModuleTextEdit.Properties.ValueMember = "RoleName";
            this.SecurityModuleTextEdit.Properties.View = this.gridView2;
            this.SecurityModuleTextEdit.Size = new System.Drawing.Size(192, 20);
            this.SecurityModuleTextEdit.StyleController = this.dataLayoutControl1;
            this.SecurityModuleTextEdit.TabIndex = 5;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.dsUserRoles;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(570, 375);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUserGroup,
            this.ItemForSecurityModule,
            this.ItemForAdd,
            this.ItemForDelete,
            this.ItemForExport,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.ItemForView,
            this.ItemForEdit,
            this.ItemForImport,
            this.ItemForExpiryDate,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(550, 355);
            // 
            // ItemForUserGroup
            // 
            this.ItemForUserGroup.Control = this.UserGroupTextEdit;
            this.ItemForUserGroup.Location = new System.Drawing.Point(0, 24);
            this.ItemForUserGroup.Name = "ItemForUserGroup";
            this.ItemForUserGroup.Size = new System.Drawing.Size(275, 24);
            this.ItemForUserGroup.Text = "User Group";
            this.ItemForUserGroup.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForSecurityModule
            // 
            this.ItemForSecurityModule.Control = this.SecurityModuleTextEdit;
            this.ItemForSecurityModule.Location = new System.Drawing.Point(275, 24);
            this.ItemForSecurityModule.Name = "ItemForSecurityModule";
            this.ItemForSecurityModule.Size = new System.Drawing.Size(275, 24);
            this.ItemForSecurityModule.Text = "Security Module";
            this.ItemForSecurityModule.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForAdd
            // 
            this.ItemForAdd.Control = this.AddCheckEdit;
            this.ItemForAdd.Location = new System.Drawing.Point(0, 71);
            this.ItemForAdd.Name = "ItemForAdd";
            this.ItemForAdd.Size = new System.Drawing.Size(275, 23);
            this.ItemForAdd.Text = "Add";
            this.ItemForAdd.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForDelete
            // 
            this.ItemForDelete.Control = this.DeleteCheckEdit;
            this.ItemForDelete.Location = new System.Drawing.Point(0, 94);
            this.ItemForDelete.Name = "ItemForDelete";
            this.ItemForDelete.Size = new System.Drawing.Size(275, 23);
            this.ItemForDelete.Text = "Delete";
            this.ItemForDelete.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForExport
            // 
            this.ItemForExport.Control = this.ExportCheckEdit;
            this.ItemForExport.Location = new System.Drawing.Point(0, 117);
            this.ItemForExport.Name = "ItemForExport";
            this.ItemForExport.Size = new System.Drawing.Size(275, 24);
            this.ItemForExport.Text = "Export";
            this.ItemForExport.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 141);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(550, 214);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(275, 23);
            this.layoutControlItem1.Text = "All Privilages";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForView
            // 
            this.ItemForView.Control = this.ViewCheckEdit;
            this.ItemForView.Location = new System.Drawing.Point(275, 48);
            this.ItemForView.Name = "ItemForView";
            this.ItemForView.Size = new System.Drawing.Size(275, 23);
            this.ItemForView.Text = "View";
            this.ItemForView.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForEdit
            // 
            this.ItemForEdit.Control = this.EditCheckEdit;
            this.ItemForEdit.Location = new System.Drawing.Point(275, 71);
            this.ItemForEdit.Name = "ItemForEdit";
            this.ItemForEdit.Size = new System.Drawing.Size(275, 23);
            this.ItemForEdit.Text = "Edit";
            this.ItemForEdit.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForImport
            // 
            this.ItemForImport.Control = this.ImportCheckEdit;
            this.ItemForImport.Location = new System.Drawing.Point(275, 94);
            this.ItemForImport.Name = "ItemForImport";
            this.ItemForImport.Size = new System.Drawing.Size(275, 23);
            this.ItemForImport.Text = "Import";
            this.ItemForImport.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForExpiryDate
            // 
            this.ItemForExpiryDate.Control = this.ExpiryDateDateEdit;
            this.ItemForExpiryDate.Location = new System.Drawing.Point(275, 117);
            this.ItemForExpiryDate.Name = "ItemForExpiryDate";
            this.ItemForExpiryDate.Size = new System.Drawing.Size(275, 24);
            this.ItemForExpiryDate.Text = "Expiry Date";
            this.ItemForExpiryDate.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.toolStrip1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(550, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // spSelectUserRolesTableAdapter
            // 
            this.spSelectUserRolesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllUserRolesTableAdapter
            // 
            this.spSelectAllUserRolesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // securityGroupsTableAdapter
            // 
            this.securityGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 375);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmUserRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Roles";
            this.Load += new System.EventHandler(this.frmUserRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUserRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectUserRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExportCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpiryDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityModuleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSecurityModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpiryDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colSecurityModule;
        private DevExpress.XtraGrid.Columns.GridColumn colView;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colExport;
        private DevExpress.XtraGrid.Columns.GridColumn colImport;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiryDate;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit ViewCheckEdit;
        private DevExpress.XtraEditors.CheckEdit AddCheckEdit;
        private DevExpress.XtraEditors.CheckEdit EditCheckEdit;
        private DevExpress.XtraEditors.CheckEdit DeleteCheckEdit;
        private DevExpress.XtraEditors.CheckEdit ExportCheckEdit;
        private DevExpress.XtraEditors.CheckEdit ImportCheckEdit;
        private DevExpress.XtraEditors.DateEdit ExpiryDateDateEdit;
        private DevExpress.XtraEditors.GridLookUpEdit UserGroupTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit SecurityModuleTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserGroup;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSecurityModule;
        private DevExpress.XtraLayout.LayoutControlItem ItemForView;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAdd;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDelete;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExport;
        private DevExpress.XtraLayout.LayoutControlItem ItemForImport;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExpiryDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource spSelectAllUserRolesBindingSource;
        private Class.DataSet.dsUserRoles dsUserRoles;
        private System.Windows.Forms.BindingSource spSelectUserRolesBindingSource;
        private Class.DataSet.dsUserRolesTableAdapters.spSelectUserRolesTableAdapter spSelectUserRolesTableAdapter;
        private Class.DataSet.dsUserRolesTableAdapters.spSelectAllUserRolesTableAdapter spSelectAllUserRolesTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private Class.DataSet.dsUserRolesTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.BindingSource securityGroupsBindingSource;
        private Class.DataSet.dsUserRolesTableAdapters.SecurityGroupsTableAdapter securityGroupsTableAdapter;
    }
}