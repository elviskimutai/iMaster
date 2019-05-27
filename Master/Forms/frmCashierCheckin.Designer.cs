namespace Master.Forms
{
    partial class frmCashierCheckin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashierCheckin));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Submit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllCashierCheckinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCashierCheckin = new Master.Class.DataSet.dsCashierCheckin();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCashier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostCenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashier1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostCenterGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spSelectCashierCheckinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectCashierCheckinTableAdapter = new Master.Class.DataSet.dsCashierCheckinTableAdapters.spSelectCashierCheckinTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsCashierCheckinTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spSelectAllCashierCheckinTableAdapter = new Master.Class.DataSet.dsCashierCheckinTableAdapters.spSelectAllCashierCheckinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCashierCheckinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCashierCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCashierCheckinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CostCenterGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectCashierCheckinBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(814, 368);
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
            this.Submit,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(584, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 20);
            this.toolStrip1.TabIndex = 27;
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
            // Submit
            // 
            this.Submit.Image = ((System.Drawing.Image)(resources.GetObject("Submit.Image")));
            this.Submit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(47, 17);
            this.Submit.Text = "Edit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
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
            this.gridControl1.DataSource = this.spSelectAllCashierCheckinBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 230);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllCashierCheckinBindingSource
            // 
            this.spSelectAllCashierCheckinBindingSource.DataMember = "spSelectAllCashierCheckin";
            this.spSelectAllCashierCheckinBindingSource.DataSource = this.dsCashierCheckin;
            // 
            // dsCashierCheckin
            // 
            this.dsCashierCheckin.DataSetName = "dsCashierCheckin";
            this.dsCashierCheckin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCashier,
            this.colCostCenter,
            this.colBusinessDate,
            this.colAmount,
            this.colCashier1,
            this.colRemarks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCashier
            // 
            this.colCashier.FieldName = "Cashier";
            this.colCashier.Name = "colCashier";
            this.colCashier.Visible = true;
            this.colCashier.VisibleIndex = 0;
            // 
            // colCostCenter
            // 
            this.colCostCenter.FieldName = "CostCenter";
            this.colCostCenter.Name = "colCostCenter";
            this.colCostCenter.Visible = true;
            this.colCostCenter.VisibleIndex = 1;
            // 
            // colBusinessDate
            // 
            this.colBusinessDate.FieldName = "BusinessDate";
            this.colBusinessDate.Name = "colBusinessDate";
            this.colBusinessDate.Visible = true;
            this.colBusinessDate.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colCashier1
            // 
            this.colCashier1.FieldName = "Cashier1";
            this.colCashier1.Name = "colCashier1";
            this.colCashier1.Visible = true;
            this.colCashier1.VisibleIndex = 4;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 5;
            // 
            // CostCenterGridLookUpEdit
            // 
            this.CostCenterGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCashierCheckinBindingSource, "CostCenter", true));
            this.CostCenterGridLookUpEdit.Location = new System.Drawing.Point(85, 66);
            this.CostCenterGridLookUpEdit.Name = "CostCenterGridLookUpEdit";
            this.CostCenterGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterGridLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterGridLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterGridLookUpEdit.Properties.NullText = "";
            this.CostCenterGridLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.CostCenterGridLookUpEdit.Size = new System.Drawing.Size(320, 20);
            this.CostCenterGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterGridLookUpEdit.TabIndex = 4;
            // 
            // spSelectCashierCheckinBindingSource
            // 
            this.spSelectCashierCheckinBindingSource.DataMember = "spSelectCashierCheckin";
            this.spSelectCashierCheckinBindingSource.DataSource = this.dsCashierCheckin;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsCashierCheckin;
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
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCashierCheckinBindingSource, "Amount", true));
            this.AmountTextEdit.Location = new System.Drawing.Point(470, 66);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "G";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(320, 20);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 5;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectCashierCheckinBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(85, 90);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(320, 20);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(814, 368);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(794, 348);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 234);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCostCenter,
            this.ItemForRemarks,
            this.ItemForAmount});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(794, 90);
            this.layoutControlGroup3.Text = "Cashier Checkin";
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterGridLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(385, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 24);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(385, 24);
            this.ItemForRemarks.Text = "Remarks";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(58, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(385, 0);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(385, 48);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(794, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectCashierCheckinTableAdapter
            // 
            this.spSelectCashierCheckinTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllCashierCheckinTableAdapter
            // 
            this.spSelectAllCashierCheckinTableAdapter.ClearBeforeFill = true;
            // 
            // frmCashierCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 368);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCashierCheckin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cashier Checkin";
            this.Load += new System.EventHandler(this.frmCashierCheckin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllCashierCheckinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCashierCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCashierCheckinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GridLookUpEdit CostCenterGridLookUpEdit;
        private System.Windows.Forms.BindingSource spSelectCashierCheckinBindingSource;
        private Class.DataSet.dsCashierCheckin dsCashierCheckin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private Class.DataSet.dsCashierCheckinTableAdapters.spSelectCashierCheckinTableAdapter spSelectCashierCheckinTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsCashierCheckinTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spSelectAllCashierCheckinBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCashier;
        private DevExpress.XtraGrid.Columns.GridColumn colCostCenter;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCashier1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private Class.DataSet.dsCashierCheckinTableAdapters.spSelectAllCashierCheckinTableAdapter spSelectAllCashierCheckinTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Submit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}