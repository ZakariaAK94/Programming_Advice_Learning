use DVLD
select *from People
SELECT ApplicationID FROM Applications 
                              where ApplicantPersonID = 1025 
                                and ApplicationTypeID =  1
                                and ApplicationStatus =1

SELECT ActiveApplicationID=Applications.ApplicationID  
From Applications INNER JOIN LocalDrivingLicenseApplications 
ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
WHERE ApplicantPersonID = 1025 
 and ApplicationTypeID=1 
 and LocalDrivingLicenseApplications.LicenseClassID = 2
 and ApplicationStatus=1

SELECT  Applications.ApplicationID
FROM    Applications INNER JOIN LocalDrivingLicenseApplications
ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
where ApplicantPersonID = 1025
and ApplicationTypeID =1
and LocalDrivingLicenseApplications.LicenseClassID =2
and ApplicationStatus =1

SELECT ActiveApplicationID = Applications.ApplicationID 
FROM Applications INNER JOIN LocalDrivingLicenseApplications
on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
where ApplicantPersonID = @PersonID 
and ApplicationTypeID = @ApplicationTypeID 
and ApplicationStatus =1
and LocalDrivingLicenseApplications.LicenseClassID = LicenseClass.LicenseClassID



 select *from Applications
 select *from LocalDrivingLicenseApplications





select *from Applications

with c as (select left(DateofBirth,11) as akil from People),  
SELECT replace(cast(akil as date), '-',':')
from c