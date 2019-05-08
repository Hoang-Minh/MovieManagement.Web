namespace MoviesManagement.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) Values(1, 0, 0, 0, 'Pay As You Go')");
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) Values(2, 30, 1, 10, 'Monthly')");
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) Values(3, 90, 3, 15, 'Quarterly')");
            Sql("Insert Into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) Values(4, 300, 12, 20, 'Yearly')");
        }
        
        public override void Down()
        {
        }
    }
}
