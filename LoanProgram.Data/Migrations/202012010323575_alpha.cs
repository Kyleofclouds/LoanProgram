namespace LoanProgram.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alpha : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applicant", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Applicant", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Applicant", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Applicant", "MarriageStatus", c => c.String(nullable: false));
            AlterColumn("dbo.Application", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Application", "Description", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Applicant", "MarriageStatus", c => c.String());
            AlterColumn("dbo.Applicant", "Address", c => c.String());
            AlterColumn("dbo.Applicant", "LastName", c => c.String());
            AlterColumn("dbo.Applicant", "FirstName", c => c.String());
        }
    }
}
