select *from (SELECT *FROM LicensesOfAnApplicant_View WHERE DriverID IN (SELECT DriverID FROM Drivers WHERE PersonID = 1042)) as Subquery
where ClassName ='Class 1 - Small Motorcycle'

SELECT l.*
FROM LicensesOfAnApplicant_View l
JOIN Drivers d ON l.DriverID = d.DriverID
WHERE d.PersonID = 1042
AND l.ClassName = 'Class 1 - Small Motorcycle';