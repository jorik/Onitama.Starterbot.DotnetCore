## Onitama Starterbot for DotnetCore

# Getting started

    Register your bot on https://botchallenge.intern.infi.nl/
    Copy the API key and paste it in Program.cs and the Makefile

# Running your bot

Your default-bot is able to join matches in the cloud and locally. When you run your bot in your IDE / from the commandline it will automatically join a remote match.

The bot has to be uploaded for it to be able to participate in tournaments or matches against other bots.

# Publishing your bot on MacOS / Linux

Requirements: `dotnet`, `make` and `zip`. 

Deploying is as easy as running `make publish` from the commandline. Make sure your bot's API-key is present in the Makefile.

# Publishing your bot on Windows:

Ask a colleague with a proper OS to publish your bot.

# bot.conf

This file is used when running your bot in the cloud. The worker will start a dotnet process using the entrypoint as its argument. The entrypoint-file is expected to be in the root of the project.
