declare @currentday datetime
set @currentday = DATEADD(day,DateDiff(day,0,GETDATE()),0);
with Timer as 
(
		select DT =	@currentday
		UNION ALL
		select dateADD(n,15,DT)
		from Timer
		where DateAdd(n,15,DT) <= cast(@currentday+2 as datetime)
)
select *from Timer option (MAXRECURSION 0)

with Nbrs as 
(
		select DT = 1
		UNION ALL
		select DT+1
		from Nbrs
		where DT <= 20
)
select *from Nbrs 
