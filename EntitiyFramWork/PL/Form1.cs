using EntitiyFramWork.BL;
using EntitiyFramWork.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EntitiyFramWork
{
    public partial class Form1 : Form
    {
        Iventory iven = new Iventory();

        int currentEmployeeId;
        int currentSkillsId;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            // loading base Values in tabels (POCO)
            if (!iven.ChackedIfDataExsist()) {
                using (EntityContext entityContext = new EntityContext())
                {
                    BasicFirstData basicValue = new BasicFirstData();
                    foreach (Employees emp in basicValue.GetBasicEmployeeValues())
                    {
                        entityContext.Employees.Add(emp);
                    }
                    foreach (EmpReference refe in basicValue.GetBasicReferenceValues())
                    {
                        entityContext.EmpReferences.Add(refe);
                    }
                    foreach (Skill skill in basicValue.GetBasicSkillsValues())
                    {
                        entityContext.skills.Add(skill);
                    }
                    foreach (SkillsInfo skillinfo in basicValue.GetSkillsInfosBasicValue())
                    {
                        entityContext.SkillsInfos.Add(skillinfo);
                    }
                    entityContext.SaveChanges();
                }
            }

            // fill at first time the Employee grid view
            FillgrvEmployees();
             currentEmployeeId = int.Parse(grvEmployees.CurrentRow.Cells["EmployeeId"].Value.ToString());
            
          
            //fill at first time the skills grid view 
            FillInSkillsgrv(currentEmployeeId);
            currentSkillsId = int.Parse(grvSkills.CurrentRow.Cells["SkillId"].Value.ToString());

            //fill the skills and reference info
            FillInRTXTSkillsAndReferences(currentSkillsId, currentEmployeeId);

            
        }

        // building the string for info texbox view (skills/referenecs)
        public string GetStringToInfoGridView( int skillId , int employeId)
        {
            string showInGrid = null;

            string url= iven.GetSkillURL(skillId);
            string[] reference = iven.GetReferences(employeId);

            showInGrid = "Skill Name: " + grvSkills.CurrentRow.Cells["SkillName"].Value.ToString() + "\r\n" +
                          grvSkills.CurrentRow.Cells["BriefDescription"].Value.ToString() + "\r\n\r\n\r\n" +
                          "Skill information:\r\n" + url + "\r\n\r\n\r\n";
            foreach (string item in reference)
            {
                showInGrid = showInGrid + " " + item + "br" ;
            }
            return showInGrid;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // get the link to work
        private void mRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
        // fill the Employee table
        private void FillgrvEmployees(string serchingskills = "0")
        {
            grvEmployees.AutoGenerateColumns = false;
            grvEmployees.DataSource = iven.GetAllEmployees();

            if(serchingskills != "0")
            {
                grvEmployees.DataSource = iven.GetEmployeesIdFromSkillsNames(serchingskills);
            }
        }
        // fill the skill table
        private void FillInSkillsgrv(int employeeId)
        {
            grvSkills.AutoGenerateColumns = false;
            grvSkills.DataSource = iven.GetSkillsById(employeeId);

        }
        // fill the info text
        private void FillInRTXTSkillsAndReferences(int currentSkillsId, int currentEmployeeId)
        {
            rtxtSkillsAndReferences.Text = GetStringToInfoGridView(currentSkillsId, currentEmployeeId);
        }

        // What hapend when selected employee changed
        private void grvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            currentEmployeeId = int.Parse(grvEmployees.CurrentRow.Cells["EmployeeId"].Value.ToString());
            FillInSkillsgrv(currentEmployeeId);
        }

        //What hapend when selected skill changed
        private void grvSkills_SelectionChanged(object sender, EventArgs e)
        {
            currentSkillsId = int.Parse(grvSkills.CurrentRow.Cells["SkillId"].Value.ToString());
            FillInRTXTSkillsAndReferences(currentSkillsId, currentEmployeeId);
        }

        private void btnSearchForSkills_Click(object sender, EventArgs e)
        {
            
            string[] wantedSkillsArr = txtSerchForSkills.Text.Split(' ');
            string wantedSkills = string.Join("' or SkillName = '", wantedSkillsArr);
            wantedSkills = "'" + wantedSkills + "'";
            FillgrvEmployees(wantedSkills);

        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) 
            btnSearchForSkills_Click(txtSerchForSkills.Text , e);
        }

        private void btnClearSearchSkills_Click(object sender, EventArgs e)
        {
            FillgrvEmployees();
            txtSerchForSkills.Text = " Add keywords separated by a space. Press <Enter> to search.";
        }

        private void txtSerchForSkills_Click(object sender, EventArgs e)
        {
            if (txtSerchForSkills.Text == " Add keywords separated by a space. Press <Enter> to search.")
            {
                txtSerchForSkills.Text = "";
            } 
        }

        private void btnSubmitNewInfo_Click(object sender, EventArgs e)
        {
            if(txtNewURLToSkill.Text.Length > 0)
            iven.AddUrlToSkill(currentSkillsId, txtNewURLToSkill.Text);
        }

        private void btnSubmitNewEmployee_Click(object sender, EventArgs e)
        {
            if((txtNewEmpLastName.TextLength > 0) && (txtNewEmpAlias.TextLength > 0) )
            {
                iven.InsertNewEmp(txtNewEmpLastName.Text, txtNewEmpFirstName.Text, txtNewEmpAlias.Text, txtNewEmpEmail.Text);
                FillgrvEmployees();
            }
            else
            {
                MessageBox.Show("Last Name and Alias are required");
            }
        }

        private void btnSubmitNewSkill_Click(object sender, EventArgs e)
        {
            iven.AddNewSkill(currentEmployeeId, txtNewSkillName.Text, txtNewBrief.Text);
            FillInSkillsgrv(currentEmployeeId);
        }

        private void btnSubmitNewReferencePerson_Click(object sender, EventArgs e)
        {
            if(txtNewRefLastName.Text.Length > 0)
            {
                iven.AddNewReferences(currentEmployeeId, txtNewRefLastName.Text, txtNewRefFirestName.Text, txtNewRefPosotion.Text,"there is no Alias", txtNewRefEmail.Text);
            }
            else
            {
                MessageBox.Show("Last Name is required");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            FillgrvEmployees();
            txtSerchForSkills.Text = "Add keywords separated by a space. Press <Enter> to search.";
        }
    }
}
