namespace Master.Forms
{
    partial class frmExchangeRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExchangeRates));
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
            this.spSelectAllExchangeRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsExchangeRates = new Master.Class.DataSet.dsExchangeRates();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFromCurr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToCurr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMultiplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDivisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MultiplierTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectExchangeRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DivisorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EffectiveDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FromCurrTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToCurrTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFromCurr = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMultiplier = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEffectiveDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToCurr = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDivisor = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectExchangeRatesTableAdapter = new Master.Class.DataSet.dsExchangeRatesTableAdapters.spSelectExchangeRatesTableAdapter();
            this.currenciesTableAdapter = new Master.Class.DataSet.dsExchangeRatesTableAdapters.CurrenciesTableAdapter();
            this.spSelectAllExchangeRatesTableAdapter = new Master.Class.DataSet.dsExchangeRatesTableAdapters.spSelectAllExchangeRatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllExchangeRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchangeRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectExchangeRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromCurrTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToCurrTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDivisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.MultiplierTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DivisorTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EffectiveDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FromCurrTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ToCurrTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectExchangeRatesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(734, 378);
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
            this.toolStrip1.Size = new System.Drawing.Size(710, 20);
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
            this.gridControl1.DataSource = this.spSelectAllExchangeRatesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(710, 216);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllExchangeRatesBindingSource
            // 
            this.spSelectAllExchangeRatesBindingSource.DataMember = "spSelectAllExchangeRates";
            this.spSelectAllExchangeRatesBindingSource.DataSource = this.dsExchangeRates;
            // 
            // dsExchangeRates
            // 
            this.dsExchangeRates.DataSetName = "dsExchangeRates";
            this.dsExchangeRates.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFromCurr,
            this.colToCurr,
            this.colMultiplier,
            this.colDivisor,
            this.colEffectiveDate,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colFromCurr
            // 
            this.colFromCurr.FieldName = "FromCurr";
            this.colFromCurr.Name = "colFromCurr";
            this.colFromCurr.Visible = true;
            this.colFromCurr.VisibleIndex = 0;
            // 
            // colToCurr
            // 
            this.colToCurr.FieldName = "ToCurr";
            this.colToCurr.Name = "colToCurr";
            this.colToCurr.Visible = true;
            this.colToCurr.VisibleIndex = 1;
            // 
            // colMultiplier
            // 
            this.colMultiplier.FieldName = "Multiplier";
            this.colMultiplier.Name = "colMultiplier";
            this.colMultiplier.Visible = true;
            this.colMultiplier.VisibleIndex = 2;
            // 
            // colDivisor
            // 
            this.colDivisor.FieldName = "Divisor";
            this.colDivisor.Name = "colDivisor";
            this.colDivisor.Visible = true;
            this.colDivisor.VisibleIndex = 3;
            // 
            // colEffectiveDate
            // 
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 4;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 5;
            // 
            // MultiplierTextEdit
            // 
            this.MultiplierTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectExchangeRatesBindingSource, "Multiplier", true));
            this.MultiplierTextEdit.Location = new System.Drawing.Point(96, 90);
            this.MultiplierTextEdit.Name = "MultiplierTextEdit";
            this.MultiplierTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MultiplierTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MultiplierTextEdit.Properties.Mask.EditMask = "F";
            this.MultiplierTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MultiplierTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MultiplierTextEdit.Size = new System.Drawing.Size(269, 20);
            this.MultiplierTextEdit.StyleController = this.dataLayoutControl1;
            this.MultiplierTextEdit.TabIndex = 6;
            this.MultiplierTextEdit.EditValueChanged += new System.EventHandler(this.MultiplierTextEdit_EditValueChanged);
            // 
            // spSelectExchangeRatesBindingSource
            // 
            this.spSelectExchangeRatesBindingSource.DataMember = "spSelectExchangeRates";
            this.spSelectExchangeRatesBindingSource.DataSource = this.dsExchangeRates;
            // 
            // DivisorTextEdit
            // 
            this.DivisorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectExchangeRatesBindingSource, "Divisor", true));
            this.DivisorTextEdit.Location = new System.Drawing.Point(441, 90);
            this.DivisorTextEdit.Name = "DivisorTextEdit";
            this.DivisorTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DivisorTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DivisorTextEdit.Properties.Mask.EditMask = "f";
            this.DivisorTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DivisorTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DivisorTextEdit.Size = new System.Drawing.Size(269, 20);
            this.DivisorTextEdit.StyleController = this.dataLayoutControl1;
            this.DivisorTextEdit.TabIndex = 7;
            // 
            // EffectiveDateDateEdit
            // 
            this.EffectiveDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectExchangeRatesBindingSource, "EffectiveDate", true));
            this.EffectiveDateDateEdit.EditValue = null;
            this.EffectiveDateDateEdit.Location = new System.Drawing.Point(96, 114);
            this.EffectiveDateDateEdit.Name = "EffectiveDateDateEdit";
            this.EffectiveDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Size = new System.Drawing.Size(269, 20);
            this.EffectiveDateDateEdit.StyleController = this.dataLayoutControl1;
            this.EffectiveDateDateEdit.TabIndex = 8;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectExchangeRatesBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(441, 114);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(269, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 9;
            // 
            // FromCurrTextEdit
            // 
            this.FromCurrTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectExchangeRatesBindingSource, "FromCurr", true));
            this.FromCurrTextEdit.Location = new System.Drawing.Point(96, 66);
            this.FromCurrTextEdit.Name = "FromCurrTextEdit";
            this.FromCurrTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromCurrTextEdit.Properties.DataSource = this.currenciesBindingSource;
            this.FromCurrTextEdit.Properties.DisplayMember = "CurrDesc";
            this.FromCurrTextEdit.Properties.NullText = "";
            this.FromCurrTextEdit.Properties.ValueMember = "CurrCode";
            this.FromCurrTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.FromCurrTextEdit.Size = new System.Drawing.Size(269, 20);
            this.FromCurrTextEdit.StyleController = this.dataLayoutControl1;
            this.FromCurrTextEdit.TabIndex = 4;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.dsExchangeRates;
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
            // ToCurrTextEdit
            // 
            this.ToCurrTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectExchangeRatesBindingSource, "ToCurr", true));
            this.ToCurrTextEdit.Location = new System.Drawing.Point(441, 66);
            this.ToCurrTextEdit.Name = "ToCurrTextEdit";
            this.ToCurrTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToCurrTextEdit.Properties.DataSource = this.currenciesBindingSource;
            this.ToCurrTextEdit.Properties.DisplayMember = "CurrDesc";
            this.ToCurrTextEdit.Properties.NullText = "";
            this.ToCurrTextEdit.Properties.ValueMember = "CurrCode";
            this.ToCurrTextEdit.Properties.View = this.gridView2;
            this.ToCurrTextEdit.Size = new System.Drawing.Size(269, 20);
            this.ToCurrTextEdit.StyleController = this.dataLayoutControl1;
            this.ToCurrTextEdit.TabIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(734, 378);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(714, 138);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFromCurr,
            this.ItemForMultiplier,
            this.ItemForEffectiveDate,
            this.ItemForToCurr,
            this.ItemForDivisor,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(714, 114);
            this.layoutControlGroup3.Text = "Exchange Rates";
            // 
            // ItemForFromCurr
            // 
            this.ItemForFromCurr.Control = this.FromCurrTextEdit;
            this.ItemForFromCurr.Location = new System.Drawing.Point(0, 0);
            this.ItemForFromCurr.Name = "ItemForFromCurr";
            this.ItemForFromCurr.Size = new System.Drawing.Size(345, 24);
            this.ItemForFromCurr.Text = "From Curr";
            this.ItemForFromCurr.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForMultiplier
            // 
            this.ItemForMultiplier.Control = this.MultiplierTextEdit;
            this.ItemForMultiplier.Location = new System.Drawing.Point(0, 24);
            this.ItemForMultiplier.Name = "ItemForMultiplier";
            this.ItemForMultiplier.Size = new System.Drawing.Size(345, 24);
            this.ItemForMultiplier.Text = "Multiplier";
            this.ItemForMultiplier.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForEffectiveDate
            // 
            this.ItemForEffectiveDate.Control = this.EffectiveDateDateEdit;
            this.ItemForEffectiveDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForEffectiveDate.Name = "ItemForEffectiveDate";
            this.ItemForEffectiveDate.Size = new System.Drawing.Size(345, 24);
            this.ItemForEffectiveDate.Text = "Effective Date";
            this.ItemForEffectiveDate.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForToCurr
            // 
            this.ItemForToCurr.Control = this.ToCurrTextEdit;
            this.ItemForToCurr.Location = new System.Drawing.Point(345, 0);
            this.ItemForToCurr.Name = "ItemForToCurr";
            this.ItemForToCurr.Size = new System.Drawing.Size(345, 24);
            this.ItemForToCurr.Text = "To Curr";
            this.ItemForToCurr.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForDivisor
            // 
            this.ItemForDivisor.Control = this.DivisorTextEdit;
            this.ItemForDivisor.Location = new System.Drawing.Point(345, 24);
            this.ItemForDivisor.Name = "ItemForDivisor";
            this.ItemForDivisor.Size = new System.Drawing.Size(345, 24);
            this.ItemForDivisor.Text = "Divisor";
            this.ItemForDivisor.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(345, 48);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(345, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(714, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(714, 220);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectExchangeRatesTableAdapter
            // 
            this.spSelectExchangeRatesTableAdapter.ClearBeforeFill = true;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllExchangeRatesTableAdapter
            // 
            this.spSelectAllExchangeRatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 378);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmExchangeRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange Rates";
            this.Load += new System.EventHandler(this.frmExchangeRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllExchangeRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExchangeRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectExchangeRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromCurrTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToCurrTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDivisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource spSelectExchangeRatesBindingSource;
        private Class.DataSet.dsExchangeRates dsExchangeRates;
        private DevExpress.XtraEditors.TextEdit MultiplierTextEdit;
        private DevExpress.XtraEditors.TextEdit DivisorTextEdit;
        private DevExpress.XtraEditors.DateEdit EffectiveDateDateEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromCurr;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMultiplier;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEffectiveDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToCurr;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDivisor;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsExchangeRatesTableAdapters.spSelectExchangeRatesTableAdapter spSelectExchangeRatesTableAdapter;
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
        private DevExpress.XtraEditors.GridLookUpEdit FromCurrTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit ToCurrTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private Class.DataSet.dsExchangeRatesTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllExchangeRatesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFromCurr;
        private DevExpress.XtraGrid.Columns.GridColumn colToCurr;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiplier;
        private DevExpress.XtraGrid.Columns.GridColumn colDivisor;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private Class.DataSet.dsExchangeRatesTableAdapters.spSelectAllExchangeRatesTableAdapter spSelectAllExchangeRatesTableAdapter;
    }
}