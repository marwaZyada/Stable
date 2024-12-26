/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[ParentId]
      ,[NameAr]
      ,[NameEn]
      ,[ModuleId]
      ,[Url]
      ,[Icon]
      ,[OrderId]
      ,[IsActive]
      ,[DepId]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[UpdatedDate]
      ,[UpdatedBy]
      ,[IsSystem]
  FROM [LegalProABC2].[dbo].[AuthPages]



  select [NameAr] from [dbo].[AuthPages]
 
  where [ParentId]is null
 