SELECT * FROM sys.schemas;

SELECT * FROM sys.tables;

SELECT * FROM Request.RequestType;

SELECT * FROM Request.[Status];

select * from Property.Property;

select * from Property.Complex;

DELETE FROM Property.Complex
WHERE (ComplexId > 35);

select * from Person.[Provider];

select * from Property.[Address];

select * from Person.Contact;

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

INSERT INTO [Person].[Provider] (ProviderName,AddressId,Active,[Guid], ModifiedDate)
values
    ('BridgeStreet',1,1,NEWID(),GETDATE());

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

INSERT INTO [Property].[Property](NumberofRooms,NumberofBaths,ProviderId,AddressId,ComplexId,Active,[Guid], ModifiedDate)
values
    (3,3,1,3,1,1,NEWID(),GETDATE()),
    (3,3,1,3,1,1,NEWID(),GETDATE()),
    (3,3,1,3,1,1,NEWID(),GETDATE()),
    (3,3,1,3,1,1,NEWID(),GETDATE()),
    (3,3,1,3,1,1,NEWID(),GETDATE());

INSERT INTO [Request].Request (RequestTypeId,Urgent,RequestTitle,
                                [Description],
                                RequestorName,PropertyId,RepresentativeName,StatusId,
                                [Action],Active)
values
    (1,0,'This is A Demo Request Title','This is a Demo Request Description','Tenant 1',1,'BridgeStreet Rep',1,'This is a Demo Action on Request.',1),
    (1,0,'This is A Demo Request Title 2','This is a Demo Request Description 2','Tenant 2',1,'BridgeStreet Rep',1,'This is a Demo Action on Request 2.',1);


INSERT INTO [Property].Complex (ComplexName,AddressId,ContactId,Active,ModifiedDate,[Guid])
VALUES
('Dulles Greene', 1, 1, 1, GETDATE(), NEWID() ),
('The Madison Belmont', 2, 2, 1, GETDATE(), NEWID() ),
('Lakeview Terrace', 3, 3, 1, GETDATE(), NEWID() ),
('Twilight Shores', 4, 4, 1, GETDATE(), NEWID() ),
('Ashford Meadows', 5, 5, 1, GETDATE(), NEWID() ),
('Park Avenue Apartments', 1, 1, 1, GETDATE(), NEWID() ),
('Van Metre Woodland Park', 2, 2, 1, GETDATE(), NEWID() ),
('Monroe Place', 3, 3, 1, GETDATE(), NEWID() ),
('Stuart Woods', 4, 4, 1, GETDATE(), NEWID() ),
('Avalon Reston Landing', 5, 5, 1, GETDATE(), NEWID() );


