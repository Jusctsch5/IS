@echo off

echo Removing DSO files...
echo;

cd ..
del /s /q *.dso
cls

cd /d %~dp0
cd ../
start Tribes2.exe -nologin -mod IS
cls

exit
