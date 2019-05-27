namespace Master.Forms
{
    partial class frmAbsenceRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbsenceRegistration));
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
            this.spSelectAllAbsenceRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbsenceRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbsenceRegistration = new Master.Class.DataSet.dsAbsenceRegistration();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectAbsenceRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpNoLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spGetEmployeeCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CostCenterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ToDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.HoursTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForRegNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHours = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectAbsenceRegistrationTableAdapter = new Master.Class.DataSet.dsAbsenceRegistrationTableAdapters.spSelectAbsenceRegistrationTableAdapter();
            this.spSelectAllAbsenceRegistrationTableAdapter = new Master.Class.DataSet.dsAbsenceRegistrationTableAdapters.spSelectAllAbsenceRegistrationTableAdapter();
            this.spGetEmployeeCodesTableAdapter = new Master.Class.DataSet.dsAbsenceRegistrationTableAdapters.spGetEmployeeCodesTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsAbsenceRegistrationTableAdapters.spGetCompanyCostCentersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllAbsenceRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbsenceRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbsenceRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAbsenceRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.RegNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmpNoLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FromDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ToDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.HoursTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.DataMember = null;
            this.dataLayoutControl1.DataSource = this.spSelectAbsenceRegistrationBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(766, 466);
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
            this.toolStrip1.Size = new System.Drawing.Size(742, 20);
            this.toolStrip1.TabIndex = 21;
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
            this.gridControl1.DataSource = this.spSelectAllAbsenceRegistrationBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(742, 280);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllAbsenceRegistrationBindingSource
            // 
            this.spSelectAllAbsenceRegistrationBindingSource.DataMember = "spSelectAllAbsenceRegistration";
            this.spSelectAllAbsenceRegistrationBindingSource.DataSource = this.dsAbsenceRegistrationBindingSource;
            // 
            // dsAbsenceRegistrationBindingSource
            // 
            this.dsAbsenceRegistrationBindingSource.DataSource = this.dsAbsenceRegistration;
            this.dsAbsenceRegistrationBindingSource.Position = 0;
            // 
            // dsAbsenceRegistration
            // 
            this.dsAbsenceRegistration.DataSetName = "dsAbsenceRegistration";
            this.dsAbsenceRegistration.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegNo,
            this.colEmpNo,
            this.colCostCenter,
            this.colDescription,
            this.colFromDate,
            this.colToDate,
            this.colHours,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colRegNo
            // 
            this.colRegNo.FieldName = "RegNo";
            this.colRegNo.Name = "colRegNo";
            this.colRegNo.Visible = true;
            this.colRegNo.VisibleIndex = 0;
            // 
            // colEmpNo
            // 
            this.colEmpNo.FieldName = "EmpNo";
            this.colEmpNo.Name = "colEmpNo";
            this.colEmpNo.Visible = true;
            this.colEmpNo.VisibleIndex = 1;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            // 
            // colFromDate
            // 
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 4;
            // 
            // colToDate
            // 
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 5;
            // 
            // colHours
            // 
            this.colHours.FieldName = "Hours";
            this.colHours.Name = "colHours";
            this.colHours.Visible = true;
            this.colHours.VisibleIndex = 6;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 7;
            // 
            // RegNoTextEdit
            // 
            this.RegNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "RegNo", true));
            this.RegNoTextEdit.Location = new System.Drawing.Point(85, 66);
            this.RegNoTextEdit.Name = "RegNoTextEdit";
            this.RegNoTextEdit.Size = new System.Drawing.Size(296, 20);
            this.RegNoTextEdit.StyleController = this.dataLayoutControl1;
            this.RegNoTextEdit.TabIndex = 4;
            // 
            // spSelectAbsenceRegistrationBindingSource
            // 
            this.spSelectAbsenceRegistrationBindingSource.DataMember = "spSelectAbsenceRegistration";
            this.spSelectAbsenceRegistrationBindingSource.DataSource = this.dsAbsenceRegistrationBindingSource;
            // 
            // EmpNoLookUpEdit
            // 
            this.EmpNoLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "EmpNo", true));
            this.EmpNoLookUpEdit.Location = new System.Drawing.Point(85, 90);
            this.EmpNoLookUpEdit.Name = "EmpNoLookUpEdit";
            this.EmpNoLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpNoLookUpEdit.Properties.DataSource = this.spGetEmployeeCodesBindingSource;
            this.EmpNoLookUpEdit.Properties.DisplayMember = "EmpNames";
            this.EmpNoLookUpEdit.Properties.NullText = "";
            this.EmpNoLookUpEdit.Properties.ValueMember = "EmpNo";
            this.EmpNoLookUpEdit.Size = new System.Drawing.Size(296, 20);
            this.EmpNoLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoLookUpEdit.TabIndex = 5;
            // 
            // spGetEmployeeCodesBindingSource
            // 
            this.spGetEmployeeCodesBindingSource.DataMember = "spGetEmployeeCodes";
            this.spGetEmployeeCodesBindingSource.DataSource = this.dsAbsenceRegistration;
            // 
            // CostCenterLookUpEdit
            // 
            this.CostCenterLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "CostCenter", true));
            this.CostCenterLookUpEdit.Location = new System.Drawing.Point(446, 66);
            this.CostCenterLookUpEdit.Name = "CostCenterLookUpEdit";
            this.CostCenterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterLookUpEdit.Properties.NullText = "";
            this.CostCenterLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterLookUpEdit.Size = new System.Drawing.Size(296, 20);
            this.CostCenterLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterLookUpEdit.TabIndex = 6;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsAbsenceRegistration;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "Description", true));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(446, 114);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(296, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 8;
            // 
            // FromDateDateEdit
            // 
            this.FromDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "FromDate", true));
            this.FromDateDateEdit.EditValue = null;
            this.FromDateDateEdit.Location = new System.Drawing.Point(446, 90);
            this.FromDateDateEdit.Name = "FromDateDateEdit";
            this.FromDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Size = new System.Drawing.Size(296, 20);
            this.FromDateDateEdit.StyleController = this.dataLayoutControl1;
            this.FromDateDateEdit.TabIndex = 9;
            // 
            // ToDateDateEdit
            // 
            this.ToDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "ToDate", true));
            this.ToDateDateEdit.EditValue = null;
            this.ToDateDateEdit.Location = new System.Drawing.Point(85, 114);
            this.ToDateDateEdit.Name = "ToDateDateEdit";
            this.ToDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Size = new System.Drawing.Size(296, 20);
            this.ToDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ToDateDateEdit.TabIndex = 10;
            // 
            // HoursTextEdit
            // 
            this.HoursTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "Hours", true));
            this.HoursTextEdit.Location = new System.Drawing.Point(85, 138);
            this.HoursTextEdit.Name = "HoursTextEdit";
            this.HoursTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.HoursTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HoursTextEdit.Properties.Mask.EditMask = "N0";
            this.HoursTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.HoursTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.HoursTextEdit.Size = new System.Drawing.Size(296, 20);
            this.HoursTextEdit.StyleController = this.dataLayoutControl1;
            this.HoursTextEdit.TabIndex = 11;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectAbsenceRegistrationBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(446, 138);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(296, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(766, 466);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(746, 446);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(746, 284);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForRegNo,
            this.ItemForToDate,
            this.ItemForDescription,
            this.ItemForHours,
            this.ItemForCostCenter,
            this.ItemForEmpNo,
            this.ItemForFromDate,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(746, 138);
            this.layoutControlGroup3.Text = "Absence Registration";
            // 
            // ItemForRegNo
            // 
            this.ItemForRegNo.Control = this.RegNoTextEdit;
            this.ItemForRegNo.Location = new System.Drawing.Point(0, 0);
            this.ItemForRegNo.Name = "ItemForRegNo";
            this.ItemForRegNo.Size = new System.Drawing.Size(361, 24);
            this.ItemForRegNo.Text = "Reg No";
            this.ItemForRegNo.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForToDate
            // 
            this.ItemForToDate.Control = this.ToDateDateEdit;
            this.ItemForToDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForToDate.Name = "ItemForToDate";
            this.ItemForToDate.Size = new System.Drawing.Size(361, 24);
            this.ItemForToDate.Text = "To Date";
            this.ItemForToDate.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(361, 48);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(361, 24);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForHours
            // 
            this.ItemForHours.Control = this.HoursTextEdit;
            this.ItemForHours.Location = new System.Drawing.Point(0, 72);
            this.ItemForHours.Name = "ItemForHours";
            this.ItemForHours.Size = new System.Drawing.Size(361, 24);
            this.ItemForHours.Text = "Hours";
            this.ItemForHours.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(361, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(361, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoLookUpEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(361, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForFromDate
            // 
            this.ItemForFromDate.Control = this.FromDateDateEdit;
            this.ItemForFromDate.Location = new System.Drawing.Point(361, 24);
            this.ItemForFromDate.Name = "ItemForFromDate";
            this.ItemForFromDate.Size = new System.Drawing.Size(361, 24);
            this.ItemForFromDate.Text = "From Date";
            this.ItemForFromDate.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(361, 72);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(361, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(746, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectAbsenceRegistrationTableAdapter
            // 
            this.spSelectAbsenceRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllAbsenceRegistrationTableAdapter
            // 
            this.spSelectAllAbsenceRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // spGetEmployeeCodesTableAdapter
            // 
            this.spGetEmployeeCodesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // frmAbsenceRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 466);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmAbsenceRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absence Registration";
            this.Load += new System.EventHandler(this.frmAbsenceRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllAbsenceRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbsenceRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbsenceRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAbsenceRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit RegNoTextEdit;
        private System.Windows.Forms.BindingSource spSelectAbsenceRegistrationBindingSource;
        private System.Windows.Forms.BindingSource dsAbsenceRegistrationBindingSource;
        private Class.DataSet.dsAbsenceRegistration dsAbsenceRegistration;
        private DevExpress.XtraEditors.LookUpEdit EmpNoLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit CostCenterLookUpEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.DateEdit FromDateDateEdit;
        private DevExpress.XtraEditors.DateEdit ToDateDateEdit;
        private DevExpress.XtraEditors.TextEdit HoursTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRegNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHours;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsAbsenceRegistrationTableAdapters.spSelectAbsenceRegistrationTableAdapter spSelectAbsenceRegistrationTableAdapter;
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
        private System.Windows.Forms.BindingSource spSelectAllAbsenceRegistrationBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRegNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHours;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private Class.DataSet.dsAbsenceRegistrationTableAdapters.spSelectAllAbsenceRegistrationTableAdapter spSelectAllAbsenceRegistrationTableAdapter;
        private System.Windows.Forms.BindingSource spGetEmployeeCodesBindingSource;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsAbsenceRegistrationTableAdapters.spGetEmployeeCodesTableAdapter spGetEmployeeCodesTableAdapter;
        private Class.DataSet.dsAbsenceRegistrationTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
    }
}