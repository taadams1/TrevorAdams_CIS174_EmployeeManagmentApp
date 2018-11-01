namespace EmployeeManager.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Guid(nullable: false),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        Department = c.String(),
                        JobTitle = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalaryType = c.Int(nullable: false),
                        AvailableHours = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
