#psake build script tasks for FizzBuzzInterview solution

properties {
    $config = 'Debug'; 
}

task -name ValidateConfig -action { 
    assert -conditionToCheck ('Debug','Release' -contains $config ) -failureMessage "Please select Debug or Release only" 
    }

task -name Clean -depends ValidateConfig -description "Deletes all build artifacts" -action {
    exec { 
            msbuild "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview.sln" /t:Clean /p:Configuration=$config
        }
}

task -name Build -depends ValidateConfig -description "Builds the outdated artifacts" -action { 
    exec { 
            msbuild "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview.sln" /t:Build /p:Configuration=$config
        }
}

task -name Default -depends Clean, Build -description "The default action will be to rebuild all artifacts and deploy a build"