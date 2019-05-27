namespace Master.Forms
{
    partial class frmKPIs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKPIs));
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
            this.spSelectAllKPIsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKPIs = new Master.Class.DataSet.dsKPIs();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKpiCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKpiDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KpiCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectKPIsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KpiDescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.userCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WeightTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TargetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForKpiCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDepartment = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWeight = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForKpiDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTarget = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectKPIsTableAdapter = new Master.Class.DataSet.dsKPIsTableAdapters.spSelectKPIsTableAdapter();
            this.spSelectAllKPIsTableAdapter = new Master.Class.DataSet.dsKPIsTableAdapters.spSelectAllKPIsTableAdapter();
            this.userCodesTableAdapter = new Master.Class.DataSet.dsKPIsTableAdapters.UserCodesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllKPIsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKPIs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpiCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectKPIsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpiDescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKpiCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKpiDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.KpiCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.KpiDescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DepartmentLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CategoryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WeightTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TargetTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectKPIsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(710, 434);
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
            this.toolStrip1.MaximumSize = new System.Drawing.Size(0, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(686, 20);
            this.toolStrip1.TabIndex = 22;
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
            this.gridControl1.DataSource = this.spSelectAllKPIsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(686, 248);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllKPIsBindingSource
            // 
            this.spSelectAllKPIsBindingSource.DataMember = "spSelectAllKPIs";
            this.spSelectAllKPIsBindingSource.DataSource = this.dsKPIs;
            // 
            // dsKPIs
            // 
            this.dsKPIs.DataSetName = "dsKPIs";
            this.dsKPIs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKpiCode,
            this.colKpiDescription,
            this.colDepartment,
            this.colCategory,
            this.colWeight,
            this.colTarget,
            this.colRemarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colKpiCode
            // 
            this.colKpiCode.FieldName = "KpiCode";
            this.colKpiCode.Name = "colKpiCode";
            this.colKpiCode.Visible = true;
            this.colKpiCode.VisibleIndex = 0;
            // 
            // colKpiDescription
            // 
            this.colKpiDescription.FieldName = "KpiDescription";
            this.colKpiDescription.Name = "colKpiDescription";
            this.colKpiDescription.Visible = true;
            this.colKpiDescription.VisibleIndex = 1;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 2;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 3;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 4;
            // 
            // colTarget
            // 
            this.colTarget.FieldName = "Target";
            this.colTarget.Name = "colTarget";
            this.colTarget.Visible = true;
            this.colTarget.VisibleIndex = 5;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 6;
            // 
            // KpiCodeTextEdit
            // 
            this.KpiCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKPIsBindingSource, "KpiCode", true));
            this.KpiCodeTextEdit.Location = new System.Drawing.Point(97, 66);
            this.KpiCodeTextEdit.Name = "KpiCodeTextEdit";
            this.KpiCodeTextEdit.Size = new System.Drawing.Size(256, 20);
            this.KpiCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.KpiCodeTextEdit.TabIndex = 4;
            // 
            // spSelectKPIsBindingSource
            // 
            this.spSelectKPIsBindingSource.DataMember = "spSelectKPIs";
            this.spSelectKPIsBindingSource.DataSource = this.dsKPIs;
            // 
            // KpiDescriptionTextEdit
            // 
            this.KpiDescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKPIsBindingSource, "KpiDescription", true));
            this.KpiDescriptionTextEdit.Location = new System.Drawing.Point(430, 66);
            this.KpiDescriptionTextEdit.Name = "KpiDescriptionTextEdit";
            this.KpiDescriptionTextEdit.Size = new System.Drawing.Size(256, 20);
            this.KpiDescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.KpiDescriptionTextEdit.TabIndex = 5;
            // 
            // DepartmentLookUpEdit
            // 
            this.DepartmentLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKPIsBindingSource, "Department", true));
            this.DepartmentLookUpEdit.Location = new System.Drawing.Point(97, 90);
            this.DepartmentLookUpEdit.Name = "DepartmentLookUpEdit";
            this.DepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartmentLookUpEdit.Properties.DataSource = this.userCodesBindingSource;
            this.DepartmentLookUpEdit.Properties.DisplayMember = "Description";
            this.DepartmentLookUpEdit.Properties.NullText = "";
            this.DepartmentLookUpEdit.Properties.ValueMember = "Code";
            this.DepartmentLookUpEdit.Size = new System.Drawing.Size(256, 20);
            this.DepartmentLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DepartmentLookUpEdit.TabIndex = 6;
            // 
            // userCodesBindingSource
            // 
            this.userCodesBindingSource.DataMember = "UserCodes";
            this.userCodesBindingSource.DataSource = this.dsKPIs;
            // 
            // CategoryTextEdit
            // 
            this.CategoryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKPIsBindingSource, "Category", true));
            this.CategoryTextEdit.Location = new System.Drawing.Point(430, 90);
            this.CategoryTextEdit.Name = "CategoryTextEdit";
            this.CategoryTextEdit.Size = new System.Drawing.Size(256, 20);
            this.CategoryTextEdit.StyleController = this.dataLayoutControl1;
            this.CategoryTextEdit.TabIndex = 7;
            // 
            // WeightTextEdit
            // 
            this.WeightTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKPIsBindingSource, "Weight", true));
            this.WeightTextEdit.Location = new System.Drawing.Point(97, 114);
            this.WeightTextEdit.Name = "WeightTextEdit";
            this.WeightTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.WeightTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.WeightTextEdit.Properties.Mask.EditMask = "N0";
            this.WeightTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.WeightTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.WeightTextEdit.Size = new System.Drawing.Size(256, 20);
            this.WeightTextEdit.StyleController = this.dataLayoutControl1;
            this.WeightTextEdit.TabIndex = 8;
            // 
            // TargetTextEdit
            // 
            this.TargetTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKPIsBindingSource, "Target", true));
            this.TargetTextEdit.Location = new System.Drawing.Point(430, 114);
            this.TargetTextEdit.Name = "TargetTextEdit";
            this.TargetTextEdit.Size = new System.Drawing.Size(256, 20);
            this.TargetTextEdit.StyleController = this.dataLayoutControl1;
            this.TargetTextEdit.TabIndex = 9;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKPIsBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(97, 138);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(589, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(710, 434);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(690, 414);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(690, 252);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForKpiCode,
            this.ItemForDepartment,
            this.ItemForWeight,
            this.ItemForRemarks,
            this.ItemForKpiDescription,
            this.ItemForCategory,
            this.ItemForTarget});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(690, 138);
            this.layoutControlGroup3.Text = "KPIs";
            // 
            // ItemForKpiCode
            // 
            this.ItemForKpiCode.Control = this.KpiCodeTextEdit;
            this.ItemForKpiCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForKpiCode.Name = "ItemForKpiCode";
            this.ItemForKpiCode.Size = new System.Drawing.Size(333, 24);
            this.ItemForKpiCode.Text = "Kpi Code";
            this.ItemForKpiCode.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForDepartment
            // 
            this.ItemForDepartment.Control = this.DepartmentLookUpEdit;
            this.ItemForDepartment.Location = new System.Drawing.Point(0, 24);
            this.ItemForDepartment.Name = "ItemForDepartment";
            this.ItemForDepartment.Size = new System.Drawing.Size(333, 24);
            this.ItemForDepartment.Text = "Department";
            this.ItemForDepartment.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForWeight
            // 
            this.ItemForWeight.Control = this.WeightTextEdit;
            this.ItemForWeight.Location = new System.Drawing.Point(0, 48);
            this.ItemForWeight.Name = "ItemForWeight";
            this.ItemForWeight.Size = new System.Drawing.Size(333, 24);
            this.ItemForWeight.Text = "Weight";
            this.ItemForWeight.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 72);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(666, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForKpiDescription
            // 
            this.ItemForKpiDescription.Control = this.KpiDescriptionTextEdit;
            this.ItemForKpiDescription.Location = new System.Drawing.Point(333, 0);
            this.ItemForKpiDescription.Name = "ItemForKpiDescription";
            this.ItemForKpiDescription.Size = new System.Drawing.Size(333, 24);
            this.ItemForKpiDescription.Text = "Kpi Description";
            this.ItemForKpiDescription.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForCategory
            // 
            this.ItemForCategory.Control = this.CategoryTextEdit;
            this.ItemForCategory.Location = new System.Drawing.Point(333, 24);
            this.ItemForCategory.Name = "ItemForCategory";
            this.ItemForCategory.Size = new System.Drawing.Size(333, 24);
            this.ItemForCategory.Text = "Category";
            this.ItemForCategory.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForTarget
            // 
            this.ItemForTarget.Control = this.TargetTextEdit;
            this.ItemForTarget.Location = new System.Drawing.Point(333, 48);
            this.ItemForTarget.Name = "ItemForTarget";
            this.ItemForTarget.Size = new System.Drawing.Size(333, 24);
            this.ItemForTarget.Text = "Target";
            this.ItemForTarget.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(690, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectKPIsTableAdapter
            // 
            this.spSelectKPIsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllKPIsTableAdapter
            // 
            this.spSelectAllKPIsTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesTableAdapter
            // 
            this.userCodesTableAdapter.ClearBeforeFill = true;
            // 
            // frmKPIs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 434);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmKPIs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPIs";
            this.Load += new System.EventHandler(this.frmKPIs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllKPIsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKPIs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpiCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectKPIsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpiDescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKpiCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKpiDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit KpiCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectKPIsBindingSource;
        private Class.DataSet.dsKPIs dsKPIs;
        private DevExpress.XtraEditors.TextEdit KpiDescriptionTextEdit;
        private DevExpress.XtraEditors.LookUpEdit DepartmentLookUpEdit;
        private DevExpress.XtraEditors.TextEdit CategoryTextEdit;
        private DevExpress.XtraEditors.TextEdit WeightTextEdit;
        private DevExpress.XtraEditors.TextEdit TargetTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKpiCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKpiDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDepartment;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategory;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWeight;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTarget;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private Class.DataSet.dsKPIsTableAdapters.spSelectKPIsTableAdapter spSelectKPIsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllKPIsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKpiCode;
        private DevExpress.XtraGrid.Columns.GridColumn colKpiDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private Class.DataSet.dsKPIsTableAdapters.spSelectAllKPIsTableAdapter spSelectAllKPIsTableAdapter;
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
        private System.Windows.Forms.BindingSource userCodesBindingSource;
        private Class.DataSet.dsKPIsTableAdapters.UserCodesTableAdapter userCodesTableAdapter;
    }
}