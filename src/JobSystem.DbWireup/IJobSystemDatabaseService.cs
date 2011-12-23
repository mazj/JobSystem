﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobSystem.DataModel.Entities;

namespace JobSystem.DbWireup
{
	public interface IJobSystemDatabaseService
	{
		void CreateDatabase(bool dropExisting = false);
		void CreateJobSystemSchemaFromMigrations(string migrationsDllPath);
		void InsertDefaultData(JobSystemDefaultData defaultData);
		void InsertCompanyDetails(CompanyDetails companyDetails);
	}
}