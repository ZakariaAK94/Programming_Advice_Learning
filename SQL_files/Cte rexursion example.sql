with Descendant as
(
	select Parent +'->'+Child  as lineage,Child as c,year(BirthDay) as BirthDay, 0 as parentAge from ParentOf  where Parent='Alice'
	union all
	select Parent +'->'+Child as lineage,Child as c,year(p.BirthDay) as BirthDay, year(p.BirthDay)-(D.BirthDay) as parentAge 
	from Parentof p inner join Descendant D
	on p.Parent= D.c
)
select lineage,BirthDay,parentAge from Descendant









WITH Ancestor AS 
(
SELECT parent AS p FROM ParentOf WHERE child = 'Frank'
UNION ALL
SELECT parent FROM Ancestor, ParentOf
WHERE Ancestor.p = ParentOf.child
)
SELECT * FROM ParentOf
	
with ancestor as
(
	select parent as p from ParentOf where child='Frank'
	union all
	select p.Parent
	from ParentOf p, ancestor a
	where p.Child=a.p
)select *from ancestor