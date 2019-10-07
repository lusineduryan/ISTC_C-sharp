namespace EF_CodeFirst_University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Faculty = c.String(),
                        Rector_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rectors", t => t.Rector_Id)
                .Index(t => t.Rector_Id);
            
            CreateTable(
                "dbo.Lecturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Module = c.String(),
                        Dean_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deans", t => t.Dean_Id)
                .Index(t => t.Dean_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        University = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentLecturers",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Lecturer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Lecturer_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Lecturers", t => t.Lecturer_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Lecturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deans", "Rector_Id", "dbo.Rectors");
            DropForeignKey("dbo.StudentLecturers", "Lecturer_Id", "dbo.Lecturers");
            DropForeignKey("dbo.StudentLecturers", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Lecturers", "Dean_Id", "dbo.Deans");
            DropIndex("dbo.StudentLecturers", new[] { "Lecturer_Id" });
            DropIndex("dbo.StudentLecturers", new[] { "Student_Id" });
            DropIndex("dbo.Lecturers", new[] { "Dean_Id" });
            DropIndex("dbo.Deans", new[] { "Rector_Id" });
            DropTable("dbo.StudentLecturers");
            DropTable("dbo.Rectors");
            DropTable("dbo.Students");
            DropTable("dbo.Lecturers");
            DropTable("dbo.Deans");
        }
    }
}
