-- using if statement with SQL 
declare @age int =25;
declare @Salary Decimal(10,2) =5000;

if(@age > 25 and @Salary <4500)
begin
	Print 'you are eligible for this programm'
end
else
begin
	Print 'you are not eligible for this programm'
end
----------------------------------------
declare @Grade char ='B';
declare @attendancePercentage int =75;
if(@Grade ='A' or @attendancePercentage>70)
begin
	Print 'Qualified for extra-curricular activities'
end
else
begin
	Print 'Not Qualified for extra-curricular activities'
end
--------------------------------------------------
--Error Handling with IF
declare @ErrorValue int;
--Query
insert into Students (Name) values ('John');
set @ErrorValue =@@ERROR;

if @ErrorValue <>0
begin
	print 'Error occurs with error number: '+cast(@ErrorValue as varchar)
end
-------------------------------------------------
declare @Name varchar(50);
declare @NbrOfPerson int;
set @Name = 'Salma';
set @NbrOfPerson =(select count(*) from students where Name =@Name);
if( @NbrOfPerson <> 0 )
    begin
	       print 'There is '+cast(@NbrOfPerson as varchar)+' with the name '+cast(@Name as varchar)
    end
else
	begin
		print 'There is no one with the name '+cast(@Name as varchar)
    end
-------------------------------------------------------
--example of using case 
SELECT EmployeeID,
    CASE DepartmentID
        WHEN 1 THEN 'Engineering'
        WHEN 2 THEN 'Human Resources'
        WHEN 3 THEN 'Sales'
        ELSE 'Other'
    END AS DepartmentName
FROM Employees;
select *from Employee
---------------------------------------------------------
-- using CTE with case statement
with EmployeesStudy as(
SELECT EmployeeID,Name,Performance,Salary,
  CASE 
        WHEN Salary >= 6500 and Salary<10000 THEN 'Category A'
		WHEN Salary >= 4500 and Salary<6500 THEN 'Category B'
		WHEN Salary >= 1000 and Salary<4500 THEN 'Category C'
        ELSE 'Category D'
    END as Categories
FROM EmployeesWithSalary)
select *,CASE 
        WHEN Categories ='Category A' THEN 'Good job'
		when Categories ='Category B' or Categories='Category A' then 'Normal job'
        ELSE 'Bad Job'
    END as SalaryRemark
from EmployeesStudy
ORDER BY Categories,SalaryRemark asc;
-------------------------------------------------
--creation of procedure
create procedure SP_UpdateSalary
as
begin
	UPDATE Employees2
SET Salary = 
    CASE 
        WHEN PerformanceRating > 90 THEN Salary * 1.15
        WHEN PerformanceRating BETWEEN 75 AND 90 THEN Salary * 1.10
		WHEN PerformanceRating BETWEEN 50 AND 74 THEN Salary * 1.05
        ELSE Salary
    END;
end

exec SP_UpdateSalary
select *from EmployeesWithSalary
---------------------------------------------------
SELECT 
    EmployeeID,
    CASE 
        WHEN Salary <= 3000 THEN 'Entry Level'
        WHEN Salary BETWEEN 3001 AND 6000 THEN 'Mid Level'
        WHEN Salary > 6000 THEN 'Senior Level'
        ELSE 'Not Specified'
    END AS EmployeeLevel
FROM EmployeesWithSalary;
---------------------------------------------------
SELECT Name, Salary
FROM EmployeesWithSalary
ORDER BY 
    CASE 
        WHEN Salary > 50000 THEN 1
        ELSE 2
    END desc,Salary;
---------------------------------------------------
select *
from Sales
order by
	case 
	when SaleAmount > 150 then 1
	else 2
	end
	asc,SaleAmount desc
