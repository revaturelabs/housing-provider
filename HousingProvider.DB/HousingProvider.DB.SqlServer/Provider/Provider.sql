CREATE TABLE [Provider].[Provider] (
    ProviderId INT primary key clustered IDENTITY(1,1),
    ProviderName NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    AddressId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)

);
