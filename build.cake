Task("Clean")
    .Does(
        ()=>{
            Information("Clean");
        }
    );

Task("Restore")
    .Does(
        ()=>{
            Information("Restore");
        }
    );

Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(
        ()=>{
            Information("Build");
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


RunTarget("Package");