-----------------------------------------------------
create procedure SP_GiveBonus
as
begin
select Name,Department,Salary,PerformanceRating,
 Bonus=
   case
   when Department ='Marketing' then
		case
			when PerformanceRating>85 then Salary*1.15
			when PerformanceRating >50 and PerformanceRating<85 then Salary*1.10
			else Salary
    	end
   when Department ='HR' then
		case
			when PerformanceRating>85 then Salary*1.08
			when PerformanceRating >50 and PerformanceRating<85 then Salary*1.03
			else Salary
		end
  when Department ='IT' then
		case
			when PerformanceRating>85 then Salary*1.2
			when PerformanceRating >50 and PerformanceRating<85 then Salary*1.10
			else Salary
		end
	end
from Employees2
end
exec SP_GiveBonus
--------------------------------------------------------------
select *from Employees2
select from
(select PerformanceRating,
   case 
    when PerformanceRating>=80 then 'High'
	when PerformanceRating >=60 and PerformanceRating<80 then 'Meduim'
	else 'Low'
   end as hierarchy
from Employees2
group by hierarchy
--------------------------------------------------------------
DECLARE @aDt DATETIME, @eDt DATETIME;
-- Assign values to @aDt and @eDt
SET @aDt = CAST('1.' + '01' + '.' + '2024' AS DATETIME);
SET @eDt = EOMONTH(CAST('1.' + '01' + '.' + '2024' AS DATETIME));
-- CTE declaration
with vars as
(
select '2024' as years,
 CAST('1.' + '01' + '.' + '2024' AS DATETIME) as aDt,
 CAST('1.' + '01' + '.' + '2024' AS DATETIME) as eDt
), months AS (
    SELECT 
	    V as zaehler,
	    Format(DateAdd(m,V-1,(select aDt from years)), 'yyyy-MM-dd') AS aDAT,  
        Format(DateAdd(m,V-1,select eDt from years),'yyyy-MM-dd') AS eDAT,
        CAST(DateAdd(m,V-1,select aDt from years) AS INT) + 109573 AS aDATG,
        CAST(DateAdd(m,V-1,select eDt from years) AS INT) + 109573 AS EDATG,

        FORMAT(DateAdd(m,v-1,@eDt), 'yyMM') AS Monat
      from (VALUES (1)) AS month(V)
)select *from months
---------------------------------------------------------------
EXEC sp_helptext 'sp_rename'
EXEC sp_help 'table_name'; --Purpose: Provides detailed information about database objects like tables, views, and columns.
EXEC sp_rename 'old_object_name', 'new_object_name';--Purpose: Renames database objects such as tables, columns, indexes, etc.
EXEC sp_depends 'object_name';--Purpose: Shows the dependencies of an object, such as what other objects reference it.
EXEC sp_helptext 'procedure_name';--Purpose: Returns the definition of a stored procedure, function, trigger, or view in SQL.
EXEC sp_columns 'table_name';--Purpose: Returns column information for a table or view.
EXEC sp_tables;--Purpose: Lists all the tables and views in the current database.
EXEC sp_indexes 'table_name';--Purpose: Returns a list of indexes defined for a table or view.
EXEC sp_changeobjectowner 'object_name', 'new_owner'; --Purpose: Changes the owner of a database object. (Deprecated in newer versions, use ALTER AUTHORIZATION instead.)
EXEC sp_addextendedproperty 'property_name', 'property_value', 'object_type', 'object_name';--Purpose: Adds or updates extended properties, which are metadata associated with database objects.
--sp_addextendedproperty / sp_updateextendedproperty
EXEC sp_addtype 'type_name', 'data_type', 'nullability';--Purpose: Creates a user-defined data type.
------------------------------------------------------------------
select PerformanceCategory,count(*) as NbrOfEmployees,AVG(Salary)
from
(select Name,Salary,
	 case
	 when PerformanceRating > 80 then 'High'
	 when PerformanceRating > 60 and PerformanceRating <=80 then 'Meduim'
	 else 'Low'
	end as PerformanceCategory
    from Employees2) as PerformanceTable
group by PerformanceCategory
-------------------------------------------------------------------
declare @counter int =1
while @counter <5
begin
	print 'Count' +cast(@Counter as varchar)
	set @Counter = @Counter+1
end
print ' '
Print 'Revered Counter'
--this loop prints from 5 to 
set @Counter = 5
while @Counter >0
begin
	print 'Count' + cast(@Counter as varchar)
	set @Counter = @Counter -1
end
-------------------------------------------------------------------
declare @EmployeeID int;
declare @Name varchar(50);
declare @MaxID int;
--initialize the starting point
select @EmployeeID =min(EmployeeID) from Employees
select @MaxID =max(EmployeeID) from Employees
Print @EmployeeID
--Loop through employees
while @EmployeeID is not null and @EmployeeID <=@MaxID
begin
	--Perform an operation e.g print emloyee's name
	select @Name = Name from Employees where EmployeeID = @EmployeeID;
	Print @Name;
	select @EmployeeID= min(EmployeeID) from Employees where EmployeeID >@EmployeeID;
end
----------------------------------------------------------------------------
declare @Balance decimal(10,2) = 950.00;
declare @Withdraw decimal(10,2) = 100.00;
declare @counter int =0;
while @Balance > 0
begin
	set @Balance = @Balance-@Withdraw;
	set @Counter = @Counter+1;
	if(@Balance<0)
	begin
		print 'insuffitiant balance, after '+cast(@Counter as varchar) +' iterations'
		break;
	end
	Print @Balance
end
--------------------------------------------------------------------------------
declare @i int =1;
declare @j int =1;
while(@i<10)
begin
	Print 'For table'+cast(@i as varchar)
	while(@j<10)
	begin
	Print cast(@i as varchar) +'*'+ cast(@j as varchar)+'='+cast(@i*@j as varchar)
	set @j = @j +1
	end
	set @i = @i +1
	set @j=1;
end
------------------------------------------------------------------------------------
declare @row int =1;
declare @col int =1;
declare @result varchar(255);
declare @headerstring varchar(100);

-- Create the header row for the columns
set @headerstring = char(9);-- Starting with a tab for the row header space
set @col =1;
while @col <=10
begin	
	set @headerstring = @headerstring +cast(@col as varchar(2))+char(9)
	set @col = @col+1
end
print @headerstring
-- Generate the multiplication table
while(@row<=10)
begin
	set @col =1;
	set @result = cast(@row as varchar)+char(9);-- Start each row with the row number
	while(@col<=10)
	begin
		set @result = @result+ cast(@row * @col as varchar)+char(9);	-- Append multiplication results
		set @col = @col +1;
	end
	Print @result;-- Print the row
	set @row = @row +1
end
----------------------------------------------------------
declare @counter int =1;
print 'Odd Numbers between 1 and 10'
while @counter <10
begin
	set @counter = @counter+1
	if @counter %2 = 0
	begin
	 continue;-- to skip to the next value / we can use 'break' to stop loop
	end
	print @counter	
end
---------------------------------------------------------
--CREATE TABLE Employees3 (                 
--    EmployeeID INT PRIMARY KEY,
--    Name NVARCHAR(100),
--    Position NVARCHAR(100)
--);    
BEGIN TRY
    -- Insert a record into the Employees table
    INSERT INTO Employees3 (EmployeeID, Name, Position) VALUES (1, 'John Doe', 'Sales Manager');
    
    -- Attempt to insert a duplicate record which will cause an error
    INSERT INTO Employees3 (EmployeeID, Name, Position) VALUES (1, 'Jane Smith', 'Marketing Manager');
END TRY
BEGIN CATCH
    -- Handle the error
    PRINT 'An error occurred: ' + ERROR_MESSAGE();
	PRINT 'An error occurred: ' + ERROR_STATE();
	PRINT 'An error occurred: ' + ERROR_LINE();
    -- Rollback the transaction if any
END CATCH
-------------------------------------------------------------------------
--Error Functions Overview:
--ERROR_NUMBER()
--Purpose: Returns the error number of the error that caused the CATCH block to be executed//Usage: Useful for identifying the specific error that occurred.
--ERROR_SEVERITY()
--Purpose: Returns the severity level of the error.//Usage: Helps in understanding the nature and seriousness of the error. Severity levels range from 0 to 25.
--ERROR_STATE()
--Purpose: Returns the state number of the error.//Usage: Useful for providing additional information about the error or to distinguish between errors with the same number.
--ERROR_PROCEDURE()
--Purpose: Returns the name of the stored procedure or trigger in which the error occurred.//Usage: Essential for identifying the source of the error in complex systems with multiple procedures and triggers.
--ERROR_LINE()
--Purpose: Returns the line number where the error occurred.//Usage: Helps in pinpointing the exact location in the code where the error was raised, facilitating quicker debugging.
--ERROR_MESSAGE()
--Purpose: Provides the complete text of the error message.//Usage: Offers a detailed description of the error, which is valuable for understanding what went wrong.
BEGIN TRY
        -- Intentional division by zero error
        SELECT 1 / 0;
    END TRY
    BEGIN CATCH
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_SEVERITY() AS ErrorSeverity,
            ERROR_STATE() AS ErrorState,
            ERROR_PROCEDURE() AS ErrorProcedure,
            ERROR_LINE() AS ErrorLine,
            ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
-----------------------------------------------------------------------------------
declare @NewStcokQte int;												 --  Understanding THROW Statement
 set @NewStcokQte = -5;													 -- Purpose: Used to raise an exception and transfer control to a CATCH block of a TRY...CATCH construct in your SQL code.
begin try																 --  Syntax: THROW [error_number, message, state];
	if @NewStcokQte <0				                    					--error_number: A constant or variable between 50000 and 2147483647.
	throw 51000,'Stock quantity could not be negative',1					--message: The error message text. It should be a string less than 2048 characters.
update Products set StockQuantity =@NewStcokQte where ProductID =1         --state: A constant or variable between 0 and 255.
end try
begin catch
	select
		ERROR_MESSAGE() as ErrorMessage,
		ERROR_NUMBER() as ErrorNbr;
end catch
--------------------------------------------------------------------------------------
-- Attempt to insert an invalid record into a table
INSERT INTO Departments (DepartmentID, Name)
VALUES (1, 'Business'); -- Assume 'DepartmentID' is a primary key and '1' already exists
declare @ErrorNumber int = @@ERROR
IF @ErrorNumber <> 0
BEGIN
    -- Handle the error
    PRINT 'An error occurred during the insert operation.';
    -- You can also capture the specific error number and store it or use it in logic
    PRINT 'The error number is: ' + CAST(@ErrorNumber AS VARCHAR);
END
--@@ERROR is often used in older scripts or in systems where TRY...CATCH is not available or applicable.
--Purpose: @@ERROR provides the error number of the last T-SQL statement that was executed. If the last statement was successful, @@ERROR returns 0.
--------------------------------------------------------------------------------------
update Employees set DepartmentID=3 where DepartmentID=4
select @@ROWCOUNT as RowAffected
--Purpose: To get the number of rows affected by the most recently executed statement in your SQL script or batch
--------------------------------------------------------------------------------------
--Transactions:A transaction in SQL is a series of database operations that are treated as a single logical unit. It ensures that either all operations within it are executed or none are.
--ACID Properties: Transactions in SQL adhere to ACID properties - Atomicity, Consistency, Isolation, Durability.
-- Create Accounts Table
CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    Balance DECIMAL(10, 2)
);
-- Create Transactions Table
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    FromAccount INT,
    ToAccount INT,
    Amount DECIMAL(10, 2),
    Date DATETIME
);
-- Insert Sample Data into Accounts
INSERT INTO Accounts (AccountID, Balance) VALUES (1, 500.00); -- Account 1
INSERT INTO Accounts (AccountID, Balance) VALUES (2, 300.00); -- Account 2
--Example
begin Transaction;
begin try
	-- Subtract $100 from Account 1
	update Accounts set Balance = Balance -100 where AccountID =1
	-- Add $100 to Account 2
	update Accounts set Balance = Balance +100 where AccountID =2
	-- Log the transaction
	Insert into Transactions (FromAccount,ToAccount,Amount,Date) values (1,2,100,GetDate())
	-- Commit the transaction
	commit;
