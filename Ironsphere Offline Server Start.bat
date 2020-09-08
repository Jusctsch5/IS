@echo off

echo Removing DSO files...
echo;

cd ..
del /s /q *.dso
cls

cd /d %~dp0
cd ../
#start Tribes2.exe -online -nopure -mod IS
start ispawn.exe 28000 Tribes2.exe -nologin -mod IS -mission T2RPG_WorldMap T2RPG -dedicated
cls
exit

# start ispawn.exe 28000 Tribes2.exe -nologin -mod ironsphererpg -mission T2RPG_WorldMap T2RPG -dedicated
# cls
# exit
