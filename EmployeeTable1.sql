 table EmployeeTable1(
EmployeeID int,
EmployeeName varchar(250),
EmployeeAge int,
EmployeeAddress varchar(550),
Gender varchar(1),
EmployeeSalary int,
);

CREATE TABLE Salary(
SalaryId int,
SalaryMonth varchar(20),
EmpId int,
EmpSalary int,


)

insert into Salary values(12,'Jan',123,9000);

insert into Salary values(17,'Feb',235,10000);


select * from salary

insert into EmployeeTable1 values(123,'Snehal',25,'Nashik');

insert into EmployeeTable1 values(134,'Swapnil',29,'Pune');

insert into EmployeeTable1 values(165,'Swati',22,'Mumbai');

--select * from EmployeeTable where EmployeeID=165

select * from EmployeeTable1

update EmployeeTable
set EmployeeID=123
where EmployeeName='Snehal'

--delete EmployeeTable
--where EmployeeName='Snehal'

ALTER  TABLE EmployeeTable1
ADD Gender varchar(1)

select * from EmployeeTable1
where EmployeeAge between 22 and 27

select * from EmployeeTable1
where  EmployeeAddress like '%UN%'

update EmployeeTable1
set  Gender='F' , EmployeeSalary=9000
where EmployeeID='121'  

select count(EmployeeID)
FROM EmployeeTable1
where EmployeeSalary=9000
