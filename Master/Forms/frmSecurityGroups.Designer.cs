namespace Master.Forms
{
    partial class frmSecurityGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityGroups));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllSecurityGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSecurityGroups = new Master.Class.DataSet.dsSecurityGroups();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectSecurityGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForGroupCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGroupName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectSecurityGroupsTableAdapter = new Master.Class.DataSet.dsSecurityGroupsTableAdapters.spSelectSecurityGroupsTableAdapter();
            this.spSelectAllSecurityGroupsTableAdapter = new Master.Class.DataSet.dsSecurityGroupsTableAdapters.spSelectAllSecurityGroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSecurityGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurityGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSecurityGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip2);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.GroupCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GroupNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.DataSource = this.spSelectSecurityGroupsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(549, 364);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripSeparator6,
            this.toolStripButton4,
            this.toolStripSeparator7,
            this.toolStripButton5,
            this.toolStripSeparator8,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(12, 12);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(525, 20);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(51, 17);
            this.toolStripButton2.Text = "&Save";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(47, 17);
            this.toolStripButton3.Text = "Edit";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 17);
            this.toolStripButton4.Text = "Delete";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(60, 17);
            this.toolStripButton5.Text = "Export";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(52, 17);
            this.toolStripButton6.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllSecurityGroupsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(525, 268);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllSecurityGroupsBindingSource
            // 
            this.spSelectAllSecurityGroupsBindingSource.DataMember = "spSelectAllSecurityGroups";
            this.spSelectAllSecurityGroupsBindingSource.DataSource = this.dsSecurityGroups;
            // 
            // dsSecurityGroups
            // 
            this.dsSecurityGroups.DataSetName = "dsSecurityGroups";
            this.dsSecurityGroups.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupCode,
            this.colGroupName,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colGroupCode
            // 
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.Name = "colGroupCode";
            this.colGroupCode.Visible = true;
            this.colGroupCode.VisibleIndex = 0;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 2;
            // 
            // GroupCodeTextEdit
            // 
            this.GroupCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSecurityGroupsBindingSource, "GroupCode", true));
            this.GroupCodeTextEdit.Location = new System.Drawing.Point(74, 36);
            this.GroupCodeTextEdit.Name = "GroupCodeTextEdit";
            this.GroupCodeTextEdit.Size = new System.Drawing.Size(198, 20);
            this.GroupCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.GroupCodeTextEdit.TabIndex = 4;
            // 
            // spSelectSecurityGroupsBindingSource
            // 
            this.spSelectSecurityGroupsBindingSource.DataMember = "spSelectSecurityGroups";
            this.spSelectSecurityGroupsBindingSource.DataSource = this.dsSecurityGroups;
            // 
            // GroupNameTextEdit
            // 
            this.GroupNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSecurityGroupsBindingSource, "GroupName", true));
            this.GroupNameTextEdit.Location = new System.Drawing.Point(338, 36);
            this.GroupNameTextEdit.Name = "GroupNameTextEdit";
            this.GroupNameTextEdit.Size = new System.Drawing.Size(199, 20);
            this.GroupNameTextEdit.StyleController = this.dataLayoutControl1;
            this.GroupNameTextEdit.TabIndex = 5;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSecurityGroupsBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(74, 60);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(463, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 6;
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
            this.toolStrip1.Location = new System.Drawing.Point(109, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(163, 20);
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
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 20);
            this.copyToolStripButton.Text = "Delete";
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
            this.toolStripButton1.Size = new System.Drawing.Size(60, 20);
            this.toolStripButton1.Text = "Export";
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
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(549, 364);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForGroupCode,
            this.ItemForGroupName,
            this.ItemForNarration,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(529, 344);
            // 
            // ItemForGroupCode
            // 
            this.ItemForGroupCode.Control = this.GroupCodeTextEdit;
            this.ItemForGroupCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForGroupCode.Name = "ItemForGroupCode";
            this.ItemForGroupCode.Size = new System.Drawing.Size(264, 24);
            this.ItemForGroupCode.Text = "Group Code";
            this.ItemForGroupCode.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForGroupName
            // 
            this.ItemForGroupName.Control = this.GroupNameTextEdit;
            this.ItemForGroupName.Location = new System.Drawing.Point(264, 24);
            this.ItemForGroupName.Name = "ItemForGroupName";
            this.ItemForGroupName.Size = new System.Drawing.Size(265, 24);
            this.ItemForGroupName.Text = "Group Name";
            this.ItemForGroupName.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(0, 48);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(529, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(529, 272);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(529, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectSecurityGroupsTableAdapter
            // 
            this.spSelectSecurityGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllSecurityGroupsTableAdapter
            // 
            this.spSelectAllSecurityGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // frmSecurityGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 364);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmSecurityGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Groups";
            this.Load += new System.EventHandler(this.frmSecurityGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSecurityGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecurityGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSecurityGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllSecurityGroupsBindingSource;
        private Class.DataSet.dsSecurityGroups dsSecurityGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCode;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraEditors.TextEdit GroupCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectSecurityGroupsBindingSource;
        private DevExpress.XtraEditors.TextEdit GroupNameTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGroupCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGroupName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsSecurityGroupsTableAdapters.spSelectSecurityGroupsTableAdapter spSelectSecurityGroupsTableAdapter;
        private Class.DataSet.dsSecurityGroupsTableAdapters.spSelectAllSecurityGroupsTableAdapter spSelectAllSecurityGroupsTableAdapter;
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
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}