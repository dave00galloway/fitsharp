REM http://stackoverflow.com/questions/5605885/visual-studio-2010-how-to-run-a-bat-from-inside-the-ide
cd %~dp0
start cmd /k java -jar fitnesse-standalone.jar -p 8989 -e 0 -o
start cmd /k C:\PROGRA~2\Google\Chrome\APPLIC~1\chrome.exe http://localhost:8989/