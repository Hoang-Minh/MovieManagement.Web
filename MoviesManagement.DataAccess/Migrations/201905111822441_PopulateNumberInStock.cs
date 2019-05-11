namespace MoviesManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNumberInStock : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies set NumberInStock = 5 where Id = 1");
            Sql("Update Movies set NumberInStock = 10 where Id = 2");
            Sql("Update Movies set NumberInStock = 6 where Id = 3");
            Sql("Update Movies set NumberInStock = 12 where Id = 4");
            Sql("Update Movies set NumberInStock = 3 where Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
