namespace LTQL_1721050227.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NTTHSanPham227",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(maxLength: 50),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap227", t => t.MaNhaCungCap, cascadeDelete: true)
                .Index(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NTTHSanPham227", "MaNhaCungCap", "dbo.NhaCungCap227");
            DropIndex("dbo.NTTHSanPham227", new[] { "MaNhaCungCap" });
            DropTable("dbo.NTTHSanPham227");
        }
    }
}
