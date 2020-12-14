# Scan Logger (EcomStatSender)
![It's a front pic!](https://github.com/alehee/EcomStatSender/blob/master/github_resources/github_front.png?raw=true)

## Description
Scan Logger (originally named *EcomStatSender*) it's a simple program I made for my workplace purposes, unfortunately I don't remember every aspect of the program. It's like keylogger but for RFID scanners (Windows sees scanners as keyboards so it's basically a keylogger...), while timer is running and if specific string was inputed the system will count the amount of scans and then final results will be send to MySQL server.

Result should be incremented when program will register few number input (0..9) in short amount of time (something like half a second)

**Polish version only!**, sorry :/

## Used technology
Technology I used for this project:
* C#
* C# WinForms
* MySQL with C# connector
* [Dylan's script](https://www.dylansweb.com/2014/10/low-level-global-keyboard-hook-sink-in-c-net/), it was very helpful, big shoutout!

## How to use
First of all - if you want to store the results you need **MySQL server**. I use web hosted MySQL server, but you can test it on XAMPP as well.

You can test it offline - the data will not be sended to the server.

When you have your environment (or not) here's what you need to do next:

  1. Download latest master branch files and unzip it
  2. Unfortunately I've lost the original MySQL table, you can create your own by analyzing the code. We need two tables - one for user accounts and second for the results, but for test you don't need any -> I've created login loophole (login: "git", password: "hub")
  
  Now we got two paths - SQL-one and non-SQL-one.
  
  #### non-SQL-one:
  
  3. Go to *\bin\Debug* and run *EcomStatSender.exe*
  4. Log in and test yourself
  
  #### SQL-one:
  
  3. Open project file in **Visual Studio 2019** and set present data in *Form1.cs*
  ```c#
  static string DATABASE_CONNECTION = "datasource=urlexample.com;port=3306;username=user;password=pass;database=database_name"; // Replace 'urlexample.com', 'user', 'pass', 'database' to your server connection options
  ```
  4. Create tables based on the sql queries in the code (all of the queries are in *Form1.cs* file), create some user and delete the loophole in *Form1.cs*
  ```c#
  if (possibleLogin == "git" && possiblePassword == "hub")
  {
    return true;
  }
  ```
  5. Compile code and go to *\bin\Debug* and run *EcomStatSender.exe*
  6. Log in and test yourself
  
And that's it! I'm really sorry for lack of the sql table examples but I hope the code will be helpful!
  
## Thank you!
Thank you for peeking at my project!

If you're interested check out my other stuff [here](https://github.com/alehee)
