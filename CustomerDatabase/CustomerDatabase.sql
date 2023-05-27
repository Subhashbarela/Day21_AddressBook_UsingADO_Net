use CustomerDetails;
select * from Customer;
create table Customer
(
CustomerId int primary key identity(1,1),
Customer_Name varchar(30),
PhoneNumber bigint not null,
Address varchar(30),
Country varchar(30),
Salary varchar(30),
Pincode int
);