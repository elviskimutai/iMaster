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
    public partial class frmBeneficiariesReport : DevExpress.XtraEditors.XtraForm
    {
        public frmBeneficiariesReport()
        {
            InitializeComponent();
            //AppConstant.UserID = "steve@live.com";
            //AppConstant.CompCode = "001";
        }

        private void frmBeneficiaries_Load(object sender, EventArgs e)
        {
            spGetEmployeeCodesTableAdapter.Fill(dsBenefeciariesReport.spGetEmployeeCodes, AppConstant.CompCode);
            glMember.EditValue = dsBenefeciariesReport.spGetEmployeeCodes.DataSet.Tables["spGetEmployeeCodes"].Rows[0]["EmpNo"].ToString();
        }
        public void LaunchReport()
        {
             AppConstant.ReportName = "Benefeciaries Report";
            try
            {
                switch (AppConstant.ReportName)
                {
                    
                    case "Benefeciaries Report":
                        this.LaunchBeneficiariesReport();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        public void LaunchBeneficiariesReport()
        {
            try
            {

                documentViewer1.PrintingSystem = null;
                rptBeneficiaries _rptBeneficiaries = new rptBeneficiaries();
                spGetBeneficiariesTableAdapter.Fill(dsBenefeciariesReport.spGetBeneficiaries, AppConstant.CompCode, glMember.EditValue.ToString(), chkAllMembers.Checked);
                _rptBeneficiaries.DataSource = dsBenefeciariesReport.spGetBeneficiaries;
                _rptBeneficiaries.DataSourceSchema = dsBenefeciariesReport.spGetBeneficiaries.DataSet.GetXmlSchema();
                _rptBeneficiaries.DataMember = "spGetBeneficiaries";
                _rptBeneficiaries.CreateDocument();

                this.documentViewer1.DocumentSource = _rptBeneficiaries;
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