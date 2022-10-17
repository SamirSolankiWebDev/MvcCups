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