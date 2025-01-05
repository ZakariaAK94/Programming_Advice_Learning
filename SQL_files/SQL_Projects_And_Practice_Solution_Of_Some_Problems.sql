select count(*) from VehicleDetails
where year not between 1950 and 2000
------------------------------------------

select count(*) from VehicleDetails
where year between 1950 and 2000

--------------------------------------------

select    Makes.Make, count(*) as NbrOfVehicles, (select count(*) from VehicleDetails where year between 1950 and 2000) 
          as TotalNbrOfVehicles
from      VehicleDetails inner join Makes
          on Makes.MakeID = VehicleDetails.MakeID
where VehicleDetails.year between 1950 and 2000
group by Make
order by NbrOfVehicles desc

------------------------------------------------
select *from
(
SELECT   Make, COUNT(*) AS NumberOfVehicles
FROM      VehicleDetails INNER JOIN Makes 
          ON Makes.MakeID = VehicleDetails.MakeID
where (VehicleDetails.Year between 1950 and 2000)
group by Make
)R1
where R1.NumberOfVehicles >12000
order by NumberOfVehicles desc
------------------------------------------------

select *, cast(NbrOfVehicles as float)/cast(TotalNbrOfVehicles as float) as Perc from
(
select    Makes.Make, count(*) as NbrOfVehicles, (select count(*) from VehicleDetails)as TotalNbrOfVehicles
from      VehicleDetails inner join Makes
          on Makes.MakeID = VehicleDetails.MakeID
where (VehicleDetails.year between 1950 and 2000)
group by Makes.Make
)R1
order by NbrOfVehicles desc

--------------------------------------------------

SELECT        Makes.Make, FuelTypes.FuelTypeName, count(*) as NbrOfVehicles
FROM           VehicleDetails INNER JOIN Makes
                          ON Makes.MakeID = VehicleDetails.MakeID INNER JOIN
                         FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
where VehicleDetails.Year between 1950 and 2000
group by Makes.Make, FuelTypes.FuelTypeName
order by Makes.Make

------------------------------------------------------

SELECT        Makes.Make, FuelTypes.FuelTypeName, COUNT(*) AS NbrOfVehicles
FROM            Makes INNER JOIN
                         VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID INNER JOIN
                         FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
						 where VehicleDetails.Year between 1950 and 2000
Group by Makes.Make, FuelTypes.FuelTypeName
order by Makes.Make

-----------------------------------------------------------------------------

SELECT         VehicleDetails.*, FuelTypes.FuelTypeName
FROM            FuelTypes INNER JOIN
                         VehicleDetails ON FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID
						 where (FuelTypes.FuelTypeName = N'GAS')
-----------------------------------------------------------------------------
select count(*) as TotalMakesRunOnGas from
(SELECT     distinct Makes.Make, FuelTypes.FuelTypeName
 FROM       FuelTypes INNER JOIN VehicleDetails 
 ON         FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID INNER JOIN Makes
 on         Makes.MakeID = VehicleDetails.MakeID
 where (FuelTypes.FuelTypeName = N'GAS')
)R1
--------------------------------------------------------------------------

SELECT      top 3  Makes.Make, count(*) as NumberOfVehicles
FROM         Makes INNER JOIN VehicleDetails 
ON          Makes.MakeID = VehicleDetails.MakeID
group by Makes.Make
order by count(*) desc
-------------------------------------------------------------------------
SELECT     Makes.Make, count(*) as NumberOfVehicles
FROM       Makes INNER JOIN VehicleDetails 
ON         Makes.MakeID = VehicleDetails.MakeID
group by Makes.Make
having count(*) >20000
order by count(*) desc
--------------------------
SELECT          Make
FROM            Makes 
where Makes.Make like '%W' 
--------------------------
select count(*) as MakesWithFWD from 
(SELECT  distinct  Makes.Make, DriveTypes.DriveTypeName
  FROM    DriveTypes INNER JOIN VehicleDetails 
  ON      DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID INNER JOIN Makes 
  on     Makes.MakeID = VehicleDetails.MakeID
  where DriveTypes.DriveTypeName ='FWD'
 )R1
