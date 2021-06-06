namespace Lethuyquynh_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenNhanVien = c.String(),
                        MaTinhThanh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.TinhThanhs",
                c => new
                    {
                        MaTinhThanh = c.Int(nullable: false, identity: true),
                        TenTinhThanh = c.String(),
                        NhanVien_MaNhanVien = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaTinhThanh)
                .ForeignKey("dbo.NhanViens", t => t.NhanVien_MaNhanVien)
                .Index(t => t.NhanVien_MaNhanVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TinhThanhs", "NhanVien_MaNhanVien", "dbo.NhanViens");
            DropIndex("dbo.TinhThanhs", new[] { "NhanVien_MaNhanVien" });
            DropTable("dbo.TinhThanhs");
            DropTable("dbo.NhanViens");
        }
    }
}
