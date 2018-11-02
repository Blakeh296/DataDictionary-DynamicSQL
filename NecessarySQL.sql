use master;
go

CREATE PROC sp_SelectAllDatabases
AS
BEGIN
		SELECT * FROM Sys.databases;
END
go

CREATE PROC sp_SelectAllTablesFromDatabase(@databaseID int, @xtype nvarchar(100))
AS
BEGIN 
		DECLARE @database int = 11;
		DECLARE @sql nvarchar(1000);
		DECLARE @uidString nvarchar(10); 
		SET @uidString = CAST(@databaseID AS NVARCHAR(10));
		SET @sql = N'Select * from sysObjects Where uid = ' + @uidString + N' and xtype in ('+@xtype+')';
		--print @sql;
		--xtype paramater is declared and set in the execute statement wit the SQL custom stored procedure
		EXEC sp_executesql @sql;
END
go

ALTER PROC sp_Dependencies (@tableName nvarchar(max))
AS
BEGIN
		DECLARE @Sql nvarchar(max);
		SET @Sql = 'exec sp_depends '+@tableName+';';
		print @Sql
		exec sp_executesql @Sql;
END

declare @table nvarchar(max) = 'Person.Person';
DECLARE @Sqll nvarchar(max);
SET @Sqll = 'exec sp_depends '+@table+';';
print @Sqll

exec sp_Dependencies 'uspPrintError';
exec sp_depends 'Person.Person';
select * from sys.tables;

--select * from SysObjects
--use AdventureWorks2012
--select * from Sys.databases
--use AdventureWorks2012
--select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'



--exec sp_SelectAllTablesFromDatabase 11 ;
--select * from Sys.databases
--select * from sys.tables 
--select * from sysObjects where xtype = 'u'