CREATE TABLE [Person].[Provider] (
    ProviderId INT primary key clustered IDENTITY(1,1) not null,
    ProviderName NVARCHAR(200) NOT NULL,
    AddressId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)

);
