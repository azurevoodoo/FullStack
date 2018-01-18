var solution = "./src/FullStack.sln";

var target = Argument("target", "Package");

Task("Clean")
    .Does(
        ()=>{
            CleanDirectories(
                "./src/**/obj/*.*"
            );
        }
    );

Task("Restore")
    .Does(
        ()=>{
            DotNetCoreRestore(solution,
            new DotNetCoreRestoreSettings {
                
            }
            );
        }
    );

Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(
        ()=>{
            DotNetCoreBuild(solution);
        }
    );

Task("Test")
    .IsDependentOn("Build")
    .Does(
        ()=>{
            Information("Test");
        }
    );

Task("Package")
    .IsDependentOn("Test")
    .Does(
        ()=>{
            Information("Package");
        }
    );


RunTarget(target);