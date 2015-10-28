Set-ExecutionPolicy RemoteSigned
Import-Module psake;

$buildTask = "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview\Build Scripts\NewBuildTasks.ps1"

Invoke-psake $buildTask