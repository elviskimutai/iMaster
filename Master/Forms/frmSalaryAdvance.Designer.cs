namespace Master.Forms
{
    partial class frmSalaryAdvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryAdvance));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllSalaryAdvancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSalaryAdvance = new Master.Class.DataSet.dsSalaryAdvance();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdvanceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprovalStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.spSelectSalaryAdvancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PayDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ApproverNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmpNoTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.employeesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CostCenterTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AdvanceTypeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.userCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ApproverTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.approverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ApprovalStatusTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFromDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAdvanceType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForApprover = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForApproverName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForApprovalStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectSalaryAdvancesTableAdapter = new Master.Class.DataSet.dsSalaryAdvanceTableAdapters.spSelectSalaryAdvancesTableAdapter();
            this.spSelectAllSalaryAdvancesTableAdapter = new Master.Class.DataSet.dsSalaryAdvanceTableAdapters.spSelectAllSalaryAdvancesTableAdapter();
            this.employeesMasterTableAdapter = new Master.Class.DataSet.dsSalaryAdvanceTableAdapters.EmployeesMasterTableAdapter();
            this.costCenterTableAdapter = new Master.Class.DataSet.dsSalaryAdvanceTableAdapters.CostCenterTableAdapter();
            this.approverTableAdapter = new Master.Class.DataSet.dsSalaryAdvanceTableAdapters.ApproverTableAdapter();
            this.userCodesTableAdapter = new Master.Class.DataSet.dsSalaryAdvanceTableAdapters.UserCodesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSalaryAdvancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalaryAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSalaryAdvancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApproverNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApproverTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalStatusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAdvanceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApprover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApproverName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApprovalStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.FromDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ToDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.PayDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ApproverNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmpNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AdvanceTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ApproverTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ApprovalStatusTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectSalaryAdvancesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(728, 446);
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
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 21);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 18);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 18);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 18);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 21);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 18);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllSalaryAdvancesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 223);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(704, 211);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllSalaryAdvancesBindingSource
            // 
            this.spSelectAllSalaryAdvancesBindingSource.DataMember = "spSelectAllSalaryAdvances";
            this.spSelectAllSalaryAdvancesBindingSource.DataSource = this.dsSalaryAdvance;
            // 
            // dsSalaryAdvance
            // 
            this.dsSalaryAdvance.DataSetName = "dsSalaryAdvance";
            this.dsSalaryAdvance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colEmpName,
            this.colCostCenterName,
            this.colFromDate,
            this.colToDate,
            this.colPayDate,
            this.colAdvanceType,
            this.colAmount,
            this.colApprover,
            this.colApproverName,
            this.colApprovalStatus,
            this.colNarration});
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
            // colEmpName
            // 
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 1;
            // 
            // colCostCenterName
            // 
            this.colCostCenterName.FieldName = "CostCenterName";
            this.colCostCenterName.Name = "colCostCenterName";
            this.colCostCenterName.Visible = true;
            this.colCostCenterName.VisibleIndex = 2;
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
            // colPayDate
            // 
            this.colPayDate.FieldName = "PayDate";
            this.colPayDate.Name = "colPayDate";
            this.colPayDate.Visible = true;
            this.colPayDate.VisibleIndex = 5;
            // 
            // colAdvanceType
            // 
            this.colAdvanceType.FieldName = "AdvanceType";
            this.colAdvanceType.Name = "colAdvanceType";
            this.colAdvanceType.Visible = true;
            this.colAdvanceType.VisibleIndex = 6;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 7;
            // 
            // colApprover
            // 
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            this.colApprover.Visible = true;
            this.colApprover.VisibleIndex = 8;
            // 
            // colApproverName
            // 
            this.colApproverName.FieldName = "ApproverName";
            this.colApproverName.Name = "colApproverName";
            this.colApproverName.Visible = true;
            this.colApproverName.VisibleIndex = 9;
            // 
            // colApprovalStatus
            // 
            this.colApprovalStatus.FieldName = "ApprovalStatus";
            this.colApprovalStatus.Name = "colApprovalStatus";
            this.colApprovalStatus.Visible = true;
            this.colApprovalStatus.VisibleIndex = 10;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 11;
            // 
            // FromDateDateEdit
            // 
            this.FromDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "FromDate", true));
            this.FromDateDateEdit.EditValue = null;
            this.FromDateDateEdit.Location = new System.Drawing.Point(104, 91);
            this.FromDateDateEdit.Name = "FromDateDateEdit";
            this.FromDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDateEdit.Size = new System.Drawing.Size(258, 20);
            this.FromDateDateEdit.StyleController = this.dataLayoutControl1;
            this.FromDateDateEdit.TabIndex = 9;
            // 
            // spSelectSalaryAdvancesBindingSource
            // 
            this.spSelectSalaryAdvancesBindingSource.DataMember = "spSelectSalaryAdvances";
            this.spSelectSalaryAdvancesBindingSource.DataSource = this.dsSalaryAdvance;
            // 
            // ToDateDateEdit
            // 
            this.ToDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "ToDate", true));
            this.ToDateDateEdit.EditValue = null;
            this.ToDateDateEdit.Location = new System.Drawing.Point(446, 91);
            this.ToDateDateEdit.Name = "ToDateDateEdit";
            this.ToDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDateEdit.Size = new System.Drawing.Size(258, 20);
            this.ToDateDateEdit.StyleController = this.dataLayoutControl1;
            this.ToDateDateEdit.TabIndex = 10;
            // 
            // PayDateDateEdit
            // 
            this.PayDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "PayDate", true));
            this.PayDateDateEdit.EditValue = null;
            this.PayDateDateEdit.Location = new System.Drawing.Point(104, 115);
            this.PayDateDateEdit.Name = "PayDateDateEdit";
            this.PayDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayDateDateEdit.Size = new System.Drawing.Size(258, 20);
            this.PayDateDateEdit.StyleController = this.dataLayoutControl1;
            this.PayDateDateEdit.TabIndex = 11;
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "Amount", true));
            this.AmountTextEdit.Location = new System.Drawing.Point(104, 139);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "G";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(258, 20);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 13;
            // 
            // ApproverNameTextEdit
            // 
            this.ApproverNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "ApproverName", true));
            this.ApproverNameTextEdit.Location = new System.Drawing.Point(104, 163);
            this.ApproverNameTextEdit.Name = "ApproverNameTextEdit";
            this.ApproverNameTextEdit.Size = new System.Drawing.Size(258, 20);
            this.ApproverNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ApproverNameTextEdit.TabIndex = 15;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(104, 187);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(600, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 17;
            // 
            // EmpNoTextEdit
            // 
            this.EmpNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "EmpNo", true));
            this.EmpNoTextEdit.Location = new System.Drawing.Point(446, 67);
            this.EmpNoTextEdit.Name = "EmpNoTextEdit";
            this.EmpNoTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpNoTextEdit.Properties.DataSource = this.employeesMasterBindingSource;
            this.EmpNoTextEdit.Properties.DisplayMember = "EmpNames";
            this.EmpNoTextEdit.Properties.NullText = "";
            this.EmpNoTextEdit.Properties.ValueMember = "EmpNo";
            this.EmpNoTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.EmpNoTextEdit.Size = new System.Drawing.Size(258, 20);
            this.EmpNoTextEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoTextEdit.TabIndex = 4;
            // 
            // employeesMasterBindingSource
            // 
            this.employeesMasterBindingSource.DataMember = "EmployeesMaster";
            this.employeesMasterBindingSource.DataSource = this.dsSalaryAdvance;
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
            this.CostCenterTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "CostCenter", true));
            this.CostCenterTextEdit.Location = new System.Drawing.Point(104, 67);
            this.CostCenterTextEdit.Name = "CostCenterTextEdit";
            this.CostCenterTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterTextEdit.Properties.DataSource = this.costCenterBindingSource;
            this.CostCenterTextEdit.Properties.DisplayMember = "ccname";
            this.CostCenterTextEdit.Properties.NullText = "";
            this.CostCenterTextEdit.Properties.ValueMember = "cccode";
            this.CostCenterTextEdit.Properties.View = this.gridView2;
            this.CostCenterTextEdit.Size = new System.Drawing.Size(258, 20);
            this.CostCenterTextEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterTextEdit.TabIndex = 7;
            this.CostCenterTextEdit.EditValueChanged += new System.EventHandler(this.CostCenterTextEdit_EditValueChanged);
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataMember = "CostCenter";
            this.costCenterBindingSource.DataSource = this.dsSalaryAdvance;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // AdvanceTypeTextEdit
            // 
            this.AdvanceTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "AdvanceType", true));
            this.AdvanceTypeTextEdit.Location = new System.Drawing.Point(446, 115);
            this.AdvanceTypeTextEdit.Name = "AdvanceTypeTextEdit";
            this.AdvanceTypeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AdvanceTypeTextEdit.Properties.DataSource = this.userCodesBindingSource;
            this.AdvanceTypeTextEdit.Properties.DisplayMember = "Description";
            this.AdvanceTypeTextEdit.Properties.NullText = "";
            this.AdvanceTypeTextEdit.Properties.ValueMember = "Code";
            this.AdvanceTypeTextEdit.Properties.View = this.gridView3;
            this.AdvanceTypeTextEdit.Size = new System.Drawing.Size(258, 20);
            this.AdvanceTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.AdvanceTypeTextEdit.TabIndex = 12;
            // 
            // userCodesBindingSource
            // 
            this.userCodesBindingSource.DataMember = "UserCodes";
            this.userCodesBindingSource.DataSource = this.dsSalaryAdvance;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ApproverTextEdit
            // 
            this.ApproverTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "Approver", true));
            this.ApproverTextEdit.Location = new System.Drawing.Point(446, 139);
            this.ApproverTextEdit.Name = "ApproverTextEdit";
            this.ApproverTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ApproverTextEdit.Properties.DataSource = this.approverBindingSource;
            this.ApproverTextEdit.Properties.DisplayMember = "FullNames";
            this.ApproverTextEdit.Properties.NullText = "";
            this.ApproverTextEdit.Properties.ValueMember = "Approver";
            this.ApproverTextEdit.Properties.View = this.gridView4;
            this.ApproverTextEdit.Size = new System.Drawing.Size(258, 20);
            this.ApproverTextEdit.StyleController = this.dataLayoutControl1;
            this.ApproverTextEdit.TabIndex = 14;
            this.ApproverTextEdit.EditValueChanged += new System.EventHandler(this.ApproverTextEdit_EditValueChanged);
            // 
            // approverBindingSource
            // 
            this.approverBindingSource.DataMember = "Approver";
            this.approverBindingSource.DataSource = this.dsSalaryAdvance;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // ApprovalStatusTextEdit
            // 
            this.ApprovalStatusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectSalaryAdvancesBindingSource, "ApprovalStatus", true));
            this.ApprovalStatusTextEdit.Location = new System.Drawing.Point(446, 163);
            this.ApprovalStatusTextEdit.Name = "ApprovalStatusTextEdit";
            this.ApprovalStatusTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ApprovalStatusTextEdit.Properties.Items.AddRange(new object[] {
            "Approved",
            "Pending Approval"});
            this.ApprovalStatusTextEdit.Size = new System.Drawing.Size(258, 20);
            this.ApprovalStatusTextEdit.StyleController = this.dataLayoutControl1;
            this.ApprovalStatusTextEdit.TabIndex = 16;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(728, 446);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(708, 426);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 211);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(708, 215);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFromDate,
            this.ItemForToDate,
            this.ItemForPayDate,
            this.ItemForAdvanceType,
            this.ItemForAmount,
            this.ItemForApprover,
            this.ItemForApproverName,
            this.ItemForApprovalStatus,
            this.ItemForNarration,
            this.ItemForCostCenter,
            this.ItemForEmpNo});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 25);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(708, 186);
            this.layoutControlGroup3.Text = "Salary Advance";
            // 
            // ItemForFromDate
            // 
            this.ItemForFromDate.Control = this.FromDateDateEdit;
            this.ItemForFromDate.Location = new System.Drawing.Point(0, 24);
            this.ItemForFromDate.Name = "ItemForFromDate";
            this.ItemForFromDate.Size = new System.Drawing.Size(342, 24);
            this.ItemForFromDate.Text = "From Date";
            this.ItemForFromDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForToDate
            // 
            this.ItemForToDate.Control = this.ToDateDateEdit;
            this.ItemForToDate.Location = new System.Drawing.Point(342, 24);
            this.ItemForToDate.Name = "ItemForToDate";
            this.ItemForToDate.Size = new System.Drawing.Size(342, 24);
            this.ItemForToDate.Text = "To Date";
            this.ItemForToDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForPayDate
            // 
            this.ItemForPayDate.Control = this.PayDateDateEdit;
            this.ItemForPayDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForPayDate.Name = "ItemForPayDate";
            this.ItemForPayDate.Size = new System.Drawing.Size(342, 24);
            this.ItemForPayDate.Text = "Pay Date";
            this.ItemForPayDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForAdvanceType
            // 
            this.ItemForAdvanceType.Control = this.AdvanceTypeTextEdit;
            this.ItemForAdvanceType.Location = new System.Drawing.Point(342, 48);
            this.ItemForAdvanceType.Name = "ItemForAdvanceType";
            this.ItemForAdvanceType.Size = new System.Drawing.Size(342, 24);
            this.ItemForAdvanceType.Text = "Advance Type";
            this.ItemForAdvanceType.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 72);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(342, 24);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForApprover
            // 
            this.ItemForApprover.Control = this.ApproverTextEdit;
            this.ItemForApprover.Location = new System.Drawing.Point(342, 72);
            this.ItemForApprover.Name = "ItemForApprover";
            this.ItemForApprover.Size = new System.Drawing.Size(342, 24);
            this.ItemForApprover.Text = "Approver";
            this.ItemForApprover.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForApproverName
            // 
            this.ItemForApproverName.Control = this.ApproverNameTextEdit;
            this.ItemForApproverName.Location = new System.Drawing.Point(0, 96);
            this.ItemForApproverName.Name = "ItemForApproverName";
            this.ItemForApproverName.Size = new System.Drawing.Size(342, 24);
            this.ItemForApproverName.Text = "Approver Name";
            this.ItemForApproverName.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForApprovalStatus
            // 
            this.ItemForApprovalStatus.Control = this.ApprovalStatusTextEdit;
            this.ItemForApprovalStatus.Location = new System.Drawing.Point(342, 96);
            this.ItemForApprovalStatus.Name = "ItemForApprovalStatus";
            this.ItemForApprovalStatus.Size = new System.Drawing.Size(342, 24);
            this.ItemForApprovalStatus.Text = "Approval Status";
            this.ItemForApprovalStatus.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(0, 120);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(684, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterTextEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(342, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoTextEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(342, 0);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(342, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(708, 25);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectSalaryAdvancesTableAdapter
            // 
            this.spSelectSalaryAdvancesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllSalaryAdvancesTableAdapter
            // 
            this.spSelectAllSalaryAdvancesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesMasterTableAdapter
            // 
            this.employeesMasterTableAdapter.ClearBeforeFill = true;
            // 
            // costCenterTableAdapter
            // 
            this.costCenterTableAdapter.ClearBeforeFill = true;
            // 
            // approverTableAdapter
            // 
            this.approverTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesTableAdapter
            // 
            this.userCodesTableAdapter.ClearBeforeFill = true;
            // 
            // frmSalaryAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 446);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmSalaryAdvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Advance";
            this.Load += new System.EventHandler(this.frmSalaryAdvance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllSalaryAdvancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalaryAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectSalaryAdvancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApproverNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApproverTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalStatusTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAdvanceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApprover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApproverName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForApprovalStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource spSelectSalaryAdvancesBindingSource;
        private Class.DataSet.dsSalaryAdvance dsSalaryAdvance;
        private DevExpress.XtraEditors.DateEdit FromDateDateEdit;
        private DevExpress.XtraEditors.DateEdit ToDateDateEdit;
        private DevExpress.XtraEditors.DateEdit PayDateDateEdit;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.TextEdit ApproverNameTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAdvanceType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForApprover;
        private DevExpress.XtraLayout.LayoutControlItem ItemForApproverName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForApprovalStatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsSalaryAdvanceTableAdapters.spSelectSalaryAdvancesTableAdapter spSelectSalaryAdvancesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spSelectAllSalaryAdvancesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenterName;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPayDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvanceType;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverName;
        private DevExpress.XtraGrid.Columns.GridColumn colApprovalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private Class.DataSet.dsSalaryAdvanceTableAdapters.spSelectAllSalaryAdvancesTableAdapter spSelectAllSalaryAdvancesTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit EmpNoTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit AdvanceTypeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit ApproverTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource employeesMasterBindingSource;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private Class.DataSet.dsSalaryAdvanceTableAdapters.EmployeesMasterTableAdapter employeesMasterTableAdapter;
        private Class.DataSet.dsSalaryAdvanceTableAdapters.CostCenterTableAdapter costCenterTableAdapter;
        private System.Windows.Forms.BindingSource approverBindingSource;
        private Class.DataSet.dsSalaryAdvanceTableAdapters.ApproverTableAdapter approverTableAdapter;
        private System.Windows.Forms.BindingSource userCodesBindingSource;
        private Class.DataSet.dsSalaryAdvanceTableAdapters.UserCodesTableAdapter userCodesTableAdapter;
        private DevExpress.XtraEditors.ComboBoxEdit ApprovalStatusTextEdit;
    }
}