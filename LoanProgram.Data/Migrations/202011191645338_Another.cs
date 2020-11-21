namespace LoanProgram.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Another : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicant", "IsHeadOfHousehold", c => c.Boolean(nullable: false));
            DropColumn("dbo.Applicant", "HeadOfHousehold");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applicant", "HeadOfHousehold", c => c.Boolean(nullable: false));
            DropColumn("dbo.Applicant", "IsHeadOfHousehold");
        }
    }
}
