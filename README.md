# Test MongoDB Connection
A console application for testing connection to MongoDB instance.

## Main

This repository contains Sitecore console application, which tests connecting to MongoDB databases using MongoDB Driver.

## Deployment

To run the app, perform the following steps on both CM and CD servers:

1. In `\bin\TestMongoDBConnection.exe.config` the file, modify the `analytics`, `tracking.live`, `tracking.history` and `tracking.contact` MongoDB connecting strings.
2. Run the `\bin\TestMongoDBConnection.exe` file.

> The log is saved into the `\bin\Sitecore.Log.{Data.Time}.txt` file.

## Content 

Sitecore Diagnostics app the following files:

1. `\bin\MongoDB.Bson.dll`
2. `\bin\MongoDB.Driver.dll`
3. `\bin\TestMongoDBConnection.exe`
4. `\bin\TestMongoDBConnection.exe.config`

## License

This patch is licensed under the [Sitecore Corporation A/S License](./LICENSE).

## Download

Downloads are available via [GitHub Releases](https://github.com/SitecoreSupport/TestMongoDBConnection/releases).