INSERT INTO [Property].Property(NumberofRooms,NumberofBaths,ProviderId,AddressId,ComplexId,Active,[Guid], ModifiedDate)
values
--(7,3,1,22,1,1, NEWID(),GETDATE()),
--(10,6,1,23,1,1, NEWID(),GETDATE()),
--(2,5,1,24,1,1, NEWID(),GETDATE()),
--(10,12,1,25,1,1, NEWID(),GETDATE()),
--(6,2,1,26,1,1, NEWID(),GETDATE()),
--(12,5,1,27,2,1, NEWID(),GETDATE()),
--(16,2,1,28,2,1, NEWID(),GETDATE()),
--(4,3,1,29,2,1, NEWID(),GETDATE()),
--(10,8,1,30,2,1, NEWID(),GETDATE()),
--(9,1,1,31,2,1, NEWID(),GETDATE()),
--(15,6,1,32,3,1, NEWID(),GETDATE()),
--(7,8,1,33,3,1, NEWID(),GETDATE()),
--(4,13,1,34,3,1, NEWID(),GETDATE()),
--(6,5,1,35,3,1, NEWID(),GETDATE()),
--(3,1,1,36,3,1, NEWID(),GETDATE()),
--(10,6,1,37,4,1, NEWID(),GETDATE()),
--(5,13,1,38,4,1, NEWID(),GETDATE()),
--(3,3,1,39,4,1, NEWID(),GETDATE()),
--(4,4,1,40,4,1, NEWID(),GETDATE()),
--(5,8,1,41,4,1, NEWID(),GETDATE()),
--(2,3,1,42,6,1, NEWID(),GETDATE()),
--(3,11,1,43,6,1, NEWID(),GETDATE()),
--(1,9,1,44,6,1, NEWID(),GETDATE()),
--(17,13,1,45,6,1, NEWID(),GETDATE()),
--(7,6,1,46,6,1, NEWID(),GETDATE()),
--(5,3,1,47,7,1, NEWID(),GETDATE()),
--(2,3,1,48,7,1, NEWID(),GETDATE()),
--(9,3,1,49,7,1, NEWID(),GETDATE()),
--(4,1,1,50,7,1, NEWID(),GETDATE()),
--(7,6,1,51,7,1, NEWID(),GETDATE()),
--(7,10,1,52,9,1, NEWID(),GETDATE()),
--(7,13,1,53,9,1, NEWID(),GETDATE()),
--(17,3,1,54,9,1, NEWID(),GETDATE()),
--(7,12,1,55,9,1, NEWID(),GETDATE()),
--(9,3,1,56,9,1, NEWID(),GETDATE()),
--(5,3,1,57,10,1, NEWID(),GETDATE()),
--(6,3,1,58,10,1, NEWID(),GETDATE()),
--(3,3,1,59,10,1, NEWID(),GETDATE()),
--(7,8,1,60,10,1, NEWID(),GETDATE()),
--(7,0,1,61,10,1, NEWID(),GETDATE()),
--(7,6,1,62,11,1, NEWID(),GETDATE()),
--(7,1,1,63,11,1, NEWID(),GETDATE()),
--(13,3,1,64,11,1, NEWID(),GETDATE()),
--(12,13,1,65,11,1, NEWID(),GETDATE()),
--(2,1,1,66,11,1, NEWID(),GETDATE()),
--(3,1,1,67,12,1, NEWID(),GETDATE()),
--(2,5,1,68,12,1, NEWID(),GETDATE()),
--(8,6,1,69,12,1, NEWID(),GETDATE()),
--(5,3,1,70,12,1, NEWID(),GETDATE()),
--(8,6,1,71,12,1, NEWID(),GETDATE()),
--(1,3,1,72,13,1, NEWID(),GETDATE()),
--(3,1,1,73,13,1, NEWID(),GETDATE()),
--(2,4,1,74,13,1, NEWID(),GETDATE()),
--(4,2,1,75,13,1, NEWID(),GETDATE()),
--(9,1,1,76,13,1, NEWID(),GETDATE()),
--(1,9,1,77,14,1, NEWID(),GETDATE()),
--(2,5,1,78,14,1, NEWID(),GETDATE()),
--(1,7,1,79,14,1, NEWID(),GETDATE()),
--(1,6,1,80,14,1, NEWID(),GETDATE()),
--(6,4,1,81,14,1, NEWID(),GETDATE()),
--(4,1,1,82,15,1, NEWID(),GETDATE()),
--(1,4,1,83,15,1, NEWID(),GETDATE()),
--(8,9,1,84,15,1, NEWID(),GETDATE()),
--(1,3,1,85,15,1, NEWID(),GETDATE()),
--(3,1,1,86,15,1, NEWID(),GETDATE()),
--(2,7,1,87,16,1, NEWID(),GETDATE()),
--(10,19,1,88,16,1, NEWID(),GETDATE()),
--(13,1,1,89,16,1, NEWID(),GETDATE()),
--(5,6,1,90,16,1, NEWID(),GETDATE()),
--(3,5,1,91,16,1, NEWID(),GETDATE()),
--(2,5,1,92,17,1, NEWID(),GETDATE()),
--(7,6,1,93,17,1, NEWID(),GETDATE()),
--(4,9,1,94,17,1, NEWID(),GETDATE()),
--(9,4,1,95,17,1, NEWID(),GETDATE()),
--(10,12,1,96,17,1, NEWID(),GETDATE()),
--(11,8,1,97,18,1, NEWID(),GETDATE()),
--(7,2,1,98,18,1, NEWID(),GETDATE()),
--(2,7,1,99,18,1, NEWID(),GETDATE()),
--(8,3,1,100,18,1, NEWID(),GETDATE()),
--(3,8,1,101,18,1, NEWID(),GETDATE()),
--(9,9,1,102,19,1, NEWID(),GETDATE()),
--(1,1,1,103,19,1, NEWID(),GETDATE()),
--(1,6,1,104,19,1, NEWID(),GETDATE()),
--(6,1,1,105,19,1, NEWID(),GETDATE()),
--(2,4,1,106,19,1, NEWID(),GETDATE()),
--(4,2,1,107,20,1, NEWID(),GETDATE()),
--(5,3,1,108,20,1, NEWID(),GETDATE()),
--(3,5,1,109,20,1, NEWID(),GETDATE()),
--(8,9,1,110,20,1, NEWID(),GETDATE()),
--(1,1,1,111,20,1, NEWID(),GETDATE()),
--(8,7,1,112,21,1, NEWID(),GETDATE()),
--(18,1,1,113,21,1, NEWID(),GETDATE()),
--(8,9,1,114,21,1, NEWID(),GETDATE()),
--(2,1,1,115,21,1, NEWID(),GETDATE()),
--(1,9,1,116,21,1, NEWID(),GETDATE()),
--(10,15,1,117,22,1, NEWID(),GETDATE()),
--(1,4,1,118,22,1, NEWID(),GETDATE()),
--(4,1,1,119,22,1, NEWID(),GETDATE()),
--(6,2,1,120,22,1, NEWID(),GETDATE()),
--(2,9,1,121,22,1, NEWID(),GETDATE()),
(10,2,1,122,1,1, NEWID(),GETDATE()),
(2,8,1,123,1,1, NEWID(),GETDATE()),
(6,7,1,124,1,1, NEWID(),GETDATE());


