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