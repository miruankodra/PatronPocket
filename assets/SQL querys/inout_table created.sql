use patronPocket

CREATE TABLE inout_info(
	inout_id int NOT NULL IDENTITY(0,1) PRIMARY KEY ,
	inout_type varchar(30) NOT NULL,
	inout_name varchar(30) NOT NULL,
	inout_date varchar(30) NOT NULL,
	inout_value varchar(30) NOT NULL,
	username varchar(30) NOT NULL FOREIGN KEY REFERENCES customer(username)
);

INSERT INTO inout_info (inout_type,inout_name,inout_date,inout_value,username) VALUES('Income', 'Initial Income', '16.2.2022', '1', 'User0');

select * from inout_info

ALTER table inout_info
ALTER COLUMN inout_name varchar(100)


