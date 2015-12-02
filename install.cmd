set service_name=%1
if "%service_name%"=="" (set service_name=AspNetWindowsService)

rmdir /q /s "%~dp0publish-output"

call dnu restore
call dnu publish src\AspNetWindowsService --wwwroot "wwwroot" --wwwroot-out "%~dp0publish-output\approot\packages\AspNetWindowsService\1.0.0\root\assets" --out publish-output --runtime active --no-source
sc create %service_name% binPath= "\"%~dp0publish-output\approot\run.cmd\" --windows-service"
sc start %service_name%
