Set-ExecutionPolicy RemoteSigned
Import-Module psake;

$buildTask = "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview\Build Scripts\NewBuildTasks.ps1"

#Change config value in the properrty below to values 'debug' or 'release' depending on build desired
Invoke-psake $buildTask -properties @{ 'config'='Debug'}