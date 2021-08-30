# SimpleBank Transaction App

A Simple Bank Transaction App using **C#.Net** Form Based Desktop Application with MS-SQL Server DataBase
---
### Requirements
- **Visual Studio IDE**
- **C#.NET**
- **MS-SQL Server DB**
---
### How to Build Simple Bank Transaction App?
---
***step 1 :***  Setup Visual Studio IDE with C#.NET Environment
---
***step 2 :***  Open Visual Studio & Create a New Form Based Application
---
![](Screen_Shots/NewApp.png)
---
***step 3 :***  Design Application Form Window (User Interface)
---
![](Screen_Shots/Design_Window.png)
---
***step 4 :***  Create a Database [Table] in inbuilt MS-SQl Server Database (LocalBank)
            - Insert Data to all Columns           
---
+ Initial Database 
![](Screen_Shots/Initial_DB.png)
---
***step 5 :*** Copy the Connection String to Your Code [Form1.cs]
---
```C#
        #Your Connection String Will be Different
        static string con_str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Sanjay-PC\\source\\repos\\Sanjay_C#_Lab\\Bank Transaction\\Bank Transaction\\LocalBankDB.mdf;Integrated Security=True";
        SqlConnection conn=new SqlConnection(con_str);
        SqlCommand cmd;
```
---
***step 6:*** 
---





