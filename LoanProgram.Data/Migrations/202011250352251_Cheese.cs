namespace LoanProgram.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cheese : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Applicant", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applicant", "Photo", c => c.String());
        }
    }
}
