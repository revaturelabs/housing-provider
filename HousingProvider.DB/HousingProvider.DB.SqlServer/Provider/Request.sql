CREATE TABLE [Provider].Request (
    RequestId INT primary key clustered IDENTITY(1,1) not null,
    RequestTypeId INT NOT NULL,
    RequestTitle NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(1000) NOT NULL,
    RequestDate DATETIME NOT NULL DEFAULT(GETDATE()),
    RequestModifiedDate DATETIME,
    RequestorName NVARCHAR(50) NOT NULL,
    PropertyId INT not null,
    RepresentativeName NVARCHAR(50) NOT NULL,
    StatusId INT NOT NULL,
    [Action] NVARCHAR(1000),
	 Urgent BIT NOT NULL DEFAULT(0),
    Active BIT NOT NULL DEFAULT(1)
CONSTRAINT FK_Provider_request_requesttypeid FOREIGN KEY (RequestTypeId) REFERENCES [Provider].[RequestType](RequestTypeId),

CONSTRAINT FK_Provider_request_propertyid FOREIGN KEY (PropertyId) REFERENCES [Provider].Property(PropertyId),
    
CONSTRAINT FK_Provider_Request_Statusid FOREIGN KEY (StatusId) REFERENCES [Provider].[Status](StatusId)
    


);
