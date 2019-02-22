namespace tenderwebsiteapi.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using tenderwebsiteapi.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<tenderwebsiteapi.Models.ApplicationDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(tenderwebsiteapi.Models.ApplicationDbContext context)
		{
			context.Contracts.AddOrUpdate(x => x.Address,
				new Contract() { Address = "eq34124512451", CreatedDate = DateTime.Now, NumSmallServers = 2, NumMediumServers = 2, NumLargeServers = 3, Description = "test1", ContractStatus = 1 },
				new Contract() { Address = "ocx1212516166", CreatedDate = DateTime.Now, NumSmallServers = 6, NumMediumServers = 3, NumLargeServers = 2, Description = "test2", ContractStatus = 1 },
				new Contract() { Address = "fe21512561612", CreatedDate = DateTime.Now, NumSmallServers = 4, NumMediumServers = 4, NumLargeServers = 1, Description = "test3", ContractStatus = 0 },
				new Contract() { Address = "e125151612612", CreatedDate = DateTime.Now, NumSmallServers = 7, NumMediumServers = 3, NumLargeServers = 3, Description = "test4", ContractStatus = 2 },
				new Contract() { Address = "gea1245125125", CreatedDate = DateTime.Now, NumSmallServers = 1, NumMediumServers = 1, NumLargeServers = 2, Description = "test5", ContractStatus = 2 }
				);
		}
	}
}
