namespace Master.Forms
{
    partial class frmKPIEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKPIEntry));
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
            this.spSelectAllKpiEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKPIEntry = new Master.Class.DataSet.dsKPIEntry();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKpi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpNoLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spSelectKpiEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetEmployeeCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ToDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.WeightTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TargetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ActualTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ScoreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.KpiTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spGetKPIsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForKpi = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWeight = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTarget = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForActual = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForScore = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectKpiEntryTableAdapter = new Master.Class.DataSet.dsKPIEntryTableAdapters.spSelectKpiEntryTableAdapter();
            this.spGetEmployeeCodesTableAdapter = new Master.Class.DataSet.dsKPIEntryTableAdapters.spGetEmployeeCodesTableAdapter();
            this.spGetKPIsTableAdapter = new Master.Class.DataSet.dsKPIEntryTableAdapters.spGetKPIsTableAdapter();
            this.spSelectAllKpiEntryTableAdapter = new Master.Class.DataSet.dsKPIEntryTableAdapters.spSelectAllKpiEntryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllKpiEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKPIEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectKpiEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetKPIsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKpi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.EmpNoLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.EmployeeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FromDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ToDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.WeightTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TargetTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ActualTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ScoreTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.KpiTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectKpiEntryBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(817, 476);
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
            this.toolStrip1.Size = new System.Drawing.Size(793, 20);
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
            this.gridControl1.DataSource = this.spSelectAllKpiEntryBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 156);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(793, 308);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllKpiEntryBindingSource
            // 
            this.spSelectAllKpiEntryBindingSource.DataMember = "spSelectAllKpiEntry";
            this.spSelectAllKpiEntryBindingSource.DataSource = this.dsKPIEntry;
            // 
            // dsKPIEntry
            // 
            this.dsKPIEntry.DataSetName = "dsKPIEntry";
            this.dsKPIEntry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKpi,
            this.colEmpNo,
            this.colEmployee,
            this.colFromDate,
            this.colToDate,
            this.colWeight,
            this.colTarget,
            this.colActual,
            this.colScore,
            this.colRemarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colKpi
            // 
            this.colKpi.FieldName = "Kpi";
            this.colKpi.Name = "colKpi";
            this.colKpi.Visible = true;
            this.colKpi.VisibleIndex = 0;
            // 
            // colEmpNo
            // 
            this.colEmpNo.FieldName = "EmpNo";
            this.colEmpNo.Name = "colEmpNo";
            this.colEmpNo.Visible = true;
            this.colEmpNo.VisibleIndex = 1;
            // 
            // colEmployee
            // 
            this.colEmployee.FieldName = "Employee";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 2;
            // 
            // colFromDate
            // 
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.Visible = true;
            this.colFromDate.VisibleIndex = 3;
            // 
            // colToDate
            // 
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.Visible = true;
            this.colToDate.VisibleIndex = 4;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            // 
            // colTarget
            // 
            this.colTarget.FieldName = "Target";
            this.colTarget.Name = "colTarget";
            this.colTarget.Visible = true;
            this.colTarget.VisibleIndex = 6;
            // 
            // colActual
            // 
            this.colActual.FieldName = "Actual";
            this.colActual.Name = "colActual";
            this.colActual.Visible = true;
            this.colActual.VisibleIndex = 7;
            // 
            // colScore
            // 
            this.colScore.FieldName = "Score";
            this.colScore.Name = "colScore";
            this.colScore.Visible = true;
            this.colScore.VisibleIndex = 8;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 9;
            // 
            // EmpNoLookUpEdit
            // 
            this.EmpNoLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "EmpNo", true));
            this.EmpNoLookUpEdit.Location = new System.Drawing.Point(462, 36);
            this.EmpNoLookUpEdit.Name = "EmpNoLookUpEdit";
            this.EmpNoLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpNoLookUpEdit.Properties.DataSource = this.spGetEmployeeCodesBindingSource;
            this.EmpNoLookUpEdit.Properties.DisplayMember = "EmpNames";
            this.EmpNoLookUpEdit.Properties.NullText = "";
            this.EmpNoLookUpEdit.Properties.ValueMember = "EmpNo";
            this.EmpNoLookUpEdit.Size = new System.Drawing.Size(343, 20);
            this.EmpNoLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoLookUpEdit.TabIndex = 5;
            this.EmpNoLookUpEdit.EditValueChanged += new System.EventHandler(this.EmpNoLookUpEdit_EditValueChanged);
            // 
            // spSelectKpiEntryBindingSource
            // 
            this.spSelectKpiEntryBindingSource.DataMember = "spSelectKpiEntry";
            this.spSelectKpiEntryBindingSource.DataSource = this.dsKPIEntry;
            // 
            // spGetEmployeeCodesBindingSource
            // 
            this.spGetEmployeeCodesBindingSource.DataMember = "spGetEmployeeCodes";
            this.spGetEmployeeCodesBindingSource.DataSource = this.dsKPIEntry;
            // 
            // EmployeeTextEdit
            // 
            this.EmployeeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "Employee", true));
            this.EmployeeTextEdit.Location = new System.Drawing.Point(65, 60);
            this.EmployeeTextEdit.Name = "EmployeeTextEdit";
            this.EmployeeTextEdit.Size = new System.Drawing.Size(340, 20);
            this.EmployeeTextEdit.StyleController = this.dataLayoutControl1;
            this.EmployeeTextEdit.TabIndex = 6;
            // 
            // FromDateDateEdit
            // 
            this.FromDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "FromDate", true));
            this.FromDateDateEdit.EditValue = null;
            this.FromDateDateEdit.Location = new System.Drawing.Point(462, 60);
            this.FromDateDateEdit.Name = "FromDateDateEdit";
            this.FromDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Size = new System.Drawing.Size(343, 20);
            this.FromDateDateEdit.StyleController = this.dataLayoutControl1;
            this.FromDateDateEdit.TabIndex = 7;
            // 
            // ToDateDateEdit
            // 
            this.ToDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "ToDate", true));
            this.ToDateDateEdit.EditValue = null;
            this.ToDateDateEdit.Location = new System.Drawing.Point(65, 84);
            this.ToDateDateEdit.Name = "ToDateDateEdit";
            this.ToDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Size = new System.Drawing.Size(340, 20);
            this.ToDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ToDateDateEdit.TabIndex = 8;
            // 
            // WeightTextEdit
            // 
            this.WeightTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "Weight", true));
            this.WeightTextEdit.Location = new System.Drawing.Point(462, 84);
            this.WeightTextEdit.Name = "WeightTextEdit";
            this.WeightTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.WeightTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.WeightTextEdit.Properties.Mask.EditMask = "N0";
            this.WeightTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.WeightTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.WeightTextEdit.Size = new System.Drawing.Size(343, 20);
            this.WeightTextEdit.StyleController = this.dataLayoutControl1;
            this.WeightTextEdit.TabIndex = 9;
            // 
            // TargetTextEdit
            // 
            this.TargetTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "Target", true));
            this.TargetTextEdit.Location = new System.Drawing.Point(65, 108);
            this.TargetTextEdit.Name = "TargetTextEdit";
            this.TargetTextEdit.Size = new System.Drawing.Size(340, 20);
            this.TargetTextEdit.StyleController = this.dataLayoutControl1;
            this.TargetTextEdit.TabIndex = 10;
            // 
            // ActualTextEdit
            // 
            this.ActualTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "Actual", true));
            this.ActualTextEdit.Location = new System.Drawing.Point(462, 108);
            this.ActualTextEdit.Name = "ActualTextEdit";
            this.ActualTextEdit.Size = new System.Drawing.Size(343, 20);
            this.ActualTextEdit.StyleController = this.dataLayoutControl1;
            this.ActualTextEdit.TabIndex = 11;
            // 
            // ScoreTextEdit
            // 
            this.ScoreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "Score", true));
            this.ScoreTextEdit.Location = new System.Drawing.Point(65, 132);
            this.ScoreTextEdit.Name = "ScoreTextEdit";
            this.ScoreTextEdit.Size = new System.Drawing.Size(340, 20);
            this.ScoreTextEdit.StyleController = this.dataLayoutControl1;
            this.ScoreTextEdit.TabIndex = 12;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(462, 132);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(343, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 13;
            // 
            // KpiTextEdit
            // 
            this.KpiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectKpiEntryBindingSource, "Kpi", true));
            this.KpiTextEdit.Location = new System.Drawing.Point(65, 36);
            this.KpiTextEdit.Name = "KpiTextEdit";
            this.KpiTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.KpiTextEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KpiCode", "Kpi Code", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KpiDescription", "Kpi Description", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Weight", "Weight", 44, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.KpiTextEdit.Properties.DataSource = this.spGetKPIsBindingSource;
            this.KpiTextEdit.Properties.DisplayMember = "KpiDescription";
            this.KpiTextEdit.Properties.NullText = "";
            this.KpiTextEdit.Properties.ValueMember = "KpiCode";
            this.KpiTextEdit.Size = new System.Drawing.Size(340, 20);
            this.KpiTextEdit.StyleController = this.dataLayoutControl1;
            this.KpiTextEdit.TabIndex = 4;
            this.KpiTextEdit.EditValueChanged += new System.EventHandler(this.KpiTextEdit_EditValueChanged);
            // 
            // spGetKPIsBindingSource
            // 
            this.spGetKPIsBindingSource.DataMember = "spGetKPIs";
            this.spGetKPIsBindingSource.DataSource = this.dsKPIEntry;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(817, 476);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForKpi,
            this.ItemForEmpNo,
            this.ItemForEmployee,
            this.ItemForFromDate,
            this.ItemForToDate,
            this.ItemForWeight,
            this.ItemForTarget,
            this.ItemForActual,
            this.ItemForScore,
            this.ItemForRemarks,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(797, 144);
            // 
            // ItemForKpi
            // 
            this.ItemForKpi.Control = this.KpiTextEdit;
            this.ItemForKpi.Location = new System.Drawing.Point(0, 24);
            this.ItemForKpi.Name = "ItemForKpi";
            this.ItemForKpi.Size = new System.Drawing.Size(397, 24);
            this.ItemForKpi.Text = "Kpi";
            this.ItemForKpi.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoLookUpEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(397, 24);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(400, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForEmployee
            // 
            this.ItemForEmployee.Control = this.EmployeeTextEdit;
            this.ItemForEmployee.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmployee.Name = "ItemForEmployee";
            this.ItemForEmployee.Size = new System.Drawing.Size(397, 24);
            this.ItemForEmployee.Text = "Employee";
            this.ItemForEmployee.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForFromDate
            // 
            this.ItemForFromDate.Control = this.FromDateDateEdit;
            this.ItemForFromDate.Location = new System.Drawing.Point(397, 48);
            this.ItemForFromDate.Name = "ItemForFromDate";
            this.ItemForFromDate.Size = new System.Drawing.Size(400, 24);
            this.ItemForFromDate.Text = "From Date";
            this.ItemForFromDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForToDate
            // 
            this.ItemForToDate.Control = this.ToDateDateEdit;
            this.ItemForToDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForToDate.Name = "ItemForToDate";
            this.ItemForToDate.Size = new System.Drawing.Size(397, 24);
            this.ItemForToDate.Text = "To Date";
            this.ItemForToDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForWeight
            // 
            this.ItemForWeight.Control = this.WeightTextEdit;
            this.ItemForWeight.Location = new System.Drawing.Point(397, 72);
            this.ItemForWeight.Name = "ItemForWeight";
            this.ItemForWeight.Size = new System.Drawing.Size(400, 24);
            this.ItemForWeight.Text = "Weight";
            this.ItemForWeight.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForTarget
            // 
            this.ItemForTarget.Control = this.TargetTextEdit;
            this.ItemForTarget.Location = new System.Drawing.Point(0, 96);
            this.ItemForTarget.Name = "ItemForTarget";
            this.ItemForTarget.Size = new System.Drawing.Size(397, 24);
            this.ItemForTarget.Text = "Target";
            this.ItemForTarget.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForActual
            // 
            this.ItemForActual.Control = this.ActualTextEdit;
            this.ItemForActual.Location = new System.Drawing.Point(397, 96);
            this.ItemForActual.Name = "ItemForActual";
            this.ItemForActual.Size = new System.Drawing.Size(400, 24);
            this.ItemForActual.Text = "Actual";
            this.ItemForActual.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForScore
            // 
            this.ItemForScore.Control = this.ScoreTextEdit;
            this.ItemForScore.Location = new System.Drawing.Point(0, 120);
            this.ItemForScore.Name = "ItemForScore";
            this.ItemForScore.Size = new System.Drawing.Size(397, 24);
            this.ItemForScore.Text = "Score";
            this.ItemForScore.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(397, 120);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(400, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(797, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(797, 312);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectKpiEntryTableAdapter
            // 
            this.spSelectKpiEntryTableAdapter.ClearBeforeFill = true;
            // 
            // spGetEmployeeCodesTableAdapter
            // 
            this.spGetEmployeeCodesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetKPIsTableAdapter
            // 
            this.spGetKPIsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllKpiEntryTableAdapter
            // 
            this.spSelectAllKpiEntryTableAdapter.ClearBeforeFill = true;
            // 
            // frmKPIEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 476);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmKPIEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI Entry";
            this.Load += new System.EventHandler(this.frmKPIEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllKpiEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKPIEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectKpiEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetEmployeeCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetKPIsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKpi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource spSelectKpiEntryBindingSource;
        private Class.DataSet.dsKPIEntry dsKPIEntry;
        private DevExpress.XtraEditors.LookUpEdit EmpNoLookUpEdit;
        private DevExpress.XtraEditors.TextEdit EmployeeTextEdit;
        private DevExpress.XtraEditors.DateEdit FromDateDateEdit;
        private DevExpress.XtraEditors.DateEdit ToDateDateEdit;
        private DevExpress.XtraEditors.TextEdit WeightTextEdit;
        private DevExpress.XtraEditors.TextEdit TargetTextEdit;
        private DevExpress.XtraEditors.TextEdit ActualTextEdit;
        private DevExpress.XtraEditors.TextEdit ScoreTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKpi;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployee;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWeight;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTarget;
        private DevExpress.XtraLayout.LayoutControlItem ItemForActual;
        private DevExpress.XtraLayout.LayoutControlItem ItemForScore;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsKPIEntryTableAdapters.spSelectKpiEntryTableAdapter spSelectKpiEntryTableAdapter;
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
        private System.Windows.Forms.BindingSource spGetEmployeeCodesBindingSource;
        private Class.DataSet.dsKPIEntryTableAdapters.spGetEmployeeCodesTableAdapter spGetEmployeeCodesTableAdapter;
        private System.Windows.Forms.BindingSource spGetKPIsBindingSource;
        private Class.DataSet.dsKPIEntryTableAdapters.spGetKPIsTableAdapter spGetKPIsTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllKpiEntryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colKpi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colActual;
        private DevExpress.XtraGrid.Columns.GridColumn colScore;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private Class.DataSet.dsKPIEntryTableAdapters.spSelectAllKpiEntryTableAdapter spSelectAllKpiEntryTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit KpiTextEdit;
    }
}