TESTRAIL

CHECKLIST

UI-tests

•	Positive: 
1.	Verify input Data on boundary values (34, 250, 287 symbols) on the "DasboardPage" -> "SearchProjectsPage" ;
2.	Verify that pop up message is displayed after clicking the logo on "DasboardPage";
3.	Verify creation project;
4.	Verify deletion of project;
5.	Verify that dialog window on the "Dasboard" -> "AdministrationPage" -> "IntegrationPage" is displayed after clicking the "Configuration Integration Button";
6.	Verify that "FileForUpload" is uploaded on the "DasboardPage" -> "AdministrationPage" -> "DataManagementPage" -> "AttachmentsPage".

•	Negative: 

7.	Verify that user can't login with invalid credentials;
8.	Verify that after input in search field (more than 250 symbols) on the "DashboardPage" get error message;
9.	Verify that Project is removed;

    
API-tests

11.	Verify that NFE GET (index.php?/api/v2/get_user/{user_id}) Request returns correct response with "user" parameters
12.	Verify that NFE POST (index.php?/api/v2/add_project Request) returns correct response with "project" parameters
13.	Verify that AFE GET (index.php?/api/v2/get_project/{project_id}) Request returns BadRequest = 400
14.	Verify that NFE POST (index.php?/api/v2/add_milestone/{project_id}) Request returns correct response with "milestones" parameters
15.	Verify that AFE GET (index.php?/api/v2/get_milestone/{milestone_id}) Request returns BadRequest = 400
