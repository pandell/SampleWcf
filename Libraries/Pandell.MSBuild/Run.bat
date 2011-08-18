@rem ******************************************************
@rem *
@rem *  Common pattern of MSBUILD target invocation
@rem *  for Pandell builds.
@rem *
@rem *  Syntax:
@rem *  Run.bat <targets> <configurations> <msbuild_file> [PAUSE]
@rem *
@rem *  <targets>: list of semicolon-separated targets to build
@rem *  <configurations>: list of semicolon-separated configurations
@rem *      to build (e.g. Debug;Release)
@rem *  <msbuild_file>: path to the msbuild file that will
@rem *      control the build; callers may want to use the
@rem *      value "%~dp0Name.proj" - %~dp0 is drive & path
@rem *      part of the batch file using it, Name.proj would
@rem *      be name of the actual build file.
@rem *  [PAUSE]: when specified, execution will pause just before
@rem *      this batch finishes - the user must hit ENTER
@rem *      key to continue; when not specified or not "PAUSE",
@rem *      the batch will finish without waiting for user input.
@rem *
@rem ******************************************************

@setlocal

@rem add a fallback path that contains MSBUILD (if no MSBUILD can be found in the existing PATH, it should be found in the Microsoft.NET subdir)
@set PATH=%PATH%;%systemroot%\Microsoft.NET\Framework\v4.0.30319

msbuild /nologo /consoleloggerparameters:ShowCommandLine;DisableMPLogging /target:%~1 /property:Configurations=%2 %3 %5 %6 %7 %8 %9

@endlocal

@IF "%~4"=="PAUSE" pause
