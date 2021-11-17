# Budget Tracker Application V1.0

This a web application to track the budget, developed with technologies Angular, .Net Core Web API, Entity Framework Core, SQL Server Database. 
While this is still a very primitive and simplified version of the application right now. The views are basically all from the admin's end, and the main features are enabling the user (admin) to conduct CRUD operations on the tables in the database. More expected features to be developed are listed in the end of this doc.


## Database
The BudgetTracker database contains 3 tables: User, Income and Expenditure. The ER diagram is displayed as follows. The database is generated through the migration feature in Entity Framework Core. The data can be found in the BudgetTracker_insertdata.sql file.

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/ER.jpg)

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/DB.jpg)

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/usertable.jpg)


## API
Web APIs were created with ASP.NET Core as follows. They were repectively under 3 controllers. 

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/API1.png)
![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/API2.png)


## SPA

Following displays the screenshots of some of the UIs:

* HOME Page

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/HomePage.jpg)

* User Details
 
![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/UserDetails.jpg)

* Add User

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/AddUser.jpg)


* User Income Details

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/UserIncomeDetails.jpg)


* User Expenditure Details

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/UserExpenditureDetails.jpg)


* All Incomes

![alt text](https://github.com/yiming-2021/YimingGu.BudgetTracker/blob/main/Screenshots/allIncomes.jpg)



## Potential Improvements in Future Versions
* Users (other than admin) should be able to log in to view the their budget data and edit their own profiles after authenticated. 
* Dashboards should contain pie charts and bar charts to visualize the data, like the relationships between incomes, expenditures and time. 
* More features regarding budget management.
