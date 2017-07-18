CREATE TABLE [Provider].[Person] (
    PersonId INT primary key clustered IDENTITY(1,1),
    ProviderId INT NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    RoleId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	 CONSTRAINT FK_Provider_Person_RoleId FOREIGN KEY (RoleId) REFERENCES [Provider].[Role](RoleId),
	 CONSTRAINT FK_Provider_Person_ProviderId FOREIGN KEY (ProviderId) REFERENCES [Provider].[Provider](ProviderId),
     CONSTRAINT FK_Provider_Person_ContactId FOREIGN KEY (ContactId) REFERENCES [Provider].[Contact](ContactId)
);