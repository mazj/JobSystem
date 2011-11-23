set projectdir=%~dp0..\..\..
set DatabaseServer=(local)\SQLEXPRESS2008R2
set DatabaseCatalogName=JobSystem
set DatabaseUsername=sa
set DatabasePassword=p'ssw0rd
set LoginName=jobsystem.development
set LoginPassword=abc@123
set CatalogUserName=jobsystem.development
set UserRoles="db_datareader,db_datawriter"
msbuild /target:CreateDevelopmentJobSystemDatabaseWithDefaultUser ^
/p:teamcity_build_checkoutDir=%projectdir% ^
/p:DevelopmentDatabaseServer=%DatabaseServer% ^
/p:DevelopmentDatabaseName=%DatabaseCatalogName% ^
/p:DevelopmentDatabaseUsername=%DatabaseUsername% ^
/p:DevelopmentDatabasePassword=%DatabasePassword% ^
/p:DevelopmentDatabaseLoginName=%LoginName% ^
/p:DevelopmentDatabaseLoginPassword=%LoginPassword% ^
/p:DevelopmentDatabaseCatalogUserName=%CatalogUserName% ^
/p:DevelopmentDatabaseUserRoles=%UserRoles%
