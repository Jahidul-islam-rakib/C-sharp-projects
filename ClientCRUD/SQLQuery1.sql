create table Clients(
	id int not null primary key identity,
	name varchar (30) not null,
	email varchar(30) not null unique,
	phone varchar (20) null,
	address varchar (50) null,
	created_at datetime not null default current_timestamp

 );

 insert into clients (name, email, phone, address)
 values
 ('najir' , 'najir@gmail.com', '234234423', 'gazipur, dhaka'),
 ('kabil', 'kabil@hotmail.com', '324234234','nandail, mymensingh')