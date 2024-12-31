WITH Numbers AS 
(
   SELECT 1 AS Number  
   UNION ALL
   SELECT Number + 1 FROM Numbers WHERE Number < 5
)
SELECT * FROM Numbers;

WITH cte_numbers(n, weekday) AS
(
    SELECT 0, DATENAME(DW, 0)
    UNION ALL
    SELECT n + 1, DATENAME(DW, n + 1) FROM cte_numbers WHERE n < 6
)
SELECT weekday FROM cte_numbers;