#  Sub Zero

## Contents

* **Sub Zero**
  - An application used for First Tech Challenge Relic Recovery scouting by #10547 The Mortal Combots
  
* **Overview**
  - Created for FTC team #10547 The Mortal Combots
  - Creates text documents that lists team scores and various things through matches
  - Adds information to a database for easy storage
  - Ability to create Excel Spread Sheets
  
* **Example Usage:** Our FTC team at West Virginia used the app to help our alliance selections

* **Getting Started**
  - **Installation**
    - **To add teams!**
      - 1. Go to Data/Teams/TeamDirectory.txt
      - 2. Follow Previous formatting to edit
      - 3. Example text : 10547,5466,10030,
      - 4. To edit: add needed teams to end, and delete unneeded teams
      - 5. Example edit: 10547,10030,11742,
    - Install "scoutingapp" to _root C Drive_ 
      - This contains the database and MUST be installed here to work
  - **Prerequisites**
    - Microsoft SQL server 2012 express 64-bit
    - Microsoft SQL Management 64-bit
    - Microsoft SQL LocalDB
    - Download Link https://www.microsoft.com/en-us/download/details.aspx?id=29062
    
* **Design Goals**
  - This program is programmed around features, at the sake of resources.
  - It can be ran on any Windows computer with the correct database version, and prerequisites
  
* **Detailed Usage**
  - Interface and better explanations down below
  - **Examples**
    - 1. Start Application
    - 2. Go to Text Export
    - 3. Fill out information as needed
    - 4. Repeat as many times as needed
    - 5. Exit text Exporter
    - 6. Open rankings from main menu
    - 7. Sort teams and select alliance partners
    
* **Developer Info**
  - Known Issues
    - No way to delete entries in database
    - ~~Team list isn't sorted by value~~
  - TODO
    - add notes to database?

### Sorted by the forms themselves

* **Main Menu**
  - Main Menu for application
    - navigate whole program
    
![Main Menu](/Images/mainMenu.PNG?raw=true "mainMenu")

* **Excel Exporter**
  - Only works with Microsoft Office installed
    - Disabled for our scouting laptop
  - Exports data to an Excel SpreadSheet
    - Custom formatted for our team

* **Text Exporter**
  - Grabs all team numbers from teamDirectory.txt created in the data folder
    - allows for a long list of team numbers
  - Exports data to a text document
    - Custom format for our team
    - One document per team, separated by a spacer and match number
![Text Pad](/Images/textPad.PNG?raw=true "textPad")
  - When the export button is clicked it also adds the needed information to a text document
    - Puts Match Number, Team Number, Auto Score, TeleOp Score, End Score, and Total Score into the database
![Text Exporter](/Images/textExport.PNG?raw=true "textExport")
    
* **Rankings Form**
  - Shows a dataGridView for the database
    - shows the information input to it
    - helps our team decide who we would pick if we had to for final alliances
![Rankings](/Images/Rankings.PNG?raw=true "Rankings")

## Changelog
* December 6, 2016 (Version 2.1a)
  - Added Scrollbar hotfix
    - Thanks to #11472 for bringing up this issue!
  - Fixed team import issue
  - Fixed the program not actually making the "Match" folder
* December 5, 2017 (Version 2.1)
  - Added comments for teams and people
    - Also major update to readme
  - Fixed a major bug where the variables were getting over filled
* December 1, 2017 (Version 2.0b)
  - Added an older database version for our scouting laptop
  - Added new .EXE with SQL references to try it for computers without SQl installed
    - Didn't work, SQL must be installed on target computer
* November 30, 2017 (Version 2.0a)
  - Tried fixing databases for other computers.
    - Didn't work. Added a version for the laptop for workaround
* November 29, 2017 (Version 2.0)
  - Added database version.
    - Puts data into a table and displays it on a form
  - Various bug fixes
* November 27, 2017 (Version 1.5)
  - Experimenting with databases
* November 20, 2017 (Version 1.1)
  - Added a new school version for school computers
    - Has an older version of .NET framework, and older Microsoft Office versions
* November 18, 2017 (Version 1.0)
  - Reworked text exporter to print per team, not per match
    - This will lead to being able to select alliance partners 
    - This is much better than the other way.
  - Big fixes
* November 14, 2017 (Version 0.5c)
  - Rewrote globalVariables so it is more appealing to the eyes.
* November 11, 2017 (Version 0.5b)
  - Remade UI for school computers. Switched from 1920 x 1080 to 1280 x 720.
* November 8, 2017 (Version 0.5a Hotfix)
  - added MIT license
* November 6, 2017 (Version 0.5a)
  - Added first school version with older packages
* November 4, 2017 (Version 0.5)
  - Reconfigured tab order
  - Update readme
  - Added Text exporter for computers without Excel
    - Added internal version number to program
    - Added notes section for during match notes
    - Added new saving method
    - Added reference picture for ciphers
    - Finished first GUI
    - Finished main math for application
* November 3, 2017 (Version 0.1)
  - Initial Commit
  - Added personalized .ico file
  - Added new saving method.
    - More efficient
  - Update to make red team 1 fill in the spreadsheet
## Contact
For questions, comments, concerns, or suggestions please email dbeehler00@gmail.com
