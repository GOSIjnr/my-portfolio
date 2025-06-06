@echo off
setlocal EnableDelayedExpansion

:: Move to root directory
for /f "delims=" %%i in ('git rev-parse --show-toplevel 2^>nul') do cd /d "%%i"

:: Confirm we're in a Git repo
git rev-parse --is-inside-work-tree >nul 2>&1

if errorlevel 1 (
    echo Can't run script, You are not inside a Git repository.
    pause
    exit /b
)

:: Save current branch so we can return to it later
for /f %%b in ('git rev-parse --abbrev-ref HEAD') do set original_branch=%%b

:: Ask user for source branch
set /p source_branch=Enter the source branch to deploy from (e.g., main):

:: Check if source branch exists
git show-ref --verify --quiet refs/heads/%source_branch%

if errorlevel 1 (
    echo Source branch "%source_branch%" does not exist.
    pause
    exit /b
)

:: Ask user for target branch (default: pages-deploy)
set /p target_branch=Enter the target branch (default is pages-deploy):
if "%target_branch%"=="" set target_branch=pages-deploy

echo.
echo Deploying from: %source_branch%
echo Deploying to: %target_branch% (as a single commit)
pause

:: Checkout source branch
git checkout %source_branch%

if errorlevel 1 (
    echo Failed to checkout source branch.
    pause
    exit /b
)

:: Create an orphan branch for deployment
git checkout --orphan deploy-temp
git reset --hard

:: Copy files from source branch to orphan branch
git checkout %source_branch% -- .

:: Commit the snapshot
git add .
git commit -m "Deploy: snapshot from %source_branch%"

:: Rename orphan branch to target branch
git branch -M %target_branch%

:: Force push the deploy branch to remote
git push -f origin %target_branch%

:: Switch back to the original branch you started from
git checkout %original_branch%

echo.
echo Deployment to %target_branch% complete!
echo You are now back on branch: %original_branch%.
echo Script completed successfully. Press any key to exit.
pause
