﻿using FluentMigrator;

namespace JobSystem.Migrations
{
	[Migration(20110928201038)]
	public class M20110928201038_AddListItemsTable : Migration
	{
		public override void Up()
		{
			Create.Table("ListItems")
				.WithIdColumn()
				.WithColumn("Name").AsString(255).NotNullable()
				.WithColumn("Type").AsInt32().NotNullable();
			Execute.Sql(
				@"ALTER TABLE dbo.ListItems ADD CONSTRAINT
					IX_ListItems UNIQUE NONCLUSTERED 
					(
					Name,
					Type
					)"
				);
		}

		public override void Down()
		{
			Delete.Table("ListItems");
		}
	}
}