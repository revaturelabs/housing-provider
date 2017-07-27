use master;
go

create database HousingProviderDB;
go

use HousingProviderDB;
go

create schema [Provider];
go


CREATE SCHEMA [Person]
GO
CREATE SCHEMA [Property]
GO
CREATE SCHEMA [Request]
GO


CREATE TABLE [Person].[Contact] (
    ContactId INT primary key clustered IDENTITY(1,1) not null,
    Email NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1), 
    [Guid] UNIQUEIDENTIFIER NOT NULL, 
    [ModifiedDate] DATETIME NOT NULL
);



INSERT INTO [Person].[Contact](Email,Phone,Active,ModifiedDate,[Guid])
values
    ('Mya@gmail.com','1235551234',1,GETDATE(),NEWID()),
	('Yasha@gmail.com','1235551234',1,GETDATE(),NEWID()),
	('James@gmail.com','1235551234',1,GETDATE(),NEWID()),
	('Ryan@gmail.com','1235551234',1,GETDATE(),NEWID()),
	('Real@gmail.com','1235551234',1,GETDATE(),NEWID());


CREATE TABLE [Person].[Person] (
    PersonId INT primary key clustered IDENTITY(1,1) not null,
    ProviderId INT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	[Guid] UNIQUEIDENTIFIER NOT NULL, 
    [ModifiedDate] DATETIME NOT NULL, 
    CONSTRAINT FK_Person_Person_ProviderId FOREIGN KEY (ProviderId) REFERENCES [Person].[Provider](ProviderId),
    CONSTRAINT FK_Person_Person_ContactId FOREIGN KEY (ContactId) REFERENCES [Person].[Contact](ContactId)
);

CREATE TABLE [Person].[Provider] (
    ProviderId INT primary key clustered IDENTITY(1,1) not null,
    ProviderName NVARCHAR(200) NOT NULL,
    AddressId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1), 
    [Guid ] UNIQUEIDENTIFIER NOT NULL, 
    [ModifiedDate] DATETIME NOT NULL
);

INSERT INTO [Person].[Provider] (ProviderName,AddressId,Active,[Guid], ModifiedDate)
values
    ('BridgeStreet',1,1,NEWID(),GETDATE());

