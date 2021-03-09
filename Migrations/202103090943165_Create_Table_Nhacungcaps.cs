namespace BOHOPUB2HAND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhacungcaps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhacungcaps",
                c => new
                    {
                        NhaCungCapID = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        TenNhaCungCap = c.String(),
                        DiaChỉ = c.String(),
                        SoDienThoai = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.NhaCungCapID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhacungcaps");
        }
    }
}
