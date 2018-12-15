namespace WDDN1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ABC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        sem = c.Int(nullable: false),
                        Fullname = c.String(),
                        Dob = c.DateTime(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(nullable: false),
                        CourseName = c.String(),
                        sem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        marks = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Marks", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Marks", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Students", "BranchId", "dbo.Branches");
            DropIndex("dbo.Marks", new[] { "CourseId" });
            DropIndex("dbo.Marks", new[] { "StudentId" });
            DropIndex("dbo.Courses", new[] { "BranchId" });
            DropIndex("dbo.Students", new[] { "BranchId" });
            DropTable("dbo.Marks");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.Branches");
        }
    }
}
