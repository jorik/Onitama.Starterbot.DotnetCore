# Onitama Starterbot for DotnetCore

## Getting started

 - Clone or fork this repository
 - Create an account on https://botchallenge.intern.infi.nl/
 - Create a bot for the Onitama game on https://botchallenge.intern.infi.nl/bots/create
 - Copy the API key and paste it in Program.cs and the Makefile
 - You can now start your first match!

## Starting a match

With this starter bot you can join a game right away. When you run your bot locally, it will automatically connect to the remote server and join a match. You will play against a version of this bot every time.

Once you've created a bot and uploaded a published version of your code to it, you will be able to schedule matches against other published bots on the website. 

Each match that is ran can be played back visually from the matches overview.

## Publishing your bot on MacOS / Linux

Requirements: `dotnet`, `make` and `zip`. 

Deploying is as easy as running `make publish` from the commandline. Make sure your bot's API-key is present in the Makefile.

## Publishing your bot on Windows:

We created a powershell script that will do the publishing and zipping for you. 
    
    Run publish.ps1 in powershell (you can find the script in this repo).

Make sure your bot's API-key is present in the Powershell file's `$APIKEY` variable, or else you will get a 404 response from the server. 

## bot.conf

This file is used when running your bot in the cloud. The worker will start a dotnet process using the entrypoint as its argument. The entrypoint-file is expected to be in the root of the project.
