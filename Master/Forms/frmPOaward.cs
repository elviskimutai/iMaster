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

namespace Master.Forms
{
    public partial class frmPOaward : DevExpress.XtraEditors.XtraForm
    {
        public frmPOaward()
        {
            InitializeComponent();
            
        }

        private void frmPOaward_Load(object sender, EventArgs e)
        {
            try
            {
                spGetCompanyCostCentersTableAdapter.Fill(dsPOAward.spGetCompanyCostCenters, AppConstant.CompCode, AppConstant.UserID);
                glCostCenter.EditValue = dsPOAward.spGetCompanyCostCenters.DataSet.Tables["spGetCompanyCostCenters"].Rows[0]["CCCode"].ToString();

            }
            catch (Exception)
            {

               
            }
        }

        private void glCostCenter_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetDepartmentRequisitionsTableAdapter.Fill(dsPOAward.spGetDepartmentRequisitions, glCostCenter.EditValue.ToString());
            }
            catch (Exception)
            {

                
            }
        }

        private void glDepartment_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spGetDeptRequsitionNoTableAdapter.Fill(dsPOAward.spGetDeptRequsitionNo, glDepartment.EditValue.ToString());
            }
            catch (Exception)
            {

                
            }
        }

        private void glRequisition_EditValueChanged(object sender, EventArgs e)
        {
            spGetReqQuotsTableAdapter.Fill(dsPOAward.spGetReqQuots, glRequisition.EditValue.ToString());
        }

        private void glQuotation_EditValueChanged(object sender, EventArgs e)
        {
            spSelectReqQuotationsTableAdapter.Fill(dsPOAward.spSelectReqQuotations, glQuotation.EditValue.ToString(),glRequisition.EditValue.ToString());
        }
        public bool ApproveQuotation()
        {
            try
            {
                Int32[] selectedRowHandles = gridView1.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                    {
                        string item = Convert.ToString(gridView1.GetRowCellValue(selectedRowHandle, colitemCode));
                        spSelectReqQuotationsTableAdapter.spApproveSupplierQuotations(glQuotation.EditValue.ToString(), item);
                       
                    }
                }

               
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
         public bool DeclineQuotation()
        {
            try
            {
                Int32[] selectedRowHandles = gridView1.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                    {
                        string item = Convert.ToString(gridView1.GetRowCellValue(selectedRowHandle, colitemCode));
                        spSelectReqQuotationsTableAdapter.spDeclineSupplierQuotations(glQuotation.EditValue.ToString(), item);
                    }
                }
               
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void spSave_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("Click YES to approve this Quotation.", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                  
                        if (ApproveQuotation() == true)
                        {
                        MessageBox.Show("You have successfully approved the quotation.");

                    }
                   
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dsPOAward.spSelectReqQuotations.Clear();
                glRequisition_EditValueChanged(sender, e);
                glQuotation_EditValueChanged(sender, e);
                glDepartment_EditValueChanged(sender, e);
            }


        }
        private void spDecline_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("You are about to decline this qoutation item.Click OK to proceed.", "Confirm!", MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {

                    if (DeclineQuotation() == true)
                    {
                        MessageBox.Show("You have declined the quotation.");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                dsPOAward.spSelectReqQuotations.Clear();
                glRequisition_EditValueChanged(sender, e);
                glQuotation_EditValueChanged(sender, e);
                glDepartment_EditValueChanged(sender, e);
            }


        }
    }
}