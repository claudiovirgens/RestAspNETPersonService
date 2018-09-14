create database restaspnetdb;

use restaspnetdb;

create table persons (
Id int(10)Unsigned null default null,
FirstName VARCHAR(50) NULL DEFAULT NULL,
LastName VARCHAR(50) NULL DEFAULT NULL,
Address VARCHAR(50) NULL DEFAULT NULL,
Gender VARCHAR(50) NULL DEFAULT NULL)
Engine=InnoDB;
alter table persons change id id int(10) auto_increment primary key;

