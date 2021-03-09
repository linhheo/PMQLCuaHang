namespace BOHOPUB2HAND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhanviens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        NhanVienID = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        TenNhanVien = c.String(),
                        ChucVu = c.String(),
                        SoDienThoai = c.String(),
                        SoTK = c.String(),
                    })
                .PrimaryKey(t => t.NhanVienID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhanviens");
        }
    }
}