end try
begin catch
     -- Rollback in case of error
	RollBack;
	 -- Error handling code here
end catch
--------------------------------------------------------------------------------------
--Table variables in TSQL
	-- Declare a table variable named @EmployeesTable
	-- This table variable is stored in memory 
	--  and is scoped to the batch, stored procedure, or function
	DECLARE @EmployeesTable TABLE (
		EmployeeId INT,
		Name VARCHAR(100),
		Department VARCHAR(50)
	);

	-- Insert records into the @EmployeesTable table variable
	INSERT INTO @EmployeesTable (EmployeeId, Name, Department)
	VALUES (10, 'Mohammed', 'Marketing');

	INSERT INTO @EmployeesTable (EmployeeId, Name, Department)
	VALUES (11, 'Ali', 'Sales');

	-- Query the table variable

	SELECT * FROM @EmployeesTable WHERE Department = 'Sales';

	-- No need to drop the table variable
	-- The table variable @EmployeesTable automatically goes out of scope and is deallocated
	-- at the end of the execution of the batch, stored procedure, or function
--------------------------------------------------------------------------------
-- Create a local temporary table named #EmployeesTemp
	-- This table will be stored in the tempdb database and is visible only to this session
	CREATE TABLE #EmployeesTemp (
		EmployeeId INT,
		Name VARCHAR(100),
		Department VARCHAR(50)
	);
	-- Insert a records into the #EmployeesTemp table
	INSERT INTO #EmployeesTemp (EmployeeId, Name, Department)
	VALUES (10, 'Mohammed', 'Marketing');

	INSERT INTO #EmployeesTemp (EmployeeId, Name, Department)
	VALUES (11, 'Ali', 'Sales');

	-- Query the table
	SELECT * FROM #EmployeesTemp WHERE Department = 'Sales';
	-- Drop (delete) the temporary table #EmployeesTemp
	-- This is a good practice to clean up, although the table would automatically be deleted
	-- when the session ends
	DROP TABLE #EmployeesTemp;
