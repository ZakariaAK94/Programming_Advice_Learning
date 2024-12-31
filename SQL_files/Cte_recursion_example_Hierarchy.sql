select *from Employees7
with EmployeeTreeHierarchy as
(
	select EmployeeID,ManagerID,Name,cast(Name as varchar(max)) as Hierarchy,0 as level
	from Employees7 
	where ManagerID is null
	union all
	select e.EmployeeID,e.ManagerID,e.Name,cast(ETH.Hierarchy+'->'+e.Name as varchar(max)) as Hierarchy,ETH.level+1 as level
	from Employees7 e inner join EmployeeTreeHierarchy ETH
	on e.ManagerID = ETH.EmployeeID
)
select *from EmployeeTreeHierarchy
order by Hierarchy

--with R as (<base_query>    base memeber(anchor memebr)
	    -- 	union all 
		 -- <recursive_query involving R>)    recursive member references R		





)






