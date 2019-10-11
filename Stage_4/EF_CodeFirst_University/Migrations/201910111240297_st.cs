namespace EF_CodeFirst_University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class st : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Deans", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Deans", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Lecturers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Lecturers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Rectors", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Rectors", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rectors", "LastName", c => c.String());
            AlterColumn("dbo.Rectors", "FirstName", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Lecturers", "LastName", c => c.String());
            AlterColumn("dbo.Lecturers", "FirstName", c => c.String());
            AlterColumn("dbo.Deans", "LastName", c => c.String());
            AlterColumn("dbo.Deans", "FirstName", c => c.String());
        }
    }
}
