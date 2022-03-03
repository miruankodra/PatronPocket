create database patronPocket;

use patronPocket;

create table customer(
customer_id int NOT NULL IDENTITY(0,1) PRIMARY KEY,
firstname varchar(30) NOT NULL,
lastname varchar(30) NOT NULL,
username varchar(30) NOT NULL UNIQUE,
email varchar(50) NOT NULL,
passkey varchar(30) NOT NULL,
phone varchar(30) NOT NULL,
country varchar(30) NOT NULL,
city varchar(30) NOT NULL,
birthday date NOT NULL,
gender varchar(30)
);

INSERT INTO customer (firstname, lastname,  username, email, passkey, phone, country, city, birthday, gender)
VALUES('First', 'User', 'User0', 'user0@patronpocket.com', 'user0password', '+000000000000','Albania','Tirona','2022-02-14','male')

SELECT * FROM customer


