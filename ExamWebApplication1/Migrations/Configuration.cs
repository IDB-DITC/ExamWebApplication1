namespace ExamWebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamWebApplication1.Models.AppDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ExamWebApplication1.Models.AppDb context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method
			//  to avoid creating duplicate seed data.


			context.Users.AddOrUpdate(new Models.UserInfo() { UserName = "admin", Password="abc123", Role = Models.UserRole.Admin });


			context.Users.AddOrUpdate(new Models.UserInfo() { UserName = "ditc", Password = "123456", Role = Models.UserRole.User });

		}
	}
}
