namespace Master.Forms
{
    partial class frmPostingPeriods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostingPeriods));
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
            this.spSelectAllPostingPeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPostigPeriods = new Master.Class.DataSet.dsPostigPeriods();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPriodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YearTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectPostingPeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.EndDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.StatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PeriodCodeComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPeriodCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForYear = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectPostingPeriodsTableAdapter = new Master.Class.DataSet.dsPostigPeriodsTableAdapters.spSelectPostingPeriodsTableAdapter();
            this.spSelectAllPostingPeriodsTableAdapter = new Master.Class.DataSet.dsPostigPeriodsTableAdapters.spSelectAllPostingPeriodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPostingPeriodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPostigPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPostingPeriodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodCodeComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPeriodCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.YearTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StartDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.EndDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.StatusComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.PeriodCodeComboBoxEdit);
            this.dataLayoutControl1.DataSource = this.spSelectPostingPeriodsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(640, 370);
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
            this.toolStrip1.Size = new System.Drawing.Size(616, 20);
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
            this.gridControl1.DataSource = this.spSelectAllPostingPeriodsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(616, 208);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllPostingPeriodsBindingSource
            // 
            this.spSelectAllPostingPeriodsBindingSource.DataMember = "spSelectAllPostingPeriods";
            this.spSelectAllPostingPeriodsBindingSource.DataSource = this.dsPostigPeriods;
            // 
            // dsPostigPeriods
            // 
            this.dsPostigPeriods.DataSetName = "dsPostigPeriods";
            this.dsPostigPeriods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriodCode,
            this.colYear,
            this.colStartDate,
            this.colEndDate,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colPriodCode
            // 
            this.colPriodCode.Caption = "PriodCode";
            this.colPriodCode.FieldName = "PeriodCode";
            this.colPriodCode.Name = "colPriodCode";
            this.colPriodCode.Visible = true;
            this.colPriodCode.VisibleIndex = 0;
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 3;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            // 
            // YearTextEdit
            // 
            this.YearTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectPostingPeriodsBindingSource, "Year", true));
            this.YearTextEdit.Location = new System.Drawing.Point(383, 66);
            this.YearTextEdit.Name = "YearTextEdit";
            this.YearTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.YearTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.YearTextEdit.Properties.Mask.EditMask = "f0";
            this.YearTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.YearTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.YearTextEdit.Size = new System.Drawing.Size(233, 20);
            this.YearTextEdit.StyleController = this.dataLayoutControl1;
            this.YearTextEdit.TabIndex = 4;
            // 
            // spSelectPostingPeriodsBindingSource
            // 
            this.spSelectPostingPeriodsBindingSource.DataMember = "spSelectPostingPeriods";
            this.spSelectPostingPeriodsBindingSource.DataSource = this.dsPostigPeriods;
            // 
            // StartDateDateEdit
            // 
            this.StartDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPostingPeriodsBindingSource, "StartDate", true));
            this.StartDateDateEdit.EditValue = null;
            this.StartDateDateEdit.Location = new System.Drawing.Point(85, 90);
            this.StartDateDateEdit.Name = "StartDateDateEdit";
            this.StartDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateDateEdit.Size = new System.Drawing.Size(233, 20);
            this.StartDateDateEdit.StyleController = this.dataLayoutControl1;
            this.StartDateDateEdit.TabIndex = 5;
            this.StartDateDateEdit.EditValueChanged += new System.EventHandler(this.StartDateDateEdit_EditValueChanged);
            // 
            // EndDateDateEdit
            // 
            this.EndDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectPostingPeriodsBindingSource, "EndDate", true));
            this.EndDateDateEdit.EditValue = null;
            this.EndDateDateEdit.Location = new System.Drawing.Point(383, 90);
            this.EndDateDateEdit.Name = "EndDateDateEdit";
            this.EndDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateDateEdit.Size = new System.Drawing.Size(233, 20);
            this.EndDateDateEdit.StyleController = this.dataLayoutControl1;
            this.EndDateDateEdit.TabIndex = 6;
            // 
            // StatusComboBoxEdit
            // 
            this.StatusComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectPostingPeriodsBindingSource, "Status", true));
            this.StatusComboBoxEdit.Location = new System.Drawing.Point(383, 114);
            this.StatusComboBoxEdit.Name = "StatusComboBoxEdit";
            this.StatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.StatusComboBoxEdit.Size = new System.Drawing.Size(233, 20);
            this.StatusComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.StatusComboBoxEdit.TabIndex = 7;
            // 
            // PeriodCodeComboBoxEdit
            // 
            this.PeriodCodeComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectPostingPeriodsBindingSource, "PeriodCode", true));
            this.PeriodCodeComboBoxEdit.Location = new System.Drawing.Point(85, 66);
            this.PeriodCodeComboBoxEdit.Name = "PeriodCodeComboBoxEdit";
            this.PeriodCodeComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PeriodCodeComboBoxEdit.Properties.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.PeriodCodeComboBoxEdit.Size = new System.Drawing.Size(233, 20);
            this.PeriodCodeComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.PeriodCodeComboBoxEdit.TabIndex = 8;
            this.PeriodCodeComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.PeriodCodeComboBoxEdit_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(640, 370);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(620, 350);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(620, 212);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForStatus,
            this.ItemForPeriodCode,
            this.ItemForYear,
            this.ItemForStartDate,
            this.ItemForEndDate});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(620, 114);
            this.layoutControlGroup3.Text = "Accounting Periods";
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusComboBoxEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(298, 48);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(298, 24);
            this.ItemForStatus.Text = "Status";
            this.ItemForStatus.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForPeriodCode
            // 
            this.ItemForPeriodCode.Control = this.PeriodCodeComboBoxEdit;
            this.ItemForPeriodCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForPeriodCode.Name = "ItemForPeriodCode";
            this.ItemForPeriodCode.Size = new System.Drawing.Size(298, 24);
            this.ItemForPeriodCode.Text = "Period Code";
            this.ItemForPeriodCode.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForYear
            // 
            this.ItemForYear.Control = this.YearTextEdit;
            this.ItemForYear.Location = new System.Drawing.Point(298, 0);
            this.ItemForYear.Name = "ItemForYear";
            this.ItemForYear.Size = new System.Drawing.Size(298, 24);
            this.ItemForYear.Text = "Year";
            this.ItemForYear.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForStartDate
            // 
            this.ItemForStartDate.Control = this.StartDateDateEdit;
            this.ItemForStartDate.Location = new System.Drawing.Point(0, 24);
            this.ItemForStartDate.Name = "ItemForStartDate";
            this.ItemForStartDate.Size = new System.Drawing.Size(298, 48);
            this.ItemForStartDate.Text = "Start Date";
            this.ItemForStartDate.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForEndDate
            // 
            this.ItemForEndDate.Control = this.EndDateDateEdit;
            this.ItemForEndDate.Location = new System.Drawing.Point(298, 24);
            this.ItemForEndDate.Name = "ItemForEndDate";
            this.ItemForEndDate.Size = new System.Drawing.Size(298, 24);
            this.ItemForEndDate.Text = "End Date";
            this.ItemForEndDate.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(620, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectPostingPeriodsTableAdapter
            // 
            this.spSelectPostingPeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllPostingPeriodsTableAdapter
            // 
            this.spSelectAllPostingPeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // frmPostingPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmPostingPeriods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posting Periods";
            this.Load += new System.EventHandler(this.frmPostingPeriods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllPostingPeriodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPostigPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPostingPeriodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodCodeComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPeriodCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit YearTextEdit;
        private System.Windows.Forms.BindingSource spSelectPostingPeriodsBindingSource;
        private Class.DataSet.dsPostigPeriods dsPostigPeriods;
        private DevExpress.XtraEditors.DateEdit StartDateDateEdit;
        private DevExpress.XtraEditors.DateEdit EndDateDateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit StatusComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit PeriodCodeComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForYear;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEndDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPeriodCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStartDate;
        private Class.DataSet.dsPostigPeriodsTableAdapters.spSelectPostingPeriodsTableAdapter spSelectPostingPeriodsTableAdapter;
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
        private System.Windows.Forms.BindingSource spSelectAllPostingPeriodsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private Class.DataSet.dsPostigPeriodsTableAdapters.spSelectAllPostingPeriodsTableAdapter spSelectAllPostingPeriodsTableAdapter;
    }
}