namespace Master.Forms
{
    partial class frmCommisionEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommisionEntry));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
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
            this.spSelectAllCommissionsEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCommissionEntry = new Master.Class.DataSet.dsCommissionEntry();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpNoLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spSelectCommissionsEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CommDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.CostCenterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCommDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectCommissionsEntryTableAdapter = new Master.Class.DataSet.dsCommissionEntryTableAdapters.spSelectCommissionsEntryTableAdapter();
            this.spSelectAllCommissionsEntryTableAdapter = new Master.Class.DataSet.dsCommissionEntryTableAdapters.spSelectAllCommissionsEntryTableAdapter();
            this.employeesMasterTableAdapter = new Master.Class.DataSet.dsCommissionEntryTableAdapters.EmployeesMasterTableAdapter();
            this.costCenterTableAdapter = new Master.Class.DataSet.dsCommissionEntryTableAdapters.CostCenterTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCommissionsEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommissionEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCommissionsEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCommDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.EmpNoLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.EmpNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CommDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CostCenterLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCommissionsEntryBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(604, 395);
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
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 44);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 41);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 41);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 41);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 41);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 41);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllCommissionsEntryBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(580, 209);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllCommissionsEntryBindingSource
            // 
            this.spSelectAllCommissionsEntryBindingSource.DataMember = "spSelectAllCommissionsEntry";
            this.spSelectAllCommissionsEntryBindingSource.DataSource = this.dsCommissionEntry;
            // 
            // dsCommissionEntry
            // 
            this.dsCommissionEntry.DataSetName = "dsCommissionEntry";
            this.dsCommissionEntry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView1.AppearancePrint.EvenRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.gridView1.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.Gray;
            this.gridView1.AppearancePrint.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.Preview.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.gridView1.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.Gray;
            this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colEmpName,
            this.colCommDate,
            this.colCompCode,
            this.colCostCenter,
            this.colAmount,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
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
            // colCommDate
            // 
            this.colCommDate.FieldName = "CommDate";
            this.colCommDate.Name = "colCommDate";
            this.colCommDate.Visible = true;
            this.colCommDate.VisibleIndex = 2;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 3;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 4;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 6;
            // 
            // EmpNoLookUpEdit
            // 
            this.EmpNoLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommissionsEntryBindingSource, "EmpNo", true));
            this.EmpNoLookUpEdit.Location = new System.Drawing.Point(365, 90);
            this.EmpNoLookUpEdit.Name = "EmpNoLookUpEdit";
            this.EmpNoLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpNoLookUpEdit.Properties.DataSource = this.employeesMasterBindingSource;
            this.EmpNoLookUpEdit.Properties.DisplayMember = "EmpNames";
            this.EmpNoLookUpEdit.Properties.NullText = "";
            this.EmpNoLookUpEdit.Properties.ValueMember = "EmpNo";
            this.EmpNoLookUpEdit.Size = new System.Drawing.Size(215, 20);
            this.EmpNoLookUpEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoLookUpEdit.TabIndex = 4;
            this.EmpNoLookUpEdit.EditValueChanged += new System.EventHandler(this.EmpNoLookUpEdit_EditValueChanged);
            // 
            // spSelectCommissionsEntryBindingSource
            // 
            this.spSelectCommissionsEntryBindingSource.DataMember = "spSelectCommissionsEntry";
            this.spSelectCommissionsEntryBindingSource.DataSource = this.dsCommissionEntry;
            // 
            // employeesMasterBindingSource
            // 
            this.employeesMasterBindingSource.DataMember = "EmployeesMaster";
            this.employeesMasterBindingSource.DataSource = this.dsCommissionEntry;
            // 
            // EmpNameTextEdit
            // 
            this.EmpNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommissionsEntryBindingSource, "EmpName", true));
            this.EmpNameTextEdit.Location = new System.Drawing.Point(365, 114);
            this.EmpNameTextEdit.Name = "EmpNameTextEdit";
            this.EmpNameTextEdit.Properties.Mask.BeepOnError = true;
            this.EmpNameTextEdit.Properties.Mask.IgnoreMaskBlank = false;
            this.EmpNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.EmpNameTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.EmpNameTextEdit.Size = new System.Drawing.Size(215, 20);
            this.EmpNameTextEdit.StyleController = this.dataLayoutControl1;
            this.EmpNameTextEdit.TabIndex = 5;
            // 
            // CommDateDateEdit
            // 
            this.CommDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommissionsEntryBindingSource, "CommDate", true));
            this.CommDateDateEdit.EditValue = null;
            this.CommDateDateEdit.Location = new System.Drawing.Point(85, 114);
            this.CommDateDateEdit.Name = "CommDateDateEdit";
            this.CommDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommDateDateEdit.Size = new System.Drawing.Size(215, 20);
            this.CommDateDateEdit.StyleController = this.dataLayoutControl1;
            this.CommDateDateEdit.TabIndex = 6;
            // 
            // CostCenterLookUpEdit
            // 
            this.CostCenterLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommissionsEntryBindingSource, "CostCenter", true));
            this.CostCenterLookUpEdit.Location = new System.Drawing.Point(85, 90);
            this.CostCenterLookUpEdit.Name = "CostCenterLookUpEdit";
            this.CostCenterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterLookUpEdit.Properties.DataSource = this.costCenterBindingSource;
            this.CostCenterLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterLookUpEdit.Properties.NullText = "";
            this.CostCenterLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterLookUpEdit.Size = new System.Drawing.Size(215, 20);
            this.CostCenterLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterLookUpEdit.TabIndex = 7;
            this.CostCenterLookUpEdit.EditValueChanged += new System.EventHandler(this.CostCenterLookUpEdit_EditValueChanged);
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataMember = "CostCenter";
            this.costCenterBindingSource.DataSource = this.dsCommissionEntry;
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommissionsEntryBindingSource, "Amount", true));
            this.AmountTextEdit.Location = new System.Drawing.Point(85, 138);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "n";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(215, 20);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 8;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.AmountTextEdit, conditionValidationRule3);
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommissionsEntryBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(365, 138);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Properties.Mask.IgnoreMaskBlank = false;
            this.NarrationTextEdit.Properties.Mask.ShowPlaceHolders = false;
            this.NarrationTextEdit.Size = new System.Drawing.Size(215, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.NarrationTextEdit, conditionValidationRule1);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(604, 395);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(584, 162);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCommDate,
            this.ItemForAmount,
            this.ItemForEmpName,
            this.ItemForNarration,
            this.ItemForCostCenter,
            this.ItemForEmpNo});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(584, 114);
            this.layoutControlGroup3.Text = "Commission Entry";
            // 
            // ItemForCommDate
            // 
            this.ItemForCommDate.Control = this.CommDateDateEdit;
            this.ItemForCommDate.Location = new System.Drawing.Point(0, 24);
            this.ItemForCommDate.Name = "ItemForCommDate";
            this.ItemForCommDate.Size = new System.Drawing.Size(280, 24);
            this.ItemForCommDate.Text = "Comm Date";
            this.ItemForCommDate.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 48);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(280, 24);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForEmpName
            // 
            this.ItemForEmpName.Control = this.EmpNameTextEdit;
            this.ItemForEmpName.Location = new System.Drawing.Point(280, 24);
            this.ItemForEmpName.Name = "ItemForEmpName";
            this.ItemForEmpName.Size = new System.Drawing.Size(280, 24);
            this.ItemForEmpName.Text = "Emp Name";
            this.ItemForEmpName.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(280, 48);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(280, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(280, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoLookUpEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(280, 0);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(280, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(584, 48);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(584, 213);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectCommissionsEntryTableAdapter
            // 
            this.spSelectCommissionsEntryTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllCommissionsEntryTableAdapter
            // 
            this.spSelectAllCommissionsEntryTableAdapter.ClearBeforeFill = true;
            // 
            // employeesMasterTableAdapter
            // 
            this.employeesMasterTableAdapter.ClearBeforeFill = true;
            // 
            // costCenterTableAdapter
            // 
            this.costCenterTableAdapter.ClearBeforeFill = true;
            // 
            // frmCommisionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 395);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCommisionEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Commision Entry";
            this.Load += new System.EventHandler(this.frmCommisionEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCommissionsEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommissionEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCommissionsEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCommDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.LookUpEdit EmpNoLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectCommissionsEntryBindingSource;
        private Class.DataSet.dsCommissionEntry dsCommissionEntry;
        private DevExpress.XtraEditors.TextEdit EmpNameTextEdit;
        private DevExpress.XtraEditors.DateEdit CommDateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit CostCenterLookUpEdit;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCommDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsCommissionEntryTableAdapters.spSelectCommissionsEntryTableAdapter spSelectCommissionsEntryTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
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
        private System.Windows.Forms.BindingSource spSelectAllCommissionsEntryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colCommDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private Class.DataSet.dsCommissionEntryTableAdapters.spSelectAllCommissionsEntryTableAdapter spSelectAllCommissionsEntryTableAdapter;
        private System.Windows.Forms.BindingSource employeesMasterBindingSource;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private Class.DataSet.dsCommissionEntryTableAdapters.EmployeesMasterTableAdapter employeesMasterTableAdapter;
        private Class.DataSet.dsCommissionEntryTableAdapters.CostCenterTableAdapter costCenterTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}