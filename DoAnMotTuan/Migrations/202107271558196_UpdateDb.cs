namespace DoAnMotTuan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Buses", "BenXeA", c => c.String(nullable: false));
            AlterColumn("dbo.Buses", "BenXeB", c => c.String(nullable: false));
            AlterColumn("dbo.Buses", "ThoiGianA", c => c.String(nullable: false));
            AlterColumn("dbo.Buses", "ThoiGianB", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Buses", "ThoiGianB", c => c.String());
            AlterColumn("dbo.Buses", "ThoiGianA", c => c.String());
            AlterColumn("dbo.Buses", "BenXeB", c => c.String());
            AlterColumn("dbo.Buses", "BenXeA", c => c.String());
        }
    }
}
