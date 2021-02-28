$env:PROJECTNAME = "Courses"
$env:BUILDCONFIGURATION = "Release"
$env:APIDIR = "/src"
$env:VERSION = "1.0"

. .\BuildNetApi.ps1

$sw = [Diagnostics.Stopwatch]::StartNew()
CIBuildNetApi
$sw.Stop()
write-host "Build time: " $sw.Elapsed.ToString()