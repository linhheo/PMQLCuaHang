namespace BOHOPUB2HAND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Hanghoas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hanghoas",
                c => new
                    {
                        HangHoaID = c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false),
                        TenHangHoa = c.String(),
                        SoLuongTonKho = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HangHoaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hanghoas");
        }
    }
}
