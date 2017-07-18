CREATE TABLE [Person].[Person] (
    PersonId INT primary key clustered IDENTITY(1,1) not null,
    ProviderId INT NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    RoleId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	 CONSTRAINT FK_Person_Person_RoleId FOREIGN KEY (RoleId) REFERENCES [Person].[Role](RoleId),
	 CONSTRAINT FK_Person_Person_ProviderId FOREIGN KEY (ProviderId) REFERENCES [Person].[Provider](ProviderId),
     CONSTRAINT FK_Person_Person_ContactId FOREIGN KEY (ContactId) REFERENCES [Person].[Contact](ContactId)
);