CREATE TABLE [Property].[Address] (
    AddressId INT primary key clustered IDENTITY(1,1) not null,
    Street1 NVARCHAR(100) NOT NULL,
    Street2 NVARCHAR(50),
    ApartmentNum INT,
    City NVARCHAR(50) NOT NULL,
    [State] NVARCHAR(50) NOT NULL,
    ZipCode NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1), 
    [Guid ] UNIQUEIDENTIFIER NOT NULL, 
    [ModifiedDate] DATETIME NOT NULL
);
INSERT INTO [Property].[Address](Street1,Street2,ApartmentNum,City,[State],ZipCode,Active,ModifiedDate,[Guid])
values
    ('11180 Sunrise Valley','Suite 400','','Herndon','VA','20190',1,GETDATE(),NEWID()), --BridgeStreet
    ('13000 Wilkes Way','','','Herndon','VA','20170',1,GETDATE(),NEWID()), --Westerly at WorldGate
    ('508 Pride Avenue','','','Herndon','VA','20170',1,GETDATE(),NEWID()), -- The Townes at Herndon Center
    ('2320 Dulles Station Blvd.','','','Herndon','VA','20171',1,GETDATE(),NEWID()), --Camden Dulles Station
    ('11659 North Shore Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()), --Fairway Apartments
    ('Sycamore Valley Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()); --The Sycamores
INSERT INTO [Property].[Address](Street1,Street2,ApartmentNum,City,[State],ZipCode,Active,ModifiedDate,[Guid])
values
    ('13000 Wilkes Way','','','Herndon','VA','20170',1,GETDATE(),NEWID()), --Westerly at WorldGate
    ('508 Pride Avenue','','','Herndon','VA','20170',1,GETDATE(),NEWID()), -- The Townes at Herndon Center
    ('2320 Dulles Station Blvd.','','','Herndon','VA','20171',1,GETDATE(),NEWID()), --Camden Dulles Station
    ('11659 North Shore Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()), --Fairway Apartments
    ('Sycamore Valley Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()); --The Sycamores
INSERT INTO [Property].[Address](Street1,Street2,ApartmentNum,City,[State],ZipCode,Active,ModifiedDate,[Guid])
values
    ('13000 Wilkes Way','','','Herndon','VA','20170',1,GETDATE(),NEWID()), --Westerly at WorldGate
    ('508 Pride Avenue','','','Herndon','VA','20170',1,GETDATE(),NEWID()), -- The Townes at Herndon Center
    ('2320 Dulles Station Blvd.','','','Herndon','VA','20171',1,GETDATE(),NEWID()), --Camden Dulles Station
    ('11659 North Shore Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()), --Fairway Apartments
    ('Sycamore Valley Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()); --The Sycamores
INSERT INTO [Property].[Address](Street1,Street2,ApartmentNum,City,[State],ZipCode,Active,ModifiedDate,[Guid])
values
    ('13000 Wilkes Way','','','Herndon','VA','20170',1,GETDATE(),NEWID()), --Westerly at WorldGate
    ('508 Pride Avenue','','','Herndon','VA','20170',1,GETDATE(),NEWID()), -- The Townes at Herndon Center
    ('2320 Dulles Station Blvd.','','','Herndon','VA','20171',1,GETDATE(),NEWID()), --Camden Dulles Station
    ('11659 North Shore Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()), --Fairway Apartments
    ('Sycamore Valley Drive','','','Herndon','VA','20190',1,GETDATE(),NEWID()); --The Sycamores



CREATE TABLE [Property].[Complex] (
    ComplexId INT primary key clustered IDENTITY(1,1) not null,
    ComplexName NVARCHAR(50) NOT NULL,
    AddressId INT NOT NULL,
    ContactId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1),
	[Guid ] UNIQUEIDENTIFIER NOT NULL, 
    [ModifiedDate] DATETIME NOT NULL, 
    CONSTRAINT FK_Property_complex_AddressId FOREIGN KEY (AddressId) REFERENCES [Property].[Address](AddressId),
	CONSTRAINT FK_Property_complex_contactid FOREIGN KEY (ContactId) REFERENCES [Person].[Contact](ContactId)
);

INSERT INTO [Property].[Complex] (ComplexName,AddressId,ContactId,Active,ModifiedDate,[Guid])
values
    ('Westerly at WorldGate',2,1,1,GETDATE(),NEWID()),
    ('The Townes at Herndon Center',3,2,1,GETDATE(),NEWID()),
    ('Camden Dulles Station',4,3,1,GETDATE(),NEWID()),
    ('Fairway Apartments',5,4,1,GETDATE(),NEWID()),
    ('The Sycamores',6,5,1,GETDATE(),NEWID());
INSERT INTO [Property].[Complex] (ComplexName,AddressId,ContactId,Active,ModifiedDate,[Guid])
values
	('Charter Oak',7,1,1,GETDATE(),NEWID()),
    ('Signature',8,2,1,GETDATE(),NEWID()),
    ('Harrison at Reston Town Center',9,3,1,GETDATE(),NEWID()),
    ('The Avant at Reston Town Center',10,4,1,GETDATE(),NEWID()),
    ('The Cosmopolitan at Reston Town Center',11,5,1,GETDATE(),NEWID());
INSERT INTO [Property].[Complex] (ComplexName,AddressId,ContactId,Active,ModifiedDate,[Guid])
values
	('Dulles Greene',12,1,1,GETDATE(),NEWID()),
    ('BLVD at Reston Station',3,2,1,GETDATE(),NEWID()),
    ('Avalon Reston Landing',13,3,1,GETDATE(),NEWID()),
    ('Waterside at Reston Apartments',14,4,1,GETDATE(),NEWID()),
    ('Stuart Woods Apartments',15,5,1,GETDATE(),NEWID());
INSERT INTO [Property].[Complex] (ComplexName,AddressId,ContactId,Active,ModifiedDate,[Guid])
values
	('Cedar Ridge Apartments',16,1,1,GETDATE(),NEWID()),
    ('Aperture',17,2,1,GETDATE(),NEWID()),
    ('Bluereal',18,3,1,GETDATE(),NEWID()),
    ('Rainbow',19,4,1,GETDATE(),NEWID()),
    ('CloudApartment',20,5,1,GETDATE(),NEWID());

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

INSERT INTO [Property].[Property](NumberofRooms,NumberofBaths,ProviderId,AddressId,ComplexId,Active,[Guid], ModifiedDate)
values
    (3,3,1,2,1,1,NEWID(),GETDATE()),
    (3,3,1,3,2,1,NEWID(),GETDATE()),
    (3,3,1,4,3,1,NEWID(),GETDATE()),
    (3,3,1,5,4,1,NEWID(),GETDATE()),
    (3,3,1,6,5,1,NEWID(),GETDATE());

CREATE TABLE [Request].Request (
    RequestId INT primary key clustered IDENTITY(1,1) not null,
    RequestTypeId INT NOT NULL,
    RequestTitle NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(1000) NOT NULL,
    RequestDate DATETIME NOT NULL DEFAULT(GETDATE()),
    RequestModifiedDate DATETIME NOT NULL,
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



CREATE TABLE [Request].[RequestType] (
    RequestTypeId INT primary key clustered IDENTITY(1,1) not null,
    RequestTypeDescription NVARCHAR(100) NOT NULL,
    Active BIT NOT NULL DEFAULT(1), 
);

INSERT INTO [Request].[RequestType] (RequestTypeDescription, Active)
values 
	('Maintenance',1),
	('Supplies',1),
	('Housing',1);

CREATE TABLE [Request].[Status] (
    StatusId INT primary key clustered IDENTITY(1,1) not null,
    [StatusDescription] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

INSERT INTO [Request].[Status] (StatusDescription)
values 
	('Pending'),
	('Completed'),
	('Rejected'),
	('Hold');

	select * from requestview;