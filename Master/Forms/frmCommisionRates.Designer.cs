namespace Master.Forms
{
    partial class frmCommisionRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommisionRates));
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
            this.spSelectAllCommisionRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCommissionRates = new Master.Class.DataSet.dsCommissionRates();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRateType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectCommisionRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToAmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RateTypeComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EffectiveDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFromAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRateType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEffectiveDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectCommisionRatesTableAdapter = new Master.Class.DataSet.dsCommissionRatesTableAdapters.spSelectCommisionRatesTableAdapter();
            this.spSelectAllCommisionRatesTableAdapter = new Master.Class.DataSet.dsCommissionRatesTableAdapters.spSelectAllCommisionRatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCommisionRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommissionRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCommisionRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToAmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTypeComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRateType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.FromAmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ToAmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RateTypeComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.RateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EffectiveDateDateEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCommisionRatesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(574, 347);
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
            this.toolStrip1.Size = new System.Drawing.Size(550, 20);
            this.toolStrip1.TabIndex = 18;
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
            this.gridControl1.DataSource = this.spSelectAllCommisionRatesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 185);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllCommisionRatesBindingSource
            // 
            this.spSelectAllCommisionRatesBindingSource.DataMember = "spSelectAllCommisionRates";
            this.spSelectAllCommisionRatesBindingSource.DataSource = this.dsCommissionRates;
            // 
            // dsCommissionRates
            // 
            this.dsCommissionRates.DataSetName = "dsCommissionRates";
            this.dsCommissionRates.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colFromAmount,
            this.colToAmount,
            this.colRateType,
            this.colRate,
            this.colEffectiveDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colFromAmount
            // 
            this.colFromAmount.FieldName = "FromAmount";
            this.colFromAmount.Name = "colFromAmount";
            this.colFromAmount.Visible = true;
            this.colFromAmount.VisibleIndex = 1;
            // 
            // colToAmount
            // 
            this.colToAmount.FieldName = "ToAmount";
            this.colToAmount.Name = "colToAmount";
            this.colToAmount.Visible = true;
            this.colToAmount.VisibleIndex = 2;
            // 
            // colRateType
            // 
            this.colRateType.FieldName = "RateType";
            this.colRateType.Name = "colRateType";
            this.colRateType.Visible = true;
            this.colRateType.VisibleIndex = 3;
            // 
            // colRate
            // 
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Visible = true;
            this.colRate.VisibleIndex = 4;
            // 
            // colEffectiveDate
            // 
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 5;
            // 
            // FromAmountTextEdit
            // 
            this.FromAmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommisionRatesBindingSource, "FromAmount", true));
            this.FromAmountTextEdit.Location = new System.Drawing.Point(96, 66);
            this.FromAmountTextEdit.Name = "FromAmountTextEdit";
            this.FromAmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.FromAmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FromAmountTextEdit.Properties.Mask.EditMask = "G";
            this.FromAmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.FromAmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.FromAmountTextEdit.Size = new System.Drawing.Size(189, 20);
            this.FromAmountTextEdit.StyleController = this.dataLayoutControl1;
            this.FromAmountTextEdit.TabIndex = 4;
            // 
            // spSelectCommisionRatesBindingSource
            // 
            this.spSelectCommisionRatesBindingSource.DataMember = "spSelectCommisionRates";
            this.spSelectCommisionRatesBindingSource.DataSource = this.dsCommissionRates;
            // 
            // ToAmountTextEdit
            // 
            this.ToAmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommisionRatesBindingSource, "ToAmount", true));
            this.ToAmountTextEdit.Location = new System.Drawing.Point(361, 66);
            this.ToAmountTextEdit.Name = "ToAmountTextEdit";
            this.ToAmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ToAmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ToAmountTextEdit.Properties.Mask.EditMask = "G";
            this.ToAmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ToAmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ToAmountTextEdit.Size = new System.Drawing.Size(189, 20);
            this.ToAmountTextEdit.StyleController = this.dataLayoutControl1;
            this.ToAmountTextEdit.TabIndex = 5;
            // 
            // RateTypeComboBoxEdit
            // 
            this.RateTypeComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectCommisionRatesBindingSource, "RateType", true));
            this.RateTypeComboBoxEdit.Location = new System.Drawing.Point(96, 90);
            this.RateTypeComboBoxEdit.Name = "RateTypeComboBoxEdit";
            this.RateTypeComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RateTypeComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Amount",
            "Percentage"});
            this.RateTypeComboBoxEdit.Size = new System.Drawing.Size(189, 20);
            this.RateTypeComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.RateTypeComboBoxEdit.TabIndex = 6;
            // 
            // RateTextEdit
            // 
            this.RateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommisionRatesBindingSource, "Rate", true));
            this.RateTextEdit.Location = new System.Drawing.Point(361, 90);
            this.RateTextEdit.Name = "RateTextEdit";
            this.RateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.RateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RateTextEdit.Properties.Mask.EditMask = "F";
            this.RateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.RateTextEdit.Size = new System.Drawing.Size(189, 20);
            this.RateTextEdit.StyleController = this.dataLayoutControl1;
            this.RateTextEdit.TabIndex = 7;
            // 
            // EffectiveDateDateEdit
            // 
            this.EffectiveDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCommisionRatesBindingSource, "EffectiveDate", true));
            this.EffectiveDateDateEdit.EditValue = null;
            this.EffectiveDateDateEdit.Location = new System.Drawing.Point(96, 114);
            this.EffectiveDateDateEdit.Name = "EffectiveDateDateEdit";
            this.EffectiveDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Size = new System.Drawing.Size(454, 20);
            this.EffectiveDateDateEdit.StyleController = this.dataLayoutControl1;
            this.EffectiveDateDateEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(574, 347);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(554, 327);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(554, 189);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFromAmount,
            this.ItemForRateType,
            this.ItemForEffectiveDate,
            this.ItemForToAmount,
            this.ItemForRate});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(554, 114);
            this.layoutControlGroup3.Text = "Commission Rates";
            // 
            // ItemForFromAmount
            // 
            this.ItemForFromAmount.Control = this.FromAmountTextEdit;
            this.ItemForFromAmount.Location = new System.Drawing.Point(0, 0);
            this.ItemForFromAmount.Name = "ItemForFromAmount";
            this.ItemForFromAmount.Size = new System.Drawing.Size(265, 24);
            this.ItemForFromAmount.Text = "From Amount";
            this.ItemForFromAmount.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForRateType
            // 
            this.ItemForRateType.Control = this.RateTypeComboBoxEdit;
            this.ItemForRateType.Location = new System.Drawing.Point(0, 24);
            this.ItemForRateType.Name = "ItemForRateType";
            this.ItemForRateType.Size = new System.Drawing.Size(265, 24);
            this.ItemForRateType.Text = "Rate Type";
            this.ItemForRateType.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForEffectiveDate
            // 
            this.ItemForEffectiveDate.Control = this.EffectiveDateDateEdit;
            this.ItemForEffectiveDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForEffectiveDate.Name = "ItemForEffectiveDate";
            this.ItemForEffectiveDate.Size = new System.Drawing.Size(530, 24);
            this.ItemForEffectiveDate.Text = "Effective Date";
            this.ItemForEffectiveDate.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForToAmount
            // 
            this.ItemForToAmount.Control = this.ToAmountTextEdit;
            this.ItemForToAmount.Location = new System.Drawing.Point(265, 0);
            this.ItemForToAmount.Name = "ItemForToAmount";
            this.ItemForToAmount.Size = new System.Drawing.Size(265, 24);
            this.ItemForToAmount.Text = "To Amount";
            this.ItemForToAmount.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForRate
            // 
            this.ItemForRate.Control = this.RateTextEdit;
            this.ItemForRate.Location = new System.Drawing.Point(265, 24);
            this.ItemForRate.Name = "ItemForRate";
            this.ItemForRate.Size = new System.Drawing.Size(265, 24);
            this.ItemForRate.Text = "Rate";
            this.ItemForRate.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(554, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectCommisionRatesTableAdapter
            // 
            this.spSelectCommisionRatesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllCommisionRatesTableAdapter
            // 
            this.spSelectAllCommisionRatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmCommisionRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 347);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCommisionRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commision Rates";
            this.Load += new System.EventHandler(this.frmCommisionRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCommisionRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommissionRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCommisionRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToAmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTypeComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRateType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit FromAmountTextEdit;
        private System.Windows.Forms.BindingSource spSelectCommisionRatesBindingSource;
        private Class.DataSet.dsCommissionRates dsCommissionRates;
        private DevExpress.XtraEditors.TextEdit ToAmountTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit RateTypeComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit RateTextEdit;
        private DevExpress.XtraEditors.DateEdit EffectiveDateDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRateType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEffectiveDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRate;
        private Class.DataSet.dsCommissionRatesTableAdapters.spSelectCommisionRatesTableAdapter spSelectCommisionRatesTableAdapter;
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
        private System.Windows.Forms.BindingSource spSelectAllCommisionRatesBindingSource;
        private Class.DataSet.dsCommissionRatesTableAdapters.spSelectAllCommisionRatesTableAdapter spSelectAllCommisionRatesTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFromAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colToAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRateType;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
    }
}