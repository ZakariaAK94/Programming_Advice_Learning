-- This script generates an employee attendance report for a specified month and year.
-- It tracks the number of days present, absent, and on leave for a particular employee.
-- Declare variables
DECLARE @EmployeeID INT;
DECLARE @ReportMonth INT;
DECLARE @ReportYear INT;
-- Initialize variables
SET @EmployeeID = 101; -- Set the Employee ID for the report
SET @ReportMonth = 7; -- Set the month for the report
SET @ReportYear = 2023; -- Set the year for the report
-- Declare extra variables
DECLARE @TotalDays INT, @PresentDays INT,@AbsentDays INT,@LeaveDays INT;

-- Calculate total days in the month
SET @TotalDays = DAY(EOMONTH(DATEFROMPARTS(@ReportYear, @ReportMonth, 1)));
-- EOMONTH and DATEFROMPARTS is a built-in fct 
-- in this example DATEFROMPARTS(Y,M,D) = 'Y-M-D'
-- and EOMONTH(Y,M,D) = 'Y-M-D' and D it is the last day in the Month M
-- Calculate present, absent, and leave days
SELECT @PresentDays = COUNT(*) FROM EmployeeAttendance
WHERE EmployeeID = @EmployeeID 
AND MONTH(AttendanceDate) = @ReportMonth 
AND YEAR(AttendanceDate) = @ReportYear 
AND Status = 'Present';

SELECT @AbsentDays = COUNT(*) FROM EmployeeAttendance
WHERE EmployeeID = @EmployeeID 
AND MONTH(AttendanceDate) = @ReportMonth 
AND YEAR(AttendanceDate) = @ReportYear 
AND Status = 'Absent';

SELECT @LeaveDays = COUNT(*) FROM EmployeeAttendance
WHERE EmployeeID = @EmployeeID 
AND MONTH(AttendanceDate) = @ReportMonth 
AND YEAR(AttendanceDate) = @ReportYear 
AND Status = 'Leave';

-- Print the report
PRINT 'Employee Attendance Report for Employee ID: ' + CAST(@EmployeeID AS VARCHAR);
PRINT 'Report Month: ' + CAST(@ReportMonth AS VARCHAR) + '/' + CAST(@ReportYear AS VARCHAR);
PRINT 'Total Working Days: ' + CAST(@TotalDays AS VARCHAR);
PRINT 'Days Present: ' + CAST(@PresentDays AS VARCHAR);
PRINT 'Days Absent: ' + CAST(@AbsentDays AS VARCHAR);
PRINT 'Days on Leave: ' + CAST(@LeaveDays AS VARCHAR);
