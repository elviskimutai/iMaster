namespace Master.Forms
{
    partial class frmDepartmentAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentAccess));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dsDepartmentAccess = new Master.Class.DataSet.dsDepartmentAccess();
            this.spSelectDepartmentAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectDepartmentAccessTableAdapter = new Master.Class.DataSet.dsDepartmentAccessTableAdapters.spSelectDepartmentAccessTableAdapter();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.DeptCodeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForDeptCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.spgetUDCByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetUDCByCategoryTableAdapter = new Master.Class.DataSet.dsDepartmentAccessTableAdapters.spgetUDCByCategoryTableAdapter();
            this.spgetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spgetUsersTableAdapter = new Master.Class.DataSet.dsDepartmentAccessTableAdapters.spgetUsersTableAdapter();
            this.spSelectDepartmentAccessBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spSelectAllDepartmentAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectAllDepartmentAccessTableAdapter = new Master.Class.DataSet.dsDepartmentAccessTableAdapters.spSelectAllDepartmentAccessTableAdapter();
            this.UserNameSearchLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepartmentAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectDepartmentAccessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDeptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectDepartmentAccessBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllDepartmentAccessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.DeptCodeGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UserNameSearchLookUpEdit);
            this.dataLayoutControl1.DataSource = this.spSelectDepartmentAccessBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(991, 480);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(991, 480);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dsDepartmentAccess
            // 
            this.dsDepartmentAccess.DataSetName = "dsDepartmentAccess";
            this.dsDepartmentAccess.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSelectDepartmentAccessBindingSource
            // 
            this.spSelectDepartmentAccessBindingSource.DataMember = "spSelectDepartmentAccess";
            this.spSelectDepartmentAccessBindingSource.DataSource = this.dsDepartmentAccess;
            // 
            // spSelectDepartmentAccessTableAdapter
            // 
            this.spSelectDepartmentAccessTableAdapter.ClearBeforeFill = true;
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(971, 460);
            // 
            // DeptCodeGridLookUpEdit
            // 
            this.DeptCodeGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectDepartmentAccessBindingSource, "DeptCode", true));
            this.DeptCodeGridLookUpEdit.Location = new System.Drawing.Point(80, 66);
            this.DeptCodeGridLookUpEdit.Name = "DeptCodeGridLookUpEdit";
            this.DeptCodeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeptCodeGridLookUpEdit.Properties.DataSource = this.spgetUDCByCategoryBindingSource;
            this.DeptCodeGridLookUpEdit.Properties.DisplayMember = "Description";
            this.DeptCodeGridLookUpEdit.Properties.NullText = "";
            this.DeptCodeGridLookUpEdit.Properties.ValueMember = "Code";
            this.DeptCodeGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.DeptCodeGridLookUpEdit.Size = new System.Drawing.Size(414, 20);
            this.DeptCodeGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DeptCodeGridLookUpEdit.TabIndex = 4;
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
            // ItemForDeptCode
            // 
            this.ItemForDeptCode.Control = this.DeptCodeGridLookUpEdit;
            this.ItemForDeptCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForDeptCode.Name = "ItemForDeptCode";
            this.ItemForDeptCode.Size = new System.Drawing.Size(474, 24);
            this.ItemForDeptCode.Text = "Dept Code";
            this.ItemForDeptCode.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForUserName
            // 
            this.ItemForUserName.Control = this.UserNameSearchLookUpEdit;
            this.ItemForUserName.Location = new System.Drawing.Point(474, 0);
            this.ItemForUserName.Name = "ItemForUserName";
            this.ItemForUserName.Size = new System.Drawing.Size(473, 48);
            this.ItemForUserName.Text = "User Name";
            this.ItemForUserName.TextSize = new System.Drawing.Size(52, 13);
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectDepartmentAccessBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(80, 90);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(414, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 6;
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 24);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(474, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(52, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllDepartmentAccessBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(967, 342);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colDeptCode,
            this.colDeptName,
            this.colUserName,
            this.colRemarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(971, 346);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(967, 20);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 25);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 25);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 25);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 25);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(971, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDeptCode,
            this.ItemForUserName,
            this.ItemForRemarks});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(971, 90);
            this.layoutControlGroup3.Text = "Department Access";
            // 
            // spgetUDCByCategoryBindingSource
            // 
            this.spgetUDCByCategoryBindingSource.DataMember = "spgetUDCByCategory";
            this.spgetUDCByCategoryBindingSource.DataSource = this.dsDepartmentAccess;
            // 
            // spgetUDCByCategoryTableAdapter
            // 
            this.spgetUDCByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // spgetUsersBindingSource
            // 
            this.spgetUsersBindingSource.DataMember = "spgetUsers";
            this.spgetUsersBindingSource.DataSource = this.dsDepartmentAccess;
            // 
            // spgetUsersTableAdapter
            // 
            this.spgetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectDepartmentAccessBindingSource1
            // 
            this.spSelectDepartmentAccessBindingSource1.DataMember = "spSelectDepartmentAccess";
            this.spSelectDepartmentAccessBindingSource1.DataSource = this.dsDepartmentAccess;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colDeptCode
            // 
            this.colDeptCode.FieldName = "DeptCode";
            this.colDeptCode.Name = "colDeptCode";
            this.colDeptCode.Visible = true;
            this.colDeptCode.VisibleIndex = 1;
            // 
            // colDeptName
            // 
            this.colDeptName.FieldName = "DeptName";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.Visible = true;
            this.colDeptName.VisibleIndex = 2;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 3;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 4;
            // 
            // spSelectAllDepartmentAccessBindingSource
            // 
            this.spSelectAllDepartmentAccessBindingSource.DataMember = "spSelectAllDepartmentAccess";
            this.spSelectAllDepartmentAccessBindingSource.DataSource = this.dsDepartmentAccess;
            // 
            // spSelectAllDepartmentAccessTableAdapter
            // 
            this.spSelectAllDepartmentAccessTableAdapter.ClearBeforeFill = true;
            // 
            // UserNameSearchLookUpEdit
            // 
            this.UserNameSearchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectDepartmentAccessBindingSource, "UserName", true));
            this.UserNameSearchLookUpEdit.Location = new System.Drawing.Point(554, 66);
            this.UserNameSearchLookUpEdit.Name = "UserNameSearchLookUpEdit";
            this.UserNameSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UserNameSearchLookUpEdit.Properties.DataSource = this.spgetUsersBindingSource;
            this.UserNameSearchLookUpEdit.Properties.DisplayMember = "FullNames";
            this.UserNameSearchLookUpEdit.Properties.NullText = "";
            this.UserNameSearchLookUpEdit.Properties.ValueMember = "UserName";
            this.UserNameSearchLookUpEdit.Properties.View = this.gridView2;
            this.UserNameSearchLookUpEdit.Size = new System.Drawing.Size(413, 20);
            this.UserNameSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.UserNameSearchLookUpEdit.TabIndex = 5;
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
            // frmDepartmentAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 480);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmDepartmentAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department Access";
            this.Load += new System.EventHandler(this.frmDepartmentAccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepartmentAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectDepartmentAccessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDeptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUDCByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectDepartmentAccessBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllDepartmentAccessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit DeptCodeGridLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectDepartmentAccessBindingSource;
        private Class.DataSet.dsDepartmentAccess dsDepartmentAccess;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDeptCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsDepartmentAccessTableAdapters.spSelectDepartmentAccessTableAdapter spSelectDepartmentAccessTableAdapter;
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
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource spgetUDCByCategoryBindingSource;
        private System.Windows.Forms.BindingSource spgetUsersBindingSource;
        private Class.DataSet.dsDepartmentAccessTableAdapters.spgetUDCByCategoryTableAdapter spgetUDCByCategoryTableAdapter;
        private Class.DataSet.dsDepartmentAccessTableAdapters.spgetUsersTableAdapter spgetUsersTableAdapter;
        private System.Windows.Forms.BindingSource spSelectDepartmentAccessBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private System.Windows.Forms.BindingSource spSelectAllDepartmentAccessBindingSource;
        private Class.DataSet.dsDepartmentAccessTableAdapters.spSelectAllDepartmentAccessTableAdapter spSelectAllDepartmentAccessTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit UserNameSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}