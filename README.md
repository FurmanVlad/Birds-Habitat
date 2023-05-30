## Final QA Project - SCE

### Description
This project is a bird management system with features such as user registration, login/logout, adding birds and cages, searching for birds or cages, editing bird information, adding chicks to birds, and viewing birds in a cage. Users can perform these actions through a user-friendly interface.



### Features
- Login functionality with username and password verification
- User registration functionality
- Logout functionality
- Main form with options to add a bird, add a cage, search for a bird, and search for a cage
- Add a chick to bird from the search results
- Edit a bird from the search results
- View list of birds that are in any cage from the search cage results

### Installation
1. Clone the repository or download the source code.
2. Open the solution in Visual Studio.
3. Clean the solution and then build the solution.
4. Run the application to start.

### Usage
1. Launch the application.
2. Enter your username and password in the respective fields.
3. Click the "Login" button to authenticate the credentials.
4. If the login is successful, you will be redirected to the main form of the application.
5. In the main form, you can perform the following actions:
   - Click the "Add Bird" button to add a new bird.
   - Click the "Add Cage" button to add a new cage.
   - Click the "Search Bird" button to search for a bird.
   - Click the "Search Cage" button to search for a cage.
   - Click the "Logout" button to log out of the application.
6. To add a new bird:
   - Click the "Add Bird" button.
   - Enter the bird's serial number, species, subspecies, hatching date, gender, cage serial number, father's serial number, mother's serial number, head color, breast color, and body color in the corresponding fields.
   - Select the species and gender from the respective drop-down lists to populate the subspecies and body color options, respectively.
   - Click the "Add Bird" button to add the bird to the system.
   - The application will validate the input data and display error messages if any fields are missing or contain invalid information.
7. To add a new cage:
   - Click the "Add Cage" button.
   - Enter the cage's serial number, length, width, height, and material in the corresponding fields.
   - Click the "Add Cage" button to add the cage to the system.
   - The application will validate the input data and display error messages if any fields are missing or contain invalid information.
8. To search for a bird or cage, follow similar steps as for adding a bird or cage.
9. To edit an existing bird:
   - Select a bird from the search results.
   - Click the "Edit" button.
   - Modify the bird's information in the provided fields.
   - Click the "Edit" button to save the changes.
   - The application will validate the input data and display error messages if any fields are missing or contain invalid information.
10. To add a chick to bird:
    - Select a bird from the search results.
    - Click the "Add chick" button.
    - Enter the bird's information in the provided fields.
    - Click the "Add chick" button to save the changes.
    - The application will validate the input data and display error messages if any fields are missing or contain invalid information.
11. To view a list of bird in a cage:
    - Select a cage from the search results.
    - Click the "View" button.
    - The application will display the list of birds that in this specific cage.
12. To log out of the application, click the "Logout" button and confirm the logout when prompted.
13. You can exit the application by closing the window or clicking the close button. A confirmation dialog will appear to confirm the exit.

### Dependencies
- .NET Framework
- Microsoft.Office.Interop.Excel
- You must change the paths in the following documents in the project where your Excel documents are stored:
    - **"C: ... Your PATH ... \Birds habitat.xlsx":**
    - AddBirdForm.cs (line 101) - 
    - AddCageForm.cs (line 49)
    - AddChickForm.cs (line 71)
    - EditBirdForm.cs (line 118)
    - SearchBirdForm.cs (line 92)
    - SearchCage.cs (line 60)
    - ShowResultBirdSearch.cs (line 154)
    - ShowResultCageSearch.cs (line 60)
    - **"C: ... Your PATH ... \Users.xlsx":**
    - LoginForm.cs (line 49)
    - SignUpForm.cs (line 76)

### Authors
- Vlad Furman
- Guy Shukrun
- Tal Berko
- Ori Hazan
