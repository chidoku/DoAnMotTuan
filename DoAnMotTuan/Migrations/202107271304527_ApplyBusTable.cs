namespace DoAnMotTuan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyBusTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BenXeA = c.String(),
                        BenXeB = c.String(),
                        ThoiGianA = c.String(),
                        ThoiGianB = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Buses");
        }
    }
}
