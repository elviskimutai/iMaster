namespace Master.Forms
{
    partial class frmPayrollReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayrollReview));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblDeductions = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblBenefits = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSalary = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.glperiod = new DevExpress.XtraEditors.GridLookUpEdit();
            this.postingPeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dspayrollreview = new Master.Class.DataSet.dspayrollreview();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PeriodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkAllCostCenters = new DevExpress.XtraEditors.CheckEdit();
            this.glPaytype = new DevExpress.XtraEditors.GridLookUpEdit();
            this.userCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glCostCenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.printPayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spPostPayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSSFNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHIFNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPINNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayrollItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDBAType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayrollStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenefits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeductions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdvance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommEarned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWithHoldingTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dspayrollreviewTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.userCodesTableAdapter = new Master.Class.DataSet.dspayrollreviewTableAdapters.UserCodesTableAdapter();
            this.postingPeriodsTableAdapter = new Master.Class.DataSet.dspayrollreviewTableAdapters.PostingPeriodsTableAdapter();
            this.spPostPayrollTableAdapter = new Master.Class.DataSet.dspayrollreviewTableAdapters.spPostPayrollTableAdapter();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glperiod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingPeriodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspayrollreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllCostCenters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPaytype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPostPayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 277);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 36;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.lblDeductions);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.lblBenefits);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblTotalSalary);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(252, 27);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(808, 40);
            this.panelControl1.TabIndex = 35;
            // 
            // lblDeductions
            // 
            this.lblDeductions.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductions.Appearance.Options.UseFont = true;
            this.lblDeductions.Location = new System.Drawing.Point(651, 5);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(9, 19);
            this.lblDeductions.TabIndex = 5;
            this.lblDeductions.Text = "0";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(561, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 19);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Deductions:";
            // 
            // lblBenefits
            // 
            this.lblBenefits.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenefits.Appearance.Options.UseFont = true;
            this.lblBenefits.Location = new System.Drawing.Point(380, 5);
            this.lblBenefits.Name = "lblBenefits";
            this.lblBenefits.Size = new System.Drawing.Size(9, 19);
            this.lblBenefits.TabIndex = 3;
            this.lblBenefits.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(301, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Benefits:";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalary.Appearance.Options.UseFont = true;
            this.lblTotalSalary.Location = new System.Drawing.Point(110, 5);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(9, 19);
            this.lblTotalSalary.TabIndex = 1;
            this.lblTotalSalary.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Total Salary:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Location = new System.Drawing.Point(1, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 220);
            this.panel3.TabIndex = 34;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.glperiod);
            this.layoutControl1.Controls.Add(this.chkAllCostCenters);
            this.layoutControl1.Controls.Add(this.glPaytype);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(248, 220);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // glperiod
            // 
            this.glperiod.EditValue = "";
            this.glperiod.Location = new System.Drawing.Point(12, 159);
            this.glperiod.Name = "glperiod";
            this.glperiod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glperiod.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.glperiod.Properties.Appearance.Options.UseFont = true;
            this.glperiod.Properties.Appearance.Options.UseForeColor = true;
            this.glperiod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glperiod.Properties.DataSource = this.postingPeriodsBindingSource;
            this.glperiod.Properties.DisplayMember = "PeriodCode";
            this.glperiod.Properties.ValueMember = "PeriodID";
            this.glperiod.Properties.View = this.gridLookUpEdit1View;
            this.glperiod.Size = new System.Drawing.Size(224, 26);
            this.glperiod.StyleController = this.layoutControl1;
            this.glperiod.TabIndex = 8;
            this.glperiod.EditValueChanged += new System.EventHandler(this.glperiod_EditValueChanged);
            // 
            // postingPeriodsBindingSource
            // 
            this.postingPeriodsBindingSource.DataMember = "PostingPeriods";
            this.postingPeriodsBindingSource.DataSource = this.dspayrollreview;
            // 
            // dspayrollreview
            // 
            this.dspayrollreview.DataSetName = "dspayrollreview";
            this.dspayrollreview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PeriodCode,
            this.StartDate,
            this.EndDate,
            this.Year});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // PeriodCode
            // 
            this.PeriodCode.Caption = "PeriodCode";
            this.PeriodCode.FieldName = "PeriodCode";
            this.PeriodCode.Name = "PeriodCode";
            this.PeriodCode.Visible = true;
            this.PeriodCode.VisibleIndex = 0;
            // 
            // StartDate
            // 
            this.StartDate.Caption = "StartDate";
            this.StartDate.FieldName = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 1;
            // 
            // EndDate
            // 
            this.EndDate.Caption = "EndDate";
            this.EndDate.FieldName = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.Visible = true;
            this.EndDate.VisibleIndex = 2;
            // 
            // Year
            // 
            this.Year.Caption = "Year";
            this.Year.FieldName = "Year";
            this.Year.Name = "Year";
            this.Year.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Year.Visible = true;
            this.Year.VisibleIndex = 3;
            // 
            // chkAllCostCenters
            // 
            this.chkAllCostCenters.Location = new System.Drawing.Point(12, 74);
            this.chkAllCostCenters.Name = "chkAllCostCenters";
            this.chkAllCostCenters.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllCostCenters.Properties.Appearance.Options.UseFont = true;
            this.chkAllCostCenters.Properties.Caption = "";
            this.chkAllCostCenters.Size = new System.Drawing.Size(224, 19);
            this.chkAllCostCenters.StyleController = this.layoutControl1;
            this.chkAllCostCenters.TabIndex = 7;
            // 
            // glPaytype
            // 
            this.glPaytype.EditValue = "";
            this.glPaytype.Location = new System.Drawing.Point(12, 113);
            this.glPaytype.Name = "glPaytype";
            this.glPaytype.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glPaytype.Properties.Appearance.Options.UseFont = true;
            this.glPaytype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPaytype.Properties.DataSource = this.userCodesBindingSource;
            this.glPaytype.Properties.DisplayMember = "Description";
            this.glPaytype.Properties.ValueMember = "Code";
            this.glPaytype.Properties.View = this.gridLookUpEdit2View;
            this.glPaytype.Size = new System.Drawing.Size(224, 26);
            this.glPaytype.StyleController = this.layoutControl1;
            this.glPaytype.TabIndex = 5;
            // 
            // userCodesBindingSource
            // 
            this.userCodesBindingSource.DataMember = "UserCodes";
            this.userCodesBindingSource.DataSource = this.dspayrollreview;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // glCostCenter
            // 
            this.glCostCenter.Location = new System.Drawing.Point(12, 28);
            this.glCostCenter.Name = "glCostCenter";
            this.glCostCenter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glCostCenter.Properties.Appearance.Options.UseFont = true;
            this.glCostCenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCostCenter.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.glCostCenter.Properties.DisplayMember = "ccname";
            this.glCostCenter.Properties.NullText = "";
            this.glCostCenter.Properties.ValueMember = "cccode";
            this.glCostCenter.Properties.View = this.gridLookUpEdit3View;
            this.glCostCenter.Size = new System.Drawing.Size(224, 26);
            this.glCostCenter.StyleController = this.layoutControl1;
            this.glCostCenter.TabIndex = 6;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dspayrollreview;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(248, 220);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.glPaytype;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem2.Text = "Pay Type";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glCostCenter;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem3.Text = "CostCenter";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkAllCostCenters;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(228, 39);
            this.layoutControlItem1.Text = "All CostCenters";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.glperiod;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 131);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 69);
            this.layoutControlItem4.Text = "Period";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 13);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.toolStripButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 20);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(72, 17);
            this.saveToolStripButton.Text = "Approve";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 17);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(66, 17);
            this.copyToolStripButton.Text = "Decline";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 17);
            this.toolStripButton1.Text = "Export";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPayrollToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 17);
            this.toolStripDropDownButton1.Text = "Links";
            // 
            // printPayrollToolStripMenuItem
            // 
            this.printPayrollToolStripMenuItem.Name = "printPayrollToolStripMenuItem";
            this.printPayrollToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.printPayrollToolStripMenuItem.Text = "Print Payroll";
            this.printPayrollToolStripMenuItem.Click += new System.EventHandler(this.printPayrollToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(252, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 478);
            this.panel1.TabIndex = 32;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spPostPayrollBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(808, 478);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spPostPayrollBindingSource
            // 
            this.spPostPayrollBindingSource.DataMember = "spPostPayroll";
            this.spPostPayrollBindingSource.DataSource = this.dspayrollreview;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colEmpName,
            this.colNSSFNo,
            this.colNHIFNo,
            this.colPINNO,
            this.colIDNo,
            this.colCompName,
            this.colCostCenterName,
            this.colJobType,
            this.colJobGrade,
            this.colPayDate,
            this.colFromDate,
            this.colToDate,
            this.colPayrollItem,
            this.colPayType,
            this.colAmount,
            this.colCurrency,
            this.colDBAType,
            this.colPayrollStatus,
            this.colTotalSalary,
            this.colBenefits,
            this.colDeductions,
            this.colAdvance,
            this.colCommEarned,
            this.colWithHoldingTax,
            this.colPaye});
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
            this.colEmpNo.Width = 43;
            // 
            // colEmpName
            // 
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 1;
            this.colEmpName.Width = 43;
            // 
            // colNSSFNo
            // 
            this.colNSSFNo.FieldName = "NSSFNo";
            this.colNSSFNo.Name = "colNSSFNo";
            this.colNSSFNo.Visible = true;
            this.colNSSFNo.VisibleIndex = 2;
            this.colNSSFNo.Width = 43;
            // 
            // colNHIFNo
            // 
            this.colNHIFNo.FieldName = "NHIFNo";
            this.colNHIFNo.Name = "colNHIFNo";
            this.colNHIFNo.Visible = true;
            this.colNHIFNo.VisibleIndex = 3;
            this.colNHIFNo.Width = 43;
            // 
            // colPINNO
            // 
            this.colPINNO.FieldName = "PINNO";
            this.colPINNO.Name = "colPINNO";
            this.colPINNO.Visible = true;
            this.colPINNO.VisibleIndex = 4;
            this.colPINNO.Width = 43;
            // 
            // colIDNo
            // 
            this.colIDNo.FieldName = "IDNo";
            this.colIDNo.Name = "colIDNo";
            this.colIDNo.Visible = true;
            this.colIDNo.VisibleIndex = 5;
            this.colIDNo.Width = 43;
            // 
            // colCompName
            // 
            this.colCompName.FieldName = "CompName";
            this.colCompName.Name = "colCompName";
            this.colCompName.Visible = true;
            this.colCompName.VisibleIndex = 6;
            this.colCompName.Width = 43;
            // 
            // colCostCenterName
            // 
            this.colCostCenterName.FieldName = "CostCenterName";
            this.colCostCenterName.Name = "colCostCenterName";
            this.colCostCenterName.Visible = true;
            this.colCostCenterName.VisibleIndex = 7;
            this.colCostCenterName.Width = 43;
            // 
            // colJobType
            // 
            this.colJobType.FieldName = "JobType";
            this.colJobType.Name = "colJobType";
            this.colJobType.Visible = true;
            this.colJobType.VisibleIndex = 8;
            this.colJobType.Width = 43;
            // 
            // colJobGrade
            // 
            this.colJobGrade.FieldName = "JobGrade";
            this.colJobGrade.Name = "colJobGrade";
            this.colJobGrade.Visible = true;
            this.colJobGrade.VisibleIndex = 9;
            this.colJobGrade.Width = 43;
            // 
            // colPayDate
            // 
            this.colPayDate.FieldName = "PayDate";
            this.colPayDate.Name = "colPayDate";
            this.colPayDate.Visible = true;
            this.colPayDate.VisibleIndex = 10;
            this.colPayDate.Width = 43;
            // 
            // colFromDate
            // 
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 11;
            this.colFromDate.Width = 43;
            // 
            // colToDate
            // 
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 12;
            this.colToDate.Width = 43;
            // 
            // colPayrollItem
            // 
            this.colPayrollItem.FieldName = "PayrollItem";
            this.colPayrollItem.Name = "colPayrollItem";
            this.colPayrollItem.Visible = true;
            this.colPayrollItem.VisibleIndex = 13;
            this.colPayrollItem.Width = 43;
            // 
            // colPayType
            // 
            this.colPayType.FieldName = "PayType";
            this.colPayType.Name = "colPayType";
            this.colPayType.Visible = true;
            this.colPayType.VisibleIndex = 14;
            this.colPayType.Width = 43;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "SUM={0:n2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 15;
            this.colAmount.Width = 100;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            // 
            // colDBAType
            // 
            this.colDBAType.FieldName = "DBAType";
            this.colDBAType.Name = "colDBAType";
            this.colDBAType.Visible = true;
            this.colDBAType.VisibleIndex = 16;
            this.colDBAType.Width = 45;
            // 
            // colPayrollStatus
            // 
            this.colPayrollStatus.FieldName = "PayrollStatus";
            this.colPayrollStatus.Name = "colPayrollStatus";
            // 
            // colTotalSalary
            // 
            this.colTotalSalary.FieldName = "TotalSalary";
            this.colTotalSalary.Name = "colTotalSalary";
            // 
            // colBenefits
            // 
            this.colBenefits.FieldName = "Benefits";
            this.colBenefits.Name = "colBenefits";
            // 
            // colDeductions
            // 
            this.colDeductions.FieldName = "Deductions";
            this.colDeductions.Name = "colDeductions";
            // 
            // colAdvance
            // 
            this.colAdvance.FieldName = "Advance";
            this.colAdvance.Name = "colAdvance";
            // 
            // colCommEarned
            // 
            this.colCommEarned.FieldName = "CommEarned";
            this.colCommEarned.Name = "colCommEarned";
            // 
            // colWithHoldingTax
            // 
            this.colWithHoldingTax.FieldName = "WithHoldingTax";
            this.colWithHoldingTax.Name = "colWithHoldingTax";
            // 
            // colPaye
            // 
            this.colPaye.FieldName = "Paye";
            this.colPaye.Name = "colPaye";
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesTableAdapter
            // 
            this.userCodesTableAdapter.ClearBeforeFill = true;
            // 
            // postingPeriodsTableAdapter
            // 
            this.postingPeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // spPostPayrollTableAdapter
            // 
            this.spPostPayrollTableAdapter.ClearBeforeFill = true;
            // 
            // imageSlider1
            // 
            this.imageSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images2"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images3"))));
            this.imageSlider1.Location = new System.Drawing.Point(10, 471);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(227, 73);
            this.imageSlider1.TabIndex = 37;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // frmPayrollReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 556);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPayrollReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Review";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPayrollReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glperiod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postingPeriodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspayrollreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllCostCenters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPaytype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPostPayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalSalary;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glperiod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit chkAllCostCenters;
        private DevExpress.XtraEditors.GridLookUpEdit glPaytype;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource postingPeriodsBindingSource;
        private Class.DataSet.dspayrollreview dspayrollreview;
        private System.Windows.Forms.BindingSource userCodesBindingSource;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dspayrollreviewTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private Class.DataSet.dspayrollreviewTableAdapters.UserCodesTableAdapter userCodesTableAdapter;
        private Class.DataSet.dspayrollreviewTableAdapters.PostingPeriodsTableAdapter postingPeriodsTableAdapter;
        private System.Windows.Forms.BindingSource spPostPayrollBindingSource;
        private Class.DataSet.dspayrollreviewTableAdapters.spPostPayrollTableAdapter spPostPayrollTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colNSSFNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNHIFNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPINNO;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCompName;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenterName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobType;
        private DevExpress.XtraGrid.Columns.GridColumn colJobGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colPayDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPayrollItem;
        private DevExpress.XtraGrid.Columns.GridColumn colPayType;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colDBAType;
        private DevExpress.XtraGrid.Columns.GridColumn colPayrollStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefits;
        private DevExpress.XtraGrid.Columns.GridColumn colDeductions;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvance;
        private DevExpress.XtraGrid.Columns.GridColumn colCommEarned;
        private DevExpress.XtraGrid.Columns.GridColumn colWithHoldingTax;
        private DevExpress.XtraGrid.Columns.GridColumn colPaye;
        private DevExpress.XtraEditors.LabelControl lblBenefits;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblDeductions;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem printPayrollToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn PeriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn EndDate;
        private DevExpress.XtraGrid.Columns.GridColumn Year;
    }
}