using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace EntitiyFramWork.Poco
{
    public class EntityContext : DbContext
    {

        public EntityContext() : base("name=EmployeeConnectionString")
        {           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EntityContext>());
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmpReference> EmpReferences { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<SkillsInfo> SkillsInfos { get; set; }


    }
}
