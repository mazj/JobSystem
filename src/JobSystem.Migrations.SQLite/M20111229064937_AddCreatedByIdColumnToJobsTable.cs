﻿using System;
using System.Collections.Generic;
using FluentMigrator;

namespace JobSystem.Migrations.SqlLite
{
    [Migration(20111229064937)]
    public class M20111229064937_AddCreatedByIdColumnToJobsTable : Migration
    {
        public override void Up()
        {
            Create.Column("CreatedById").OnTable("Jobs").AsGuid().Nullable();
            Create.ForeignKey("FK_Jobs_CreatedByUserAccount")
                .FromTable("Jobs")
                .ForeignColumn("CreatedById")
                .ToTable("UserAccounts")
                .PrimaryColumn("Id");
        }

        public override void Down()
        {
            Delete.Column("CreatedById").FromTable("Jobs");
            Delete.ForeignKey("FK_Jobs_CreatedByUserAccount");
        }
    }
}