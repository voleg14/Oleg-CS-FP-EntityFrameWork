using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFramWork.Poco
{
    class BasicFirstData
    {
        public Employees[] GetBasicEmployeeValues()
        {
            Employees[] empArr = new Employees[] {
          new Employees { EmployeeId = 1, LastName = "Durocher", FirstName = "Yolanda", Alias = "Man",Email = "Dick@gmail.com" },
          new Employees { EmployeeId = 2, LastName = "Dealba", FirstName = "Morgan", Alias = "Alpha",Email = "Morgan@walla.com" },
          new Employees { EmployeeId = 3, LastName = "Selvy", FirstName = "Stefanie", Alias = "Bitmap",Email = "Yolanda@yandex.ru" },
          new Employees { EmployeeId = 4, LastName = "Dockstader", FirstName = "Diann", Alias = "Bowie",Email = "Bitmap@mail.ru" },
          new Employees { EmployeeId = 5, LastName = "Parnell", FirstName = "Shanice", Alias = "Bowler",Email = "Threadgill@yahoo.com" },
          new Employees { EmployeeId = 6, LastName = "Mattern", FirstName = "Lavone", Alias = "Lady Killer",Email = "Threadgill@gmail.com" },
          new Employees { EmployeeId = 7, LastName = "Threadgill", FirstName = "Dick", Alias = "Mad Jack",Email = "Speedwell@yahoo.com" },
          new Employees { EmployeeId = 8, LastName = "Steinfeldt", FirstName = "Luna", Alias = "Commando",Email = "Bowler@yahoo.co.il" },
          new Employees { EmployeeId = 9, LastName = "Sesco", FirstName = "Sherlyn", Alias = "Speedwell",Email = "Commando@gmail.com" },
          new Employees { EmployeeId = 10, LastName = "Haslem", FirstName = "Dorian", Alias = "Cujo",Email = "Cujo@gmail.com" }};
            return empArr;
        }
        public EmpReference[] GetBasicReferenceValues()
        {
            EmpReference[] refArr = new EmpReference[]
            {
                new EmpReference {LastName = "Yessenia"     ,FirstName = "Mancia"     ,Position = "Administrator"  ,Alias = "Manimal", EmployeeId= 1, Email="vAdministrator@gmail.com"},
                new EmpReference {LastName = "Marguez"      ,FirstName = "Gracia"     ,Position = "Programmer"     ,Alias = "Speedwell", EmployeeId= 3, Email="Programmer@walla.co.il"},
                new EmpReference {LastName = "Remus"        ,FirstName = "Leighann"   ,Position = "Developer"      ,Alias = "Sofa King", EmployeeId= 4, Email="Remus@mail.ru"},
                new EmpReference {LastName = "Lamb"         ,FirstName = "Philip"     ,Position = "Developer"      ,Alias = "Sky Bully", EmployeeId= 5, Email="Zabel@yahoo.co.il"},
                new EmpReference {LastName = "Fennel"       ,FirstName = "Sheila"     ,Position = "Developer"      ,Alias = "Skull Crusher", EmployeeId= 6, Email="Sheila@ort.gov.il"},
                new EmpReference {LastName = "Zabel"        ,FirstName = "Tessa"      ,Position = "Programmer"     ,Alias = "Little Cobra", EmployeeId= 7, Email="Programmer@walla.com"},
                new EmpReference {LastName = "Geist"        ,FirstName = "Bettye"     ,Position = "Administrator"  ,Alias = "Celtic Charger", EmployeeId= 8, Email="Celtic@yandex.ru"},
                new EmpReference {LastName = "Artman"       ,FirstName = "Willette"   ,Position = "Programmer"     ,Alias = "Midas", EmployeeId= 9, Email="Midas@gmail.co.il"},
                new EmpReference {LastName = "Charlesworth" ,FirstName = "Stefany"    ,Position = "Developer"      ,Alias = "Swerve", EmployeeId= 10, Email="Swerve@walla.com"},
                new EmpReference {LastName = "Doster"       ,FirstName = "Colene "    ,Position = "Programmer"     ,Alias = "Cujo", EmployeeId= 1, Email="Cujo@gmail.com"},
                new EmpReference {LastName = "Kindred"      ,FirstName = "Shenita"    ,Position = "Administrator"  ,Alias = "Cosmo", EmployeeId= 2, Email="Cosmo@gmail.com"},
                new EmpReference {LastName = "Jagger"       ,FirstName = "Janett"     ,Position = "Manager"        ,Alias = "Chuckles", EmployeeId= 2, Email="Chuckles@gmail.com"},
                new EmpReference {LastName = "Ricks"        ,FirstName = "Angeline"   ,Position = "Developer"      ,Alias = "Commando", EmployeeId= 5, Email="Janett@gmail.com"},
                new EmpReference {LastName = "Blumenfeld"   ,FirstName = "Concepcion" ,Position = "Administrator"  ,Alias = "Cosmo", EmployeeId= 6, Email="Concepcion@gmail.com"},
                new EmpReference {LastName = "Wiliams"      ,FirstName = "Lavern"     ,Position = "Manager"        ,Alias = "Squatch", EmployeeId= 8, Email="Lavern@gmail.com"},
            };
            return refArr;
        }

        public Skill[] GetBasicSkillsValues()
        {
            Skill[] skArr = new Skill[]
            {
                new Skill {SkillId = 1, EmployeeId = 1 , SkillName = "C#" , BriefDescription = "C# is an elegant and type-safe object-oriented language that enables developers to build a variety of secure and robust applications that run on the .NET Framework. You can use C# to create Windows client applications, XML Web services, distributed components, client-server applications, database applications, and much, much more. Visual C# provides an advanced code editor, convenient user interface designers, integrated debugger, and many other tools to make it easier to develop applications based on the C# language and the .NET Framework."},
                new Skill {SkillId = 2, EmployeeId = 2 , SkillName = "C#" , BriefDescription = "C# is an elegant and type-safe object-oriented language that enables developers to build a variety of secure and robust applications that run on the .NET Framework. You can use C# to create Windows client applications, XML Web services, distributed components, client-server applications, database applications, and much, much more. Visual C# provides an advanced code editor, convenient user interface designers, integrated debugger, and many other tools to make it easier to develop applications based on the C# language and the .NET Framework."},
                new Skill {SkillId = 3, EmployeeId = 3 , SkillName = "C#" , BriefDescription = "C# is an elegant and type-safe object-oriented language that enables developers to build a variety of secure and robust applications that run on the .NET Framework. You can use C# to create Windows client applications, XML Web services, distributed components, client-server applications, database applications, and much, much more. Visual C# provides an advanced code editor, convenient user interface designers, integrated debugger, and many other tools to make it easier to develop applications based on the C# language and the .NET Framework."},
                new Skill {SkillId = 4, EmployeeId = 4 , SkillName = "C#" , BriefDescription = "C# is an elegant and type-safe object-oriented language that enables developers to build a variety of secure and robust applications that run on the .NET Framework. You can use C# to create Windows client applications, XML Web services, distributed components, client-server applications, database applications, and much, much more. Visual C# provides an advanced code editor, convenient user interface designers, integrated debugger, and many other tools to make it easier to develop applications based on the C# language and the .NET Framework."},
                new Skill {SkillId = 5, EmployeeId = 5 , SkillName = "C#" , BriefDescription = "C# is an elegant and type-safe object-oriented language that enables developers to build a variety of secure and robust applications that run on the .NET Framework. You can use C# to create Windows client applications, XML Web services, distributed components, client-server applications, database applications, and much, much more. Visual C# provides an advanced code editor, convenient user interface designers, integrated debugger, and many other tools to make it easier to develop applications based on the C# language and the .NET Framework."},
                new Skill {SkillId = 6, EmployeeId = 1 , SkillName = "ADO.NET 2.0" , BriefDescription = "ADO.NET 2.0 is a Microsoft specification that provides data access features designed to work together for provider independence, increased component reuse, and application convertibility. Additional features make it easier for an application to dynamically discover information about the data source, schema, and provider."},
                new Skill {SkillId = 7, EmployeeId = 2 , SkillName = "ADO.NET 2.0" , BriefDescription = "ADO.NET 2.0 is a Microsoft specification that provides data access features designed to work together for provider independence, increased component reuse, and application convertibility. Additional features make it easier for an application to dynamically discover information about the data source, schema, and provider."},
                new Skill {SkillId = 8, EmployeeId = 3 , SkillName = "ADO.NET 2.0" , BriefDescription = "ADO.NET 2.0 is a Microsoft specification that provides data access features designed to work together for provider independence, increased component reuse, and application convertibility. Additional features make it easier for an application to dynamically discover information about the data source, schema, and provider."},
                new Skill {SkillId = 9, EmployeeId = 6 , SkillName = "ADO.NET 2.0" , BriefDescription = "ADO.NET 2.0 is a Microsoft specification that provides data access features designed to work together for provider independence, increased component reuse, and application convertibility. Additional features make it easier for an application to dynamically discover information about the data source, schema, and provider."},
                new Skill {SkillId = 10, EmployeeId = 7 , SkillName = "ADO.NET 2.0" , BriefDescription = "ADO.NET 2.0 is a Microsoft specification that provides data access features designed to work together for provider independence, increased component reuse, and application convertibility. Additional features make it easier for an application to dynamically discover information about the data source, schema, and provider."},
                new Skill {SkillId = 11, EmployeeId = 8 , SkillName = ".NET Programming" , BriefDescription = ".NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library named Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (in contrast to a hardware environment) named Common Language Runtime (CLR), an application virtual machine that provides services such as security, memory management, and exception handling.FCL and CLR together constitute .NET Framework"},
                new Skill {SkillId = 12, EmployeeId = 9 , SkillName = ".NET Programming" , BriefDescription = ".NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library named Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (in contrast to a hardware environment) named Common Language Runtime (CLR), an application virtual machine that provides services such as security, memory management, and exception handling. FCL and CLR together constitute .NET Framework"},
                new Skill {SkillId = 13, EmployeeId = 10 , SkillName = ".NET Programming" , BriefDescription = ".NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library named Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (in contrast to a hardware environment) named Common Language Runtime (CLR), an application virtual machine that provides services such as security, memory management, and exception handling.FCL and CLR together constitute .NET Framework"},
                new Skill {SkillId = 14, EmployeeId = 8, SkillName = "sql developer" , BriefDescription = "SQL is a declarative programming language that is used in many relational databases. The specific syntax of SQL may vary a little from database to database, but the relevant concepts are mostly the same. However, there is a difference between knowing these concepts of SQL and actually being able to write sound, efficient, and proper SQL statements ensuring stability, reliability, and performance of databases."},
                new Skill {SkillId = 15, EmployeeId = 9, SkillName = "sql developer" , BriefDescription = "SQL is a declarative programming language that is used in many relational databases. The specific syntax of SQL may vary a little from database to database, but the relevant concepts are mostly the same. However, there is a difference between knowing these concepts of SQL and actually being able to write sound, efficient, and proper SQL statements ensuring stability, reliability, and performance of databases."},
                new Skill {SkillId = 16, EmployeeId = 1 , SkillName = "sql developer" , BriefDescription = "SQL is a declarative programming language that is used in many relational databases. The specific syntax of SQL may vary a little from database to database, but the relevant concepts are mostly the same. However, there is a difference between knowing these concepts of SQL and actually being able to write sound, efficient, and proper SQL statements ensuring stability, reliability, and performance of databases."},
                new Skill {SkillId = 17, EmployeeId = 5 , SkillName = "sql developer" , BriefDescription = "SQL is a declarative programming language that is used in many relational databases. The specific syntax of SQL may vary a little from database to database, but the relevant concepts are mostly the same. However, there is a difference between knowing these concepts of SQL and actually being able to write sound, efficient, and proper SQL statements ensuring stability, reliability, and performance of databases."},
                new Skill {SkillId = 18, EmployeeId = 6 , SkillName = "sql developer" , BriefDescription = "SQL is a declarative programming language that is used in many relational databases. The specific syntax of SQL may vary a little from database to database, but the relevant concepts are mostly the same. However, there is a difference between knowing these concepts of SQL and actually being able to write sound, efficient, and proper SQL statements ensuring stability, reliability, and performance of databases."},
                new Skill {SkillId = 19, EmployeeId = 9 , SkillName = "AJAX" , BriefDescription = "Ajax (also AJAX /ˈeɪdʒæks/; short for 'Asynchronous JavaScript And XML')[1][2] is a set of Web development techniques using many Web technologies on the client side to create asynchronous Web applications. With Ajax, Web applications can send and retrieve data from a server asynchronously (in the background) without interfering with the display and behavior of the existing page. By decoupling the data interchange layer from the presentation layer, Ajax allows Web pages, and by extension Web applications, to change content dynamically without the need to reload the entire page.[3] In practice, modern implementations commonly utilize JSON instead of XML due to the advantages of JSON being native to JavaScript"},
                new Skill {SkillId = 20, EmployeeId = 8 , SkillName = "AJAX" , BriefDescription = "Ajax (also AJAX /ˈeɪdʒæks/; short for 'Asynchronous JavaScript And XML')[1][2] is a set of Web development techniques using many Web technologies on the client side to create asynchronous Web applications. With Ajax, Web applications can send and retrieve data from a server asynchronously (in the background) without interfering with the display and behavior of the existing page. By decoupling the data interchange layer from the presentation layer, Ajax allows Web pages, and by extension Web applications, to change content dynamically without the need to reload the entire page.[3] In practice, modern implementations commonly utilize JSON instead of XML due to the advantages of JSON being native to JavaScript"},
                new Skill {SkillId = 21, EmployeeId = 4 , SkillName = "AJAX" , BriefDescription = "Ajax (also AJAX /ˈeɪdʒæks/; short for 'Asynchronous JavaScript And XML')[1][2] is a set of Web development techniques using many Web technologies on the client side to create asynchronous Web applications. With Ajax, Web applications can send and retrieve data from a server asynchronously (in the background) without interfering with the display and behavior of the existing page. By decoupling the data interchange layer from the presentation layer, Ajax allows Web pages, and by extension Web applications, to change content dynamically without the need to reload the entire page.[3] In practice, modern implementations commonly utilize JSON instead of XML due to the advantages of JSON being native to JavaScript"}
            };
            return skArr;
        }

        public SkillsInfo[] GetSkillsInfosBasicValue()
        {
            SkillsInfo[] skillinfo = new SkillsInfo[]
            {
                new SkillsInfo {SkillId = 1 , URL = "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework"},
                new SkillsInfo {SkillId = 2, URL = "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework"},
                new SkillsInfo {SkillId = 3, URL = "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework"},
                new SkillsInfo {SkillId = 4, URL = "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework"},
                new SkillsInfo {SkillId = 5, URL = "https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework"},
                new SkillsInfo {SkillId = 6, URL = "https://docs.oracle.com/cd/B28359_01/win.111/b28375/featADO20.htm"},
                new SkillsInfo {SkillId = 7, URL = "https://docs.oracle.com/cd/B28359_01/win.111/b28375/featADO20.htm"},
                new SkillsInfo {SkillId = 8, URL = "https://docs.oracle.com/cd/B28359_01/win.111/b28375/featADO20.htm"},
                new SkillsInfo {SkillId = 9, URL = "https://docs.oracle.com/cd/B28359_01/win.111/b28375/featADO20.htm"},
                new SkillsInfo {SkillId = 10, URL = "https://docs.oracle.com/cd/B28359_01/win.111/b28375/featADO20.htm",},
                new SkillsInfo {SkillId = 11, URL = "https://en.wikipedia.org/wiki/.NET_Framework",},
                new SkillsInfo {SkillId = 12, URL = "https://en.wikipedia.org/wiki/.NET_Framework",},
                new SkillsInfo {SkillId = 13, URL = "https://en.wikipedia.org/wiki/.NET_Framework",},
                new SkillsInfo {SkillId = 14, URL = "https://www.toptal.com/sql/job-description",},
                new SkillsInfo {SkillId = 15, URL = "https://www.toptal.com/sql/job-description",},
                new SkillsInfo {SkillId = 16, URL = "https://www.toptal.com/sql/job-description",},
                new SkillsInfo {SkillId = 17, URL = "https://www.toptal.com/sql/job-description",},
                new SkillsInfo {SkillId = 18, URL = "https://www.toptal.com/sql/job-description",},
                new SkillsInfo {SkillId = 19, URL = "https://en.wikipedia.org/wiki/Ajax_(programming)",},
                new SkillsInfo {SkillId = 20, URL = "https://en.wikipedia.org/wiki/Ajax_(programming)",},
                new SkillsInfo {SkillId = 21, URL = "https://en.wikipedia.org/wiki/Ajax_(programming)",}
            };
            return skillinfo;
        }


    }
}
