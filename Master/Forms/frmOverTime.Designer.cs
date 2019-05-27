namespace Master.Forms
{
    partial class frmOverTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOverTime));
            this.dsOverTime = new Master.Class.DataSet.dsOverTime();
            this.spSelectOverTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectOverTimeTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.spSelectOverTimeTableAdapter();
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
            this.spSelectAllOverTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRateType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoursWorked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayrollItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHourlyRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMultiplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppliedRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HoursWorkedTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WorkDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PayrollItemTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HourlyRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MultiplierTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AppliedRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ToDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.TotalPayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmpNoTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.employeesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CostCenterTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ShiftTypeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.userCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RateTypeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.overTimeRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CurrencyTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TaskTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForHoursWorked = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShiftType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWorkDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHourlyRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAppliedRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTask = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRateType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayrollItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMultiplier = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTotalPay = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectAllOverTimeTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.spSelectAllOverTimeTableAdapter();
            this.employeesMasterTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.EmployeesMasterTableAdapter();
            this.costCenterTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.CostCenterTableAdapter();
            this.userCodesTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.UserCodesTableAdapter();
            this.overTimeRatesTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.OverTimeRatesTableAdapter();
            this.currenciesTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.CurrenciesTableAdapter();
            this.spGetEmployeeRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetEmployeeRatesTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.spGetEmployeeRatesTableAdapter();
            this.spGetRateTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetRateTypeTableAdapter = new Master.Class.DataSet.dsOverTimeTableAdapters.spGetRateTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsOverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectOverTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllOverTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorkedTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollItemTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourlyRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppliedRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overTimeRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHourlyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAppliedRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRateType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayrollItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRateTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsOverTime
            // 
            this.dsOverTime.DataSetName = "dsOverTime";
            this.dsOverTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSelectOverTimeBindingSource
            // 
            this.spSelectOverTimeBindingSource.DataMember = "spSelectOverTime";
            this.spSelectOverTimeBindingSource.DataSource = this.dsOverTime;
            // 
            // spSelectOverTimeTableAdapter
            // 
            this.spSelectOverTimeTableAdapter.ClearBeforeFill = true;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.EmpNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HoursWorkedTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WorkDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.PayrollItemTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HourlyRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MultiplierTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AppliedRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FromDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ToDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.TotalPayTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmpNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ShiftTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RateTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrencyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TaskTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectOverTimeBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(791, 467);
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
            this.toolStrip1.Size = new System.Drawing.Size(767, 20);
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
            this.gridControl1.DataSource = this.spSelectAllOverTimeBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 294);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(767, 161);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllOverTimeBindingSource
            // 
            this.spSelectAllOverTimeBindingSource.DataMember = "spSelectAllOverTime";
            this.spSelectAllOverTimeBindingSource.DataSource = this.dsOverTime;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colCostCenter,
            this.colEmpName,
            this.colShiftType,
            this.colRateType,
            this.colHoursWorked,
            this.colWorkDate,
            this.colPayrollItem,
            this.colHourlyRate,
            this.colMultiplier,
            this.colAppliedRate,
            this.colFromDate,
            this.colToDate,
            this.colTotalPay,
            this.colNarration,
            this.colTask});
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
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 1;
            // 
            // colEmpName
            // 
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 2;
            // 
            // colShiftType
            // 
            this.colShiftType.FieldName = "ShiftType";
            this.colShiftType.Name = "colShiftType";
            this.colShiftType.Visible = true;
            this.colShiftType.VisibleIndex = 3;
            // 
            // colRateType
            // 
            this.colRateType.FieldName = "RateType";
            this.colRateType.Name = "colRateType";
            this.colRateType.Visible = true;
            this.colRateType.VisibleIndex = 4;
            // 
            // colHoursWorked
            // 
            this.colHoursWorked.FieldName = "HoursWorked";
            this.colHoursWorked.Name = "colHoursWorked";
            this.colHoursWorked.Visible = true;
            this.colHoursWorked.VisibleIndex = 5;
            // 
            // colWorkDate
            // 
            this.colWorkDate.FieldName = "WorkDate";
            this.colWorkDate.Name = "colWorkDate";
            this.colWorkDate.Visible = true;
            this.colWorkDate.VisibleIndex = 6;
            // 
            // colPayrollItem
            // 
            this.colPayrollItem.FieldName = "PayrollItem";
            this.colPayrollItem.Name = "colPayrollItem";
            this.colPayrollItem.Visible = true;
            this.colPayrollItem.VisibleIndex = 7;
            // 
            // colHourlyRate
            // 
            this.colHourlyRate.FieldName = "HourlyRate";
            this.colHourlyRate.Name = "colHourlyRate";
            this.colHourlyRate.Visible = true;
            this.colHourlyRate.VisibleIndex = 8;
            // 
            // colMultiplier
            // 
            this.colMultiplier.FieldName = "Multiplier";
            this.colMultiplier.Name = "colMultiplier";
            this.colMultiplier.Visible = true;
            this.colMultiplier.VisibleIndex = 9;
            // 
            // colAppliedRate
            // 
            this.colAppliedRate.FieldName = "AppliedRate";
            this.colAppliedRate.Name = "colAppliedRate";
            this.colAppliedRate.Visible = true;
            this.colAppliedRate.VisibleIndex = 10;
            // 
            // colFromDate
            // 
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 11;
            // 
            // colToDate
            // 
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 12;
            // 
            // colTotalPay
            // 
            this.colTotalPay.FieldName = "TotalPay";
            this.colTotalPay.Name = "colTotalPay";
            this.colTotalPay.Visible = true;
            this.colTotalPay.VisibleIndex = 13;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 14;
            // 
            // colTask
            // 
            this.colTask.FieldName = "Task";
            this.colTask.Name = "colTask";
            this.colTask.Visible = true;
            this.colTask.VisibleIndex = 15;
            // 
            // EmpNameTextEdit
            // 
            this.EmpNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "EmpName", true));
            this.EmpNameTextEdit.Location = new System.Drawing.Point(483, 90);
            this.EmpNameTextEdit.Name = "EmpNameTextEdit";
            this.EmpNameTextEdit.Size = new System.Drawing.Size(284, 20);
            this.EmpNameTextEdit.StyleController = this.dataLayoutControl1;
            this.EmpNameTextEdit.TabIndex = 7;
            // 
            // HoursWorkedTextEdit
            // 
            this.HoursWorkedTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "HoursWorked", true));
            this.HoursWorkedTextEdit.Location = new System.Drawing.Point(109, 114);
            this.HoursWorkedTextEdit.Name = "HoursWorkedTextEdit";
            this.HoursWorkedTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.HoursWorkedTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HoursWorkedTextEdit.Properties.Mask.EditMask = "F";
            this.HoursWorkedTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.HoursWorkedTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.HoursWorkedTextEdit.Size = new System.Drawing.Size(285, 20);
            this.HoursWorkedTextEdit.StyleController = this.dataLayoutControl1;
            this.HoursWorkedTextEdit.TabIndex = 10;
            this.HoursWorkedTextEdit.EditValueChanged += new System.EventHandler(this.HoursWorkedTextEdit_EditValueChanged);
            // 
            // WorkDateDateEdit
            // 
            this.WorkDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "WorkDate", true));
            this.WorkDateDateEdit.EditValue = null;
            this.WorkDateDateEdit.Location = new System.Drawing.Point(109, 138);
            this.WorkDateDateEdit.Name = "WorkDateDateEdit";
            this.WorkDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WorkDateDateEdit.Size = new System.Drawing.Size(284, 20);
            this.WorkDateDateEdit.StyleController = this.dataLayoutControl1;
            this.WorkDateDateEdit.TabIndex = 11;
            // 
            // PayrollItemTextEdit
            // 
            this.PayrollItemTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "PayrollItem", true));
            this.PayrollItemTextEdit.Location = new System.Drawing.Point(482, 138);
            this.PayrollItemTextEdit.Name = "PayrollItemTextEdit";
            this.PayrollItemTextEdit.Size = new System.Drawing.Size(285, 20);
            this.PayrollItemTextEdit.StyleController = this.dataLayoutControl1;
            this.PayrollItemTextEdit.TabIndex = 12;
            // 
            // HourlyRateTextEdit
            // 
            this.HourlyRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "HourlyRate", true));
            this.HourlyRateTextEdit.Location = new System.Drawing.Point(109, 162);
            this.HourlyRateTextEdit.Name = "HourlyRateTextEdit";
            this.HourlyRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.HourlyRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HourlyRateTextEdit.Properties.Mask.EditMask = "G";
            this.HourlyRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.HourlyRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.HourlyRateTextEdit.Size = new System.Drawing.Size(284, 20);
            this.HourlyRateTextEdit.StyleController = this.dataLayoutControl1;
            this.HourlyRateTextEdit.TabIndex = 13;
            this.HourlyRateTextEdit.EditValueChanged += new System.EventHandler(this.HourlyRateTextEdit_EditValueChanged);
            // 
            // MultiplierTextEdit
            // 
            this.MultiplierTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "Multiplier", true));
            this.MultiplierTextEdit.Location = new System.Drawing.Point(482, 162);
            this.MultiplierTextEdit.Name = "MultiplierTextEdit";
            this.MultiplierTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MultiplierTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MultiplierTextEdit.Properties.Mask.EditMask = "F";
            this.MultiplierTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MultiplierTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MultiplierTextEdit.Size = new System.Drawing.Size(285, 20);
            this.MultiplierTextEdit.StyleController = this.dataLayoutControl1;
            this.MultiplierTextEdit.TabIndex = 14;
            this.MultiplierTextEdit.EditValueChanged += new System.EventHandler(this.MultiplierTextEdit_EditValueChanged);
            // 
            // AppliedRateTextEdit
            // 
            this.AppliedRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "AppliedRate", true));
            this.AppliedRateTextEdit.Location = new System.Drawing.Point(109, 186);
            this.AppliedRateTextEdit.Name = "AppliedRateTextEdit";
            this.AppliedRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AppliedRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AppliedRateTextEdit.Properties.Mask.EditMask = "G";
            this.AppliedRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AppliedRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AppliedRateTextEdit.Size = new System.Drawing.Size(284, 20);
            this.AppliedRateTextEdit.StyleController = this.dataLayoutControl1;
            this.AppliedRateTextEdit.TabIndex = 15;
            this.AppliedRateTextEdit.EditValueChanged += new System.EventHandler(this.AppliedRateTextEdit_EditValueChanged);
            // 
            // FromDateDateEdit
            // 
            this.FromDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "FromDate", true));
            this.FromDateDateEdit.EditValue = null;
            this.FromDateDateEdit.Location = new System.Drawing.Point(109, 210);
            this.FromDateDateEdit.Name = "FromDateDateEdit";
            this.FromDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Size = new System.Drawing.Size(284, 20);
            this.FromDateDateEdit.StyleController = this.dataLayoutControl1;
            this.FromDateDateEdit.TabIndex = 16;
            // 
            // ToDateDateEdit
            // 
            this.ToDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "ToDate", true));
            this.ToDateDateEdit.EditValue = null;
            this.ToDateDateEdit.Location = new System.Drawing.Point(482, 210);
            this.ToDateDateEdit.Name = "ToDateDateEdit";
            this.ToDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Size = new System.Drawing.Size(285, 20);
            this.ToDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ToDateDateEdit.TabIndex = 17;
            // 
            // TotalPayTextEdit
            // 
            this.TotalPayTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "TotalPay", true));
            this.TotalPayTextEdit.Location = new System.Drawing.Point(482, 234);
            this.TotalPayTextEdit.Name = "TotalPayTextEdit";
            this.TotalPayTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TotalPayTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TotalPayTextEdit.Properties.Mask.EditMask = "F";
            this.TotalPayTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TotalPayTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TotalPayTextEdit.Size = new System.Drawing.Size(285, 20);
            this.TotalPayTextEdit.StyleController = this.dataLayoutControl1;
            this.TotalPayTextEdit.TabIndex = 18;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(109, 258);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(284, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 20;
            // 
            // EmpNoTextEdit
            // 
            this.EmpNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "EmpNo", true));
            this.EmpNoTextEdit.Location = new System.Drawing.Point(483, 66);
            this.EmpNoTextEdit.Name = "EmpNoTextEdit";
            this.EmpNoTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpNoTextEdit.Properties.DataSource = this.employeesMasterBindingSource;
            this.EmpNoTextEdit.Properties.DisplayMember = "EmpNames";
            this.EmpNoTextEdit.Properties.NullText = "";
            this.EmpNoTextEdit.Properties.ValueMember = "EmpNo";
            this.EmpNoTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.EmpNoTextEdit.Size = new System.Drawing.Size(284, 20);
            this.EmpNoTextEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoTextEdit.TabIndex = 4;
            this.EmpNoTextEdit.EditValueChanged += new System.EventHandler(this.EmpNoTextEdit_EditValueChanged);
            // 
            // employeesMasterBindingSource
            // 
            this.employeesMasterBindingSource.DataMember = "EmployeesMaster";
            this.employeesMasterBindingSource.DataSource = this.dsOverTime;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // CostCenterTextEdit
            // 
            this.CostCenterTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "CostCenter", true));
            this.CostCenterTextEdit.Location = new System.Drawing.Point(109, 66);
            this.CostCenterTextEdit.Name = "CostCenterTextEdit";
            this.CostCenterTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterTextEdit.Properties.DataSource = this.costCenterBindingSource;
            this.CostCenterTextEdit.Properties.DisplayMember = "ccname";
            this.CostCenterTextEdit.Properties.NullText = "";
            this.CostCenterTextEdit.Properties.ValueMember = "cccode";
            this.CostCenterTextEdit.Properties.View = this.gridView3;
            this.CostCenterTextEdit.Size = new System.Drawing.Size(285, 20);
            this.CostCenterTextEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterTextEdit.TabIndex = 6;
            this.CostCenterTextEdit.EditValueChanged += new System.EventHandler(this.CostCenterTextEdit_EditValueChanged);
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataMember = "CostCenter";
            this.costCenterBindingSource.DataSource = this.dsOverTime;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ShiftTypeTextEdit
            // 
            this.ShiftTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "ShiftType", true));
            this.ShiftTypeTextEdit.Location = new System.Drawing.Point(109, 90);
            this.ShiftTypeTextEdit.Name = "ShiftTypeTextEdit";
            this.ShiftTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ShiftTypeTextEdit.Properties.DataSource = this.userCodesBindingSource;
            this.ShiftTypeTextEdit.Properties.DisplayMember = "Description";
            this.ShiftTypeTextEdit.Properties.NullText = "";
            this.ShiftTypeTextEdit.Properties.ValueMember = "Code";
            this.ShiftTypeTextEdit.Properties.View = this.gridView4;
            this.ShiftTypeTextEdit.Size = new System.Drawing.Size(285, 20);
            this.ShiftTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.ShiftTypeTextEdit.TabIndex = 8;
            // 
            // userCodesBindingSource
            // 
            this.userCodesBindingSource.DataMember = "UserCodes";
            this.userCodesBindingSource.DataSource = this.dsOverTime;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // RateTypeTextEdit
            // 
            this.RateTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "RateType", true));
            this.RateTypeTextEdit.Location = new System.Drawing.Point(483, 114);
            this.RateTypeTextEdit.Name = "RateTypeTextEdit";
            this.RateTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RateTypeTextEdit.Properties.DataSource = this.overTimeRatesBindingSource;
            this.RateTypeTextEdit.Properties.DisplayMember = "RateCode";
            this.RateTypeTextEdit.Properties.NullText = "";
            this.RateTypeTextEdit.Properties.ValueMember = "RateCode";
            this.RateTypeTextEdit.Properties.View = this.gridView5;
            this.RateTypeTextEdit.Size = new System.Drawing.Size(284, 20);
            this.RateTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.RateTypeTextEdit.TabIndex = 9;
            this.RateTypeTextEdit.EditValueChanged += new System.EventHandler(this.RateTypeTextEdit_EditValueChanged);
            // 
            // overTimeRatesBindingSource
            // 
            this.overTimeRatesBindingSource.DataMember = "OverTimeRates";
            this.overTimeRatesBindingSource.DataSource = this.dsOverTime;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // CurrencyTextEdit
            // 
            this.CurrencyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "Currency", true));
            this.CurrencyTextEdit.Location = new System.Drawing.Point(482, 186);
            this.CurrencyTextEdit.Name = "CurrencyTextEdit";
            this.CurrencyTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CurrencyTextEdit.Properties.DataSource = this.currenciesBindingSource;
            this.CurrencyTextEdit.Properties.DisplayMember = "CurrDesc";
            this.CurrencyTextEdit.Properties.NullText = "";
            this.CurrencyTextEdit.Properties.ValueMember = "CurrCode";
            this.CurrencyTextEdit.Properties.View = this.gridView6;
            this.CurrencyTextEdit.Size = new System.Drawing.Size(285, 20);
            this.CurrencyTextEdit.StyleController = this.dataLayoutControl1;
            this.CurrencyTextEdit.TabIndex = 19;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.dsOverTime;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // TaskTextEdit
            // 
            this.TaskTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectOverTimeBindingSource, "Task", true));
            this.TaskTextEdit.Location = new System.Drawing.Point(109, 234);
            this.TaskTextEdit.Name = "TaskTextEdit";
            this.TaskTextEdit.Size = new System.Drawing.Size(284, 20);
            this.TaskTextEdit.StyleController = this.dataLayoutControl1;
            this.TaskTextEdit.TabIndex = 21;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(791, 467);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(771, 282);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForHoursWorked,
            this.ItemForShiftType,
            this.ItemForWorkDate,
            this.ItemForHourlyRate,
            this.ItemForAppliedRate,
            this.ItemForTask,
            this.ItemForEmpName,
            this.ItemForRateType,
            this.ItemForPayrollItem,
            this.ItemForMultiplier,
            this.ItemForTotalPay,
            this.ItemForCurrency,
            this.ItemForFromDate,
            this.ItemForToDate,
            this.ItemForNarration,
            this.ItemForCostCenter,
            this.ItemForEmpNo});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(771, 258);
            this.layoutControlGroup3.Text = "Over Time";
            // 
            // ItemForHoursWorked
            // 
            this.ItemForHoursWorked.Control = this.HoursWorkedTextEdit;
            this.ItemForHoursWorked.Location = new System.Drawing.Point(0, 48);
            this.ItemForHoursWorked.Name = "ItemForHoursWorked";
            this.ItemForHoursWorked.Size = new System.Drawing.Size(374, 24);
            this.ItemForHoursWorked.Text = "Hours Worked";
            this.ItemForHoursWorked.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForShiftType
            // 
            this.ItemForShiftType.Control = this.ShiftTypeTextEdit;
            this.ItemForShiftType.Location = new System.Drawing.Point(0, 24);
            this.ItemForShiftType.Name = "ItemForShiftType";
            this.ItemForShiftType.Size = new System.Drawing.Size(374, 24);
            this.ItemForShiftType.Text = "Shift Type";
            this.ItemForShiftType.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForWorkDate
            // 
            this.ItemForWorkDate.Control = this.WorkDateDateEdit;
            this.ItemForWorkDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForWorkDate.Name = "ItemForWorkDate";
            this.ItemForWorkDate.Size = new System.Drawing.Size(373, 24);
            this.ItemForWorkDate.Text = "Work Date";
            this.ItemForWorkDate.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForHourlyRate
            // 
            this.ItemForHourlyRate.Control = this.HourlyRateTextEdit;
            this.ItemForHourlyRate.Location = new System.Drawing.Point(0, 96);
            this.ItemForHourlyRate.Name = "ItemForHourlyRate";
            this.ItemForHourlyRate.Size = new System.Drawing.Size(373, 24);
            this.ItemForHourlyRate.Text = "Hourly Rate";
            this.ItemForHourlyRate.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForAppliedRate
            // 
            this.ItemForAppliedRate.Control = this.AppliedRateTextEdit;
            this.ItemForAppliedRate.Location = new System.Drawing.Point(0, 120);
            this.ItemForAppliedRate.Name = "ItemForAppliedRate";
            this.ItemForAppliedRate.Size = new System.Drawing.Size(373, 24);
            this.ItemForAppliedRate.Text = "Amount Per Hour";
            this.ItemForAppliedRate.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForTask
            // 
            this.ItemForTask.Control = this.TaskTextEdit;
            this.ItemForTask.Location = new System.Drawing.Point(0, 168);
            this.ItemForTask.Name = "ItemForTask";
            this.ItemForTask.Size = new System.Drawing.Size(373, 24);
            this.ItemForTask.Text = "Task";
            this.ItemForTask.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForEmpName
            // 
            this.ItemForEmpName.Control = this.EmpNameTextEdit;
            this.ItemForEmpName.Location = new System.Drawing.Point(374, 24);
            this.ItemForEmpName.Name = "ItemForEmpName";
            this.ItemForEmpName.Size = new System.Drawing.Size(373, 24);
            this.ItemForEmpName.Text = "Emp Name";
            this.ItemForEmpName.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForRateType
            // 
            this.ItemForRateType.Control = this.RateTypeTextEdit;
            this.ItemForRateType.Location = new System.Drawing.Point(374, 48);
            this.ItemForRateType.Name = "ItemForRateType";
            this.ItemForRateType.Size = new System.Drawing.Size(373, 24);
            this.ItemForRateType.Text = "Rate Type";
            this.ItemForRateType.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForPayrollItem
            // 
            this.ItemForPayrollItem.Control = this.PayrollItemTextEdit;
            this.ItemForPayrollItem.Location = new System.Drawing.Point(373, 72);
            this.ItemForPayrollItem.Name = "ItemForPayrollItem";
            this.ItemForPayrollItem.Size = new System.Drawing.Size(374, 24);
            this.ItemForPayrollItem.Text = "Payroll Item";
            this.ItemForPayrollItem.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForMultiplier
            // 
            this.ItemForMultiplier.Control = this.MultiplierTextEdit;
            this.ItemForMultiplier.Location = new System.Drawing.Point(373, 96);
            this.ItemForMultiplier.Name = "ItemForMultiplier";
            this.ItemForMultiplier.Size = new System.Drawing.Size(374, 24);
            this.ItemForMultiplier.Text = "Multiplier";
            this.ItemForMultiplier.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForTotalPay
            // 
            this.ItemForTotalPay.Control = this.TotalPayTextEdit;
            this.ItemForTotalPay.Location = new System.Drawing.Point(373, 168);
            this.ItemForTotalPay.Name = "ItemForTotalPay";
            this.ItemForTotalPay.Size = new System.Drawing.Size(374, 48);
            this.ItemForTotalPay.Text = "Total Pay";
            this.ItemForTotalPay.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForCurrency
            // 
            this.ItemForCurrency.Control = this.CurrencyTextEdit;
            this.ItemForCurrency.Location = new System.Drawing.Point(373, 120);
            this.ItemForCurrency.Name = "ItemForCurrency";
            this.ItemForCurrency.Size = new System.Drawing.Size(374, 24);
            this.ItemForCurrency.Text = "Currency";
            this.ItemForCurrency.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForFromDate
            // 
            this.ItemForFromDate.Control = this.FromDateDateEdit;
            this.ItemForFromDate.Location = new System.Drawing.Point(0, 144);
            this.ItemForFromDate.Name = "ItemForFromDate";
            this.ItemForFromDate.Size = new System.Drawing.Size(373, 24);
            this.ItemForFromDate.Text = "From Date";
            this.ItemForFromDate.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForToDate
            // 
            this.ItemForToDate.Control = this.ToDateDateEdit;
            this.ItemForToDate.Location = new System.Drawing.Point(373, 144);
            this.ItemForToDate.Name = "ItemForToDate";
            this.ItemForToDate.Size = new System.Drawing.Size(374, 24);
            this.ItemForToDate.Text = "To Date";
            this.ItemForToDate.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(0, 192);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(373, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterTextEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(374, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(82, 13);
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoTextEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(374, 0);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(373, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(771, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 282);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(771, 165);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectAllOverTimeTableAdapter
            // 
            this.spSelectAllOverTimeTableAdapter.ClearBeforeFill = true;
            // 
            // employeesMasterTableAdapter
            // 
            this.employeesMasterTableAdapter.ClearBeforeFill = true;
            // 
            // costCenterTableAdapter
            // 
            this.costCenterTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesTableAdapter
            // 
            this.userCodesTableAdapter.ClearBeforeFill = true;
            // 
            // overTimeRatesTableAdapter
            // 
            this.overTimeRatesTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetEmployeeRatesBindingSource
            // 
            this.spGetEmployeeRatesBindingSource.DataMember = "spGetEmployeeRates";
            this.spGetEmployeeRatesBindingSource.DataSource = this.dsOverTime;
            // 
            // spGetEmployeeRatesTableAdapter
            // 
            this.spGetEmployeeRatesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetRateTypeBindingSource
            // 
            this.spGetRateTypeBindingSource.DataMember = "spGetRateType";
            this.spGetRateTypeBindingSource.DataSource = this.dsOverTime;
            // 
            // spGetRateTypeTableAdapter
            // 
            this.spGetRateTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmOverTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 467);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmOverTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Over Time";
            this.Load += new System.EventHandler(this.frmOverTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsOverTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectOverTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllOverTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWorkedTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollItemTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourlyRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppliedRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overTimeRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWorkDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHourlyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAppliedRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRateType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayrollItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRateTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Class.DataSet.dsOverTime dsOverTime;
        private System.Windows.Forms.BindingSource spSelectOverTimeBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.spSelectOverTimeTableAdapter spSelectOverTimeTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit EmpNameTextEdit;
        private DevExpress.XtraEditors.TextEdit HoursWorkedTextEdit;
        private DevExpress.XtraEditors.DateEdit WorkDateDateEdit;
        private DevExpress.XtraEditors.TextEdit PayrollItemTextEdit;
        private DevExpress.XtraEditors.TextEdit HourlyRateTextEdit;
        private DevExpress.XtraEditors.TextEdit MultiplierTextEdit;
        private DevExpress.XtraEditors.TextEdit AppliedRateTextEdit;
        private DevExpress.XtraEditors.DateEdit FromDateDateEdit;
        private DevExpress.XtraEditors.DateEdit ToDateDateEdit;
        private DevExpress.XtraEditors.TextEdit TotalPayTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShiftType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRateType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHoursWorked;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWorkDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayrollItem;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHourlyRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMultiplier;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAppliedRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTotalPay;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrency;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTask;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource spSelectAllOverTimeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftType;
        private DevExpress.XtraGrid.Columns.GridColumn colRateType;
        private DevExpress.XtraGrid.Columns.GridColumn colHoursWorked;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPayrollItem;
        private DevExpress.XtraGrid.Columns.GridColumn colHourlyRate;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiplier;
        private DevExpress.XtraGrid.Columns.GridColumn colAppliedRate;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPay;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraGrid.Columns.GridColumn colTask;
        private Class.DataSet.dsOverTimeTableAdapters.spSelectAllOverTimeTableAdapter spSelectAllOverTimeTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit EmpNoTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
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
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit ShiftTypeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GridLookUpEdit RateTypeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.GridLookUpEdit CurrencyTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.TextEdit TaskTextEdit;
        private System.Windows.Forms.BindingSource employeesMasterBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.EmployeesMasterTableAdapter employeesMasterTableAdapter;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.CostCenterTableAdapter costCenterTableAdapter;
        private System.Windows.Forms.BindingSource userCodesBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.UserCodesTableAdapter userCodesTableAdapter;
        private System.Windows.Forms.BindingSource overTimeRatesBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.OverTimeRatesTableAdapter overTimeRatesTableAdapter;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
        private System.Windows.Forms.BindingSource spGetEmployeeRatesBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.spGetEmployeeRatesTableAdapter spGetEmployeeRatesTableAdapter;
        private System.Windows.Forms.BindingSource spGetRateTypeBindingSource;
        private Class.DataSet.dsOverTimeTableAdapters.spGetRateTypeTableAdapter spGetRateTypeTableAdapter;
    }
}