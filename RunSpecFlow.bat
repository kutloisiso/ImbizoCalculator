"C:\Program Files (x86)\NUnit 2.6.2\bin\nunit-console.exe" /labels /out=TestResult.txt /xml=TestResult.xml /framework=net-4.0 Bowling.Specflow\bin\Debug\Bowling.Specflow.dll
 
"packages\SpecFlow.1.9.0\tools\specflow.exe" nunitexecutionreport Bowling.Specflow\Bowling.SpecFlow.csproj
 
IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
EXIT
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1