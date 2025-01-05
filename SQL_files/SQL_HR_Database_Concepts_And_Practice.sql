use HR_Database;

select *from Employees;
-----------------------
select *from Countries;
----------------------
select *from Departments;
------------------------
select distinct MonthlySalary from Employees;
-------------------------
select distinct FirstName, DepartmentID from employees where FirstName = 'Abigail';
--------------------------
select FirstName, DepartmentID from employees where FirstName = 'Abigail';
----------------------------
select FirstName from employees where  not (MonthlySalary <= 500 and Gendor = 'F');
------------------------------------
select FirstName from employees where  MonthlySalary > 500 or Gendor = 'M';
-------------------------------------------------
select distinct FirstName from employees where MonthlySalary <= 500;
------------------------------------------------
select * from employees where  MonthlySalary <= 500 and Gendor = 'F' and ID >500 and DepartmentID in (1,5,7) and CountryID in (1,2) and BonusPerc <> 0;
------------------------------------------
select Departments.Name from Departments
where ID in (select DepartmentID from employees where  MonthlySalary <= 500 and Gendor = 'F' and ID >500 and DepartmentID in (1,5,7) and CountryID in (1,2) and BonusPerc <> 0);
---------------------------------------------
select Name from Departments where ID in (1,7);
----------------------------------------------
select ID, FirstName, MonthlySalary from Employees
where DepartmentID = 1
Order by MonthlySalary  desc;
------------------------------------------------
select ID, FirstName, MonthlySalary from Employees
where DepartmentID = 1
Order by FirstName ,MonthlySalary  desc;
-----------------------------------------------
select ID, FirstName, MonthlySalary from Employees
where DepartmentID = 1
Order by FirstName desc,MonthlySalary  asc;
-----------------------------------------------
select ID, FirstName, MonthlySalary from Employees where MonthlySalary in
( select distinct top 3 Monthlysalary from Employees
  order by MonthlySalary asc
)
order by MonthlySalary asc;
----------------------------------------------
select ID,FirstName, MonthlySalary from Employees where MonthlySalary in
( select distinct top 3 MonthlySalary from Employees
  order by MonthlySalary desc
)
order by MonthlySalary desc;
----------------------------------------------
select ID, FirstName +' ' + LastName as FullName, ThirdBonus = Monthlysalary *1.7 from Employees;
select ID, FullName = FirstName +' ' + LastName, ThirdBonus = Monthlysalary *1.7 from Employees;
select ID, FullName = FirstName +' ' + LastName, DATEDIFF(year, DateofBirth, GETDATE()) as Age from Employees;
select ID, FullName = FirstName +' ' + LastName, Age= DATEDIFF(year, DateofBirth, GETDATE()),YearsOfExperience= DATEDIFF(year, HireDate, GETDATE()),  PercOfLifePassingasWorker  = DATEDIFF(year, HireDate, GETDATE())/DATEDIFF(year, DateofBirth, GETDATE()) from Employees;
select *from Employees;
-----------------------------------------------
select DepartmentID, DepartmentName =(select Departments.Name from Departments where ID=DepartmentID),
		TotalSalary = Sum(MonthlySalary),
		TotalEmployees = Count(MonthlySalary),
		Average = Avg(MonthlySalary),
		MaxSalary = Max(MonthlySalary),
		MinSalary = Min(MonthlySalary)
		from Employees
		Group by DepartmentID
		order by DepartmentID
---------------------------------------------------
select CountryID, CountryName =(select Countries.Name from Countries where ID=CountryID),
		TotalSalary = Sum(MonthlySalary),
		TotalEmployees = Count(MonthlySalary),
		Average = Avg(MonthlySalary),
		MaxSalary = Max(MonthlySalary),
		MinSalary = Min(MonthlySalary)
		from Employees
		Group by CountryID
		order by CountryID
---------------------------------------------------------------------------------
select ID,FirstName,Age = Datediff(year,DateOfBirth, getdate()) from Employees;
---------------------------------------------------------------------------------
select ID,FullName = FirsTname +' '+LastName,Age = Datediff(year,DateOfBirth, getdate()) from Employees;
-------------------------------------------------------------------
select DepartmentID,
TotalCount = Count(MonthlySalary),
TotalSalary = Sum(MonthlySalary),
Average = Avg(MonthlySalary),
MaxSalary = Max(MonthlySalary),
MinSalary = Min(MonthlySalary)
from Employees
Group by DepartmentID
having Count(MonthlySalary) >120
order by DepartmentID;
-------------------------------------------------------
select *from (
select DepartmentID,
TotalCount = Count(MonthlySalary),
TotalSalary = Sum(MonthlySalary),
Average = Avg(MonthlySalary),
MaxSalary = Max(MonthlySalary),
MinSalary = Min(MonthlySalary)
from Employees
Group by DepartmentID
) R1
where R1.TotalCount >120;
---------------------------------------------
select ID,FirstName from employees
where FirstName like 'ab%';
----------------------------------------
select ID,FirstName from employees
where FirstName like '%b';
----------------------------------
select ID,FirstName from employees
where FirstName like '%tell%';
-------------------------------------
select ID,FirstName from employees
where FirstName like 'a%a';
------------------------------------
select ID,FirstName from employees
where FirstName like '_a%';
-----------------------------------
select ID,FirstName from employees
where FirstName like '______a%';
----------------------------------
select ID,FirstName from employees
where FirstName like 'a___%';
----------------------------------
update employees
set FirstName ='Mohammed', LastName ='AKIL'
where ID=285;
------------------------------------
update employees
set FirstName ='Mohammad', LastName ='Maher'
where ID=286;
------------------------------------
select ID,FirstName,LastName from employees
where FirstName = 'Mohammed' or FirstName ='Mohammad';
------------------------------------
--will search from Mohammed or Mohammad
select ID,FirstName, LastName from employees
where firstName like 'Mohamm[ae]d';
---------------------------------------
--We can use Not
select ID,FirstName, LastName from employees
where firstName not like 'Mohamm[ae]d';
----------------------------------------
select ID,FirstName,LastName from Employees
where FirstName like 'a%' or FirstName like 'b%' or FirstName like 'c%'
order by FirstName asc;
-----------------------------------------
select ID,FirstName,LastName from Employees
where FirstName like '[abc]%'
order by FirstName asc;
-----------------------------------------
select ID,FirstName,LastName from Employees
where FirstName like '[a-g]%'
order by FirstName asc;
----------------------------------------
select ID, FullName =FirstName +' ' +LastName, 
GenderStatus =
case
     when Gendor ='M' then 'Male'
	 when Gendor ='F' then 'Female'
End,
SocialStatus=
case
	when Monthlysalary <1000 then 'Intermediate'
	else 'Rich'
end,
Status =
case
	when ExitDate is not null then 'Active'
	else 'Resigned'
end

From employees


