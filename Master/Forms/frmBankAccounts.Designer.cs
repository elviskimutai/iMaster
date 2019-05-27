namespace Master.Forms
{
    partial class frmBankAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankAccounts));
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
            this.spSelectAllBankAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBankAccounts = new Master.Class.DataSet.dsBankAccounts();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGLAcc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowOverdraft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverdraftLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectBankAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EffectiveDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.MinBalanceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AllowOverdraftCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.OverdraftLimitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationMemoExEdit = new DevExpress.XtraEditors.MemoExEdit();
            this.GLAccLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForGLAcc = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEffectiveDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMinBalance = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAllowOverdraft = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOverdraftLimit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectBankAccountsTableAdapter = new Master.Class.DataSet.dsBankAccountsTableAdapters.spSelectBankAccountsTableAdapter();
            this.spSelectAllBankAccountsTableAdapter = new Master.Class.DataSet.dsBankAccountsTableAdapters.spSelectAllBankAccountsTableAdapter();
            this.cOATableAdapter = new Master.Class.DataSet.dsBankAccountsTableAdapters.COATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllBankAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectBankAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBalanceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowOverdraftCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverdraftLimitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLAccLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGLAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMinBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAllowOverdraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOverdraftLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.AccNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EffectiveDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.MinBalanceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AllowOverdraftCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.OverdraftLimitTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationMemoExEdit);
            this.dataLayoutControl1.Controls.Add(this.GLAccLookUpEdit);
            this.dataLayoutControl1.DataSource = this.spSelectBankAccountsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(740, 436);
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
            this.toolStrip1.Size = new System.Drawing.Size(716, 20);
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
            this.gridControl1.DataSource = this.spSelectAllBankAccountsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(716, 250);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllBankAccountsBindingSource
            // 
            this.spSelectAllBankAccountsBindingSource.DataMember = "spSelectAllBankAccounts";
            this.spSelectAllBankAccountsBindingSource.DataSource = this.dsBankAccounts;
            // 
            // dsBankAccounts
            // 
            this.dsBankAccounts.DataSetName = "dsBankAccounts";
            this.dsBankAccounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGLAcc,
            this.colAccName,
            this.colAccNumber,
            this.colEffectiveDate,
            this.colMinBalance,
            this.colAllowOverdraft,
            this.colOverdraftLimit,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colGLAcc
            // 
            this.colGLAcc.FieldName = "GLAcc";
            this.colGLAcc.Name = "colGLAcc";
            this.colGLAcc.Visible = true;
            this.colGLAcc.VisibleIndex = 0;
            // 
            // colAccName
            // 
            this.colAccName.FieldName = "AccName";
            this.colAccName.Name = "colAccName";
            this.colAccName.Visible = true;
            this.colAccName.VisibleIndex = 1;
            // 
            // colAccNumber
            // 
            this.colAccNumber.FieldName = "AccNumber";
            this.colAccNumber.Name = "colAccNumber";
            this.colAccNumber.Visible = true;
            this.colAccNumber.VisibleIndex = 2;
            // 
            // colEffectiveDate
            // 
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 3;
            // 
            // colMinBalance
            // 
            this.colMinBalance.FieldName = "MinBalance";
            this.colMinBalance.Name = "colMinBalance";
            this.colMinBalance.Visible = true;
            this.colMinBalance.VisibleIndex = 4;
            // 
            // colAllowOverdraft
            // 
            this.colAllowOverdraft.FieldName = "AllowOverdraft";
            this.colAllowOverdraft.Name = "colAllowOverdraft";
            this.colAllowOverdraft.Visible = true;
            this.colAllowOverdraft.VisibleIndex = 5;
            // 
            // colOverdraftLimit
            // 
            this.colOverdraftLimit.FieldName = "OverdraftLimit";
            this.colOverdraftLimit.Name = "colOverdraftLimit";
            this.colOverdraftLimit.Visible = true;
            this.colOverdraftLimit.VisibleIndex = 6;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 7;
            // 
            // AccNameTextEdit
            // 
            this.AccNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBankAccountsBindingSource, "AccName", true));
            this.AccNameTextEdit.Location = new System.Drawing.Point(451, 66);
            this.AccNameTextEdit.Name = "AccNameTextEdit";
            this.AccNameTextEdit.Size = new System.Drawing.Size(265, 20);
            this.AccNameTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNameTextEdit.TabIndex = 5;
            // 
            // spSelectBankAccountsBindingSource
            // 
            this.spSelectBankAccountsBindingSource.DataMember = "spSelectBankAccounts";
            this.spSelectBankAccountsBindingSource.DataSource = this.dsBankAccounts;
            // 
            // AccNumberTextEdit
            // 
            this.AccNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBankAccountsBindingSource, "AccNumber", true));
            this.AccNumberTextEdit.Location = new System.Drawing.Point(103, 90);
            this.AccNumberTextEdit.Name = "AccNumberTextEdit";
            this.AccNumberTextEdit.Size = new System.Drawing.Size(265, 20);
            this.AccNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNumberTextEdit.TabIndex = 6;
            // 
            // EffectiveDateDateEdit
            // 
            this.EffectiveDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBankAccountsBindingSource, "EffectiveDate", true));
            this.EffectiveDateDateEdit.EditValue = null;
            this.EffectiveDateDateEdit.Location = new System.Drawing.Point(451, 90);
            this.EffectiveDateDateEdit.Name = "EffectiveDateDateEdit";
            this.EffectiveDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Size = new System.Drawing.Size(265, 20);
            this.EffectiveDateDateEdit.StyleController = this.dataLayoutControl1;
            this.EffectiveDateDateEdit.TabIndex = 7;
            // 
            // MinBalanceTextEdit
            // 
            this.MinBalanceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBankAccountsBindingSource, "MinBalance", true));
            this.MinBalanceTextEdit.Location = new System.Drawing.Point(103, 114);
            this.MinBalanceTextEdit.Name = "MinBalanceTextEdit";
            this.MinBalanceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MinBalanceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MinBalanceTextEdit.Properties.Mask.EditMask = "G";
            this.MinBalanceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MinBalanceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MinBalanceTextEdit.Size = new System.Drawing.Size(265, 20);
            this.MinBalanceTextEdit.StyleController = this.dataLayoutControl1;
            this.MinBalanceTextEdit.TabIndex = 8;
            // 
            // AllowOverdraftCheckEdit
            // 
            this.AllowOverdraftCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBankAccountsBindingSource, "AllowOverdraft", true));
            this.AllowOverdraftCheckEdit.Location = new System.Drawing.Point(451, 114);
            this.AllowOverdraftCheckEdit.Name = "AllowOverdraftCheckEdit";
            this.AllowOverdraftCheckEdit.Properties.Caption = "Allow Overdraft";
            this.AllowOverdraftCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AllowOverdraftCheckEdit.Size = new System.Drawing.Size(265, 19);
            this.AllowOverdraftCheckEdit.StyleController = this.dataLayoutControl1;
            this.AllowOverdraftCheckEdit.TabIndex = 9;
            // 
            // OverdraftLimitTextEdit
            // 
            this.OverdraftLimitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBankAccountsBindingSource, "OverdraftLimit", true));
            this.OverdraftLimitTextEdit.Location = new System.Drawing.Point(103, 138);
            this.OverdraftLimitTextEdit.Name = "OverdraftLimitTextEdit";
            this.OverdraftLimitTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.OverdraftLimitTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OverdraftLimitTextEdit.Properties.Mask.EditMask = "G";
            this.OverdraftLimitTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.OverdraftLimitTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.OverdraftLimitTextEdit.Size = new System.Drawing.Size(265, 20);
            this.OverdraftLimitTextEdit.StyleController = this.dataLayoutControl1;
            this.OverdraftLimitTextEdit.TabIndex = 10;
            // 
            // NarrationMemoExEdit
            // 
            this.NarrationMemoExEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectBankAccountsBindingSource, "Narration", true));
            this.NarrationMemoExEdit.Location = new System.Drawing.Point(451, 138);
            this.NarrationMemoExEdit.Name = "NarrationMemoExEdit";
            this.NarrationMemoExEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NarrationMemoExEdit.Size = new System.Drawing.Size(265, 20);
            this.NarrationMemoExEdit.StyleController = this.dataLayoutControl1;
            this.NarrationMemoExEdit.TabIndex = 11;
            // 
            // GLAccLookUpEdit
            // 
            this.GLAccLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectBankAccountsBindingSource, "GLAcc", true));
            this.GLAccLookUpEdit.Location = new System.Drawing.Point(103, 66);
            this.GLAccLookUpEdit.Name = "GLAccLookUpEdit";
            this.GLAccLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GLAccLookUpEdit.Properties.DataSource = this.cOABindingSource;
            this.GLAccLookUpEdit.Properties.DisplayMember = "AccName";
            this.GLAccLookUpEdit.Properties.NullText = "";
            this.GLAccLookUpEdit.Properties.ValueMember = "AccCode";
            this.GLAccLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.GLAccLookUpEdit.Size = new System.Drawing.Size(265, 20);
            this.GLAccLookUpEdit.StyleController = this.dataLayoutControl1;
            this.GLAccLookUpEdit.TabIndex = 4;
            // 
            // cOABindingSource
            // 
            this.cOABindingSource.DataMember = "COA";
            this.cOABindingSource.DataSource = this.dsBankAccounts;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(740, 436);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(720, 416);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(720, 254);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForGLAcc,
            this.ItemForAccName,
            this.ItemForAccNumber,
            this.ItemForEffectiveDate,
            this.ItemForMinBalance,
            this.ItemForAllowOverdraft,
            this.ItemForOverdraftLimit,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(720, 138);
            this.layoutControlGroup3.Text = "Bank Accounts";
            // 
            // ItemForGLAcc
            // 
            this.ItemForGLAcc.Control = this.GLAccLookUpEdit;
            this.ItemForGLAcc.Location = new System.Drawing.Point(0, 0);
            this.ItemForGLAcc.Name = "ItemForGLAcc";
            this.ItemForGLAcc.Size = new System.Drawing.Size(348, 24);
            this.ItemForGLAcc.Text = "GL Acc";
            this.ItemForGLAcc.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForAccName
            // 
            this.ItemForAccName.Control = this.AccNameTextEdit;
            this.ItemForAccName.Location = new System.Drawing.Point(348, 0);
            this.ItemForAccName.Name = "ItemForAccName";
            this.ItemForAccName.Size = new System.Drawing.Size(348, 24);
            this.ItemForAccName.Text = "Acc Name";
            this.ItemForAccName.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForAccNumber
            // 
            this.ItemForAccNumber.Control = this.AccNumberTextEdit;
            this.ItemForAccNumber.Location = new System.Drawing.Point(0, 24);
            this.ItemForAccNumber.Name = "ItemForAccNumber";
            this.ItemForAccNumber.Size = new System.Drawing.Size(348, 24);
            this.ItemForAccNumber.Text = "Acc Number";
            this.ItemForAccNumber.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForEffectiveDate
            // 
            this.ItemForEffectiveDate.Control = this.EffectiveDateDateEdit;
            this.ItemForEffectiveDate.Location = new System.Drawing.Point(348, 24);
            this.ItemForEffectiveDate.Name = "ItemForEffectiveDate";
            this.ItemForEffectiveDate.Size = new System.Drawing.Size(348, 24);
            this.ItemForEffectiveDate.Text = "Effective Date";
            this.ItemForEffectiveDate.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForMinBalance
            // 
            this.ItemForMinBalance.Control = this.MinBalanceTextEdit;
            this.ItemForMinBalance.Location = new System.Drawing.Point(0, 48);
            this.ItemForMinBalance.Name = "ItemForMinBalance";
            this.ItemForMinBalance.Size = new System.Drawing.Size(348, 24);
            this.ItemForMinBalance.Text = "Min Balance";
            this.ItemForMinBalance.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForAllowOverdraft
            // 
            this.ItemForAllowOverdraft.Control = this.AllowOverdraftCheckEdit;
            this.ItemForAllowOverdraft.Location = new System.Drawing.Point(348, 48);
            this.ItemForAllowOverdraft.Name = "ItemForAllowOverdraft";
            this.ItemForAllowOverdraft.Size = new System.Drawing.Size(348, 24);
            this.ItemForAllowOverdraft.Text = "Allow Overdraft";
            this.ItemForAllowOverdraft.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForOverdraftLimit
            // 
            this.ItemForOverdraftLimit.Control = this.OverdraftLimitTextEdit;
            this.ItemForOverdraftLimit.Location = new System.Drawing.Point(0, 72);
            this.ItemForOverdraftLimit.Name = "ItemForOverdraftLimit";
            this.ItemForOverdraftLimit.Size = new System.Drawing.Size(348, 24);
            this.ItemForOverdraftLimit.Text = "Overdraft Limit";
            this.ItemForOverdraftLimit.TextSize = new System.Drawing.Size(76, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationMemoExEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(348, 72);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(348, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(720, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectBankAccountsTableAdapter
            // 
            this.spSelectBankAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllBankAccountsTableAdapter
            // 
            this.spSelectAllBankAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // cOATableAdapter
            // 
            this.cOATableAdapter.ClearBeforeFill = true;
            // 
            // frmBankAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmBankAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Accounts";
            this.Load += new System.EventHandler(this.frmBankAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllBankAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectBankAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBalanceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllowOverdraftCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverdraftLimitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GLAccLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGLAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMinBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAllowOverdraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOverdraftLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource spSelectBankAccountsBindingSource;
        private Class.DataSet.dsBankAccounts dsBankAccounts;
        private DevExpress.XtraEditors.TextEdit AccNameTextEdit;
        private DevExpress.XtraEditors.TextEdit AccNumberTextEdit;
        private DevExpress.XtraEditors.DateEdit EffectiveDateDateEdit;
        private DevExpress.XtraEditors.TextEdit MinBalanceTextEdit;
        private DevExpress.XtraEditors.CheckEdit AllowOverdraftCheckEdit;
        private DevExpress.XtraEditors.TextEdit OverdraftLimitTextEdit;
        private DevExpress.XtraEditors.MemoExEdit NarrationMemoExEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGLAcc;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEffectiveDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMinBalance;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAllowOverdraft;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOverdraftLimit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsBankAccountsTableAdapters.spSelectBankAccountsTableAdapter spSelectBankAccountsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllBankAccountsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGLAcc;
        private DevExpress.XtraGrid.Columns.GridColumn colAccName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMinBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowOverdraft;
        private DevExpress.XtraGrid.Columns.GridColumn colOverdraftLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private Class.DataSet.dsBankAccountsTableAdapters.spSelectAllBankAccountsTableAdapter spSelectAllBankAccountsTableAdapter;
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
        private System.Windows.Forms.BindingSource cOABindingSource;
        private Class.DataSet.dsBankAccountsTableAdapters.COATableAdapter cOATableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit GLAccLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}