CREATE TABLE [Provider].[Property] (
    PropertyId INT IDENTITY(1,1),
    NumberofRooms INT NOT NULL,
    NumberofBaths INT NOT NULL,
    ProviderId INT NOT NULL,
    AddressId INT NOT NULL,
    ComplexId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);