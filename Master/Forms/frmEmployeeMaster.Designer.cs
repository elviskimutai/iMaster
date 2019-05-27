namespace Master.Forms
{
    partial class frmEmployeeMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeMaster));
            this.dsEmployeeMaster = new Master.Class.DataSet.dsEmployeeMaster();
            this.spSelectEmployeesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSelectEmployeesMasterTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.spSelectEmployeesMasterTableAdapter();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.glBank = new DevExpress.XtraEditors.GridLookUpEdit();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllEmployeesMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPINNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSSFNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsuranceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNationality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhysicalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasicSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostCenterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmpNamesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CountryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PINNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IDNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NSSFNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TaxTableTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.InsuranceNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DepartmentLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.userCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HireDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PayStartDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PayEndDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.LeaveStartDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.NationalityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PostalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhysicalAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsDisabledCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.DisabilityDescTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DOBDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.RetirementDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.MaritalStatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GenderComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LanguagesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SupervisorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.JobTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.userCodesJobtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobGradeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.userCodesJobGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PayFreqTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AnnualSalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BasicSalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HrsPerDayTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HourlyRateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PayPerHourCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.TaxableCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.NSSFExemptCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.NHIFExemptCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.OverTimeExemptCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ReviewTypeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BankBranchLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.bankBranchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AccNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PayStatusTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCostCenter = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpNames = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCounty = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPINNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIDNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNSSFNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxTable = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInsuranceNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDepartment = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHireDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLeaveStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNationality = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPostalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhysicalAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsDisabled = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDisabilityDesc = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDOB = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRetirementDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMaritalStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGender = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLanguages = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSupervisor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPayStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJobType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJobGrade = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayFreq = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBasicSalary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHrsPerDay = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHourlyRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPayPerHour = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTaxable = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNSSFExempt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNHIFExempt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOverTimeExempt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReviewType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAccName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBankBranch = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAnnualSalary = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectAllEmployeesMasterTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.spSelectAllEmployeesMasterTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.countriesTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.CountriesTableAdapter();
            this.userCodesTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.UserCodesTableAdapter();
            this.userCodesJobtypeTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.UserCodesJobtypeTableAdapter();
            this.userCodesJobGradeTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.UserCodesJobGradeTableAdapter();
            this.banksTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.BanksTableAdapter();
            this.bankBranchesTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.BankBranchesTableAdapter();
            this.countiesTableAdapter = new Master.Class.DataSet.dsEmployeeMasterTableAdapters.CountiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployeeMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmployeesMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllEmployeesMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNamesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PINNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSSFNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxTableTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HireDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HireDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStartDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStartDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayEndDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayEndDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveStartDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveStartDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationalityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsDisabledCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabilityDescTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetirementDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetirementDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritalStatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupervisorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesJobtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobGradeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesJobGradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayFreqTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualSalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasicSalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HrsPerDayTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourlyRateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayPerHourCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxableCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSSFExemptCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHIFExemptCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverTimeExemptCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankBranchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBranchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStatusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCounty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPINNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNSSFNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInsuranceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHireDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLeaveStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisabilityDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRetirementDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaritalStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLanguages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupervisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBasicSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHrsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHourlyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNSSFExempt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNHIFExempt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOverTimeExempt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReviewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAnnualSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dsEmployeeMaster
            // 
            this.dsEmployeeMaster.DataSetName = "dsEmployeeMaster";
            this.dsEmployeeMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSelectEmployeesMasterBindingSource
            // 
            this.spSelectEmployeesMasterBindingSource.DataMember = "spSelectEmployeesMaster";
            this.spSelectEmployeesMasterBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // spSelectEmployeesMasterTableAdapter
            // 
            this.spSelectEmployeesMasterTableAdapter.ClearBeforeFill = true;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.glBank);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CostCenterLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.EmpNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmpNamesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CountyLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.PINNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IDNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NSSFNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxTableTextEdit);
            this.dataLayoutControl1.Controls.Add(this.InsuranceNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DepartmentLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.HireDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.PayStartDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.PayEndDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.LeaveStartDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.NationalityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PostalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhysicalAddressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MobileTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsDisabledCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.DisabilityDescTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DOBDateEdit);
            this.dataLayoutControl1.Controls.Add(this.RetirementDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.MaritalStatusComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.GenderComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.LanguagesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SupervisorTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ImagePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.JobTypeLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.JobGradeLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.PayFreqTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AnnualSalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BasicSalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HrsPerDayTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HourlyRateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PayPerHourCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.TaxableCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.NSSFExemptCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.NHIFExemptCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.OverTimeExemptCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.ReviewTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.BankBranchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.AccNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AccNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PayStatusTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectEmployeesMasterBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(881, 546);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlNew,
            this.toolStripSeparator5,
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
            this.toolStrip1.Size = new System.Drawing.Size(857, 22);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlNew
            // 
            this.tlNew.Image = ((System.Drawing.Image)(resources.GetObject("tlNew.Image")));
            this.tlNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlNew.Name = "tlNew";
            this.tlNew.Size = new System.Drawing.Size(51, 19);
            this.tlNew.Text = "New";
            this.tlNew.Click += new System.EventHandler(this.tlNew_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 22);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 19);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 22);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 19);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 22);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 19);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 22);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 19);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 22);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 19);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // glBank
            // 
            this.glBank.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Bank", true));
            this.glBank.EditValue = "";
            this.glBank.Location = new System.Drawing.Point(115, 238);
            this.glBank.Name = "glBank";
            this.glBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glBank.Properties.DataSource = this.banksBindingSource;
            this.glBank.Properties.DisplayMember = "BankName";
            this.glBank.Properties.ValueMember = "BankCode";
            this.glBank.Properties.View = this.gridLookUpEdit1View;
            this.glBank.Size = new System.Drawing.Size(323, 20);
            this.glBank.StyleController = this.dataLayoutControl1;
            this.glBank.TabIndex = 51;
            this.glBank.EditValueChanged += new System.EventHandler(this.glBank_EditValueChanged);
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataMember = "Banks";
            this.banksBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllEmployeesMasterBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 298);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(857, 236);
            this.gridControl1.TabIndex = 50;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllEmployeesMasterBindingSource
            // 
            this.spSelectAllEmployeesMasterBindingSource.DataMember = "spSelectAllEmployeesMaster";
            this.spSelectAllEmployeesMasterBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpNo,
            this.colEmpNames,
            this.colPINNo,
            this.colIDNo,
            this.colNSSFNo,
            this.colInsuranceNo,
            this.colNationality,
            this.colPostalAddress,
            this.colPhysicalAddress,
            this.colMobile,
            this.colEmail,
            this.colDOB,
            this.colJobGrade,
            this.colBasicSalary});
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
            // colEmpNames
            // 
            this.colEmpNames.FieldName = "EmpNames";
            this.colEmpNames.Name = "colEmpNames";
            this.colEmpNames.Visible = true;
            this.colEmpNames.VisibleIndex = 1;
            // 
            // colPINNo
            // 
            this.colPINNo.FieldName = "PINNo";
            this.colPINNo.Name = "colPINNo";
            this.colPINNo.Visible = true;
            this.colPINNo.VisibleIndex = 2;
            // 
            // colIDNo
            // 
            this.colIDNo.FieldName = "IDNo";
            this.colIDNo.Name = "colIDNo";
            this.colIDNo.Visible = true;
            this.colIDNo.VisibleIndex = 3;
            // 
            // colNSSFNo
            // 
            this.colNSSFNo.FieldName = "NSSFNo";
            this.colNSSFNo.Name = "colNSSFNo";
            this.colNSSFNo.Visible = true;
            this.colNSSFNo.VisibleIndex = 4;
            // 
            // colInsuranceNo
            // 
            this.colInsuranceNo.FieldName = "InsuranceNo";
            this.colInsuranceNo.Name = "colInsuranceNo";
            this.colInsuranceNo.Visible = true;
            this.colInsuranceNo.VisibleIndex = 5;
            // 
            // colNationality
            // 
            this.colNationality.FieldName = "Nationality";
            this.colNationality.Name = "colNationality";
            this.colNationality.Visible = true;
            this.colNationality.VisibleIndex = 6;
            // 
            // colPostalAddress
            // 
            this.colPostalAddress.FieldName = "PostalAddress";
            this.colPostalAddress.Name = "colPostalAddress";
            this.colPostalAddress.Visible = true;
            this.colPostalAddress.VisibleIndex = 7;
            // 
            // colPhysicalAddress
            // 
            this.colPhysicalAddress.FieldName = "PhysicalAddress";
            this.colPhysicalAddress.Name = "colPhysicalAddress";
            this.colPhysicalAddress.Visible = true;
            this.colPhysicalAddress.VisibleIndex = 8;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 9;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 10;
            // 
            // colDOB
            // 
            this.colDOB.FieldName = "DOB";
            this.colDOB.Name = "colDOB";
            this.colDOB.Visible = true;
            this.colDOB.VisibleIndex = 11;
            // 
            // colJobGrade
            // 
            this.colJobGrade.FieldName = "JobGrade";
            this.colJobGrade.Name = "colJobGrade";
            this.colJobGrade.Visible = true;
            this.colJobGrade.VisibleIndex = 12;
            // 
            // colBasicSalary
            // 
            this.colBasicSalary.FieldName = "BasicSalary";
            this.colBasicSalary.Name = "colBasicSalary";
            this.colBasicSalary.Visible = true;
            this.colBasicSalary.VisibleIndex = 13;
            // 
            // CostCenterLookUpEdit
            // 
            this.CostCenterLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "CostCenter", true));
            this.CostCenterLookUpEdit.Location = new System.Drawing.Point(115, 72);
            this.CostCenterLookUpEdit.Name = "CostCenterLookUpEdit";
            this.CostCenterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CostCenterLookUpEdit.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.CostCenterLookUpEdit.Properties.DisplayMember = "ccname";
            this.CostCenterLookUpEdit.Properties.NullText = "";
            this.CostCenterLookUpEdit.Properties.ValueMember = "cccode";
            this.CostCenterLookUpEdit.Size = new System.Drawing.Size(323, 20);
            this.CostCenterLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CostCenterLookUpEdit.TabIndex = 4;
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // EmpNoTextEdit
            // 
            this.EmpNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "EmpNo", true));
            this.EmpNoTextEdit.Location = new System.Drawing.Point(533, 72);
            this.EmpNoTextEdit.Name = "EmpNoTextEdit";
            this.EmpNoTextEdit.Size = new System.Drawing.Size(324, 20);
            this.EmpNoTextEdit.StyleController = this.dataLayoutControl1;
            this.EmpNoTextEdit.TabIndex = 5;
            // 
            // EmpNamesTextEdit
            // 
            this.EmpNamesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "EmpNames", true));
            this.EmpNamesTextEdit.Location = new System.Drawing.Point(115, 96);
            this.EmpNamesTextEdit.Name = "EmpNamesTextEdit";
            this.EmpNamesTextEdit.Size = new System.Drawing.Size(323, 20);
            this.EmpNamesTextEdit.StyleController = this.dataLayoutControl1;
            this.EmpNamesTextEdit.TabIndex = 6;
            this.EmpNamesTextEdit.EditValueChanged += new System.EventHandler(this.EmpNamesTextEdit_EditValueChanged);
            // 
            // CountryLookUpEdit
            // 
            this.CountryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Country", true));
            this.CountryLookUpEdit.Location = new System.Drawing.Point(533, 96);
            this.CountryLookUpEdit.Name = "CountryLookUpEdit";
            this.CountryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryLookUpEdit.Properties.DataSource = this.countriesBindingSource;
            this.CountryLookUpEdit.Properties.DisplayMember = "CountryName";
            this.CountryLookUpEdit.Properties.NullText = "";
            this.CountryLookUpEdit.Properties.ValueMember = "CountryCode";
            this.CountryLookUpEdit.Size = new System.Drawing.Size(324, 20);
            this.CountryLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CountryLookUpEdit.TabIndex = 7;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // CountyLookUpEdit
            // 
            this.CountyLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "County", true));
            this.CountyLookUpEdit.Location = new System.Drawing.Point(115, 120);
            this.CountyLookUpEdit.Name = "CountyLookUpEdit";
            this.CountyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountyLookUpEdit.Properties.DataSource = this.countiesBindingSource;
            this.CountyLookUpEdit.Properties.DisplayMember = "CountyCode";
            this.CountyLookUpEdit.Properties.NullText = "";
            this.CountyLookUpEdit.Properties.ValueMember = "CountyName";
            this.CountyLookUpEdit.Size = new System.Drawing.Size(323, 20);
            this.CountyLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CountyLookUpEdit.TabIndex = 8;
            // 
            // countiesBindingSource
            // 
            this.countiesBindingSource.DataMember = "Counties";
            this.countiesBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // PINNoTextEdit
            // 
            this.PINNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PINNo", true));
            this.PINNoTextEdit.Location = new System.Drawing.Point(533, 120);
            this.PINNoTextEdit.Name = "PINNoTextEdit";
            this.PINNoTextEdit.Size = new System.Drawing.Size(324, 20);
            this.PINNoTextEdit.StyleController = this.dataLayoutControl1;
            this.PINNoTextEdit.TabIndex = 9;
            // 
            // IDNoTextEdit
            // 
            this.IDNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "IDNo", true));
            this.IDNoTextEdit.Location = new System.Drawing.Point(115, 144);
            this.IDNoTextEdit.Name = "IDNoTextEdit";
            this.IDNoTextEdit.Size = new System.Drawing.Size(323, 20);
            this.IDNoTextEdit.StyleController = this.dataLayoutControl1;
            this.IDNoTextEdit.TabIndex = 10;
            // 
            // NSSFNoTextEdit
            // 
            this.NSSFNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "NSSFNo", true));
            this.NSSFNoTextEdit.Location = new System.Drawing.Point(533, 144);
            this.NSSFNoTextEdit.Name = "NSSFNoTextEdit";
            this.NSSFNoTextEdit.Size = new System.Drawing.Size(324, 20);
            this.NSSFNoTextEdit.StyleController = this.dataLayoutControl1;
            this.NSSFNoTextEdit.TabIndex = 11;
            // 
            // TaxTableTextEdit
            // 
            this.TaxTableTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "TaxTable", true));
            this.TaxTableTextEdit.Location = new System.Drawing.Point(115, 168);
            this.TaxTableTextEdit.Name = "TaxTableTextEdit";
            this.TaxTableTextEdit.Size = new System.Drawing.Size(323, 20);
            this.TaxTableTextEdit.StyleController = this.dataLayoutControl1;
            this.TaxTableTextEdit.TabIndex = 12;
            // 
            // InsuranceNoTextEdit
            // 
            this.InsuranceNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "InsuranceNo", true));
            this.InsuranceNoTextEdit.Location = new System.Drawing.Point(533, 168);
            this.InsuranceNoTextEdit.Name = "InsuranceNoTextEdit";
            this.InsuranceNoTextEdit.Size = new System.Drawing.Size(324, 20);
            this.InsuranceNoTextEdit.StyleController = this.dataLayoutControl1;
            this.InsuranceNoTextEdit.TabIndex = 13;
            // 
            // DepartmentLookUpEdit
            // 
            this.DepartmentLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Department", true));
            this.DepartmentLookUpEdit.Location = new System.Drawing.Point(115, 192);
            this.DepartmentLookUpEdit.Name = "DepartmentLookUpEdit";
            this.DepartmentLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartmentLookUpEdit.Properties.DataSource = this.userCodesBindingSource;
            this.DepartmentLookUpEdit.Properties.DisplayMember = "Description";
            this.DepartmentLookUpEdit.Properties.NullText = "";
            this.DepartmentLookUpEdit.Properties.ValueMember = "Code";
            this.DepartmentLookUpEdit.Size = new System.Drawing.Size(323, 20);
            this.DepartmentLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DepartmentLookUpEdit.TabIndex = 14;
            // 
            // userCodesBindingSource
            // 
            this.userCodesBindingSource.DataMember = "UserCodes";
            this.userCodesBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // HireDateDateEdit
            // 
            this.HireDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "HireDate", true));
            this.HireDateDateEdit.EditValue = null;
            this.HireDateDateEdit.Location = new System.Drawing.Point(533, 192);
            this.HireDateDateEdit.Name = "HireDateDateEdit";
            this.HireDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HireDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HireDateDateEdit.Size = new System.Drawing.Size(324, 20);
            this.HireDateDateEdit.StyleController = this.dataLayoutControl1;
            this.HireDateDateEdit.TabIndex = 15;
            // 
            // PayStartDateDateEdit
            // 
            this.PayStartDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PayStartDate", true));
            this.PayStartDateDateEdit.EditValue = null;
            this.PayStartDateDateEdit.Location = new System.Drawing.Point(115, 216);
            this.PayStartDateDateEdit.Name = "PayStartDateDateEdit";
            this.PayStartDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayStartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayStartDateDateEdit.Size = new System.Drawing.Size(323, 20);
            this.PayStartDateDateEdit.StyleController = this.dataLayoutControl1;
            this.PayStartDateDateEdit.TabIndex = 16;
            // 
            // PayEndDateDateEdit
            // 
            this.PayEndDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PayEndDate", true));
            this.PayEndDateDateEdit.EditValue = null;
            this.PayEndDateDateEdit.Location = new System.Drawing.Point(533, 216);
            this.PayEndDateDateEdit.Name = "PayEndDateDateEdit";
            this.PayEndDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayEndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayEndDateDateEdit.Size = new System.Drawing.Size(324, 20);
            this.PayEndDateDateEdit.StyleController = this.dataLayoutControl1;
            this.PayEndDateDateEdit.TabIndex = 17;
            // 
            // LeaveStartDateDateEdit
            // 
            this.LeaveStartDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "LeaveStartDate", true));
            this.LeaveStartDateDateEdit.EditValue = null;
            this.LeaveStartDateDateEdit.Location = new System.Drawing.Point(115, 240);
            this.LeaveStartDateDateEdit.Name = "LeaveStartDateDateEdit";
            this.LeaveStartDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LeaveStartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LeaveStartDateDateEdit.Size = new System.Drawing.Size(323, 20);
            this.LeaveStartDateDateEdit.StyleController = this.dataLayoutControl1;
            this.LeaveStartDateDateEdit.TabIndex = 18;
            // 
            // NationalityTextEdit
            // 
            this.NationalityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Nationality", true));
            this.NationalityTextEdit.Location = new System.Drawing.Point(533, 240);
            this.NationalityTextEdit.Name = "NationalityTextEdit";
            this.NationalityTextEdit.Size = new System.Drawing.Size(324, 20);
            this.NationalityTextEdit.StyleController = this.dataLayoutControl1;
            this.NationalityTextEdit.TabIndex = 19;
            // 
            // PostalAddressTextEdit
            // 
            this.PostalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PostalAddress", true));
            this.PostalAddressTextEdit.Location = new System.Drawing.Point(115, 72);
            this.PostalAddressTextEdit.Name = "PostalAddressTextEdit";
            this.PostalAddressTextEdit.Size = new System.Drawing.Size(323, 20);
            this.PostalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PostalAddressTextEdit.TabIndex = 20;
            // 
            // PhysicalAddressTextEdit
            // 
            this.PhysicalAddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PhysicalAddress", true));
            this.PhysicalAddressTextEdit.Location = new System.Drawing.Point(533, 72);
            this.PhysicalAddressTextEdit.Name = "PhysicalAddressTextEdit";
            this.PhysicalAddressTextEdit.Size = new System.Drawing.Size(324, 20);
            this.PhysicalAddressTextEdit.StyleController = this.dataLayoutControl1;
            this.PhysicalAddressTextEdit.TabIndex = 21;
            // 
            // MobileTextEdit
            // 
            this.MobileTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Mobile", true));
            this.MobileTextEdit.Location = new System.Drawing.Point(115, 96);
            this.MobileTextEdit.Name = "MobileTextEdit";
            this.MobileTextEdit.Size = new System.Drawing.Size(323, 20);
            this.MobileTextEdit.StyleController = this.dataLayoutControl1;
            this.MobileTextEdit.TabIndex = 22;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(533, 96);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(324, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 23;
            // 
            // IsDisabledCheckEdit
            // 
            this.IsDisabledCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "IsDisabled", true));
            this.IsDisabledCheckEdit.Location = new System.Drawing.Point(115, 120);
            this.IsDisabledCheckEdit.Name = "IsDisabledCheckEdit";
            this.IsDisabledCheckEdit.Properties.Caption = "Is Disabled";
            this.IsDisabledCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IsDisabledCheckEdit.Size = new System.Drawing.Size(323, 19);
            this.IsDisabledCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsDisabledCheckEdit.TabIndex = 24;
            // 
            // DisabilityDescTextEdit
            // 
            this.DisabilityDescTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "DisabilityDesc", true));
            this.DisabilityDescTextEdit.Location = new System.Drawing.Point(533, 120);
            this.DisabilityDescTextEdit.Name = "DisabilityDescTextEdit";
            this.DisabilityDescTextEdit.Size = new System.Drawing.Size(324, 20);
            this.DisabilityDescTextEdit.StyleController = this.dataLayoutControl1;
            this.DisabilityDescTextEdit.TabIndex = 25;
            // 
            // DOBDateEdit
            // 
            this.DOBDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "DOB", true));
            this.DOBDateEdit.EditValue = null;
            this.DOBDateEdit.Location = new System.Drawing.Point(115, 143);
            this.DOBDateEdit.Name = "DOBDateEdit";
            this.DOBDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DOBDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DOBDateEdit.Size = new System.Drawing.Size(323, 20);
            this.DOBDateEdit.StyleController = this.dataLayoutControl1;
            this.DOBDateEdit.TabIndex = 26;
            this.DOBDateEdit.EditValueChanged += new System.EventHandler(this.DOBDateEdit_EditValueChanged);
            // 
            // RetirementDateDateEdit
            // 
            this.RetirementDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "RetirementDate", true));
            this.RetirementDateDateEdit.EditValue = null;
            this.RetirementDateDateEdit.Location = new System.Drawing.Point(533, 144);
            this.RetirementDateDateEdit.Name = "RetirementDateDateEdit";
            this.RetirementDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RetirementDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RetirementDateDateEdit.Size = new System.Drawing.Size(324, 20);
            this.RetirementDateDateEdit.StyleController = this.dataLayoutControl1;
            this.RetirementDateDateEdit.TabIndex = 27;
            // 
            // MaritalStatusComboBoxEdit
            // 
            this.MaritalStatusComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "MaritalStatus", true));
            this.MaritalStatusComboBoxEdit.Location = new System.Drawing.Point(115, 167);
            this.MaritalStatusComboBoxEdit.Name = "MaritalStatusComboBoxEdit";
            this.MaritalStatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MaritalStatusComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.MaritalStatusComboBoxEdit.Size = new System.Drawing.Size(323, 20);
            this.MaritalStatusComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.MaritalStatusComboBoxEdit.TabIndex = 28;
            // 
            // GenderComboBoxEdit
            // 
            this.GenderComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spSelectEmployeesMasterBindingSource, "Gender", true));
            this.GenderComboBoxEdit.Location = new System.Drawing.Point(533, 168);
            this.GenderComboBoxEdit.Name = "GenderComboBoxEdit";
            this.GenderComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GenderComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderComboBoxEdit.Size = new System.Drawing.Size(324, 20);
            this.GenderComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.GenderComboBoxEdit.TabIndex = 29;
            // 
            // LanguagesTextEdit
            // 
            this.LanguagesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Languages", true));
            this.LanguagesTextEdit.Location = new System.Drawing.Point(115, 191);
            this.LanguagesTextEdit.Name = "LanguagesTextEdit";
            this.LanguagesTextEdit.Size = new System.Drawing.Size(323, 20);
            this.LanguagesTextEdit.StyleController = this.dataLayoutControl1;
            this.LanguagesTextEdit.TabIndex = 30;
            // 
            // SupervisorTextEdit
            // 
            this.SupervisorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Supervisor", true));
            this.SupervisorTextEdit.Location = new System.Drawing.Point(533, 192);
            this.SupervisorTextEdit.Name = "SupervisorTextEdit";
            this.SupervisorTextEdit.Size = new System.Drawing.Size(324, 20);
            this.SupervisorTextEdit.StyleController = this.dataLayoutControl1;
            this.SupervisorTextEdit.TabIndex = 31;
            // 
            // ImagePictureEdit
            // 
            this.ImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Image", true));
            this.ImagePictureEdit.Location = new System.Drawing.Point(24, 72);
            this.ImagePictureEdit.Name = "ImagePictureEdit";
            this.ImagePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ImagePictureEdit.Size = new System.Drawing.Size(833, 210);
            this.ImagePictureEdit.StyleController = this.dataLayoutControl1;
            this.ImagePictureEdit.TabIndex = 32;
            // 
            // JobTypeLookUpEdit
            // 
            this.JobTypeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "JobType", true));
            this.JobTypeLookUpEdit.Location = new System.Drawing.Point(533, 72);
            this.JobTypeLookUpEdit.Name = "JobTypeLookUpEdit";
            this.JobTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JobTypeLookUpEdit.Properties.DataSource = this.userCodesJobtypeBindingSource;
            this.JobTypeLookUpEdit.Properties.DisplayMember = "Description";
            this.JobTypeLookUpEdit.Properties.NullText = "";
            this.JobTypeLookUpEdit.Properties.ValueMember = "Code";
            this.JobTypeLookUpEdit.Size = new System.Drawing.Size(324, 20);
            this.JobTypeLookUpEdit.StyleController = this.dataLayoutControl1;
            this.JobTypeLookUpEdit.TabIndex = 34;
            // 
            // userCodesJobtypeBindingSource
            // 
            this.userCodesJobtypeBindingSource.DataMember = "UserCodesJobtype";
            this.userCodesJobtypeBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // JobGradeLookUpEdit
            // 
            this.JobGradeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "JobGrade", true));
            this.JobGradeLookUpEdit.Location = new System.Drawing.Point(115, 96);
            this.JobGradeLookUpEdit.Name = "JobGradeLookUpEdit";
            this.JobGradeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JobGradeLookUpEdit.Properties.DataSource = this.userCodesJobGradeBindingSource;
            this.JobGradeLookUpEdit.Properties.DisplayMember = "Description";
            this.JobGradeLookUpEdit.Properties.NullText = "";
            this.JobGradeLookUpEdit.Properties.ValueMember = "Code";
            this.JobGradeLookUpEdit.Size = new System.Drawing.Size(323, 20);
            this.JobGradeLookUpEdit.StyleController = this.dataLayoutControl1;
            this.JobGradeLookUpEdit.TabIndex = 35;
            // 
            // userCodesJobGradeBindingSource
            // 
            this.userCodesJobGradeBindingSource.DataMember = "UserCodesJobGrade";
            this.userCodesJobGradeBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // PayFreqTextEdit
            // 
            this.PayFreqTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PayFreq", true));
            this.PayFreqTextEdit.Location = new System.Drawing.Point(533, 96);
            this.PayFreqTextEdit.Name = "PayFreqTextEdit";
            this.PayFreqTextEdit.Size = new System.Drawing.Size(324, 20);
            this.PayFreqTextEdit.StyleController = this.dataLayoutControl1;
            this.PayFreqTextEdit.TabIndex = 36;
            // 
            // AnnualSalaryTextEdit
            // 
            this.AnnualSalaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "AnnualSalary", true));
            this.AnnualSalaryTextEdit.Location = new System.Drawing.Point(533, 120);
            this.AnnualSalaryTextEdit.Name = "AnnualSalaryTextEdit";
            this.AnnualSalaryTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AnnualSalaryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AnnualSalaryTextEdit.Properties.Mask.EditMask = "G";
            this.AnnualSalaryTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AnnualSalaryTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AnnualSalaryTextEdit.Size = new System.Drawing.Size(324, 20);
            this.AnnualSalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.AnnualSalaryTextEdit.TabIndex = 37;
            // 
            // BasicSalaryTextEdit
            // 
            this.BasicSalaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "BasicSalary", true));
            this.BasicSalaryTextEdit.Location = new System.Drawing.Point(115, 120);
            this.BasicSalaryTextEdit.Name = "BasicSalaryTextEdit";
            this.BasicSalaryTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BasicSalaryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BasicSalaryTextEdit.Properties.Mask.EditMask = "G";
            this.BasicSalaryTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BasicSalaryTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BasicSalaryTextEdit.Size = new System.Drawing.Size(323, 20);
            this.BasicSalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.BasicSalaryTextEdit.TabIndex = 38;
            this.BasicSalaryTextEdit.EditValueChanged += new System.EventHandler(this.BasicSalaryTextEdit_EditValueChanged);
            // 
            // HrsPerDayTextEdit
            // 
            this.HrsPerDayTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "HrsPerDay", true));
            this.HrsPerDayTextEdit.Location = new System.Drawing.Point(115, 144);
            this.HrsPerDayTextEdit.Name = "HrsPerDayTextEdit";
            this.HrsPerDayTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.HrsPerDayTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HrsPerDayTextEdit.Properties.Mask.EditMask = "F";
            this.HrsPerDayTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.HrsPerDayTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.HrsPerDayTextEdit.Size = new System.Drawing.Size(323, 20);
            this.HrsPerDayTextEdit.StyleController = this.dataLayoutControl1;
            this.HrsPerDayTextEdit.TabIndex = 39;
            // 
            // HourlyRateTextEdit
            // 
            this.HourlyRateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "HourlyRate", true));
            this.HourlyRateTextEdit.Location = new System.Drawing.Point(533, 144);
            this.HourlyRateTextEdit.Name = "HourlyRateTextEdit";
            this.HourlyRateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.HourlyRateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HourlyRateTextEdit.Properties.Mask.EditMask = "G";
            this.HourlyRateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.HourlyRateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.HourlyRateTextEdit.Size = new System.Drawing.Size(324, 20);
            this.HourlyRateTextEdit.StyleController = this.dataLayoutControl1;
            this.HourlyRateTextEdit.TabIndex = 40;
            // 
            // PayPerHourCheckEdit
            // 
            this.PayPerHourCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PayPerHour", true));
            this.PayPerHourCheckEdit.Location = new System.Drawing.Point(115, 168);
            this.PayPerHourCheckEdit.Name = "PayPerHourCheckEdit";
            this.PayPerHourCheckEdit.Properties.Caption = "Pay Per Hour";
            this.PayPerHourCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PayPerHourCheckEdit.Size = new System.Drawing.Size(323, 19);
            this.PayPerHourCheckEdit.StyleController = this.dataLayoutControl1;
            this.PayPerHourCheckEdit.TabIndex = 41;
            // 
            // TaxableCheckEdit
            // 
            this.TaxableCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "Taxable", true));
            this.TaxableCheckEdit.Location = new System.Drawing.Point(533, 168);
            this.TaxableCheckEdit.Name = "TaxableCheckEdit";
            this.TaxableCheckEdit.Properties.Caption = "Taxable";
            this.TaxableCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TaxableCheckEdit.Size = new System.Drawing.Size(324, 19);
            this.TaxableCheckEdit.StyleController = this.dataLayoutControl1;
            this.TaxableCheckEdit.TabIndex = 42;
            // 
            // NSSFExemptCheckEdit
            // 
            this.NSSFExemptCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "NSSFExempt", true));
            this.NSSFExemptCheckEdit.Location = new System.Drawing.Point(115, 191);
            this.NSSFExemptCheckEdit.Name = "NSSFExemptCheckEdit";
            this.NSSFExemptCheckEdit.Properties.Caption = "NSSF Exempt";
            this.NSSFExemptCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NSSFExemptCheckEdit.Size = new System.Drawing.Size(323, 19);
            this.NSSFExemptCheckEdit.StyleController = this.dataLayoutControl1;
            this.NSSFExemptCheckEdit.TabIndex = 43;
            // 
            // NHIFExemptCheckEdit
            // 
            this.NHIFExemptCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "NHIFExempt", true));
            this.NHIFExemptCheckEdit.Location = new System.Drawing.Point(533, 191);
            this.NHIFExemptCheckEdit.Name = "NHIFExemptCheckEdit";
            this.NHIFExemptCheckEdit.Properties.Caption = "NHIF Exempt";
            this.NHIFExemptCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NHIFExemptCheckEdit.Size = new System.Drawing.Size(324, 19);
            this.NHIFExemptCheckEdit.StyleController = this.dataLayoutControl1;
            this.NHIFExemptCheckEdit.TabIndex = 44;
            // 
            // OverTimeExemptCheckEdit
            // 
            this.OverTimeExemptCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "OverTimeExempt", true));
            this.OverTimeExemptCheckEdit.Location = new System.Drawing.Point(115, 214);
            this.OverTimeExemptCheckEdit.Name = "OverTimeExemptCheckEdit";
            this.OverTimeExemptCheckEdit.Properties.Caption = "Over Time Exempt";
            this.OverTimeExemptCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OverTimeExemptCheckEdit.Size = new System.Drawing.Size(323, 19);
            this.OverTimeExemptCheckEdit.StyleController = this.dataLayoutControl1;
            this.OverTimeExemptCheckEdit.TabIndex = 45;
            // 
            // ReviewTypeTextEdit
            // 
            this.ReviewTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "ReviewType", true));
            this.ReviewTypeTextEdit.Location = new System.Drawing.Point(533, 214);
            this.ReviewTypeTextEdit.Name = "ReviewTypeTextEdit";
            this.ReviewTypeTextEdit.Size = new System.Drawing.Size(324, 20);
            this.ReviewTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.ReviewTypeTextEdit.TabIndex = 46;
            // 
            // BankBranchLookUpEdit
            // 
            this.BankBranchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "BankBranch", true));
            this.BankBranchLookUpEdit.Location = new System.Drawing.Point(533, 238);
            this.BankBranchLookUpEdit.Name = "BankBranchLookUpEdit";
            this.BankBranchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BankBranchLookUpEdit.Properties.DataSource = this.bankBranchesBindingSource;
            this.BankBranchLookUpEdit.Properties.DisplayMember = "BranchName";
            this.BankBranchLookUpEdit.Properties.NullText = "";
            this.BankBranchLookUpEdit.Properties.ValueMember = "BranchCode";
            this.BankBranchLookUpEdit.Size = new System.Drawing.Size(324, 20);
            this.BankBranchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.BankBranchLookUpEdit.TabIndex = 47;
            // 
            // bankBranchesBindingSource
            // 
            this.bankBranchesBindingSource.DataMember = "BankBranches";
            this.bankBranchesBindingSource.DataSource = this.dsEmployeeMaster;
            // 
            // AccNoTextEdit
            // 
            this.AccNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "AccNo", true));
            this.AccNoTextEdit.Location = new System.Drawing.Point(533, 262);
            this.AccNoTextEdit.Name = "AccNoTextEdit";
            this.AccNoTextEdit.Size = new System.Drawing.Size(324, 20);
            this.AccNoTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNoTextEdit.TabIndex = 48;
            // 
            // AccNameTextEdit
            // 
            this.AccNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "AccName", true));
            this.AccNameTextEdit.Location = new System.Drawing.Point(115, 262);
            this.AccNameTextEdit.Name = "AccNameTextEdit";
            this.AccNameTextEdit.Size = new System.Drawing.Size(323, 20);
            this.AccNameTextEdit.StyleController = this.dataLayoutControl1;
            this.AccNameTextEdit.TabIndex = 49;
            // 
            // PayStatusTextEdit
            // 
            this.PayStatusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectEmployeesMasterBindingSource, "PayStatus", true));
            this.PayStatusTextEdit.Location = new System.Drawing.Point(115, 72);
            this.PayStatusTextEdit.Name = "PayStatusTextEdit";
            this.PayStatusTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayStatusTextEdit.Properties.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.PayStatusTextEdit.Size = new System.Drawing.Size(323, 20);
            this.PayStatusTextEdit.StyleController = this.dataLayoutControl1;
            this.PayStatusTextEdit.TabIndex = 33;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(881, 546);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(861, 526);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 26);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(861, 260);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlGroup6});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCostCenter,
            this.ItemForEmpNo,
            this.ItemForEmpNames,
            this.ItemForCountry,
            this.ItemForCounty,
            this.ItemForPINNo,
            this.ItemForIDNo,
            this.ItemForNSSFNo,
            this.ItemForTaxTable,
            this.ItemForInsuranceNo,
            this.ItemForDepartment,
            this.ItemForHireDate,
            this.ItemForPayStartDate,
            this.ItemForPayEndDate,
            this.ItemForLeaveStartDate,
            this.ItemForNationality});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(837, 214);
            this.layoutControlGroup3.Text = "Basic Information";
            // 
            // ItemForCostCenter
            // 
            this.ItemForCostCenter.Control = this.CostCenterLookUpEdit;
            this.ItemForCostCenter.Location = new System.Drawing.Point(0, 0);
            this.ItemForCostCenter.Name = "ItemForCostCenter";
            this.ItemForCostCenter.Size = new System.Drawing.Size(418, 24);
            this.ItemForCostCenter.Text = "Cost Center";
            this.ItemForCostCenter.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.EmpNoTextEdit;
            this.ItemForEmpNo.Location = new System.Drawing.Point(418, 0);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(419, 24);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForEmpNames
            // 
            this.ItemForEmpNames.Control = this.EmpNamesTextEdit;
            this.ItemForEmpNames.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmpNames.Name = "ItemForEmpNames";
            this.ItemForEmpNames.Size = new System.Drawing.Size(418, 24);
            this.ItemForEmpNames.Text = "Emp Names";
            this.ItemForEmpNames.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForCountry
            // 
            this.ItemForCountry.Control = this.CountryLookUpEdit;
            this.ItemForCountry.Location = new System.Drawing.Point(418, 24);
            this.ItemForCountry.Name = "ItemForCountry";
            this.ItemForCountry.Size = new System.Drawing.Size(419, 24);
            this.ItemForCountry.Text = "Country";
            this.ItemForCountry.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForCounty
            // 
            this.ItemForCounty.Control = this.CountyLookUpEdit;
            this.ItemForCounty.Location = new System.Drawing.Point(0, 48);
            this.ItemForCounty.Name = "ItemForCounty";
            this.ItemForCounty.Size = new System.Drawing.Size(418, 24);
            this.ItemForCounty.Text = "County";
            this.ItemForCounty.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForPINNo
            // 
            this.ItemForPINNo.Control = this.PINNoTextEdit;
            this.ItemForPINNo.Location = new System.Drawing.Point(418, 48);
            this.ItemForPINNo.Name = "ItemForPINNo";
            this.ItemForPINNo.Size = new System.Drawing.Size(419, 24);
            this.ItemForPINNo.Text = "PINNo";
            this.ItemForPINNo.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForIDNo
            // 
            this.ItemForIDNo.Control = this.IDNoTextEdit;
            this.ItemForIDNo.Location = new System.Drawing.Point(0, 72);
            this.ItemForIDNo.Name = "ItemForIDNo";
            this.ItemForIDNo.Size = new System.Drawing.Size(418, 24);
            this.ItemForIDNo.Text = "IDNo";
            this.ItemForIDNo.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForNSSFNo
            // 
            this.ItemForNSSFNo.Control = this.NSSFNoTextEdit;
            this.ItemForNSSFNo.Location = new System.Drawing.Point(418, 72);
            this.ItemForNSSFNo.Name = "ItemForNSSFNo";
            this.ItemForNSSFNo.Size = new System.Drawing.Size(419, 24);
            this.ItemForNSSFNo.Text = "NSSFNo";
            this.ItemForNSSFNo.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForTaxTable
            // 
            this.ItemForTaxTable.Control = this.TaxTableTextEdit;
            this.ItemForTaxTable.Location = new System.Drawing.Point(0, 96);
            this.ItemForTaxTable.Name = "ItemForTaxTable";
            this.ItemForTaxTable.Size = new System.Drawing.Size(418, 24);
            this.ItemForTaxTable.Text = "Tax Table";
            this.ItemForTaxTable.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForInsuranceNo
            // 
            this.ItemForInsuranceNo.Control = this.InsuranceNoTextEdit;
            this.ItemForInsuranceNo.Location = new System.Drawing.Point(418, 96);
            this.ItemForInsuranceNo.Name = "ItemForInsuranceNo";
            this.ItemForInsuranceNo.Size = new System.Drawing.Size(419, 24);
            this.ItemForInsuranceNo.Text = "Insurance No";
            this.ItemForInsuranceNo.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForDepartment
            // 
            this.ItemForDepartment.Control = this.DepartmentLookUpEdit;
            this.ItemForDepartment.Location = new System.Drawing.Point(0, 120);
            this.ItemForDepartment.Name = "ItemForDepartment";
            this.ItemForDepartment.Size = new System.Drawing.Size(418, 24);
            this.ItemForDepartment.Text = "Department";
            this.ItemForDepartment.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForHireDate
            // 
            this.ItemForHireDate.Control = this.HireDateDateEdit;
            this.ItemForHireDate.Location = new System.Drawing.Point(418, 120);
            this.ItemForHireDate.Name = "ItemForHireDate";
            this.ItemForHireDate.Size = new System.Drawing.Size(419, 24);
            this.ItemForHireDate.Text = "Hire Date";
            this.ItemForHireDate.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForPayStartDate
            // 
            this.ItemForPayStartDate.Control = this.PayStartDateDateEdit;
            this.ItemForPayStartDate.Location = new System.Drawing.Point(0, 144);
            this.ItemForPayStartDate.Name = "ItemForPayStartDate";
            this.ItemForPayStartDate.Size = new System.Drawing.Size(418, 24);
            this.ItemForPayStartDate.Text = "Pay Start Date";
            this.ItemForPayStartDate.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForPayEndDate
            // 
            this.ItemForPayEndDate.Control = this.PayEndDateDateEdit;
            this.ItemForPayEndDate.Location = new System.Drawing.Point(418, 144);
            this.ItemForPayEndDate.Name = "ItemForPayEndDate";
            this.ItemForPayEndDate.Size = new System.Drawing.Size(419, 24);
            this.ItemForPayEndDate.Text = "Pay End Date";
            this.ItemForPayEndDate.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForLeaveStartDate
            // 
            this.ItemForLeaveStartDate.Control = this.LeaveStartDateDateEdit;
            this.ItemForLeaveStartDate.Location = new System.Drawing.Point(0, 168);
            this.ItemForLeaveStartDate.Name = "ItemForLeaveStartDate";
            this.ItemForLeaveStartDate.Size = new System.Drawing.Size(418, 46);
            this.ItemForLeaveStartDate.Text = "Leave Start Date";
            this.ItemForLeaveStartDate.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForNationality
            // 
            this.ItemForNationality.Control = this.NationalityTextEdit;
            this.ItemForNationality.Location = new System.Drawing.Point(418, 168);
            this.ItemForNationality.Name = "ItemForNationality";
            this.ItemForNationality.Size = new System.Drawing.Size(419, 46);
            this.ItemForNationality.Text = "Nationality";
            this.ItemForNationality.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPostalAddress,
            this.ItemForPhysicalAddress,
            this.ItemForMobile,
            this.ItemForEmail,
            this.ItemForIsDisabled,
            this.ItemForDisabilityDesc,
            this.ItemForDOB,
            this.ItemForRetirementDate,
            this.ItemForMaritalStatus,
            this.ItemForGender,
            this.ItemForLanguages,
            this.ItemForSupervisor});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(837, 214);
            this.layoutControlGroup4.Text = "Personal Information";
            // 
            // ItemForPostalAddress
            // 
            this.ItemForPostalAddress.Control = this.PostalAddressTextEdit;
            this.ItemForPostalAddress.Location = new System.Drawing.Point(0, 0);
            this.ItemForPostalAddress.Name = "ItemForPostalAddress";
            this.ItemForPostalAddress.Size = new System.Drawing.Size(418, 24);
            this.ItemForPostalAddress.Text = "Postal Address";
            this.ItemForPostalAddress.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForPhysicalAddress
            // 
            this.ItemForPhysicalAddress.Control = this.PhysicalAddressTextEdit;
            this.ItemForPhysicalAddress.Location = new System.Drawing.Point(418, 0);
            this.ItemForPhysicalAddress.Name = "ItemForPhysicalAddress";
            this.ItemForPhysicalAddress.Size = new System.Drawing.Size(419, 24);
            this.ItemForPhysicalAddress.Text = "Physical Address";
            this.ItemForPhysicalAddress.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForMobile
            // 
            this.ItemForMobile.Control = this.MobileTextEdit;
            this.ItemForMobile.Location = new System.Drawing.Point(0, 24);
            this.ItemForMobile.Name = "ItemForMobile";
            this.ItemForMobile.Size = new System.Drawing.Size(418, 24);
            this.ItemForMobile.Text = "Mobile";
            this.ItemForMobile.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(418, 24);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(419, 24);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForIsDisabled
            // 
            this.ItemForIsDisabled.Control = this.IsDisabledCheckEdit;
            this.ItemForIsDisabled.Location = new System.Drawing.Point(0, 48);
            this.ItemForIsDisabled.Name = "ItemForIsDisabled";
            this.ItemForIsDisabled.Size = new System.Drawing.Size(418, 23);
            this.ItemForIsDisabled.Text = "Is Disabled";
            this.ItemForIsDisabled.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForDisabilityDesc
            // 
            this.ItemForDisabilityDesc.Control = this.DisabilityDescTextEdit;
            this.ItemForDisabilityDesc.Location = new System.Drawing.Point(418, 48);
            this.ItemForDisabilityDesc.Name = "ItemForDisabilityDesc";
            this.ItemForDisabilityDesc.Size = new System.Drawing.Size(419, 24);
            this.ItemForDisabilityDesc.Text = "Disability Desc";
            this.ItemForDisabilityDesc.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForDOB
            // 
            this.ItemForDOB.Control = this.DOBDateEdit;
            this.ItemForDOB.Location = new System.Drawing.Point(0, 71);
            this.ItemForDOB.Name = "ItemForDOB";
            this.ItemForDOB.Size = new System.Drawing.Size(418, 24);
            this.ItemForDOB.Text = "DOB";
            this.ItemForDOB.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForRetirementDate
            // 
            this.ItemForRetirementDate.Control = this.RetirementDateDateEdit;
            this.ItemForRetirementDate.Location = new System.Drawing.Point(418, 72);
            this.ItemForRetirementDate.Name = "ItemForRetirementDate";
            this.ItemForRetirementDate.Size = new System.Drawing.Size(419, 24);
            this.ItemForRetirementDate.Text = "Retirement Date";
            this.ItemForRetirementDate.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForMaritalStatus
            // 
            this.ItemForMaritalStatus.Control = this.MaritalStatusComboBoxEdit;
            this.ItemForMaritalStatus.Location = new System.Drawing.Point(0, 95);
            this.ItemForMaritalStatus.Name = "ItemForMaritalStatus";
            this.ItemForMaritalStatus.Size = new System.Drawing.Size(418, 24);
            this.ItemForMaritalStatus.Text = "Marital Status";
            this.ItemForMaritalStatus.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForGender
            // 
            this.ItemForGender.Control = this.GenderComboBoxEdit;
            this.ItemForGender.Location = new System.Drawing.Point(418, 96);
            this.ItemForGender.Name = "ItemForGender";
            this.ItemForGender.Size = new System.Drawing.Size(419, 24);
            this.ItemForGender.Text = "Gender";
            this.ItemForGender.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForLanguages
            // 
            this.ItemForLanguages.Control = this.LanguagesTextEdit;
            this.ItemForLanguages.Location = new System.Drawing.Point(0, 119);
            this.ItemForLanguages.Name = "ItemForLanguages";
            this.ItemForLanguages.Size = new System.Drawing.Size(418, 95);
            this.ItemForLanguages.Text = "Languages";
            this.ItemForLanguages.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForSupervisor
            // 
            this.ItemForSupervisor.Control = this.SupervisorTextEdit;
            this.ItemForSupervisor.Location = new System.Drawing.Point(418, 120);
            this.ItemForSupervisor.Name = "ItemForSupervisor";
            this.ItemForSupervisor.Size = new System.Drawing.Size(419, 94);
            this.ItemForSupervisor.Text = "Supervisor";
            this.ItemForSupervisor.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPayStatus,
            this.ItemForJobType,
            this.ItemForJobGrade,
            this.ItemForPayFreq,
            this.ItemForBasicSalary,
            this.ItemForHrsPerDay,
            this.ItemForHourlyRate,
            this.ItemForPayPerHour,
            this.ItemForTaxable,
            this.ItemForNSSFExempt,
            this.ItemForNHIFExempt,
            this.ItemForOverTimeExempt,
            this.ItemForReviewType,
            this.ItemForAccNo,
            this.ItemForAccName,
            this.layoutControlItem2,
            this.ItemForBankBranch,
            this.ItemForAnnualSalary});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(837, 214);
            this.layoutControlGroup5.Text = "Other Information";
            // 
            // ItemForPayStatus
            // 
            this.ItemForPayStatus.Control = this.PayStatusTextEdit;
            this.ItemForPayStatus.Location = new System.Drawing.Point(0, 0);
            this.ItemForPayStatus.Name = "ItemForPayStatus";
            this.ItemForPayStatus.Size = new System.Drawing.Size(418, 24);
            this.ItemForPayStatus.Text = "Pay Status";
            this.ItemForPayStatus.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForJobType
            // 
            this.ItemForJobType.Control = this.JobTypeLookUpEdit;
            this.ItemForJobType.Location = new System.Drawing.Point(418, 0);
            this.ItemForJobType.Name = "ItemForJobType";
            this.ItemForJobType.Size = new System.Drawing.Size(419, 24);
            this.ItemForJobType.Text = "Job Type";
            this.ItemForJobType.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForJobGrade
            // 
            this.ItemForJobGrade.Control = this.JobGradeLookUpEdit;
            this.ItemForJobGrade.Location = new System.Drawing.Point(0, 24);
            this.ItemForJobGrade.Name = "ItemForJobGrade";
            this.ItemForJobGrade.Size = new System.Drawing.Size(418, 24);
            this.ItemForJobGrade.Text = "Job Grade";
            this.ItemForJobGrade.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForPayFreq
            // 
            this.ItemForPayFreq.Control = this.PayFreqTextEdit;
            this.ItemForPayFreq.Location = new System.Drawing.Point(418, 24);
            this.ItemForPayFreq.Name = "ItemForPayFreq";
            this.ItemForPayFreq.Size = new System.Drawing.Size(419, 24);
            this.ItemForPayFreq.Text = "Pay Freq";
            this.ItemForPayFreq.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForBasicSalary
            // 
            this.ItemForBasicSalary.Control = this.BasicSalaryTextEdit;
            this.ItemForBasicSalary.Location = new System.Drawing.Point(0, 48);
            this.ItemForBasicSalary.Name = "ItemForBasicSalary";
            this.ItemForBasicSalary.Size = new System.Drawing.Size(418, 24);
            this.ItemForBasicSalary.Text = "Basic Salary";
            this.ItemForBasicSalary.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForHrsPerDay
            // 
            this.ItemForHrsPerDay.Control = this.HrsPerDayTextEdit;
            this.ItemForHrsPerDay.Location = new System.Drawing.Point(0, 72);
            this.ItemForHrsPerDay.Name = "ItemForHrsPerDay";
            this.ItemForHrsPerDay.Size = new System.Drawing.Size(418, 24);
            this.ItemForHrsPerDay.Text = "Hrs Per Day";
            this.ItemForHrsPerDay.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForHourlyRate
            // 
            this.ItemForHourlyRate.Control = this.HourlyRateTextEdit;
            this.ItemForHourlyRate.Location = new System.Drawing.Point(418, 72);
            this.ItemForHourlyRate.Name = "ItemForHourlyRate";
            this.ItemForHourlyRate.Size = new System.Drawing.Size(419, 24);
            this.ItemForHourlyRate.Text = "Hourly Rate";
            this.ItemForHourlyRate.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForPayPerHour
            // 
            this.ItemForPayPerHour.Control = this.PayPerHourCheckEdit;
            this.ItemForPayPerHour.Location = new System.Drawing.Point(0, 96);
            this.ItemForPayPerHour.Name = "ItemForPayPerHour";
            this.ItemForPayPerHour.Size = new System.Drawing.Size(418, 23);
            this.ItemForPayPerHour.Text = "Pay Per Hour";
            this.ItemForPayPerHour.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForTaxable
            // 
            this.ItemForTaxable.Control = this.TaxableCheckEdit;
            this.ItemForTaxable.Location = new System.Drawing.Point(418, 96);
            this.ItemForTaxable.Name = "ItemForTaxable";
            this.ItemForTaxable.Size = new System.Drawing.Size(419, 23);
            this.ItemForTaxable.Text = "Taxable";
            this.ItemForTaxable.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForNSSFExempt
            // 
            this.ItemForNSSFExempt.Control = this.NSSFExemptCheckEdit;
            this.ItemForNSSFExempt.Location = new System.Drawing.Point(0, 119);
            this.ItemForNSSFExempt.Name = "ItemForNSSFExempt";
            this.ItemForNSSFExempt.Size = new System.Drawing.Size(418, 23);
            this.ItemForNSSFExempt.Text = "NSSF Exempt";
            this.ItemForNSSFExempt.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForNHIFExempt
            // 
            this.ItemForNHIFExempt.Control = this.NHIFExemptCheckEdit;
            this.ItemForNHIFExempt.Location = new System.Drawing.Point(418, 119);
            this.ItemForNHIFExempt.Name = "ItemForNHIFExempt";
            this.ItemForNHIFExempt.Size = new System.Drawing.Size(419, 23);
            this.ItemForNHIFExempt.Text = "NHIF Exempt";
            this.ItemForNHIFExempt.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForOverTimeExempt
            // 
            this.ItemForOverTimeExempt.Control = this.OverTimeExemptCheckEdit;
            this.ItemForOverTimeExempt.Location = new System.Drawing.Point(0, 142);
            this.ItemForOverTimeExempt.Name = "ItemForOverTimeExempt";
            this.ItemForOverTimeExempt.Size = new System.Drawing.Size(418, 24);
            this.ItemForOverTimeExempt.Text = "Over Time Exempt";
            this.ItemForOverTimeExempt.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForReviewType
            // 
            this.ItemForReviewType.Control = this.ReviewTypeTextEdit;
            this.ItemForReviewType.Location = new System.Drawing.Point(418, 142);
            this.ItemForReviewType.Name = "ItemForReviewType";
            this.ItemForReviewType.Size = new System.Drawing.Size(419, 24);
            this.ItemForReviewType.Text = "Review Type";
            this.ItemForReviewType.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForAccNo
            // 
            this.ItemForAccNo.Control = this.AccNoTextEdit;
            this.ItemForAccNo.Location = new System.Drawing.Point(418, 190);
            this.ItemForAccNo.Name = "ItemForAccNo";
            this.ItemForAccNo.Size = new System.Drawing.Size(419, 24);
            this.ItemForAccNo.Text = "Acc No";
            this.ItemForAccNo.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForAccName
            // 
            this.ItemForAccName.Control = this.AccNameTextEdit;
            this.ItemForAccName.Location = new System.Drawing.Point(0, 190);
            this.ItemForAccName.Name = "ItemForAccName";
            this.ItemForAccName.Size = new System.Drawing.Size(418, 24);
            this.ItemForAccName.Text = "Acc Name";
            this.ItemForAccName.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.glBank;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem2.Text = "Bank";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForBankBranch
            // 
            this.ItemForBankBranch.Control = this.BankBranchLookUpEdit;
            this.ItemForBankBranch.Location = new System.Drawing.Point(418, 166);
            this.ItemForBankBranch.Name = "ItemForBankBranch";
            this.ItemForBankBranch.Size = new System.Drawing.Size(419, 24);
            this.ItemForBankBranch.Text = "Bank Branch";
            this.ItemForBankBranch.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForAnnualSalary
            // 
            this.ItemForAnnualSalary.Control = this.AnnualSalaryTextEdit;
            this.ItemForAnnualSalary.Location = new System.Drawing.Point(418, 48);
            this.ItemForAnnualSalary.Name = "ItemForAnnualSalary";
            this.ItemForAnnualSalary.Size = new System.Drawing.Size(419, 24);
            this.ItemForAnnualSalary.Text = "Annual Salary";
            this.ItemForAnnualSalary.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForImage});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(837, 214);
            this.layoutControlGroup6.Text = "Passport";
            // 
            // ItemForImage
            // 
            this.ItemForImage.Control = this.ImagePictureEdit;
            this.ItemForImage.Location = new System.Drawing.Point(0, 0);
            this.ItemForImage.Name = "ItemForImage";
            this.ItemForImage.Size = new System.Drawing.Size(837, 214);
            this.ItemForImage.StartNewLine = true;
            this.ItemForImage.Text = "Image";
            this.ItemForImage.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForImage.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 286);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(861, 240);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.toolStrip1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(861, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // spSelectAllEmployeesMasterTableAdapter
            // 
            this.spSelectAllEmployeesMasterTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesTableAdapter
            // 
            this.userCodesTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesJobtypeTableAdapter
            // 
            this.userCodesJobtypeTableAdapter.ClearBeforeFill = true;
            // 
            // userCodesJobGradeTableAdapter
            // 
            this.userCodesJobGradeTableAdapter.ClearBeforeFill = true;
            // 
            // banksTableAdapter
            // 
            this.banksTableAdapter.ClearBeforeFill = true;
            // 
            // bankBranchesTableAdapter
            // 
            this.bankBranchesTableAdapter.ClearBeforeFill = true;
            // 
            // countiesTableAdapter
            // 
            this.countiesTableAdapter.ClearBeforeFill = true;
            // 
            // frmEmployeeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 546);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmEmployeeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Master";
            this.Load += new System.EventHandler(this.frmEmployeeMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployeeMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmployeesMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllEmployeesMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostCenterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNamesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PINNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSSFNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxTableTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HireDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HireDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStartDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStartDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayEndDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayEndDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveStartDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaveStartDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationalityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsDisabledCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabilityDescTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOBDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetirementDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetirementDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaritalStatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupervisorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesJobtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobGradeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCodesJobGradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayFreqTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnnualSalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasicSalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HrsPerDayTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourlyRateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayPerHourCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxableCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSSFExemptCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHIFExemptCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverTimeExemptCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankBranchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBranchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStatusTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCounty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPINNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIDNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNSSFNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInsuranceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHireDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLeaveStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhysicalAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisabilityDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRetirementDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaritalStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLanguages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupervisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBasicSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHrsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHourlyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNSSFExempt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNHIFExempt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOverTimeExempt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReviewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBankBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAnnualSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spSelectEmployeesMasterBindingSource;
        private Class.DataSet.dsEmployeeMaster dsEmployeeMaster;
        private Class.DataSet.dsEmployeeMasterTableAdapters.spSelectEmployeesMasterTableAdapter spSelectEmployeesMasterTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource spSelectAllEmployeesMasterBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNames;
        private DevExpress.XtraGrid.Columns.GridColumn colPINNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNSSFNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInsuranceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNationality;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhysicalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDOB;
        private DevExpress.XtraGrid.Columns.GridColumn colJobGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colBasicSalary;
        private DevExpress.XtraEditors.LookUpEdit CostCenterLookUpEdit;
        private DevExpress.XtraEditors.TextEdit EmpNoTextEdit;
        private DevExpress.XtraEditors.TextEdit EmpNamesTextEdit;
        private DevExpress.XtraEditors.LookUpEdit CountryLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit CountyLookUpEdit;
        private DevExpress.XtraEditors.TextEdit PINNoTextEdit;
        private DevExpress.XtraEditors.TextEdit IDNoTextEdit;
        private DevExpress.XtraEditors.TextEdit NSSFNoTextEdit;
        private DevExpress.XtraEditors.TextEdit TaxTableTextEdit;
        private DevExpress.XtraEditors.TextEdit InsuranceNoTextEdit;
        private DevExpress.XtraEditors.LookUpEdit DepartmentLookUpEdit;
        private DevExpress.XtraEditors.DateEdit HireDateDateEdit;
        private DevExpress.XtraEditors.DateEdit PayStartDateDateEdit;
        private DevExpress.XtraEditors.DateEdit PayEndDateDateEdit;
        private DevExpress.XtraEditors.DateEdit LeaveStartDateDateEdit;
        private DevExpress.XtraEditors.TextEdit NationalityTextEdit;
        private DevExpress.XtraEditors.TextEdit PostalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit PhysicalAddressTextEdit;
        private DevExpress.XtraEditors.TextEdit MobileTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsDisabledCheckEdit;
        private DevExpress.XtraEditors.TextEdit DisabilityDescTextEdit;
        private DevExpress.XtraEditors.DateEdit DOBDateEdit;
        private DevExpress.XtraEditors.DateEdit RetirementDateDateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit MaritalStatusComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit GenderComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit LanguagesTextEdit;
        private DevExpress.XtraEditors.TextEdit SupervisorTextEdit;
        private DevExpress.XtraEditors.PictureEdit ImagePictureEdit;
        private DevExpress.XtraEditors.LookUpEdit JobTypeLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit JobGradeLookUpEdit;
        private DevExpress.XtraEditors.TextEdit PayFreqTextEdit;
        private DevExpress.XtraEditors.TextEdit AnnualSalaryTextEdit;
        private DevExpress.XtraEditors.TextEdit BasicSalaryTextEdit;
        private DevExpress.XtraEditors.TextEdit HrsPerDayTextEdit;
        private DevExpress.XtraEditors.TextEdit HourlyRateTextEdit;
        private DevExpress.XtraEditors.CheckEdit PayPerHourCheckEdit;
        private DevExpress.XtraEditors.CheckEdit TaxableCheckEdit;
        private DevExpress.XtraEditors.CheckEdit NSSFExemptCheckEdit;
        private DevExpress.XtraEditors.CheckEdit NHIFExemptCheckEdit;
        private DevExpress.XtraEditors.CheckEdit OverTimeExemptCheckEdit;
        private DevExpress.XtraEditors.TextEdit ReviewTypeTextEdit;
        private DevExpress.XtraEditors.LookUpEdit BankBranchLookUpEdit;
        private DevExpress.XtraEditors.TextEdit AccNoTextEdit;
        private DevExpress.XtraEditors.TextEdit AccNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPostalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhysicalAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobile;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsDisabled;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDisabilityDesc;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDOB;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRetirementDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaritalStatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGender;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLanguages;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupervisor;
        private DevExpress.XtraLayout.LayoutControlItem ItemForImage;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostCenter;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNames;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountry;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCounty;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPINNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIDNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNSSFNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxTable;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInsuranceNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDepartment;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHireDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayStartDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayEndDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLeaveStartDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNationality;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayStatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJobType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJobGrade;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayFreq;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAnnualSalary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBasicSalary;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHrsPerDay;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHourlyRate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayPerHour;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxable;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNSSFExempt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNHIFExempt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOverTimeExempt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReviewType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBankBranch;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Class.DataSet.dsEmployeeMasterTableAdapters.spSelectAllEmployeesMasterTableAdapter spSelectAllEmployeesMasterTableAdapter;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource userCodesBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.UserCodesTableAdapter userCodesTableAdapter;
        private System.Windows.Forms.BindingSource userCodesJobtypeBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.UserCodesJobtypeTableAdapter userCodesJobtypeTableAdapter;
        private System.Windows.Forms.BindingSource userCodesJobGradeBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.UserCodesJobGradeTableAdapter userCodesJobGradeTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit glBank;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.BanksTableAdapter banksTableAdapter;
        private System.Windows.Forms.BindingSource bankBranchesBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.BankBranchesTableAdapter bankBranchesTableAdapter;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private Class.DataSet.dsEmployeeMasterTableAdapters.CountiesTableAdapter countiesTableAdapter;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraEditors.ComboBoxEdit PayStatusTextEdit;
        private System.Windows.Forms.ToolStripButton tlNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}