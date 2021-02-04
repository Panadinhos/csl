#!/usr/bin/bash
rm app.exe
mcs -out:app.exe app.cs
sudo chmod +x app.exe
echo -n "É para correr (n)??? "
read correr
./app.exe
