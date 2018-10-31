--select * from SysObjects
--use AdventureWorks2012
--select * from Sys.databases
--use AdventureWorks2012
--select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'


create proc SelectAllDatabases
AS
BEGIN
		select * from Sys.databases;
END



ALTER PROC SelectAllTablesFromDatabase
AS
BEGIN 
		Declare @sql nvarchar(1000);
		Declare @param nvarchar(200);
		set @sql = 'Select * from sysObjects' +  ' Where xtype = @xtype and uid = @DatabaseID';
		set @param = '@xtype nvarchar(2), @DatabaseID TINYINT(20)';

		Execute sp_executesql @sql, @param, 'U', 11
END
exec SelectAllTablesFromDatabase
select * from Sys.databases
select * from sys.tables
select * from sysObjects where xtype = 'u'