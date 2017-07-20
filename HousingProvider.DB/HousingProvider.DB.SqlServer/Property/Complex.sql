CREATE TABLE [Property].[Complex] (
    ComplexId INT primary key clustered IDENTITY(1,1) not null,
    ComplexName NVARCHAR(50) NOT NULL,
    AddressId INT NOT NULL,
    ContactId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	[Guid ] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT FK_Property_complex_AddressId FOREIGN KEY (AddressId) REFERENCES [Property].[Address](AddressId),
	CONSTRAINT FK_Property_complex_contactid FOREIGN KEY (ContactId) REFERENCES [Person].[Contact](ContactId)
);