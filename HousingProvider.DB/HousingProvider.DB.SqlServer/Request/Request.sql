CREATE TABLE [Request].Request (
    RequestId INT primary key clustered IDENTITY(1,1) not null,
    RequestTypeId INT NOT NULL,
    RequestTitle NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(1000) NOT NULL,
    RequestDate DATETIME NOT NULL DEFAULT(GETDATE()),
    RequestModifiedDate DATETIME NULL,
    RequestorName NVARCHAR(50) NOT NULL,
    PropertyId INT not null,
    RepresentativeName NVARCHAR(50) NOT NULL,
    StatusId INT NOT NULL,
    [Action] NVARCHAR(1000),
	 Urgent BIT NOT NULL DEFAULT(0),
    Active BIT NOT NULL DEFAULT(1),
[Guid] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT FK_Request_request_requesttypeid FOREIGN KEY (RequestTypeId) REFERENCES [Request].[RequestType](RequestTypeId),

CONSTRAINT FK_Request_request_propertyid FOREIGN KEY (PropertyId) REFERENCES [Property].Property(PropertyId),
    
CONSTRAINT FK_Request_Request_Statusid FOREIGN KEY (StatusId) REFERENCES [Request].[Status](StatusId)
    


);
