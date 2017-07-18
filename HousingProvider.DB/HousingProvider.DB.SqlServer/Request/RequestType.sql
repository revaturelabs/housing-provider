CREATE TABLE [Provider].[RequestType] (
    RequestTypeId INT primary key clustered IDENTITY(1,1) not null,
    RequestTypeDescription NVARCHAR(100) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)

);