-----------------------------
SELECT  distinct  Makes.Make, DriveTypes.DriveTypeName, count(*) as TotalVehicles
FROM    DriveTypes INNER JOIN VehicleDetails 
ON     DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID INNER JOIN Makes
on     Makes.MakeID = VehicleDetails.MakeID
group by Makes.Make, DriveTypes.DriveTypeName
Having count(*) > 10000
order by Makes.Make, TotalVehicles
--------------------------------
select * from VehicleDetails
where NumDoors is null
--------------------------------
select count(*) as total from VehicleDetails
where NumDoors is null
----------------------------
select PercOfNoSpecifiedDoors = cast ((select count(*) as TotalDoorsNonSpecified from VehicleDetails where NumDoors is null) as float) /
       cast ((select count(*) as TotalDoors from VehicleDetails) as float)
--------------------------------
SELECT  distinct  VehicleDetails.MakeID, Makes.Make, SubModels.SubModelName
FROM    VehicleDetails INNER JOIN SubModels 
 ON     VehicleDetails.SubModelID = SubModels.SubModelID INNER JOIN Makes 
 ON     Makes.MakeID = VehicleDetails.MakeID
where SubModelName = 'Elite'
---------------------------------
select * from VehicleDetails
where Engine_Liter_Display >3 and NumDoors =2
---------------------------------

SELECT  distinct Makes.Make, VehicleDetails.*
FROM    Makes INNER JOIN VehicleDetails 
ON    Makes.MakeID = VehicleDetails.MakeID
where (Engine like '%OHV%') and (VehicleDetails.Engine_Cylinders = 4)
------------------------------------

SELECT Bodies.BodyName,VehicleDetails.*
FROM   VehicleDetails INNER JOIN Bodies
 ON    Bodies.BodyID = VehicleDetails.BodyID
WHERE  (Bodies.BodyName = 'Sport Utility') AND (VehicleDetails.Year > 2020)

------------------------------------

SELECT  Bodies.BodyName,VehicleDetails.*
FROM    VehicleDetails INNER JOIN Bodies
  ON    Bodies.BodyID = VehicleDetails.BodyID
WHERE   Bodies.BodyName in ('Coupe','Hatchback','Sedan') and Year in (2008,2020,2021)

----------------------------------------
select Found = 1 
where exists 
(
select top 1 *from VehicleDetails where year = 1950
)

--------------------------------------------
select distinct NumDoors from VehicleDetails
order by NumDoors desc

update VehicleDetails
set NumDoors = 'NULL' where NumDoors='NULL' or NumDoors =' NULL'

select Vehicle_Display_Name, NumDoors,
case
	when NumDoors = 0 then 'Zero Doors'
	when NumDoors =1 then 'One Doors' 
	when NumDoors =2 then 'Two Doors' 
	when NumDoors =3 then 'Three Doors' 
	when NumDoors =4 then 'Four Doors' 
	when NumDoors =5 then 'Five Doors' 
	when NumDoors =6 then 'Six Doors' 
	when NumDoors =8 then 'Eight Doors' 
	when NumDoors is NULL then 'Not Set' 
	else 'UnKnown'
end as DoorsDiscription
from VehicleDetails

--------------------------------
select *from
(select Vehicle_Display_Name, year, Age = Year(GetDate())-VehicleDetails.year from VehicleDetails)R1
where Age between 15 and 25
--------------------------------
select Min(Engine_CC) as MinimumEngineCC,Max(Engine_CC) as MaximumEngineCC,Avg(Engine_CC) as AverageEngineCC from VehicleDetails
--------------------------------

select * from  VehicleDetails
where Engine_CC = (select Min(Engine_CC) as MinEngineCC from VehicleDetails)

select * from  VehicleDetails
where Engine_CC = (select Max(Engine_CC) as MaxEngineCC from VehicleDetails)

select * from  VehicleDetails
where Engine_CC < (select Avg(Engine_CC) as AverageEngineCC from VehicleDetails)

select count(*) as NumberOfVehiclesAboveAverageEngineCC from VehicleDetails
where Engine_CC > (select Avg(Engine_CC) as AverageEngineCC from VehicleDetails)

select Count(*) as NumberOfVehiclesAboveAverageEngineCC from
(
 
	Select ID,VehicleDetails.Vehicle_Display_Name from VehicleDetails
	where Engine_CC > ( select  Avg(Engine_CC) as MinEngineCC  from VehicleDetails )

) R1

---------------------------------------------------------

