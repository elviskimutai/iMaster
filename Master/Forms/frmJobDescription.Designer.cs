namespace Master.Forms
{
    partial class frmJobDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobDescription));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllHRJobDescriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDescription = new Master.Class.DataSet.dsDescription();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.AppDueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.spSelectHRJobDescriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobDescMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.JobTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ReqNoLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spGetJobReqNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForReqNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJobTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAppDueDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJobDesc = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsJobDescription = new Master.Class.DataSet.dsJobDescription();
            this.dsJobDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectHRJobDescriptionsTableAdapter = new Master.Class.DataSet.dsDescriptionTableAdapters.spSelectHRJobDescriptionsTableAdapter();
            this.spSelectAllHRJobDescriptionsTableAdapter = new Master.Class.DataSet.dsDescriptionTableAdapters.spSelectAllHRJobDescriptionsTableAdapter();
            this.spGetJobReqNoTableAdapter = new Master.Class.DataSet.dsDescriptionTableAdapters.spGetJobReqNoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllHRJobDescriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppDueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectHRJobDescriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobDescMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReqNoLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetJobReqNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAppDueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobDescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.AppDueDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.JobDescMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.JobTitleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ReqNoLookUpEdit);
            this.dataLayoutControl1.DataSource = this.spSelectHRJobDescriptionsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(830, 468);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllHRJobDescriptionsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 267);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(806, 189);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllHRJobDescriptionsBindingSource
            // 
            this.spSelectAllHRJobDescriptionsBindingSource.DataMember = "spSelectAllHRJobDescriptions";
            this.spSelectAllHRJobDescriptionsBindingSource.DataSource = this.dsDescription;
            // 
            // dsDescription
            // 
            this.dsDescription.DataSetName = "dsDescription";
            this.dsDescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReqNo,
            this.colJobTitle,
            this.colAppDueDate,
            this.colJobDesc,
            this.colRemarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colReqNo
            // 
            this.colReqNo.FieldName = "ReqNo";
            this.colReqNo.Name = "colReqNo";
            this.colReqNo.Visible = true;
            this.colReqNo.VisibleIndex = 0;
            // 
            // colJobTitle
            // 
            this.colJobTitle.FieldName = "JobTitle";
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.Visible = true;
            this.colJobTitle.VisibleIndex = 1;
            // 
            // colAppDueDate
            // 
            this.colAppDueDate.FieldName = "AppDueDate";
            this.colAppDueDate.Name = "colAppDueDate";
            this.colAppDueDate.Visible = true;
            this.colAppDueDate.VisibleIndex = 2;
            // 
            // colJobDesc
            // 
            this.colJobDesc.FieldName = "JobDesc";
            this.colJobDesc.Name = "colJobDesc";
            this.colJobDesc.Visible = true;
            this.colJobDesc.VisibleIndex = 3;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 4;
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
            this.toolStrip1.Size = new System.Drawing.Size(806, 22);
            this.toolStrip1.TabIndex = 21;
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
            // AppDueDateDateEdit
            // 
            this.AppDueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectHRJobDescriptionsBindingSource, "AppDueDate", true));
            this.AppDueDateDateEdit.EditValue = null;
            this.AppDueDateDateEdit.Location = new System.Drawing.Point(94, 92);
            this.AppDueDateDateEdit.Name = "AppDueDateDateEdit";
            this.AppDueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AppDueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AppDueDateDateEdit.Size = new System.Drawing.Size(712, 20);
            this.AppDueDateDateEdit.StyleController = this.dataLayoutControl1;
            this.AppDueDateDateEdit.TabIndex = 6;
            // 
            // spSelectHRJobDescriptionsBindingSource
            // 
            this.spSelectHRJobDescriptionsBindingSource.DataMember = "spSelectHRJobDescriptions";
            this.spSelectHRJobDescriptionsBindingSource.DataSource = this.dsDescription;
            // 
            // JobDescMemoEdit
            // 
            this.JobDescMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectHRJobDescriptionsBindingSource, "JobDesc", true));
            this.JobDescMemoEdit.Location = new System.Drawing.Point(94, 116);
            this.JobDescMemoEdit.Name = "JobDescMemoEdit";
            this.JobDescMemoEdit.Size = new System.Drawing.Size(712, 111);
            this.JobDescMemoEdit.StyleController = this.dataLayoutControl1;
            this.JobDescMemoEdit.TabIndex = 7;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectHRJobDescriptionsBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(94, 231);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(712, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 8;
            // 
            // JobTitleTextEdit
            // 
            this.JobTitleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectHRJobDescriptionsBindingSource, "JobTitle", true));
            this.JobTitleTextEdit.Location = new System.Drawing.Point(488, 68);
            this.JobTitleTextEdit.Name = "JobTitleTextEdit";
            this.JobTitleTextEdit.Size = new System.Drawing.Size(318, 20);
            this.JobTitleTextEdit.StyleController = this.dataLayoutControl1;
            this.JobTitleTextEdit.TabIndex = 5;
            // 
            // ReqNoLookUpEdit
            // 
            this.ReqNoLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectHRJobDescriptionsBindingSource, "ReqNo", true));
            this.ReqNoLookUpEdit.Location = new System.Drawing.Point(94, 68);
            this.ReqNoLookUpEdit.Name = "ReqNoLookUpEdit";
            this.ReqNoLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ReqNoLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ReqNoLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ReqNoLookUpEdit.Properties.DataSource = this.spGetJobReqNoBindingSource;
            this.ReqNoLookUpEdit.Properties.DisplayMember = "JobTitle";
            this.ReqNoLookUpEdit.Properties.NullText = "";
            this.ReqNoLookUpEdit.Properties.ValueMember = "ReqNo";
            this.ReqNoLookUpEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReqNoLookUpEdit.Size = new System.Drawing.Size(320, 20);
            this.ReqNoLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ReqNoLookUpEdit.TabIndex = 4;
            this.ReqNoLookUpEdit.EditValueChanged += new System.EventHandler(this.ReqNoLookUpEdit_EditValueChanged);
            // 
            // spGetJobReqNoBindingSource
            // 
            this.spGetJobReqNoBindingSource.DataMember = "spGetJobReqNo";
            this.spGetJobReqNoBindingSource.DataSource = this.dsDescription;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(830, 468);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(810, 448);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForReqNo,
            this.ItemForJobTitle,
            this.ItemForAppDueDate,
            this.ItemForJobDesc,
            this.ItemForRemarks});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(810, 229);
            this.layoutControlGroup3.Text = "Job Description";
            // 
            // ItemForReqNo
            // 
            this.ItemForReqNo.Control = this.ReqNoLookUpEdit;
            this.ItemForReqNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectHRJobDescriptionsBindingSource, "ReqNo", true));
            this.ItemForReqNo.Location = new System.Drawing.Point(0, 0);
            this.ItemForReqNo.Name = "ItemForReqNo";
            this.ItemForReqNo.Size = new System.Drawing.Size(394, 24);
            this.ItemForReqNo.Text = "Req No";
            this.ItemForReqNo.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForJobTitle
            // 
            this.ItemForJobTitle.Control = this.JobTitleTextEdit;
            this.ItemForJobTitle.Location = new System.Drawing.Point(394, 0);
            this.ItemForJobTitle.Name = "ItemForJobTitle";
            this.ItemForJobTitle.Size = new System.Drawing.Size(392, 24);
            this.ItemForJobTitle.Text = "Job Title";
            this.ItemForJobTitle.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForAppDueDate
            // 
            this.ItemForAppDueDate.Control = this.AppDueDateDateEdit;
            this.ItemForAppDueDate.Location = new System.Drawing.Point(0, 24);
            this.ItemForAppDueDate.Name = "ItemForAppDueDate";
            this.ItemForAppDueDate.Size = new System.Drawing.Size(786, 24);
            this.ItemForAppDueDate.Text = "App Due Date";
            this.ItemForAppDueDate.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForJobDesc
            // 
            this.ItemForJobDesc.Control = this.JobDescMemoEdit;
            this.ItemForJobDesc.Location = new System.Drawing.Point(0, 48);
            this.ItemForJobDesc.Name = "ItemForJobDesc";
            this.ItemForJobDesc.Size = new System.Drawing.Size(786, 115);
            this.ItemForJobDesc.StartNewLine = true;
            this.ItemForJobDesc.Text = "Job Desc";
            this.ItemForJobDesc.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 163);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(786, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(810, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 255);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(810, 193);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dsJobDescription
            // 
            this.dsJobDescription.DataSetName = "dsDescription";
            this.dsJobDescription.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsJobDescriptionBindingSource
            // 
            this.dsJobDescriptionBindingSource.DataSource = this.dsJobDescription;
            this.dsJobDescriptionBindingSource.Position = 0;
            // 
            // spSelectHRJobDescriptionsTableAdapter
            // 
            this.spSelectHRJobDescriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllHRJobDescriptionsTableAdapter
            // 
            this.spSelectAllHRJobDescriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // spGetJobReqNoTableAdapter
            // 
            this.spGetJobReqNoTableAdapter.ClearBeforeFill = true;
            // 
            // frmJobDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 468);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmJobDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Description";
            this.Load += new System.EventHandler(this.frmJobDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllHRJobDescriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppDueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectHRJobDescriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobDescMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReqNoLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetJobReqNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAppDueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobDescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource spSelectHRJobDescriptionsBindingSource;
        private Class.DataSet.dsDescription dsDescription;
        private DevExpress.XtraEditors.DateEdit AppDueDateDateEdit;
        private DevExpress.XtraEditors.MemoEdit JobDescMemoEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReqNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJobTitle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAppDueDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJobDesc;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private Class.DataSet.dsJobDescription dsJobDescription;
        private System.Windows.Forms.BindingSource dsJobDescriptionBindingSource;
        private Class.DataSet.dsDescriptionTableAdapters.spSelectHRJobDescriptionsTableAdapter spSelectHRJobDescriptionsTableAdapter;
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
        private System.Windows.Forms.BindingSource spSelectAllHRJobDescriptionsBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Class.DataSet.dsDescriptionTableAdapters.spSelectAllHRJobDescriptionsTableAdapter spSelectAllHRJobDescriptionsTableAdapter;
        private System.Windows.Forms.BindingSource spGetJobReqNoBindingSource;
        private DevExpress.XtraEditors.TextEdit JobTitleTextEdit;
        private Class.DataSet.dsDescriptionTableAdapters.spGetJobReqNoTableAdapter spGetJobReqNoTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit ReqNoLookUpEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colReqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colAppDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colJobDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}