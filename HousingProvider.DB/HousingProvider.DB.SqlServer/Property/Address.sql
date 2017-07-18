CREATE TABLE [Property].[Address] (
    AddressId INT primary key clustered IDENTITY(1,1) not null,
    Street1 NVARCHAR(100) NOT NULL,
    Street2 NVARCHAR(50),
    ApartmentNum INT,
    City NVARCHAR(50) NOT NULL,
    [State] NVARCHAR(50) NOT NULL,
    ZipCode NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)


);