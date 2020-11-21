namespace LoanProgram.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1More : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applicant", "FirstName", c => c.String());
            AlterColumn("dbo.Applicant", "LastName", c => c.String());
            AlterColumn("dbo.Applicant", "Address", c => c.String());
            AlterColumn("dbo.Applicant", "MarriageStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicant", "MarriageStatus", c => c.String(nullable: false));
            AlterColumn("dbo.Applicant", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Applicant", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Applicant", "FirstName", c => c.String(nullable: false));
        }
    }
}
