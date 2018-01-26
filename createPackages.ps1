# Author: Klaus Comelli
# Manually build multi-target packages using dotnet pack

# Building DEBUG packages (incl. build action) 
dotnet pack .\AlexaSkillsKit.Lib -c Debug -o .\bin\Packages\Debug --version-suffix "debug"

# Building Release packages (incl. build action) 
dotnet pack .\AlexaSkillsKit.Lib -c Release -o .\bin\Packages\Release