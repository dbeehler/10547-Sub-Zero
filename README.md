#  Sub Zero

## Contents

* **Sub Zero**
  - An application used for First Tech Challenge scouting by 10547 The Mortal Combots
  
* **Overview**
  - Created for FTC team #10547 The Mortal Combots
  - Creates text documents that lists team scores and various things through matches
  - Adds information to a database for easy storage
  - Ability to create Excel Spread Sheets
  
* **Example Usage:** Our FTC team at West Virginia used the app to help our alliance selections

* **Getting Started**
  - **Installation**
    - Install "scoutingapp" to _root C Drive_ 
      - This contains the database and MUST be installed here to work
  - **Prerequisites**
    - Microsoft SQL server 2012 express 64-bit
    - Microsoft SQL Management 64-bit
    - Microsoft SQL LocalDB
    - Download Link https://www.microsoft.com/en-us/download/details.aspx?id=29062
    
* **Design Goals**
  - This program is programmed around features, at the stake of resources.
  - It can be ran on any computer with the correct database version, and prerequisites
  
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
    - Team list isn't sorted by value

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
    - One document per team, seperated by a spacer and match number
![Text Pad](/Images/textPad.PNG?raw=true "textPad")
  - When the export button is clicked it also adds the needed information to a text document
    - Puts Match Number, Team Number, Auto Score, TeleOp Score, End Score, and Total Score into the database
![Text Exporter](/Images/textExport.PNG?raw=true "textExport")
    
* **Rankings Form**
  - Shows a dataGridView for the database
    - shows the information input to it
    - helps our team decide who we would pick if we had to for final alliances
  - 
![Rankings](/Images/Rankings.PNG?raw=true "Rankings")

* **Team Import**
  - Ability to import team Numbers
    - you type the team numbers into the box and it exports to the text document
    - can also edit text pad manually if wanted
      - must follow formatting
  - Button for viewing all teams in the file
  
