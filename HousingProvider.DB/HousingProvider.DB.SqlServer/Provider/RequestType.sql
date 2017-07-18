CREATE TABLE [Provider].[RequestType] (
    RequestTypeId INT IDENTITY(1,1) not null,
    RequestTypeDescription NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);
