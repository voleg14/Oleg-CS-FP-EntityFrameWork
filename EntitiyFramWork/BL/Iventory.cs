using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using EntitiyFramWork.DAL;

namespace EntitiyFramWork.BL
{
    class Iventory
    {
        public bool ChackedIfDataExsist()
        {
            bool exsist = false;
            DataTable tb = DbComunication.GetInventoryTable("Select * From Employees");

            if (tb.Rows.Count != 0)
            {
                exsist = true;
            }
            return exsist;
        }
        public DataTable GetAllEmployees()
        {
            return DbComunication.GetInventoryTable(" Select * From Employees ");
        }

        public DataTable GetSkillsById(int empId)
        {
            return DbComunication.GetInventoryTable(" Select * From Skills Where EmployeeId = " + empId);
        }

        public string GetSkillURL(int skillId)
        {
            DataTable db = DbComunication.GetInventoryTable(" Select URL From SkillsInfoes where SkillId = " + skillId);
            if(db.Rows.Count > 0)
            {
                return db.Rows[0]["URL"].ToString();
            }
            else
            {
                return " there is no url ";
            }
            
        }
        public string[] GetReferences(int employeeId)
        {
            DataTable refe = DbComunication.GetInventoryTable(" Select * From EmpReferences Where EmployeeId = " + employeeId);

            string[] anse = new string[refe.Rows.Count];
            int i = 0;
            foreach (DataRow row in refe.Rows)
            {
                anse[i] = string.Format(row["FirstName"].ToString() + " " +
                                            row["LastName"].ToString() + " Position: " +
                                            row["Position"].ToString() + " Email: " +
                                            row["Email"].ToString());
                i++;
            };


            return anse;
        }

        public DataTable GetEmployeesIdFromSkillsNames(string skillNames)
        {
            string ret = "";
            DataTable empId = DbComunication.GetInventoryTable(" Select EmployeeId From Skills Where SkillName = " + skillNames);
            foreach (DataRow row in empId.Rows)
            {
                ret = ret + "EmployeeId = '" + row["EmployeeId"].ToString() + "' ";
                if(row != empId.Rows[empId.Rows.Count -1])
                {
                    ret = ret + " or ";
                }
            }

            DataTable empKnowSkill = DbComunication.GetInventoryTable("Select * From Employees Where " + ret);
            return empKnowSkill;
        }

        public void InsertNewEmp( string lastName, string firstName, string alias, string email)
        {
            DbComunication.InsertNewEmployee(lastName, firstName, alias, email);
        }

        public void AddNewSkill( int employeeId, string skillName, string briefDesc)
        {
            DbComunication.InsertNewSkill(employeeId, skillName, briefDesc);
        }

        public void AddNewReferences(int employeeId, string lastName, string firstName, string position, string alias, string email)
        {
            DbComunication.InsertNewReferences(employeeId, lastName, firstName, position, alias, email);
        }
        public void AddUrlToSkill(int skillId, string url)
        {
            DbComunication.InsertURLToSkill(skillId, url);
        }
    }
}
