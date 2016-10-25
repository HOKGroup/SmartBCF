# SmartBCF


The SmartBCF is designed to convert [BCF](https://github.com/BuildingSMART/BCF-XML) to file-based database [SQLite](https://www.sqlite.org/) to facilitate issue tracking in more collaborative workflow. The SmartBCF package consists of two components, SmartBCF Manager for desktop app and SmartBCF Add-In for Revit.
![](Diagram.png)

#Data Transmission
The SmartBCF itself doesn't support to generate BCF files yet. The feature could be implemented in the next version. 
For general usages, preparing BCF files from other Rule Checking software like [Solibri Model Checker](https://www.solibri.com/products/solibri-model-checker/) or [Autodesk Navisworks](http://www.autodesk.com/products/navisworks/overview) or Issue Tracking platforms like [CASE Issue Tracker](https://github.com/teocomi/issue-tracker), [BCFier](https://github.com/teocomi/BCFier) or [BIM Collab](http://www.bimcollab.com/) would be recommended. Once you have BCF files, you can convert BCF to SQLite, merge multiple BCF into single SQLite, and convert SQLite back to BCF.



![](DataTransfer.png)
#Documentation
For more information about the SmartBCF, documentation links are below.
* [SmartBCF Manager](https://hokgroup.gitbooks.io/smartbcf/content/smartbcf_manager.html)
* [SmartBCF Add-In for Revit](https://hokgroup.gitbooks.io/smartbcf/content/smartbcf_add-in.html)

#Installation

### Requirements
.NET Framework 4.6 is required. [Download](https://www.microsoft.com/net/download)

SmartBCF Add-In supports for 
* Autodesk Revit 2014
* Autodesk Revit 2015
* Autodesk Revit 2016
* Autodesk Revit 2017


### Dependencies

* System.Data.SQLite (v.1.0.99.0 or later)
* Expression.Blend.Sdk (v.1.0.2 or later)

### Debugging
Select a configuration that matches the version number of Revit you may need e.g. "2016" or "2017" and debug the solution. The solution is initially created by Visual Studio 2012.

### Revit Add-In Files
After debuging the Visual Studio solution, go to HOK.SmartBCF.AddIn/bin/201x and make a copy of the following files. 

* Resources directory including files
* x64 directory including files
* x86 directory including files
* EntityFramework.dll
* EntityFramework.SqlServer.dll
* HOK.SmartBCF.addin
* HOK.SmartBCF.AddIn.dll
* HOK.SmartBCF.dll
* System.Data.SQLite.dll
* System.Data.SQLite.EF6.dll
* System.Data.SQLite.Linq.dll
* System.Windows.Interactivity.dll


For Windows 7/8/8.1, paste those files in C:\ProgramData\Autodesk\Revit\Addins\201x\ 
(The ProgramData folder is hidden by default. The path may vary depending on the flavor of Autodesk Revit you are using.)




