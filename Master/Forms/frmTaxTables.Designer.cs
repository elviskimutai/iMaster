namespace Master.Forms
{
    partial class frmTaxTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaxTables));
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
            this.spSelectAllTaxTablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTaxTables = new Master.Class.DataSet.dsTaxTables();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAuthority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectTaxTablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxDescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TaxRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EffectiveDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.TaxAuthorityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTaxCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxAuthority = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEffectiveDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectTaxTablesTableAdapter = new Master.Class.DataSet.dsTaxTablesTableAdapters.spSelectTaxTablesTableAdapter();
            this.spSelectAllTaxTablesTableAdapter = new Master.Class.DataSet.dsTaxTablesTableAdapters.spSelectAllTaxTablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllTaxTablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTaxTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectTaxTablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxAuthorityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxAuthority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.TaxCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxDescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EffectiveDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxAuthorityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectTaxTablesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(623, 369);
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
            this.toolStrip1.Size = new System.Drawing.Size(599, 21);
            this.toolStrip1.TabIndex = 20;
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
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 18);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 21);
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
            this.gridControl1.DataSource = this.spSelectAllTaxTablesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 151);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(599, 206);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllTaxTablesBindingSource
            // 
            this.spSelectAllTaxTablesBindingSource.DataMember = "spSelectAllTaxTables";
            this.spSelectAllTaxTablesBindingSource.DataSource = this.dsTaxTables;
            // 
            // dsTaxTables
            // 
            this.dsTaxTables.DataSetName = "dsTaxTables";
            this.dsTaxTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTaxCode,
            this.colTaxDescription,
            this.colTaxRate,
            this.colEffectiveDate,
            this.colTaxAuthority,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colTaxCode
            // 
            this.colTaxCode.FieldName = "TaxCode";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.Visible = true;
            this.colTaxCode.VisibleIndex = 0;
            // 
            // colTaxDescription
            // 
            this.colTaxDescription.FieldName = "TaxDescription";
            this.colTaxDescription.Name = "colTaxDescription";
            this.colTaxDescription.Visible = true;
            this.colTaxDescription.VisibleIndex = 1;
            // 
            // colTaxRate
            // 
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 2;
            // 
            // colEffectiveDate
            // 
            this.colEffectiveDate.FieldName = "EffectiveDate";
            this.colEffectiveDate.Name = "colEffectiveDate";
            this.colEffectiveDate.Visible = true;
            this.colEffectiveDate.VisibleIndex = 3;
            // 
            // colTaxAuthority
            // 
            this.colTaxAuthority.FieldName = "TaxAuthority";
            this.colTaxAuthority.Name = "colTaxAuthority";
            this.colTaxAuthority.Visible = true;
            this.colTaxAuthority.VisibleIndex = 4;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 5;
            // 
            // TaxCodeTextEdit
            // 
            this.TaxCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectTaxTablesBindingSource, "TaxCode", true));
            this.TaxCodeTextEdit.Location = new System.Drawing.Point(101, 67);
            this.TaxCodeTextEdit.Name = "TaxCodeTextEdit";
            this.TaxCodeTextEdit.Size = new System.Drawing.Size(209, 20);
            this.TaxCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxCodeTextEdit.TabIndex = 4;
            // 
            // spSelectTaxTablesBindingSource
            // 
            this.spSelectTaxTablesBindingSource.DataMember = "spSelectTaxTables";
            this.spSelectTaxTablesBindingSource.DataSource = this.dsTaxTables;
            // 
            // TaxDescriptionTextEdit
            // 
            this.TaxDescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectTaxTablesBindingSource, "TaxDescription", true));
            this.TaxDescriptionTextEdit.Location = new System.Drawing.Point(391, 67);
            this.TaxDescriptionTextEdit.Name = "TaxDescriptionTextEdit";
            this.TaxDescriptionTextEdit.Size = new System.Drawing.Size(208, 20);
            this.TaxDescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxDescriptionTextEdit.TabIndex = 5;
            // 
            // TaxRateTextEdit
            // 
            this.TaxRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectTaxTablesBindingSource, "TaxRate", true));
            this.TaxRateTextEdit.Location = new System.Drawing.Point(101, 91);
            this.TaxRateTextEdit.Name = "TaxRateTextEdit";
            this.TaxRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TaxRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TaxRateTextEdit.Properties.Mask.EditMask = "F";
            this.TaxRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TaxRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TaxRateTextEdit.Size = new System.Drawing.Size(209, 20);
            this.TaxRateTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxRateTextEdit.TabIndex = 6;
            // 
            // EffectiveDateDateEdit
            // 
            this.EffectiveDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectTaxTablesBindingSource, "EffectiveDate", true));
            this.EffectiveDateDateEdit.EditValue = null;
            this.EffectiveDateDateEdit.Location = new System.Drawing.Point(391, 91);
            this.EffectiveDateDateEdit.Name = "EffectiveDateDateEdit";
            this.EffectiveDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDateDateEdit.Size = new System.Drawing.Size(208, 20);
            this.EffectiveDateDateEdit.StyleController = this.dataLayoutControl1;
            this.EffectiveDateDateEdit.TabIndex = 7;
            // 
            // TaxAuthorityTextEdit
            // 
            this.TaxAuthorityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectTaxTablesBindingSource, "TaxAuthority", true));
            this.TaxAuthorityTextEdit.Location = new System.Drawing.Point(101, 115);
            this.TaxAuthorityTextEdit.Name = "TaxAuthorityTextEdit";
            this.TaxAuthorityTextEdit.Size = new System.Drawing.Size(209, 20);
            this.TaxAuthorityTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxAuthorityTextEdit.TabIndex = 8;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectTaxTablesBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(391, 115);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(208, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 9;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(623, 369);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(603, 139);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(603, 25);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTaxCode,
            this.ItemForTaxRate,
            this.ItemForTaxAuthority,
            this.ItemForTaxDescription,
            this.ItemForEffectiveDate,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 25);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(603, 114);
            this.layoutControlGroup3.Text = "Tax Tables";
            // 
            // ItemForTaxCode
            // 
            this.ItemForTaxCode.Control = this.TaxCodeTextEdit;
            this.ItemForTaxCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForTaxCode.Name = "ItemForTaxCode";
            this.ItemForTaxCode.Size = new System.Drawing.Size(290, 24);
            this.ItemForTaxCode.Text = "Tax Code";
            this.ItemForTaxCode.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForTaxRate
            // 
            this.ItemForTaxRate.Control = this.TaxRateTextEdit;
            this.ItemForTaxRate.Location = new System.Drawing.Point(0, 24);
            this.ItemForTaxRate.Name = "ItemForTaxRate";
            this.ItemForTaxRate.Size = new System.Drawing.Size(290, 24);
            this.ItemForTaxRate.Text = "Tax Rate";
            this.ItemForTaxRate.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForTaxAuthority
            // 
            this.ItemForTaxAuthority.Control = this.TaxAuthorityTextEdit;
            this.ItemForTaxAuthority.Location = new System.Drawing.Point(0, 48);
            this.ItemForTaxAuthority.Name = "ItemForTaxAuthority";
            this.ItemForTaxAuthority.Size = new System.Drawing.Size(290, 24);
            this.ItemForTaxAuthority.Text = "Tax Authority";
            this.ItemForTaxAuthority.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForTaxDescription
            // 
            this.ItemForTaxDescription.Control = this.TaxDescriptionTextEdit;
            this.ItemForTaxDescription.Location = new System.Drawing.Point(290, 0);
            this.ItemForTaxDescription.Name = "ItemForTaxDescription";
            this.ItemForTaxDescription.Size = new System.Drawing.Size(289, 24);
            this.ItemForTaxDescription.Text = "Tax Description";
            this.ItemForTaxDescription.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForEffectiveDate
            // 
            this.ItemForEffectiveDate.Control = this.EffectiveDateDateEdit;
            this.ItemForEffectiveDate.Location = new System.Drawing.Point(290, 24);
            this.ItemForEffectiveDate.Name = "ItemForEffectiveDate";
            this.ItemForEffectiveDate.Size = new System.Drawing.Size(289, 24);
            this.ItemForEffectiveDate.Text = "Effective Date";
            this.ItemForEffectiveDate.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(290, 48);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(289, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 139);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(603, 210);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // spSelectTaxTablesTableAdapter
            // 
            this.spSelectTaxTablesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllTaxTablesTableAdapter
            // 
            this.spSelectAllTaxTablesTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaxTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 369);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmTaxTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Tables";
            this.Load += new System.EventHandler(this.frmTaxTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllTaxTablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTaxTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectTaxTablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxDescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxAuthorityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxAuthority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit TaxCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectTaxTablesBindingSource;
        private Class.DataSet.dsTaxTables dsTaxTables;
        private DevExpress.XtraEditors.TextEdit TaxDescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit TaxRateTextEdit;
        private DevExpress.XtraEditors.DateEdit EffectiveDateDateEdit;
        private DevExpress.XtraEditors.TextEdit TaxAuthorityTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEffectiveDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxAuthority;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsTaxTablesTableAdapters.spSelectTaxTablesTableAdapter spSelectTaxTablesTableAdapter;
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
        private System.Windows.Forms.BindingSource spSelectAllTaxTablesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAuthority;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private Class.DataSet.dsTaxTablesTableAdapters.spSelectAllTaxTablesTableAdapter spSelectAllTaxTablesTableAdapter;
    }
}