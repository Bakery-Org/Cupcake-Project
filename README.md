# Cupcake-Project
<br>
<br>
<h1>Coding</h1>
<br>
<h2>Begin coding for a project</h2><br>
Open the repo: cd REPONAME (e.g., cd budget-frontend)
Ensure you are on the main branch: git checkout main
Ensure you are up-to-date: git pull
Create a new branch for your task: git checkout -b BRANCHNAME (e.g., git checkout -b error-messages)
Open VS Code: code .
Make all your edits
Add all your updates: git add .
Commit your updates: git commit -m "[FILENAME] UPDATE" (e.g., git commit -m "[Signup] Fix error messages")
Set the upstream during the initial push of your updates: git push -u origin BRANCHNAME (e.g., `git push -u origin error-messages)
Push directly on later updates (only works if you have already set an upstream): git push
Continue coding after taking a break
Go to the branch you were working on: git checkout BRANCHYOUWEREWORKINGON (e.g., git checkout test-signup)
Pull in any new code from the main branch: git pull origin main
Resolve any merge conflicts that may now be revealed
Proceed as above (i.e., pick up at step 6 in the “Begin Coding for a Project” section)
Continue coding after submitting a pull request
Create a new branch: git checkout -b NEWBRANCHNAME (e.g., git checkout -b test-login)
Pull in your code from the branch you were just working on: git merge OLDBRANCHNAME (e.g., git merge test-signup)
Pull in any new code from the main branch: git pull origin main
Resolve any merge conflicts that may now be revealed
Proceed as above (i.e., pick up from step 6 in the “Begin Coding for a Project” section)
<br>
<h2>Testing</h2><br>
Test your code before submitting
<br>
<em>Frontend</em>
Run both the frontend and the backend: npm start (each one)
Go to the site in Chrome
Navigate to the section of the site related to your updates
Investigate page elements if necessary
Take screenshots of what you do to help others who will test your code to know they can replicate what you have done
<br>
<em>Backend</em>
Run the backend: npm start
Open Postman
Test routes
Take screenshots of what you do to help others who will test your code to know they can replicate what you have done
Test someone else's code before approving
Go to the main branch: git checkout main
Ensure your main branch is up-to-date: git pull
Checkout the branch with the code you need to test: git checkout SOMEONEELSESBRANCH (e.g., git checkout readme-edits)
Test everything indicated in the pull request
<br>
<h2></h2>Pull Requests</h2>
Submit a pull request
Pull in any new code from the remote repo: git pull origin main
Resolve any merge conflicts that may now be revealed
Add, commit, and push your latest code
Go to the main page of the remote repo on GitHub
Go to a list of the repo’s branches by clicking on the “branch” link to the right of the “main” dropdown above the list of all the repo’s top-level folders and files
Begin a new pull request by clicking on the “New pull request” button on the far right of the line with your branch’s name
Include a list of to-do items for someone else to use for testing in the body of the pull request (these should include all the tests that you have already done from the “Test Your Code Before Submitting” section)
Assign someone else to handle your pull request by clicking the sprocket image next to “Assignees” and selecting someone from the list
Finalize the pull request by clicking the green “Create pull request” button
If you pull request has conflicts, add notes about how to resolve them in the comments section of the pull request
<br>
<h2>Approve pull requests</h2><br>
Go to the “Pull requests” tab for the repo on GitHub
Click on the specific pull request in the list
Check off tasks as you perform each test
Scroll down and click the green “Merge pull request” button once you have tested everything indicated in the pull request (if this button is grayed out, then you have a merge conflict; see below)
After merged, delete the branch
<br>
<h2>Conflicts</h2>
Resolve your merge conflicts
Ensure you are on the branch with the merge conflict: git checkout CONFLICTEDBRANCH (e.g., git checkout budget-function)
Get all the conflicts from the main branch to display in your local repo’s conflicted branch: git pull origin main
Open VS Code (if not already open): code .
Resolve conflicts (search for the >>>>>, <<<<<, or ===== pipes to find conflicts; your final version must not include any of those)
Add all your updates: git add .
Commit your updates: git commit -m "[FILENAME] Resolve conflicts with WHATEVER ISSUE" (e.g., git commit -m "[App] Resolve conflicts with updateBudget function")
Push your updates: git push origin CONFLICTEDBRANCH (or just git push if branch’s upstream is already established, which it should be)
Resolve others' merge conflicts
Go to the “Pull requests” tab for the repo on GitHub
Click on the specific pull request with the conflict in the list
Read the provided suggestions about the merge conflict in the comments
Consider setting up a call with whoever submitted the pull request and possibly other members of the team
Consider doing a driver-navigator setup to fix the problems with others’ inputs
Click the gray “Resolve conflicts” button
Resolve conflicts on each page (search for the >>>>>, <<<<<, or ===== pipes to find conflicts; your final version must not include any of those)
Click the gray “Mark as resolved” button after resolving conflicts on each page (you will need to do this separately for each page)
Finalize merge after resolving all the conflicts by clicking the green “Commit merge” button
