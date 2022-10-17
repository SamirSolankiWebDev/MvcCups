﻿Program name:MvcCups
Program purpose: To review the components of an ASP.NET MVC application
Program suthor: Samir Solanki
Date Created: 2022-09-14 [ISO date format]

1050:FirstStep: Today I Created a new application of ASP.net MVC in .NET core 3.1 framework authentication - Individual Account.
Selected Razor runtime.. will this aactually work ! let us test this and see... [it didnt worked]

1100 - Let execute the application
1105 - Oh it didnt worked reason is This site can't be reached https://localhost:44370/
 Let us try to fix and see if it work
 - Let us open launchSetting.json../.. line no 7 ans comment 
 // "sslPort":44370 //

 After done the comment on // "sslPort":44389 // this Line the code started running. I got the Welcome Screen on browser This link is 
 http://localhost:46966/

 All done 
 
  1121: Kept the application running ... testing Razor compile...
 change some content..... index.cshtml - from "Welcome" to "Hello World"........
 VS19 didnt seem to push ... but refereshed the browser and new context displayed

 ...../////////************ Part 2 .. Doing new chnages as per the part 2 documents.. ********///////////

 - Adding new controller 
 - Right click on "Controller" folder and add the new controller Given name "HelloWorldController.cs"
 - Now you can find the new controller "HelloWorldController.cs" inside "Controllers" Folder

 - In HelloWorldController I have added the new code ad per the documents..
 - Inside public class... added public string Index and return .."This is my default action..."

 - Added new Method Welcome... 
 and added return "This is the Welcome action method..."

 - After running the code and calling the link http://localhost:34699/HelloWorld
  It didnt worked ...
  - Because i have not added the "using System.Text.Encodings.Web;" include in my "HelloWorldController.cs"....
  - After adding this code It worked and gave me output... "This is my default action..."

  - .. Added new code in HelloWorldController.cs 
    .. added new 2 parameters in the line of code name and numTimes (Count) .. this code shows the number of count of browser refresh.


    - I replaced the parameter  from numTimes to ID
 public string Welcome(string name, int ID = 1)...
 and run the Code..
 Added this paramter in link .. http://localhost:46966/HelloWorld/Welcome?name=Samir&ID=14
 and got the output as ..Hello Samir, ID: 14..


 .......//////************. Part 3... To Add the View to ASP>NET MVC app... *********/////////////

 - Create a new Folder inside Views Folder.. and give the name as "HelloWorld"..
 - Cretae a new File insde.. View/HelloWorld Folder and select as RazorView Empty and give the name as "Index.cshtml" 

 - Before creating the View Replace the Code in HelloWorldController.cs file 

 public IActionResult Index()
{
    return View();
}

-Add the New File Inside View Folder... 