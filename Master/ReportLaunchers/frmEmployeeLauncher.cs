using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Master.Class.Report;

namespace Master.ReportLaunchers
{
    public partial class frmEmployeeLauncher : DevExpress.XtraEditors.XtraForm
    {
        public frmEmployeeLauncher()
        {
            InitializeComponent();
            //AppConstant.UserID = "steve@live.com";
            //AppConstant.CompCode = "001";
        }

        private void frmEmployeeLauncher_Load(object sender, EventArgs e)
        {
            spGetCompanyCostCentersTableAdapter.Fill(dsEmployeeReport.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
            glCostCenter.EditValue = dsEmployeeReport.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["cccode"].ToString();
            userCodesTableAdapter.Fill(dsEmployeeReport.UserCodes, "Departments");
            glDepartment.EditValue = dsEmployeeReport.UserCodes.DataSet.Tables["UserCodes"].Rows[0]["Code"].ToString();
            chkAllDepartments.Checked = true;
            chkAllCostCenters.Checked = true;
        }

        public void LaunchReport()
        {
            try
            {
                AppConstant.ReportName = "Employee Report";
                switch (AppConstant.ReportName)
                {

                    case "Employee Report":
                        this.LaunchEmployeeReport();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
        public void LaunchEmployeeReport()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptEmployee _rptEmployee = new rptEmployee();
                spGetEmployeesTableAdapter.Fill(dsEmployeeReport.spGetEmployees, AppConstant.CompCode, glCostCenter.EditValue.ToString(), chkAllCostCenters.Checked, glDepartment.EditValue.ToString(), chkAllDepartments.Checked);
                _rptEmployee.DataSource = dsEmployeeReport.spGetEmployees;
                _rptEmployee.DataSourceSchema = dsEmployeeReport.spGetEmployees.DataSet.GetXmlSchema();
                _rptEmployee.DataMember = "spGetEmployees";
                _rptEmployee.CreateDocument();

                this.documentViewer1.DocumentSource = _rptEmployee;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! There are no records for specified parameters.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LaunchReport();
        }
    }
}