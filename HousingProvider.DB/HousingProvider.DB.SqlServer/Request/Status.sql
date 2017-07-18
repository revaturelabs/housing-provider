CREATE TABLE [Provider].[Status] (
    StatusId INT primary key clustered IDENTITY(1,1) not null,
    [StatusDescription] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);
