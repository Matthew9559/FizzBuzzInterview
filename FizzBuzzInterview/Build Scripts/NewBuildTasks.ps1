#psake build script tasks for FizzBuzzInterview solution

properties {
    $config = "Debug"
    $solutionPath =  "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\FizzBuzzInterview.sln"
    $nunitPath = "\\psf\Dropbox\Software Projects\C#\FizzBuzzInterview\packages\NUnit.2.6.4\lib\nunit.framework.dll"
}

task -name ValidateNUnit -action {
    assert -conditionToCheck (Test-Path($nunitPath)) -failureMessage "NUnit must be installed in order to run tests"
    }

task -name ValidateConfig -action { 
    assert -conditionToCheck ('Debug','Release' -contains $config ) -failureMessage "Please select Debug or Release only" 
    }

task -name Clean -depends ValidateConfig, ValidateNUnit -description "Deletes all build artifacts" -action {
    exec { 
            msbuild  $solutionPath /t:Clean /p:Configuration=$config
        }
}

task -name Build -depends ValidateConfig, ValidateNUnit -description "Builds the outdated artifacts" -action { 
    exec { 
            msbuild $solutionPath /t:Build /p:Configuration=$config
        }
}

task -name Default -depends Clean, Build -description "The default action will be to rebuild all artifacts and deploy a build"