USE Robotics_WH;

IF object_id(N'Robotics_WH.dbo.[Stock_Description]') is null
BEGIN
	CREATE TABLE [Stock_Description] (
	  [Stock_Code] SMALLINT,
	  [Stock_Name] NVARCHAR(127),
	  [Stock_Desc] NVARCHAR(MAX),
	  PRIMARY KEY ([Stock_Code])
	);
END;
