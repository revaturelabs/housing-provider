/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
use master;
go

create database HousingProviderDB;
go

use HousingProviderDB;
go

create schema [Provider];
go


CREATE TABLE [Provider].[Person] (
    PersonId INT IDENTITY(1,1),
    ProviderId INT NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    RoleId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[Provider] (
    ProviderId INT IDENTITY(1,1),
    ProviderName NVARCHAR(50) NOT NULL,
    ContactId INT NOT NULL,
    AddressId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[Complex] (
    ComplexId INT IDENTITY(1,1),
    ComplexName NVARCHAR(50) NOT NULL,
    AddressId INT NOT NULL,
    ContactId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[Contact] (
    ContactId INT IDENTITY(1,1),
    Email NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[Address] (
    AddressId INT IDENTITY(1,1),
    Street1 NVARCHAR(100) NOT NULL,
    Street2 NVARCHAR(50),
    ApartmentNum INT,
    City NVARCHAR(50) NOT NULL,
    [State] NVARCHAR(50) NOT NULL,
    ZipCode NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[Status] (
    StatusId INT IDENTITY(1,1),
    [StatusDescription] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[RequestType] (
    RequestTypeId INT IDENTITY(1,1),
    RequestTypeDescription NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].Request (
    RequestId INT IDENTITY(1,1),
    RequestTypeId INT NOT NULL,
    Urgent BIT NOT NULL DEFAULT(0),
    RequestTitle NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(1000) NOT NULL,
    RequestDate DATETIME NOT NULL DEFAULT(GETDATE()),
    RequestModifiedDate DATETIME,
    RequestorName NVARCHAR(50) NOT NULL,
    PropertyId INT,
    RepresentativeName NVARCHAR(50) NOT NULL,
    StatusId INT NOT NULL,
    [Action] NVARCHAR(1000),
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[Property] (
    PropertyId INT IDENTITY(1,1),
    NumberofRooms INT NOT NULL,
    NumberofBaths INT NOT NULL,
    ProviderId INT NOT NULL,
    AddressId INT NOT NULL,
    ComplexId INT NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);

CREATE TABLE [Provider].[Role] (
    RoleId INT IDENTITY(1,1),
    [RoleDescription] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT(1)
);


-- Add the primary Keys
Alter table [Provider].[Person]
    ADD constraint PK_provider_Person_PersonId primary key clustered(PersonId);

Alter table [Provider].[Provider]
    ADD constraint PK_provider_Provider_ProviderId primary key clustered(ProviderId);

Alter table [Provider].[Complex]
    ADD constraint PK_provider_Complex_ComplexId primary key clustered(ComplexId);

Alter table [Provider].[Contact]
    ADD constraint PK_provider_Contact_ContactId primary key clustered(ContactId);

Alter table [Provider].[Address]
    ADD constraint PK_provider_Address_AddressId primary key clustered(AddressId);
--
Alter table [Provider].[Status]
    ADD constraint PK_provider_Status_StatusId primary key clustered(StatusId);

Alter table [Provider].[RequestType]
    ADD constraint PK_provider_RequestType_RequestTypeId primary key clustered(RequestTypeId);

Alter table [Provider].[Request]
    ADD constraint PK_provider_Request_RequestId primary key clustered(RequestId);

Alter table [Provider].[Property]
    ADD constraint PK_provider_Property_PropertyId primary key clustered(PropertyId);

Alter table [Provider].[Role]
    ADD constraint PK_provider_Role_RoleId primary key clustered(RoleId);


-- Add the foreign keys
ALTER TABLE [Provider].[Person]
    ADD CONSTRAINT FK_Provider_Person_ContactId FOREIGN KEY (ContactId) REFERENCES [Provider].[Contact](ContactId);

ALTER TABLE [Provider].[Person]
    ADD CONSTRAINT FK_Provider_Person_ProviderId FOREIGN KEY (ProviderId) REFERENCES [Provider].[Provider](ProviderId);

ALTER TABLE [Provider].[Person]
    ADD CONSTRAINT FK_Provider_Person_RoleId FOREIGN KEY (RoleId) REFERENCES [Provider].[Role](RoleId);

ALTER TABLE [Provider].[Property]
    ADD CONSTRAINT FK_Provider_Property_ProviderId FOREIGN KEY (ProviderId) REFERENCES [Provider].[Provider](ProviderId);

ALTER TABLE [Provider].[Property]
    ADD CONSTRAINT FK_Provider_Property_AddressId FOREIGN KEY (AddressId) REFERENCES [Provider].[Address](AddressId);

ALTER TABLE [Provider].[Property]
    ADD CONSTRAINT FK_Provider_Property_ComplexId FOREIGN KEY (ComplexId) REFERENCES [Provider].[Complex](ComplexId);

ALTER TABLE [Provider].[Complex]
    ADD CONSTRAINT FK_Provider_complex_AddressId FOREIGN KEY (AddressId) REFERENCES [Provider].[Address](AddressId);

ALTER TABLE [Provider].[Complex]
    ADD CONSTRAINT FK_Provider_complex_contactid FOREIGN KEY (ContactId) REFERENCES [Provider].[Contact](ContactId);

ALTER TABLE [Provider].[Provider]
    ADD CONSTRAINT FK_Provider_provider_contactId FOREIGN KEY (ContactId) REFERENCES [Provider].[Contact](ContactId);

ALTER TABLE [Provider].[Provider]
    ADD CONSTRAINT FK_Provider_provider_AddressId FOREIGN KEY (AddressId) REFERENCES [Provider].[Address](AddressId);

ALTER TABLE [Provider].[Request]
    ADD CONSTRAINT FK_Provider_request_requesttypeid FOREIGN KEY (RequestTypeId) REFERENCES [Provider].[RequestType](RequestTypeId);

ALTER TABLE [Provider].[Request]
    ADD CONSTRAINT FK_Provider_request_propertyid FOREIGN KEY (PropertyId) REFERENCES [Provider].Property(PropertyId);
    
ALTER TABLE [Provider].[Request]
    ADD CONSTRAINT FK_Provider_Request_Statusid FOREIGN KEY (StatusId) REFERENCES [Provider].[Status](StatusId);


INSERT INTO [Provider].[RequestType] (RequestTypeDescription)
values 
	('Maintenance'),
	('Supplies'),
	('Housing');

INSERT INTO [Provider].[Status] (StatusDescription)
values 
	('Pending'),
	('Completed'),
	('Rejected'),
	('Hold');

INSERT INTO [Provider].[Role] (RoleDescription)
values 
	('Administrator'),
	('Representative');


INSERT INTO [Provider].[Contact](Email,Phone,Active)
values
    ('fake@email.com','123-555-1234',1);


INSERT INTO [Provider].[Address](Street1,Street2,ApartmentNum,City,[State],ZipCode,Active)
values
    ('11180 Sunrise Valley','Suite 400','','Herndon','VA','20190',1), --BridgeStreet
    ('13000 Wilkes Way','','','Herndon','VA','20170',1), --Westerly at WorldGate
    ('508 Pride Avenue','','','Herndon','VA','20170',1), -- The Townes at Herndon Center
    ('2320 Dulles Station Blvd.','','','Herndon','VA','20171',1), --Camden Dulles Station
    ('11659 North Shore Drive','','','Herndon','VA','20190',1), --Fairway Apartments
    ('Sycamore Valley Drive','','','Herndon','VA','20190',1); --The Sycamores

INSERT INTO [Provider].[Provider] (ProviderName,ContactId,AddressId,Active)
values
    ('BridgeStreet',1,1,1);

INSERT INTO [Provider].[Complex] (ComplexName,AddressId,ContactId,Active)
values
    ('Westerly at WorldGate',2,1,1),
    ('The Townes at Herndon Center',3,1,1),
    ('Camden Dulles Station',4,1,1),
    ('Fairway Apartments',5,1,1),
    ('The Sycamores',6,1,1);

INSERT INTO [Provider].[Property](NumberofRooms,NumberofBaths,ProviderId,AddressId,ComplexId,Active)
values
    (3,3,1,1,1,1),
    (3,3,1,1,1,1),
    (3,3,1,1,1,1),
    (3,3,1,1,1,1),
    (3,3,1,1,1,1);

INSERT INTO [Provider].Request (RequestTypeId,Urgent,RequestTitle,
                                [Description],
                                RequestorName,PropertyId,RepresentativeName,StatusId,
                                [Action],Active)
values
    (1,0,'This is A Demo Request Title','This is a Demo Request Description','Tenant 1',1,'BridgeStreet Rep',1,'This is a Demo Action on Request.',1),
    (1,0,'This is A Demo Request Title 2','This is a Demo Request Description 2','Tenant 2',1,'BridgeStreet Rep',1,'This is a Demo Action on Request 2.',1);