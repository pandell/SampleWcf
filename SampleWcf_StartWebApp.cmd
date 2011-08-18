@echo off
rem **
rem ** This command starts IIS Express
rem ** that serves GeoNexus
rem **

setlocal
title SampleWcf Web Server

set SolutionDir=%~dp0
rem -- SolutionDir is referenced from webapp.config, all "absolute" paths
rem -- in webapp.config use this as a prefix; it allows webapp.config to
rem -- not be hard-coded to absolute path in source control, yet provide
rem -- absolute path to IIS Express when it's running

set Path=%ProgramFiles(x86)%\IIS Express;%ProgramFiles%\IIS Express;%Path%
rem -- Extend the path so that IIS Express executables can be found whether
rem -- this command is running in 32bit (%ProgramFiles%\IIS Express) or
rem -- 64bit (%ProgramFiles(x86)%\IIS Express) cmd.exe.

call iisexpress.exe "/config:%~dp0Source\SampleWcf.Web\Webapp.config" /systray:false /trace:w
rem -- Run IIS Express against our webapp.config file; don't run systray app
rem -- (the console output is enough to see what's happening and to stop
rem -- the web server)

pause
endlocal
