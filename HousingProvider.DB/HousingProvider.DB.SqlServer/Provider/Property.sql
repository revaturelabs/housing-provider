CREATE TABLE [Provider].[Property] (
    PropertyId INT primary key clustered IDENTITY(1,1),
    NumberofRooms INT NOT NULL,
    NumberofBaths INT NOT NULL,
    ProviderId INT NOT NULL,
    AddressId INT NOT NULL,
    ComplexId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	 CONSTRAINT FK_Provider_Property_ProviderId FOREIGN KEY (ProviderId) REFERENCES [Provider].[Provider](ProviderId),
	 CONSTRAINT FK_Provider_Property_AddressId FOREIGN KEY (AddressId) REFERENCES [Provider].[Address](AddressId),
	 CONSTRAINT FK_Provider_Property_ComplexId FOREIGN KEY (ComplexId) REFERENCES [Provider].[Complex](ComplexId)
);