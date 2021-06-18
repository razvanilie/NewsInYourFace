# NewsInYourFace
A news scrapper made for MDS using UiPath that shows recent news from websites and can possibly send them via e-mail.
# Video Presentation
[Link to video](https://youtu.be/SasLtBCEy8A)
# Build Tool
Our project is developed using UiPath(UiPath + ReFramework to be more precise) that is in itself a building tool. When we want to run the robot we simply press the Run Button and if we want to give the project to someone else just zip the entire file and send it(nothing too hard).                            
![uipath](https://i.imgur.com/2zV50f1.png)

Also we have a bonus C# App which purpose is to be a 'man-in-the-middle' app that helps the user to start the robot giving him ways to configure the robot in many ways(choose which sites to be scrapped, choose how old the news have to be etc.) The app has been made using Microsoft Visual Studio so this is our second Building Tool.


![c#app](https://i.imgur.com/QIQxkcK.png)


# UML Diagram 


![diagramdarnupreadiagram](https://i.imgur.com/Y3kYcAu.png)


# User Stories
[Feedback and issues resolved](https://github.com/razvanilie/NewsInYourFace/issues) : We released a beta version 1.0 to a test group and we colected feedback and we solved and adressed every complain and issue.

1. [Close apps used by the robot and open them again](https://github.com/razvanilie/NewsInYourFace/issues/15)
2. [Create a C# App for better user experience](https://github.com/razvanilie/NewsInYourFace/issues/14)
3. [Write user options from C# App into a csv](https://github.com/razvanilie/NewsInYourFace/issues/13)
4. [Load the csv from the UiPath App](https://github.com/razvanilie/NewsInYourFace/issues/12)
5. [Use a modified version of UiPath ReFramework that extract the queue from an excel](https://github.com/razvanilie/NewsInYourFace/issues/11)
6. [Navigate to techcrunch.com and extract data](https://github.com/razvanilie/NewsInYourFace/issues/10)
7. [Navigate to uipath.com/blog and extract data](https://github.com/razvanilie/NewsInYourFace/issues/9)
8. [Navigate to cultivatedculture.com and extract data](https://github.com/razvanilie/NewsInYourFace/issues/8)
9. [At least two ways to extract data from websites](https://github.com/razvanilie/NewsInYourFace/issues/7)
10. [Extract news that are not older than a 'maximumAge' given in the C# App](https://github.com/razvanilie/NewsInYourFace/issues/6)
11. [Open the txt at the end with all the news](https://github.com/razvanilie/NewsInYourFace/issues/5)
12. [In case of an error, don't stop the robot, just go to the next website](https://github.com/razvanilie/NewsInYourFace/issues/4)

# BUGS

WE ALSO SOLVED BUGS :heartpulse: :heartpulse: :heartpulse:

1. [Some dates aren't formatted properly](https://github.com/razvanilie/NewsInYourFace/issues/3)
2. [C# data validation](https://github.com/razvanilie/NewsInYourFace/issues/2)
3. [techcrunch.com has a "Accept Cookies" window that blocks the robot](https://github.com/razvanilie/NewsInYourFace/issues/1)


# Details
Aplication created using UiPath 2021.4.4, 
Programming language: VB.NET / C#
CommandPrompt.Activities: [1.0.8]
UiPath.Excel.Activities: [2.10.4]
UiPath.System.Activities: [21.4.1]
UiPath.UIAutomation.Activities: [21.4.4]

