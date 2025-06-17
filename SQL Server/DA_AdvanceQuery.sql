--Advance Queries: Date time function, Window function, Sub query, Case statement, CTE, query optimisation

--select * from Employee_N 
--select * from Employee
--SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'Employee_N'

--------------------------------------------Date time function----------------------------------------------
select EmpID,
CURRENT_TIMESTAMP AS CURRENT_DATE_AND_TIME, 
DATENAME(YEAR, '2025/06/03') AS DATE_IN_YEARS, 
DATEPART(YEAR, '2025/06/03') AS DATE_IN_YEAR,
DATETIMEFROMPARTS (2024, 02, 29, 19, 11, 55, 343) AS DATE_TIME,
FORMAT(CAST('2025-06-03' AS DATE), 'dddd') as day,
EOMONTH('2025-06-03') AS END_OF_MONTH
 from Employee

 -------------------------------------------Window function--------------------------------------------------
 SELECT Empid,Salary, 
 AVG(salary) OVER( PARTITION BY EmpId) AS Avg_Salary, 
 Sum(salary) OVER( PARTITION BY EmpId) as sum_salary, 
 Max(salary) OVER( PARTITION BY EmpId) as max_salary, 
 Min(salary) OVER( PARTITION BY EmpId) as min_salary,
 count(salary) OVER( PARTITION BY EmpId) as count_salary
 FROM employee

 SELECT EmpId,empname, Salary,
       RANK() OVER(PARTITION BY empname ORDER BY Salary DESC) AS emp_rank
FROM employee order by empid;

 SELECT EmpId,empname, Salary,
       Dense_Rank() OVER(PARTITION BY empname ORDER BY Salary DESC) AS emp_rank
FROM employee order by empid;

SELECT EmpId,empname, Salary,
       ROW_NUMBER() OVER(PARTITION BY empname ORDER BY Salary DESC) AS emp_row_no
FROM employee;

--------------------------------------------Sub query------------------------------------
SELECT EmpId,empname, Salary 
FROM employee 
WHERE EmpId IN (
SELECT EmpId FROM employee WHERE sex='F'
);

-----------------------------------------Case Statement------------------------------------
SELECT EmpId,empname, Salary, 
CASE
    WHEN Salary > 10000 THEN 'The Salary is greater than 10000'
    WHEN Salary >= 5000 THEN 'The Salary is greater than 5000 and less than 10000'
    ELSE 'The Salary is less than 5000'
END AS SalaryText
FROM Employee;

-----------------------------------------CTE------------------------------------
WITH RankedEmployees AS (
    SELECT EmpId,empname, Salary,
           RANK() OVER(PARTITION BY empname ORDER BY Salary DESC) AS emp_rank
    FROM employee
)
SELECT EmpId,empname, Salary
FROM RankedEmployees
WHERE emp_rank <= 3;

-----------------------------------------Query Optization------------------------------------