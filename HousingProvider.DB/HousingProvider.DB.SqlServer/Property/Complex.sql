CREATE TABLE [Provider].[Complex] (
    ComplexId INT primary key clustered IDENTITY(1,1),
    ComplexName NVARCHAR(50) NOT NULL,
    AddressId INT NOT NULL,
    ContactId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	CONSTRAINT FK_Provider_complex_AddressId FOREIGN KEY (AddressId) REFERENCES [Provider].[Address](AddressId),
	CONSTRAINT FK_Provider_complex_contactid FOREIGN KEY (ContactId) REFERENCES [Provider].[Contact](ContactId)
);