---------------------------
	-- Create a local temporary table named #EmployeesTemp
	-- This table will be stored in the tempdb database and is visible only to this session
	CREATE TABLE ##EmployeesTemp1 (
		EmployeeId INT,
		Name VARCHAR(100),
		Department VARCHAR(50)
	);
	-- Insert a records into the #EmployeesTemp table
	INSERT INTO ##EmployeesTemp1 (EmployeeId, Name, Department)
	VALUES (10, 'Mohammed', 'Marketing');

	INSERT INTO ##EmployeesTemp1 (EmployeeId, Name, Department)
	VALUES (11, 'Ali', 'Sales');

	-- Query the table
	SELECT * FROM ##EmployeesTemp1 WHERE Department = 'Sales';
	-- Drop (delete) the temporary table #EmployeesTemp
	-- This is a good practice to clean up, although the table would automatically be deleted
	-- when the session ends
	DROP TABLE ##EmployeesTemp1;
--------------------------------------------------------------------------------
	--Return Statment with procedure
	CREATE PROCEDURE SP_CheckPersonExists
		 @PersonID INT
	AS
	BEGIN
	    IF EXISTS(SELECT * FROM People WHERE PersonID = @PersonID)
	        RETURN 1;  -- Person exists
	    ELSE
	        RETURN 0;  -- Person does not exist
	END
	
	DECLARE @Result INT;
	EXEC @Result = SP_CheckPersonExists @PersonID = 7; -- Replace 123 with the actual PersonID
	IF @Result = 1
	    PRINT 'Person exists.';
	ELSE
	    PRINT 'Person does not exist.';


