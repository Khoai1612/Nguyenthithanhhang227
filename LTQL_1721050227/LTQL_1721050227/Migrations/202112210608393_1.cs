namespace LTQL_1721050227.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap227",
                c => new
                    {
                        MaNhaCungcap = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungcap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCap227");
        }
    }
}