select distinct Engine_CC from VehicleDetails
order by Engine_CC desc

----------------------------------------------------------

select distinct top 3 Engine_CC from VehicleDetails
order by Engine_CC desc

----------------------------------------------------------
select * from VehicleDetails
where Engine_CC in (select distinct top 3 Engine_CC from VehicleDetails
order by Engine_CC desc)
----------------------------------------------------------
SELECT  distinct   Makes.Make, VehicleDetails.*
FROM    Makes INNER JOIN VehicleDetails 
ON Makes.MakeID = VehicleDetails.MakeID
where Engine_CC in (select distinct top 3 Engine_CC from VehicleDetails order by Engine_CC desc)
order by Make
------------------------------------------------------------
select Engine_CC,
case
       when Engine_CC between 0 and 1000 then 100
	   when Engine_CC between 1001 and 2000 then  200
	   when Engine_CC between 2001 and 4000 then  300
	   when Engine_CC between 4001 and 6000 then  400
	   when Engine_CC between 6001 and 8000 then  500
	   when Engine_CC > 8000 then 600
	   else  0
end as Tax
from
(select distinct Engine_CC from VehicleDetails)R1
order by Tax desc
---------------------------------------------------------------

SELECT  Makes.Make, Sum(VehicleDetails.NumDoors) AS TotalNumberOfDoors
FROM    VehicleDetails INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
Group By Make
Order By TotalNumberOfDoors desc
-------------------------------------------------------------------
SELECT   Makes.Make, count(*) as NumberOfModels
FROM     MakeModels INNER JOIN Makes 
ON MakeModels.MakeID = Makes.MakeID
GROUP BY Makes.Make
Order By NumberOfModels Desc
-------------------------------------------------------------------
select top 3 Makes.Make, count(*) as NumberOfModels
FROM   MakeModels INNER JOIN Makes ON MakeModels.MakeID = Makes.MakeID
GROUP BY Makes.Make
Order By NumberOfModels Desc
-------------------------------------------------------------------
select Max(NumberOfModels) as MaxNumberOfModels
from
(
SELECT    Makes.Make, COUNT(*) AS NumberOfModels
FROM      Makes INNER JOIN
		  MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make		
) R1
--------------------------------------------------------------------

SELECT    Makes.Make, COUNT(*) AS NumberOfModels
FROM      Makes INNER JOIN
		  MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
order by NumberOfModels desc
--------------------------------------------------------------------
SELECT   Makes.Make, COUNT(*) AS NumberOfModels
FROM     Makes INNER JOIN MakeModels 
ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
having COUNT(*) = 
(
select Max(NumberOfModels) as MaxNumberOfModels
from
(
SELECT      MakeID, COUNT(*) AS NumberOfModels
FROM       MakeModels
GROUP BY MakeID		
--order by NumberOfModels desc
) R1
)
--------------------------------------------------------

SELECT  Makes.Make, count(*) as numberofModels
FROM    MakeModels INNER JOIN Makes 
ON MakeModels.MakeID = Makes.MakeID
group by Makes.Make
Having count(*) =
(
select Max(NumberOfModels) as MaxNumberOfModels
from
(
SELECT    Makes.Make, COUNT(*) AS NumberOfModels
FROM      Makes INNER JOIN
		  MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make		
) R1)
----------------------------------------------------------

SELECT    Makes.Make, count(*) as TotalModels
FROM      MakeModels INNER JOIN Makes 
ON MakeModels.MakeID = Makes.MakeID
group by Makes.Make
Having count(*) =
(
select max(TotalModels) from
(
select       Makes.Make, count(*) as TotalModels
FROM         MakeModels INNER JOIN
             Makes ON MakeModels.MakeID = Makes.MakeID
group by Makes.Make)R1
)
--------------------------------------------------------------------
SELECT  Makes.Make, count(*) as TotalModels
FROM    MakeModels INNER JOIN Makes 
ON MakeModels.MakeID = Makes.MakeID
group by Makes.Make
Having count(*) =
(
select min(TotalModels) from
(
select       Makes.Make, count(*) as TotalModels
FROM         MakeModels INNER JOIN
             Makes ON MakeModels.MakeID = Makes.MakeID
group by Makes.Make)R1
)

---------------------------------------------------------
SELECT * FROM FuelTypes 
order by NewID()

-----------------------------------------------------------
