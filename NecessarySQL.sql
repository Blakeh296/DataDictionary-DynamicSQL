--select * from SysObjects
--use AdventureWorks2012
--select * from Sys.databases
--use AdventureWorks2012
--select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'BASE TABLE'


create proc sp_SelectAllDatabases
AS
BEGIN
		select * from Sys.databases;
END
go

Create PROC sp_SelectAllTablesFromDatabase(@databaseID int)
AS
BEGIN 
		Declare @database int = 11;
		Declare @sql nvarchar(1000);
		Declare @uidString nvarchar(10); 
		set @uidString = CAST(@databaseID AS NVARCHAR(10));
		set @sql = N'Select * from sysObjects Where uid = ' + @uidString + N' and xtype = @xtype';
		print @sql;
		--xtype paramater is declared and set in the execute statement wit the SQL custom stored procedure
		Execute sp_executesql @sql, N'@xtype nvarchar(100)',@xtype = 'U';
END

--exec sp_SelectAllTablesFromDatabase 11 ;

--select * from Sys.databases
--select * from sys.tables
--select * from sysObjects where xtype = 'u'