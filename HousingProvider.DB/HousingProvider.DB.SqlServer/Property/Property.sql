CREATE TABLE [Property].[Property] (
    PropertyId INT primary key clustered IDENTITY(1,1) not null,
    NumberofRooms INT NOT NULL,
    NumberofBaths INT NOT NULL,
    ProviderId INT NOT NULL,
    AddressId INT NOT NULL,
    ComplexId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	 [Guid ] UNIQUEIDENTIFIER NOT NULL, 
    [ModifiedDate] DATETIME NOT NULL, 
    CONSTRAINT FK_Property_Property_ProviderId FOREIGN KEY (ProviderId) REFERENCES [Person].[Provider](ProviderId),
	 CONSTRAINT FK_Property_Property_AddressId FOREIGN KEY (AddressId) REFERENCES [Property].[Address](AddressId),
	 CONSTRAINT FK_Property_Property_ComplexId FOREIGN KEY (ComplexId) REFERENCES [Property].[Complex](ComplexId)
);