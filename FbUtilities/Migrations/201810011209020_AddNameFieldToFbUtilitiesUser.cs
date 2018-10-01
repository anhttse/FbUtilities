namespace FbUtilities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameFieldToFbUtilitiesUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FbUtilitiesUser", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FbUtilitiesUser", "Name");
        }
    }
}
