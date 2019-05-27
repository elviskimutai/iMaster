namespace Master.Forms
{
    partial class frmNHIFRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNHIFRates));
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
            this.spSelectAllNHIFRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNHIFRates = new Master.Class.DataSet.dsNHIFRates();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRateType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromSalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectNHIFRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToSalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RateTypeComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EffectiveDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFromSalary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForToSalary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRateType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEffectiveDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectNHIFRatesTableAdapter = new Master.Class.DataSet.dsNHIFRatesTableAdapters.spSelectNHIFRatesTableAdapter();
            this.spSelectAllNHIFRatesTableAdapter = new Master.Class.DataSet.dsNHIFRatesTableAdapters.spSelectAllNHIFRatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllNHIFRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNHIFRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectNHIFRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTypeComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRateType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.FromSalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ToSalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RateTypeComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.RateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EffectiveDateDateEdit);
            this.dataLayoutControl1.DataSource = this.spSelectNHIFRatesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(594, 414);
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
            this.toolStrip1.Size = new System.Drawing.Size(570, 20);
            this.toolStrip1.TabIndex = 19;
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
            this.gridControl1.DataSource = this.spSelectAllNHIFRatesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 108);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(570, 294);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllNHIFRatesBindingSource
            // 
            this.spSelectAllNHIFRatesBindingSource.DataMember = "spSelectAllNHIFRates";
            this.spSelectAllNHIFRatesBindingSource.DataSource = this.dsNHIFRates;
            // 
            // dsNHIFRates
            // 
            this.dsNHIFRates.DataSetName = "dsNHIFRates";
            this.dsNHIFRates.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colFromSalary,
            this.colToSalary,
            this.colRateType,
            this.colRate,
            this.colEffectiveDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colFromSalary
            // 
            this.colFromSalary.FieldName = "FromSalary";
            this.colFromSalary.Name = "colFromSalary";
            this.colFromSalary.Visible = true;
            this.colFromSalary.VisibleIndex = 1;
            // 
            // colToSalary
            // 
            this.colToSalary.FieldName = "ToSalary";
            this.colToSalary.Name = "colToSalary";
            this.colToSalary.Visible = true;
            this.colToSalary.VisibleIndex = 2;
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
            // FromSalaryTextEdit
            // 
            this.FromSalaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectNHIFRatesBindingSource, "FromSalary", true));
            this.FromSalaryTextEdit.Location = new System.Drawing.Point(84, 36);
            this.FromSalaryTextEdit.Name = "FromSalaryTextEdit";
            this.FromSalaryTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.FromSalaryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FromSalaryTextEdit.Properties.Mask.EditMask = "G";
            this.FromSalaryTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.FromSalaryTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.FromSalaryTextEdit.Size = new System.Drawing.Size(211, 20);
            this.FromSalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.FromSalaryTextEdit.TabIndex = 4;
            // 
            // spSelectNHIFRatesBindingSource
            // 
            this.spSelectNHIFRatesBindingSource.DataMember = "spSelectNHIFRates";
            this.spSelectNHIFRatesBindingSource.DataSource = this.dsNHIFRates;
            // 
            // ToSalaryTextEdit
            // 
            this.ToSalaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectNHIFRatesBindingSource, "ToSalary", true));
            this.ToSalaryTextEdit.Location = new System.Drawing.Point(371, 36);
            this.ToSalaryTextEdit.Name = "ToSalaryTextEdit";
            this.ToSalaryTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ToSalaryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ToSalaryTextEdit.Properties.Mask.EditMask = "G";
            this.ToSalaryTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ToSalaryTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ToSalaryTextEdit.Size = new System.Drawing.Size(211, 20);
            this.ToSalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.ToSalaryTextEdit.TabIndex = 5;
            // 
            // RateTypeComboBoxEdit
            // 
            this.RateTypeComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectNHIFRatesBindingSource, "RateType", true));
            this.RateTypeComboBoxEdit.Location = new System.Drawing.Point(84, 60);
            this.RateTypeComboBoxEdit.Name = "RateTypeComboBoxEdit";
            this.RateTypeComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RateTypeComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Amount",
            "Percentage"});
            this.RateTypeComboBoxEdit.Size = new System.Drawing.Size(211, 20);
            this.RateTypeComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.RateTypeComboBoxEdit.TabIndex = 6;
            // 
            // RateTextEdit
            // 
            this.RateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectNHIFRatesBindingSource, "Rate", true));
            this.RateTextEdit.Location = new System.Drawing.Point(371, 60);
            this.RateTextEdit.Name = "RateTextEdit";
            this.RateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.RateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RateTextEdit.Properties.Mask.EditMask = "F";
            this.RateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.RateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.RateTextEdit.Size = new System.Drawing.Size(211, 20);
            this.RateTextEdit.StyleController = this.dataLayoutControl1;
            this.RateTextEdit.TabIndex = 7;
            // 
            // EffectiveDateDateEdit
            // 
            this.EffectiveDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectNHIFRatesBindingSource, "EffectiveDate", true));
            this.EffectiveDateDateEdit.EditValue = null;
            this.EffectiveDateDateEdit.Location = new System.Drawing.Point(84, 84);
            this.EffectiveDateDateEdit.Name = "EffectiveDateDateEdit";
            this.EffectiveDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Size = new System.Drawing.Size(498, 20);
            this.EffectiveDateDateEdit.StyleController = this.dataLayoutControl1;
            this.EffectiveDateDateEdit.TabIndex = 8;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(594, 414);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFromSalary,
            this.ItemForToSalary,
            this.ItemForRateType,
            this.ItemForRate,
            this.ItemForEffectiveDate,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(574, 96);
            // 
            // ItemForFromSalary
            // 
            this.ItemForFromSalary.Control = this.FromSalaryTextEdit;
            this.ItemForFromSalary.Location = new System.Drawing.Point(0, 24);
            this.ItemForFromSalary.Name = "ItemForFromSalary";
            this.ItemForFromSalary.Size = new System.Drawing.Size(287, 24);
            this.ItemForFromSalary.Text = "From Salary";
            this.ItemForFromSalary.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForToSalary
            // 
            this.ItemForToSalary.Control = this.ToSalaryTextEdit;
            this.ItemForToSalary.Location = new System.Drawing.Point(287, 24);
            this.ItemForToSalary.Name = "ItemForToSalary";
            this.ItemForToSalary.Size = new System.Drawing.Size(287, 24);
            this.ItemForToSalary.Text = "To Salary";
            this.ItemForToSalary.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForRateType
            // 
            this.ItemForRateType.Control = this.RateTypeComboBoxEdit;
            this.ItemForRateType.Location = new System.Drawing.Point(0, 48);
            this.ItemForRateType.Name = "ItemForRateType";
            this.ItemForRateType.Size = new System.Drawing.Size(287, 24);
            this.ItemForRateType.Text = "Rate Type";
            this.ItemForRateType.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForRate
            // 
            this.ItemForRate.Control = this.RateTextEdit;
            this.ItemForRate.Location = new System.Drawing.Point(287, 48);
            this.ItemForRate.Name = "ItemForRate";
            this.ItemForRate.Size = new System.Drawing.Size(287, 24);
            this.ItemForRate.Text = "Rate";
            this.ItemForRate.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForEffectiveDate
            // 
            this.ItemForEffectiveDate.Control = this.EffectiveDateDateEdit;
            this.ItemForEffectiveDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForEffectiveDate.Name = "ItemForEffectiveDate";
            this.ItemForEffectiveDate.Size = new System.Drawing.Size(574, 24);
            this.ItemForEffectiveDate.Text = "Effective Date";
            this.ItemForEffectiveDate.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(574, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(574, 298);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectNHIFRatesTableAdapter
            // 
            this.spSelectNHIFRatesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllNHIFRatesTableAdapter
            // 
            this.spSelectAllNHIFRatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmNHIFRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 414);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmNHIFRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHIF Rates";
            this.Load += new System.EventHandler(this.frmNHIFRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllNHIFRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNHIFRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectNHIFRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToSalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTypeComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFromSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForToSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRateType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit FromSalaryTextEdit;
        private System.Windows.Forms.BindingSource spSelectNHIFRatesBindingSource;
        private Class.DataSet.dsNHIFRates dsNHIFRates;
        private DevExpress.XtraEditors.TextEdit ToSalaryTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit RateTypeComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit RateTextEdit;
        private DevExpress.XtraEditors.DateEdit EffectiveDateDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFromSalary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForToSalary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRateType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEffectiveDate;
        private Class.DataSet.dsNHIFRatesTableAdapters.spSelectNHIFRatesTableAdapter spSelectNHIFRatesTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private System.Windows.Forms.BindingSource spSelectAllNHIFRatesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFromSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colToSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colRateType;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private Class.DataSet.dsNHIFRatesTableAdapters.spSelectAllNHIFRatesTableAdapter spSelectAllNHIFRatesTableAdapter;
    }
}