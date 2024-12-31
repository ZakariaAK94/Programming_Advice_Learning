select *from LocalDrivingLicenseApplications where ApplicationID = 72
select *from Applications where ApplicationID = 72
select *from TestAppointments where LocalDrivingLicenseApplicationID = 35
select *from Tests where TestAppointmentID in (86,87,88,89,90,91)
select *from TestAppointments_View where LocalDrivingLicenseApplicationID = 35
select *from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = 35
