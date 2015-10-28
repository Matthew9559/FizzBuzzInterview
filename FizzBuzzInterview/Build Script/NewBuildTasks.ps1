#psake build script tasks for FizzBuzzInterview solution

task -name Clean -description "Deletes all build artifacts" -action {
    exec { 
            msbuild "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview.sln" /t:Clean
        }
}

task -name Build -description "Builds the outdated artifacts" -action { 
    exec { 
            msbuild "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview.sln" /t:Build
        }
}


task -name Default -depends Clean, Build -description "The default action will be to rebuild all artifacts"