INSERT INTO [Property].[Address](Street1,Street2,ApartmentNum,City,[State],ZipCode,Active,ModifiedDate,[Guid])
values
--('2100 WordsWorth Ct.','',102,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2100 WordsWorth Ct.','',104,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2100 WordsWorth Ct.','',302,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2100 WordsWorth Ct.','',304,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2100 WordsWorth Ct.','',306,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('508 Pride Avenue','',629,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('508 Pride Avenue','',724,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('508 Pride Avenue','',229,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('508 Pride Avenue','',521,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('508 Pride Avenue','',148,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2320 Dulles Station Blvd.','',204,'Herndon','VA','20171',1,GETDATE(),NEWID()),
--('2320 Dulles Station Blvd.','',206,'Herndon','VA','20171',1,GETDATE(),NEWID()),
--('2320 Dulles Station Blvd.','',404,'Herndon','VA','20171',1,GETDATE(),NEWID()),
--('2320 Dulles Station Blvd.','',412,'Herndon','VA','20171',1,GETDATE(),NEWID()),
--('2320 Dulles Station Blvd.','',414,'Herndon','VA','20171',1,GETDATE(),NEWID()),
--('11659 North Shore Drive','',104,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('11659 North Shore Drive','',106,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('11659 North Shore Drive','',302,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('11659 North Shore Drive','',304,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('11659 North Shore Drive','',404,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive Bld.1','',102,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive Bld.1','',104,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive Bld.2','',104,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive Bld.2','',202,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive Bld.2','',204,'Herndon','VA','20190',1,GETDATE(),NEWID()),
--('13000 WorldGate Drive','',148,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('13000 WorldGate Drive','',156,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('13000 WorldGate Drive','',240,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('13000 WorldGate Drive','',250,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('13000 WorldGate Drive','',346,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11850 Freedom Drive Bld.1','',110,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11850 Freedom Drive Bld.1','',120,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11850 Freedom Drive Bld.2','',210,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11850 Freedom Drive Bld.2','',214,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11850 Freedom Drive Bld.3','',220,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11410 Esplanade Drive Bld.1','',125,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11410 Esplanade Drive Bld.1','',127,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11410 Esplanade Drive Bld.2','',215,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11410 Esplanade Drive Bld.2','',217,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11410 Esplanade Drive Bld.2','',219,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11012 Becontree Lake Drive','',110,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11012 Becontree Lake Drive','',114,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11012 Becontree Lake Drive','',210,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11012 Becontree Lake Drive','',220,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11012 Becontree Lake Drive','',316,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11901 Winterthur Lane Bld.1','',110,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11901 Winterthur Lane Bld.3','',114,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11901 Winterthur Lane Bld.5','',210,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11901 Winterthur Lane Bld.6','',214,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11901 Winterthur Lane Bld.9','',216,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('174 Swayne Way Bld.1','',120,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('174 Swayne Way Bld.2','',134,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('174 Swayne Way Bld.2','',220,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('174 Swayne Way Bld.3','',226,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('174 Swayne Way Bld.3','',320,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('790 Pride Avenue','',114,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('790 Pride Avenue','',115,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('790 Pride Avenue','',120,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('790 Pride Avenue','',212,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('790 Pride Avenue','',214,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('111 Dulles Blvd.','',113,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('111 Dulles Blvd.','',117,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('111 Dulles Blvd.','',121,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('111 Dulles Blvd.','',211,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('111 Dulles Blvd.','',215,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('4432 North Drive','',110,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('4432 North Drive','',120,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('4432 North Drive','',224,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('4432 North Drive','',314,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('4432 North Drive','',318,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive','',110,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive','',120,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive','',214,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive','',218,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('Sycamore Valley Drive','',220,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('5322 Way Street Bld.1','',118,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('5322 Way Street Bld.1','',120,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('5322 Way Street Bld.2','',214,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('5322 Way Street Bld.2','',310,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('5322 Way Street Bld.3','',320,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('904 Garview Avenue','',110,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('904 Garview Avenue','',302,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('904 Garview Avenue','',306,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('904 Garview Avenue','',310,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('904 Garview Avenue','',316,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('1043 Station Blvd. Bld.1','',121,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('1043 Station Blvd. Bld.2','',229,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('1043 Station Blvd. Bld.2','',231,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('1043 Station Blvd. Bld.3','',313,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('1043 Station Blvd. Bld.3','',319,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2435 Stalaybridge Drive','',216,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2435 Stalaybridge Drive','',217,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2435 Stalaybridge Drive','',310,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2435 Stalaybridge Drive','',312,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('2435 Stalaybridge Drive','',3140,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11100 Garden View Loop','',114,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11100 Garden View Loop','',120,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11100 Garden View Loop','',210,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11100 Garden View Loop','',216,'Herndon','VA','20170',1,GETDATE(),NEWID()),
--('11100 Garden View Loop','',220,'Herndon','VA','20170',1,GETDATE(),NEWID()),
('2100 RavenTower Ct.','',102,'Herndon','VA','20170',1,GETDATE(),NEWID()),
('2100 RavenTower Ct.','',104,'Herndon','VA','20170',1,GETDATE(),NEWID()),
('2100 RavenTower Ct.','',204,'Herndon','VA','20170',1,GETDATE(),NEWID());


drop table [person].person;
drop table [request].Request;
drop table [request].RequestType;
drop table [request].[Status];
drop table [property].Property;
drop table [person].[Provider];
drop table [property].complex;
drop table [property].[Address];
drop table [person].Contact;



