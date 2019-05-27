namespace Master.Forms
{
    partial class frmLeaveManagent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveManagent));
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spSelectLeaveManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLeaveManagement = new Master.Class.DataSet.dsLeaveManagement();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllLeaveManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeaveType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarryOver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeaveDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeaveBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LeaveDaysTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EffectiveDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.EmpNoTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.employeesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LeaveTypeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetLeaveTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CostCenterTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForLeaveType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLeaveDays = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spGetCarryOverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectLeaveManagementTableAdapter = new Master.Class.DataSet.dsLeaveManagementTableAdapters.spSelectLeaveManagementTableAdapter();
            this.spSelectAllLeaveManagementTableAdapter = new Master.Class.DataSet.dsLeaveManagementTableAdapters.spSelectAllLeaveManagementTableAdapter();
            this.employeesMasterTableAdapter = new Master.Class.DataSet.dsLeaveManagementTableAdapters.EmployeesMasterTableAdapter();
            this.costCenterTableAdapter = new Master.Class.DataSet.dsLeaveManagementTableAdapters.CostCenterTableAdapter();
            this.spGetLeaveTypesTableAdapter = new Master.Class.DataSet.dsLeaveManagementTableAdapters.spGetLeaveTypesTableAdapter();
            this.spGetCarryOverTableAdapter = new Master.Class.DataSet.dsLeaveManagementTableAdapters.spGetCarryOverTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectLeaveManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLeaveManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllLeaveManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveDaysTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetLeaveTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLeaveType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLeaveDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCarryOverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.LeaveDaysTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EffectiveDateEdit);
            this.dataLayoutControl1.Controls.Add(this.EmpNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LeaveTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterTextEdit);
            this.dataLayoutControl1.Controls.Add(this.labelControl2);
            this.dataLayoutControl1.DataSource = this.spSelectLeaveManagementBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(602, 355);
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
            this.toolStrip1.Size = new System.Drawing.Size(578, 20);
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
            this.toolStripSeparator2.Visible = false;
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 17);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Visible = false;
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 20);
            this.toolStripSeparator3.Visible = false;
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 17);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Visible = false;
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
            // labelControl1
            // 
            this.labelControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectLeaveManagementBindingSource, "CarryOver", true));
            this.labelControl1.Location = new System.Drawing.Point(96, 138);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(482, 13);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 13;
            // 
            // spSelectLeaveManagementBindingSource
            // 
            this.spSelectLeaveManagementBindingSource.DataMember = "spSelectLeaveManagement";
            this.spSelectLeaveManagementBindingSource.DataSource = this.dsLeaveManagement;
            // 
            // dsLeaveManagement
            // 
            this.dsLeaveManagement.DataSetName = "dsLeaveManagement";
            this.dsLeaveManagement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllLeaveManagementBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 184);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(578, 159);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllLeaveManagementBindingSource
            // 
            this.spSelectAllLeaveManagementBindingSource.DataMember = "spSelectAllLeaveManagement";
            this.spSelectAllLeaveManagementBindingSource.DataSource = this.dsLeaveManagement;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colCompCode,
            this.colCostCenter,
            this.colLeaveType,
            this.colEffectiveDate,
            this.colCarryOver,
            this.colLeaveDays,
            this.colLeaveBalance});
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
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 1;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 2;
            // 
            // colLeaveType
            // 
            this.colLeaveType.FieldName = "LeaveType";
            this.colLeaveType.Name = "colLeaveType";
            this.colLeaveType.Visible = true;
            this.colLeaveType.VisibleIndex = 3;
            // 
            // colEffectiveDate
            // 
            this.colEffectiveDate.Caption = "Effective Date";
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 6;
            // 
            // colCarryOver
            // 
            this.colCarryOver.FieldName = "CarryOver";
            this.colCarryOver.Name = "colCarryOver";
            this.colCarryOver.Visible = true;
            this.colCarryOver.VisibleIndex = 4;
            // 
            // colLeaveDays
            // 
            this.colLeaveDays.FieldName = "LeaveDays";
            this.colLeaveDays.Name = "colLeaveDays";
            this.colLeaveDays.Visible = true;
            this.colLeaveDays.VisibleIndex = 5;
            // 
            // colLeaveBalance
            // 
            this.colLeaveBalance.Caption = "Leave Balance";
            this.colLeaveBalance.FieldName = "LeaveBalance";
            this.colLeaveBalance.Name = "colLeaveBalance";
            // 
            // LeaveDaysTextEdit
            // 
            this.LeaveDaysTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectLeaveManagementBindingSource, "LeaveDays", true));
            this.LeaveDaysTextEdit.Location = new System.Drawing.Point(375, 90);
            this.LeaveDaysTextEdit.Name = "LeaveDaysTextEdit";
            this.LeaveDaysTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.LeaveDaysTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LeaveDaysTextEdit.Properties.Mask.EditMask = "F";
            this.LeaveDaysTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.LeaveDaysTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.LeaveDaysTextEdit.Size = new System.Drawing.Size(203, 20);
            this.LeaveDaysTextEdit.StyleController = this.dataLayoutControl1;
            this.LeaveDaysTextEdit.TabIndex = 9;
            this.LeaveDaysTextEdit.EditValueChanged += new System.EventHandler(this.LeaveDaysTextEdit_EditValueChanged);
            // 
            // EffectiveDateEdit
            // 
            this.EffectiveDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectLeaveManagementBindingSource, "EffectiveDate", true));
            this.EffectiveDateEdit.EditValue = null;
            this.EffectiveDateEdit.Location = new System.Drawing.Point(96, 114);
            this.EffectiveDateEdit.Name = "EffectiveDateEdit";
            this.EffectiveDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateEdit.Size = new System.Drawing.Size(203, 20);
            this.EffectiveDateEdit.StyleController = this.dataLayoutControl1;
            this.EffectiveDateEdit.TabIndex = 10;
            // 
            // EmpNoTextEdit
            // 
            this.EmpNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectLeaveManagementBindingSource, "EmpNo", true));
            this.EmpNoTextEdit.Location = new System.Drawing.Point(375, 66);
            this.EmpNoTextEdit.Name = "EmpNoTextEdit";
            this.EmpNoTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpNoTextEdit.Properties.DataSource = this.employeesMasterBindingSource;
            this.EmpNoTextEdit.Properties.DisplayMember = "EmpNames";
            this.EmpNoTextEdit.Properties.NullText = "";
            this.EmpNoTextEdit.Properties.ValueMember = "EmpNo";
            this.EmpNoTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.EmpNoTextEdit.Size = new System.Drawing.Size(203, 20);
            this.EmpNoTextEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoTextEdit.TabIndex = 4;
            this.EmpNoTextEdit.EditValueChanged += new System.EventHandler(this.EmpNoTextEdit_EditValueChanged);
            // 
            // employeesMasterBindingSource
            // 
            this.employeesMasterBindingSource.DataMember = "EmployeesMaster";
            this.employeesMasterBindingSource.DataSource = this.dsLeaveManagement;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LeaveTypeTextEdit
            // 
            this.LeaveTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectLeaveManagementBindingSource, "LeaveType", true));
            this.LeaveTypeTextEdit.Location = new System.Drawing.Point(96, 90);
            this.LeaveTypeTextEdit.Name = "LeaveTypeTextEdit";
            this.LeaveTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LeaveTypeTextEdit.Properties.DataSource = this.spGetLeaveTypesBindingSource;
            this.LeaveTypeTextEdit.Properties.DisplayMember = "LeaveDescription";
            this.LeaveTypeTextEdit.Properties.NullText = "";
            this.LeaveTypeTextEdit.Properties.ValueMember = "leaveCode";
            this.LeaveTypeTextEdit.Properties.View = this.gridView2;
            this.LeaveTypeTextEdit.Size = new System.Drawing.Size(203, 20);
            this.LeaveTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.LeaveTypeTextEdit.TabIndex = 7;
            this.LeaveTypeTextEdit.EditValueChanged += new System.EventHandler(this.LeaveTypeTextEdit_EditValueChanged);
            // 
            // spGetLeaveTypesBindingSource
            // 
            this.spGetLeaveTypesBindingSource.DataMember = "spGetLeaveTypes";
            this.spGetLeaveTypesBindingSource.DataSource = this.dsLeaveManagement;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // CostCenterTextEdit
            // 
            this.CostCenterTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectLeaveManagementBindingSource, "CostCenter", true));
            this.CostCenterTextEdit.Location = new System.Drawing.Point(96, 66);
            this.CostCenterTextEdit.Name = "CostCenterTextEdit";
            this.CostCenterTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterTextEdit.Properties.DataSource = this.costCenterBindingSource;
            this.CostCenterTextEdit.Properties.DisplayMember = "ccname";
            this.CostCenterTextEdit.Properties.NullText = "";
            this.CostCenterTextEdit.Properties.ValueMember = "cccode";
            this.CostCenterTextEdit.Properties.View = this.gridView3;
            this.CostCenterTextEdit.Size = new System.Drawing.Size(203, 20);
            this.CostCenterTextEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterTextEdit.TabIndex = 6;
            this.CostCenterTextEdit.EditValueChanged += new System.EventHandler(this.CostCenterTextEdit_EditValueChanged);
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataMember = "CostCenter";
            this.costCenterBindingSource.DataSource = this.dsLeaveManagement;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectLeaveManagementBindingSource, "LeaveBalance", true));
            this.labelControl2.Location = new System.Drawing.Point(96, 155);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(482, 13);
            this.labelControl2.StyleController = this.dataLayoutControl1;
            this.labelControl2.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(602, 355);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(582, 172);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForLeaveType,
            this.ItemForLeaveDays,
            this.layoutControlItem2,
            this.ItemForFromDate,
            this.layoutControlItem4,
            this.ItemForCostCenter,
            this.ItemForEmpNo});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(582, 148);
            this.layoutControlGroup3.Text = "Leave Management";
            // 
            // ItemForLeaveType
            // 
            this.ItemForLeaveType.Control = this.LeaveTypeTextEdit;
            this.ItemForLeaveType.Location = new System.Drawing.Point(0, 24);
            this.ItemForLeaveType.Name = "ItemForLeaveType";
            this.ItemForLeaveType.Size = new System.Drawing.Size(279, 24);
            this.ItemForLeaveType.Text = "Leave Type";
            this.ItemForLeaveType.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForLeaveDays
            // 
            this.ItemForLeaveDays.Control = this.LeaveDaysTextEdit;
            this.ItemForLeaveDays.Location = new System.Drawing.Point(279, 24);
            this.ItemForLeaveDays.Name = "ItemForLeaveDays";
            this.ItemForLeaveDays.Size = new System.Drawing.Size(279, 48);
            this.ItemForLeaveDays.Text = "Leave Days";
            this.ItemForLeaveDays.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(558, 17);
            this.layoutControlItem2.Text = "Carry Over";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForFromDate
            // 
            this.ItemForFromDate.Control = this.EffectiveDateEdit;
            this.ItemForFromDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForFromDate.Name = "ItemForFromDate";
            this.ItemForFromDate.Size = new System.Drawing.Size(279, 24);
            this.ItemForFromDate.Text = "EffectiveDate";
            this.ItemForFromDate.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl2;
            this.layoutControlItem4.CustomizationFormText = "Leave Balance";
            this.layoutControlItem4.DataBindings.Add(new System.Windows.Forms.Binding("CustomizationFormText", this.spSelectLeaveManagementBindingSource, "LeaveBalance", true));
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(558, 17);
            this.layoutControlItem4.Text = "Leave Balance";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterTextEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(279, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoTextEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(279, 0);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(279, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.toolStrip1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(582, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 172);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(582, 163);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spGetCarryOverBindingSource
            // 
            this.spGetCarryOverBindingSource.DataMember = "spGetCarryOver";
            this.spGetCarryOverBindingSource.DataSource = this.dsLeaveManagement;
            // 
            // spSelectLeaveManagementTableAdapter
            // 
            this.spSelectLeaveManagementTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllLeaveManagementTableAdapter
            // 
            this.spSelectAllLeaveManagementTableAdapter.ClearBeforeFill = true;
            // 
            // employeesMasterTableAdapter
            // 
            this.employeesMasterTableAdapter.ClearBeforeFill = true;
            // 
            // costCenterTableAdapter
            // 
            this.costCenterTableAdapter.ClearBeforeFill = true;
            // 
            // spGetLeaveTypesTableAdapter
            // 
            this.spGetLeaveTypesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCarryOverTableAdapter
            // 
            this.spGetCarryOverTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "spSelectLeaveManagement";
            // 
            // frmLeaveManagent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 355);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmLeaveManagent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Management";
            this.Load += new System.EventHandler(this.frmLeaveManagent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectLeaveManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLeaveManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllLeaveManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveDaysTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetLeaveTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLeaveType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLeaveDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCarryOverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource spSelectLeaveManagementBindingSource;
        private Class.DataSet.dsLeaveManagement dsLeaveManagement;
        private DevExpress.XtraEditors.TextEdit LeaveDaysTextEdit;
        private DevExpress.XtraEditors.DateEdit EffectiveDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLeaveDays;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLeaveType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsLeaveManagementTableAdapters.spSelectLeaveManagementTableAdapter spSelectLeaveManagementTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit EmpNoTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit LeaveTypeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spSelectAllLeaveManagementBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colLeaveType;
        private DevExpress.XtraGrid.Columns.GridColumn colCarryOver;
        private DevExpress.XtraGrid.Columns.GridColumn colLeaveDays;
        private Class.DataSet.dsLeaveManagementTableAdapters.spSelectAllLeaveManagementTableAdapter spSelectAllLeaveManagementTableAdapter;
        private System.Windows.Forms.BindingSource employeesMasterBindingSource;
        private Class.DataSet.dsLeaveManagementTableAdapters.EmployeesMasterTableAdapter employeesMasterTableAdapter;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private Class.DataSet.dsLeaveManagementTableAdapters.CostCenterTableAdapter costCenterTableAdapter;
        private System.Windows.Forms.BindingSource spGetLeaveTypesBindingSource;
        private Class.DataSet.dsLeaveManagementTableAdapters.spGetLeaveTypesTableAdapter spGetLeaveTypesTableAdapter;
        private System.Windows.Forms.BindingSource spGetCarryOverBindingSource;
        private Class.DataSet.dsLeaveManagementTableAdapters.spGetCarryOverTableAdapter spGetCarryOverTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLeaveBalance;
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
    }
}