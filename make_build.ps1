# Make build.txt when rebuild the project. build.txt will be use as string resource.
# Set the pre-build event as "powershell .\make_build.ps1" in project properties.
Get-Date -Format "yyMMdd" | Out-File -FilePath build.txt -NoNewline
