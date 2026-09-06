@echo off
setlocal enabledelayedexpansion

echo Detecting GPU...

set "REQ_FILE=req-cpu.txt"

for /f "usebackq delims=" %%G in (`powershell -NoProfile -Command "(Get-CimInstance Win32_VideoController | Select-Object -ExpandProperty Name) -join ';'"`) do set "GPU_NAMES=%%G"

echo Found GPU(s): %GPU_NAMES%

echo %GPU_NAMES% | findstr /I "NVIDIA GeForce Quadro RTX" >nul
if %errorlevel%==0 (
    set "REQ_FILE=req-nvidia.txt"
    goto :found
)

echo %GPU_NAMES% | findstr /I "AMD Radeon" >nul
if %errorlevel%==0 (
    set "REQ_FILE=req-amd.txt"
    goto :found
)

echo %GPU_NAMES% | findstr /I "Intel Arc" >nul
if %errorlevel%==0 (
    set "REQ_FILE=req-intel.txt"
    goto :found
)

echo No NVIDIA or AMD GPU detected — falling back to req-cpu.txt
:found

echo Using %REQ_FILE%

python -m venv .venv
call .venv\Scripts\activate.bat
python -m pip install --upgrade pip
python -m pip install --no-deps -r %REQ_FILE%
python main.py

pause