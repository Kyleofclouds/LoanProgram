namespace LoanProgram.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Application", "Salary", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Application", "Salary", c => c.Int(nullable: false));
        }
    }
}
