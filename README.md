# Mortal Combots #10547 Scouting App
## Scouting app made in Visual Basic for the Mortal Combots FTC team _#10547_

# Installation
## Inside "Install to C Drive" there is a folder called "scoutingapp" install that to _root C Drive_

## Documentation

### Sorted by the forms themselves

* **Main Menu**
  - Main Menu for application
    - navigate whole program

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
  - When the export button is clicked it also adds the needed information to a text document
    - Puts Match Number, Team Number, Auto Score, TeleOp Score, End Score, and Total Score into the database
    
* **Rankings Form**
  - Shows a dataGridView for the database
    - shows the information input to it
    - helps our team decide who we would pick if we had to for final alliances
  - 

* **Team Import**
  - Ability to import team Numbers
    - you type the team numbers into the box and it exports to the text document
    - can also edit text pad manually if wanted
      - must follow formatting
  - Button for viewing all teams in the file
  
