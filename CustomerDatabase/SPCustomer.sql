create procedure SPCustomer
(
@Customer_Name varchar(30),
@PhoneNumber bigint,
@Address varchar(30),
@Country varchar(30),
@Salary varchar(30),
@Pincode int
)
AS BEGIN
insert into Customer(Customer_Name,PhoneNumber,Address,Country,Salary,Pincode)
values(@Customer_Name,@PhoneNumber,@Address,@Country,@Salary,@Pincode)
END

