namespace BOHOPUB2HAND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Khachhangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachhangs",
                c => new
                    {
                        KhachHangID = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        TenKhachHang = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.KhachHangID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachhangs");
        }
    }
}
