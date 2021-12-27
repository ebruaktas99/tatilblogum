namespace TatilBlogum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersonelAdiColumnInHakkimizdasTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hakkimizdas", "PersonelAdi", c => c.String());
            AddColumn("dbo.Hakkimizdas", "Gorev", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hakkimizdas", "Gorev");
            DropColumn("dbo.Hakkimizdas", "PersonelAdi");
        }
    }
}
