create database LibraryManagement;
use LibraryManagement;
create table members(memberID int identity (1111,1), nicNumber varchar(13), memberName varchar(50), 
emailAddress varchar(50), telephoneNumber varchar(10), dob varchar(20), gender varchar(8), mAddress varchar(200));
create table users(username varchar(30), password varchar(10), accessLable varchar(3));
create table book(isbn varchar(10) primary key, boolkName varchar(50), author varchar(50), 
category varchar(30), publication varchar(50), quantity int, description varchar(300));
create table issuedBooks(recNo int identity (1111,1) primary key, bookISBN varchar(10), bookName varchar(50),
memID int, memName varchar(50), issuedDate varchar(20), dueDate varchar(20));
create table returnBooks (recNo int identity (1111,1) primary key, bookISBN varchar(10), bookName varchar(50),
memID int, memName varchar(50), issuedDate varchar(20), dueDate varchar(20),returnDate varchar(20));
select * from members;
select * from users;
select * from book;
select isbn, boolkName, author, category, publication from book where isbn like('fb%') or boolkName like('ad%');
select * from issuedBooks;
select * from returnBooks;
insert into users values ('admin','admin123','ad');
insert into users values ('ashen','admin123','ma');
create table reservations(resID int identity (1111,1) primary key, isbn varchar(10), bookName varchar(50),
bookAuthor varchar(50), memberID int, memberName varchar(50), dateCollecting varchar(20));
insert into reservations (isbn,bookName,bookAuthor,memberID,memberName,dateCollecting) values ('','','','','','');
SELECT* FROM book where boolkName like('%l%');
select * from reservations;