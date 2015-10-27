# Ensure that permissions are set to run scripts on PC
Set-ExecutionPolicy RemoteSigned

# Set variables
$baseDir = "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview"
$msbuild = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
$options = "/p:Configuration=Release" #Add "/noconsolelogger" if want to avoid console output from build
$releaseFolder = $baseDir + "FizzBuzzInterview\bin\Release"

# Ensure at working directory
cd $baseDir

# Clean and Build variables
$clean = $msbuild + " ""FizzBuzzInterview.sln"" " + $options + " /t:Clean"
$build = $msbuild + " ""FizzBuzzInterview.sln"" " + $options + " /t:Build"

# Run Clean and Build for both Fizzbuzz main project and Tests
Invoke-Expression $clean
Invoke-Expression $build
