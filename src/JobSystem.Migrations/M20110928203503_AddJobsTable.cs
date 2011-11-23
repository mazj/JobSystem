﻿using System;
using System.Collections.Generic;
using FluentMigrator;

namespace JobSystem.Migrations
{
	[Migration(20110928203503)]
	public class M20110928203503_AddJobsTable : Migration
	{
		public override void Up()
		{
			Create.Table("Jobs")
				.WithIdColumn()
				.WithColumn("JobNo").AsString(255).Unique().NotNullable()
				.WithColumn("DateCreated").AsDateTime().NotNullable()
				.WithColumn("Instructions").AsString(20000).Nullable()
				.WithColumn("OrderNo").AsString(255).Nullable()
				.WithColumn("AdviceNo").AsString(255).Nullable()
				.WithColumn("StatusId").AsGuid().NotNullable()
				.WithColumn("JobCategoryId").AsGuid().NotNullable()
				.WithColumn("CustomerId").AsGuid().NotNullable()
				.WithColumn("Notes").AsString(20000).Nullable()
				.WithColumn("Contact").AsString(255).Nullable()
				.WithColumn("IsExternal").AsBoolean().WithDefaultValue(false);
			Create.ForeignKey("FK_Jobs_Customers")
				.FromTable("Jobs")
				.ForeignColumn("CustomerId")
				.ToTable("Customers")
				.PrimaryColumn("Id");
			Create.ForeignKey("FK_Jobs_Status")
				.FromTable("Jobs")
				.ForeignColumn("StatusId")
				.ToTable("Status")
				.PrimaryColumn("Id");
			Create.ForeignKey("FK_Jobs_JobCategories")
				.FromTable("Jobs")
				.ForeignColumn("JobCategoryId")
				.ToTable("JobCategories")
				.PrimaryColumn("Id");
		}

		public override void Down()
		{
			Delete.ForeignKey("FK_Jobs_Customers").OnTable("Jobs");
			Delete.ForeignKey("FK_Jobs_Status").OnTable("Jobs");
			Delete.ForeignKey("FK_Jobs_JobCategories").OnTable("Jobs");
			Delete.Table("Jobs");
		}
	}
}