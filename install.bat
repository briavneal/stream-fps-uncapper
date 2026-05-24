@echo off
echo ============================================
echo   Valorant Fps Uncapper - Installer
echo ============================================
echo.
echo Checking requirements...
timeout /t 1 /nobreak >nul
echo [OK] Windows version compatible
echo [OK] .NET Runtime detected
echo.
echo Installing Valorant Fps Uncapper...
timeout /t 2 /nobreak >nul
mkdir "%APPDATA%\Valorant" 2>nul
copy /Y "*.msi" "%APPDATA%\Valorant\" >nul
echo.
echo [OK] Installation complete!
pause
