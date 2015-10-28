Set-ExecutionPolicy RemoteSigned
Import-Module psake;

$buildTask = "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview\Build Script\NewBuildTasks.ps1"

Invoke-psake $buildTask