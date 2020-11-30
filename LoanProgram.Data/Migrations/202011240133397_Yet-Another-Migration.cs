namespace LoanProgram.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YetAnotherMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicant", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Applicant", "Photo");
        }
    }
}
