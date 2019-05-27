namespace Master.Forms
{
    partial class frmPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayroll));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.glPeriod = new DevExpress.XtraEditors.GridLookUpEdit();
            this.postingPeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPayroll = new Master.Class.DataSet.dsPayroll();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.payrollSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayrollItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBAType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayrollStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glPaymentType = new DevExpress.XtraEditors.GridLookUpEdit();
            this.userCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtpPayDate = new DevExpress.XtraEditors.DateEdit();
            this.chkAllCostCenters = new DevExpress.XtraEditors.CheckEdit();
            this.glCostCenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mmoNarration = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spProcessPayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costCenterTableAdapter = new Master.Class.DataSet.dsPayrollTableAdapters.CostCenterTableAdapter();
            this.userCodesTableAdapter = new Master.Class.DataSet.dsPayrollTableAdapters.UserCodesTableAdapter();
            this.spProcessPayrollTableAdapter = new Master.Class.DataSet.dsPayrollTableAdapters.spProcessPayrollTableAdapter();
            this.payrollSummaryTableAdapter = new Master.Class.DataSet.dsPayrollTableAdapters.PayrollSummaryTableAdapter();
            this.postingPeriodsTableAdapter = new Master.Class.DataSet.dsPayrollTableAdapters.PostingPeriodsTableAdapter();
            this.spCancelPayrollProcessingTableAdapter1 = new Master.Class.DataSet.dsPayrollTableAdapters.spCancelPayrollProcessingTableAdapter();
            this.dsApprovers1 = new Master.Class.DataSet.dsApprovers();
            this.dsApprovers2 = new Master.Class.DataSet.dsApprovers();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingPeriodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllCostCenters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNarration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProcessPayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApprovers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApprovers2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.glPeriod);
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.glPaymentType);
            this.layoutControl1.Controls.Add(this.dtpPayDate);
            this.layoutControl1.Controls.Add(this.chkAllCostCenters);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Controls.Add(this.mmoNarration);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(889, 574);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // glPeriod
            // 
            this.glPeriod.EditValue = "January";
            this.glPeriod.Location = new System.Drawing.Point(518, 98);
            this.glPeriod.Name = "glPeriod";
            this.glPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPeriod.Properties.DataSource = this.postingPeriodsBindingSource;
            this.glPeriod.Properties.DisplayMember = "PeriodCode";
            this.glPeriod.Properties.ValueMember = "PeriodID";
            this.glPeriod.Properties.View = this.gridView2;
            this.glPeriod.Size = new System.Drawing.Size(347, 20);
            this.glPeriod.StyleController = this.layoutControl1;
            this.glPeriod.TabIndex = 28;
            this.glPeriod.EditValueChanged += new System.EventHandler(this.glPeriod_EditValueChanged);
            // 
            // postingPeriodsBindingSource
            // 
            this.postingPeriodsBindingSource.DataMember = "PostingPeriods";
            this.postingPeriodsBindingSource.DataSource = this.dsPayroll;
            // 
            // dsPayroll
            // 
            this.dsPayroll.DataSetName = "dsPayroll";
            this.dsPayroll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 28);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(67, 25);
            this.saveToolStripButton.Text = "Process";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
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
            this.copyToolStripButton.Size = new System.Drawing.Size(63, 25);
            this.copyToolStripButton.Text = "Cancel";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(65, 25);
            this.toolStripButton2.Text = "Submit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.payrollSummaryBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(865, 404);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // payrollSummaryBindingSource
            // 
            this.payrollSummaryBindingSource.DataMember = "PayrollSummary";
            this.payrollSummaryBindingSource.DataSource = this.dsPayroll;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colEmpName,
            this.colGender,
            this.colCostCenterName,
            this.colJobGrade,
            this.colPayDate,
            this.colFromDate,
            this.colToDate,
            this.colPayrollItem,
            this.colAmount,
            this.colDBAType,
            this.colPayrollStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmpNo
            // 
            this.colEmpNo.FieldName = "EmpNo";
            this.colEmpNo.Name = "colEmpNo";
            this.colEmpNo.Visible = true;
            this.colEmpNo.VisibleIndex = 0;
            // 
            // colEmpName
            // 
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 1;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 2;
            // 
            // colCostCenterName
            // 
            this.colCostCenterName.FieldName = "CostCenterName";
            this.colCostCenterName.Name = "colCostCenterName";
            this.colCostCenterName.Visible = true;
            this.colCostCenterName.VisibleIndex = 3;
            // 
            // colJobGrade
            // 
            this.colJobGrade.FieldName = "JobGrade";
            this.colJobGrade.Name = "colJobGrade";
            this.colJobGrade.Visible = true;
            this.colJobGrade.VisibleIndex = 4;
            // 
            // colPayDate
            // 
            this.colPayDate.FieldName = "PayDate";
            this.colPayDate.Name = "colPayDate";
            this.colPayDate.Visible = true;
            this.colPayDate.VisibleIndex = 5;
            // 
            // colFromDate
            // 
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 6;
            // 
            // colToDate
            // 
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 7;
            // 
            // colPayrollItem
            // 
            this.colPayrollItem.FieldName = "PayrollItem";
            this.colPayrollItem.Name = "colPayrollItem";
            this.colPayrollItem.Visible = true;
            this.colPayrollItem.VisibleIndex = 8;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 9;
            // 
            // colDBAType
            // 
            this.colDBAType.FieldName = "DBAType";
            this.colDBAType.Name = "colDBAType";
            this.colDBAType.Visible = true;
            this.colDBAType.VisibleIndex = 10;
            // 
            // colPayrollStatus
            // 
            this.colPayrollStatus.FieldName = "PayrollStatus";
            this.colPayrollStatus.Name = "colPayrollStatus";
            this.colPayrollStatus.Visible = true;
            this.colPayrollStatus.VisibleIndex = 11;
            // 
            // glPaymentType
            // 
            this.glPaymentType.EditValue = "Payment type";
            this.glPaymentType.Location = new System.Drawing.Point(96, 98);
            this.glPaymentType.Name = "glPaymentType";
            this.glPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPaymentType.Properties.DataSource = this.userCodesBindingSource;
            this.glPaymentType.Properties.DisplayMember = "Description";
            this.glPaymentType.Properties.ValueMember = "Code";
            this.glPaymentType.Properties.View = this.gridLookUpEdit2View;
            this.glPaymentType.Size = new System.Drawing.Size(346, 20);
            this.glPaymentType.StyleController = this.layoutControl1;
            this.glPaymentType.TabIndex = 25;
            // 
            // userCodesBindingSource
            // 
            this.userCodesBindingSource.DataMember = "UserCodes";
            this.userCodesBindingSource.DataSource = this.dsPayroll;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.EditValue = null;
            this.dtpPayDate.Location = new System.Drawing.Point(96, 122);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPayDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPayDate.Size = new System.Drawing.Size(346, 20);
            this.dtpPayDate.StyleController = this.layoutControl1;
            this.dtpPayDate.TabIndex = 24;
            // 
            // chkAllCostCenters
            // 
            this.chkAllCostCenters.Location = new System.Drawing.Point(518, 74);
            this.chkAllCostCenters.Name = "chkAllCostCenters";
            this.chkAllCostCenters.Properties.Caption = "";
            this.chkAllCostCenters.Size = new System.Drawing.Size(347, 19);
            this.chkAllCostCenters.StyleController = this.layoutControl1;
            this.chkAllCostCenters.TabIndex = 21;
            // 
            // glCostCenter
            // 
            this.glCostCenter.EditValue = "001";
            this.glCostCenter.Location = new System.Drawing.Point(96, 74);
            this.glCostCenter.Name = "glCostCenter";
            this.glCostCenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCostCenter.Properties.DataSource = this.costCenterBindingSource;
            this.glCostCenter.Properties.DisplayMember = "CCName";
            this.glCostCenter.Properties.ValueMember = "CCCode";
            this.glCostCenter.Properties.View = this.gridLookUpEdit1View;
            this.glCostCenter.Size = new System.Drawing.Size(346, 20);
            this.glCostCenter.StyleController = this.layoutControl1;
            this.glCostCenter.TabIndex = 20;
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataMember = "CostCenter";
            this.costCenterBindingSource.DataSource = this.dsPayroll;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // mmoNarration
            // 
            this.mmoNarration.EditValue = "Payroll processing";
            this.mmoNarration.Location = new System.Drawing.Point(518, 122);
            this.mmoNarration.Name = "mmoNarration";
            this.mmoNarration.Size = new System.Drawing.Size(347, 20);
            this.mmoNarration.StyleController = this.layoutControl1;
            this.mmoNarration.TabIndex = 26;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(889, 574);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(869, 114);
            this.layoutControlGroup2.Text = "PayRoll Processing";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glCostCenter;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(422, 24);
            this.layoutControlItem3.Text = "CostCenter";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dtpPayDate;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(422, 24);
            this.layoutControlItem7.Text = "PayDate";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkAllCostCenters;
            this.layoutControlItem4.Location = new System.Drawing.Point(422, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem4.Text = "All CostCenter";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.glPaymentType;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(422, 24);
            this.layoutControlItem8.Text = "Payment Type";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.mmoNarration;
            this.layoutControlItem9.Location = new System.Drawing.Point(422, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem9.Text = "Remarks";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.glPeriod;
            this.layoutControlItem5.Location = new System.Drawing.Point(422, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem5.Text = "Period";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(869, 408);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(869, 32);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spProcessPayrollBindingSource
            // 
            this.spProcessPayrollBindingSource.DataMember = "spProcessPayroll";
            this.spProcessPayrollBindingSource.DataSource = this.dsPayroll;
            // 
            // costCenterTableAdapter
            // 
            this.costCenterTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesTableAdapter
            // 
            this.userCodesTableAdapter.ClearBeforeFill = true;
            // 
            // spProcessPayrollTableAdapter
            // 
            this.spProcessPayrollTableAdapter.ClearBeforeFill = true;
            // 
            // payrollSummaryTableAdapter
            // 
            this.payrollSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // postingPeriodsTableAdapter
            // 
            this.postingPeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // spCancelPayrollProcessingTableAdapter1
            // 
            this.spCancelPayrollProcessingTableAdapter1.ClearBeforeFill = true;
            // 
            // dsApprovers1
            // 
            this.dsApprovers1.DataSetName = "dsApprovers";
            this.dsApprovers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsApprovers2
            // 
            this.dsApprovers2.DataSetName = "dsApprovers";
            this.dsApprovers2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "PeriodCode";
            this.gridColumn1.FieldName = "PeriodCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "StartDate";
            this.gridColumn2.FieldName = "StartDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "EndDate";
            this.gridColumn3.FieldName = "EndDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Year";
            this.gridColumn4.FieldName = "Year";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 574);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingPeriodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllCostCenters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNarration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProcessPayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApprovers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApprovers2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GridLookUpEdit glPaymentType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.DateEdit dtpPayDate;
        private DevExpress.XtraEditors.CheckEdit chkAllCostCenters;
        private DevExpress.XtraEditors.GridLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.BindingSource userCodesBindingSource;
        private Class.DataSet.dsPayroll dsPayroll;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private Class.DataSet.dsPayrollTableAdapters.CostCenterTableAdapter costCenterTableAdapter;
        private Class.DataSet.dsPayrollTableAdapters.UserCodesTableAdapter userCodesTableAdapter;
        private System.Windows.Forms.BindingSource spProcessPayrollBindingSource;
        private Class.DataSet.dsPayrollTableAdapters.spProcessPayrollTableAdapter spProcessPayrollTableAdapter;
        private System.Windows.Forms.BindingSource payrollSummaryBindingSource;
        private Class.DataSet.dsPayrollTableAdapters.PayrollSummaryTableAdapter payrollSummaryTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenterName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colPayDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPayrollItem;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDBAType;
        private DevExpress.XtraGrid.Columns.GridColumn colPayrollStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.GridLookUpEdit glPeriod;
        private System.Windows.Forms.BindingSource postingPeriodsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private Class.DataSet.dsPayrollTableAdapters.PostingPeriodsTableAdapter postingPeriodsTableAdapter;
        private DevExpress.XtraEditors.TextEdit mmoNarration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private Class.DataSet.dsPayrollTableAdapters.spCancelPayrollProcessingTableAdapter spCancelPayrollProcessingTableAdapter1;
        private Class.DataSet.dsApprovers dsApprovers1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Class.DataSet.dsApprovers dsApprovers2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}