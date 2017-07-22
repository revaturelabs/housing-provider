SELECT * FROM sys.schemas;

SELECT * FROM sys.tables;

SELECT * FROM Request.RequestType;

SELECT * FROM Request.[Status];



INSERT INTO [Request].[RequestType] (RequestTypeDescription)
values 
	('Maintenance'),
	('Supplies'),
	('Housing');

INSERT INTO [Request].[Status] (StatusDescription)
values 
	('Pending'),
	('Completed'),
	('Rejected'),
	('Hold');

INSERT INTO [Person].[Contact](Email,Phone,Active,ModifiedDate,[Guid])
values
    ('fake@email.com','123-555-1234',1,GETDATE(),NEWID());

INSERT INTO [Property].[Address](Street1,Street2,ApartmentNum,City,[State],ZipCode,Active,ModifiedDate,[Guid])
values
    ('11180 Sunrise Valley','Suite 400','','Herndon','VA','20190',1,GETDATE(),NEWID()), --BridgeStreet
    ('13000 Wilkes Way','','','Herndon','VA','20170',1,GETDATE(),NEWID()), --Westerly at WorldGate
    ('508 Pride Avenue','','','Herndon','VA','20170',1,GETDATE(),NEWID()), -- The Townes at Herndon Center
    ('2320 Dulles Station Blvd.','','','Herndon','VA','20171',1,GETDATE(),NEWID()), --Camden Dulles Station
    ('11659 North Shore Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()), --Fairway Apartments
    ('Sycamore Valley Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()); --The Sycamores

INSERT INTO [Person].[Provider] (ProviderName,ContactId,AddressId,Active)
values
    ('BridgeStreet',1,1,1);

INSERT INTO [Property].[Complex] (ComplexName,AddressId,ContactId,Active,ModifiedDate,[Guid])
values
    ('Westerly at WorldGate',2,1,1,GETDATE(),NEWID()),
    ('The Townes at Herndon Center',3,1,1,GETDATE(),NEWID()),
    ('Camden Dulles Station',4,1,1,GETDATE(),NEWID()),
    ('Fairway Apartments',5,1,1,GETDATE(),NEWID()),
    ('The Sycamores',6,1,1,GETDATE(),NEWID());

INSERT INTO [Person].[Person](ProviderId, FirstName, LastName, ContactId, RoleId, Active,[Guid])
values
    (1,'John','Smith',1,1,1),
    (1,'Jane','Doe',1,1,1);

INSERT INTO [Property].[Property](NumberofRooms,NumberofBaths,ProviderId,AddressId,ComplexId,Active)
values
    (3,3,1,1,1,1),
    (3,3,1,1,1,1),
    (3,3,1,1,1,1),
    (3,3,1,1,1,1),
    (3,3,1,1,1,1);

INSERT INTO [Request].Request (RequestTypeId,Urgent,RequestTitle,
                                [Description],
                                RequestorName,PropertyId,RepresentativeName,StatusId,
                                [Action],Active)
values
    (1,0,'This is A Demo Request Title','This is a Demo Request Description','Tenant 1',1,'BridgeStreet Rep',1,'This is a Demo Action on Request.',1),
    (1,0,'This is A Demo Request Title 2','This is a Demo Request Description 2','Tenant 2',1,'BridgeStreet Rep',1,'This is a Demo Action on Request 2.',1);