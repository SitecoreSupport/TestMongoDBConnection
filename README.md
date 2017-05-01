# Test MongoDB Connection

A console application for testing connection to a MongoDB instance.

## Main

This repository contains Sitecore console app, which tests databases' connections in MongoDB using MongoDB .NET\C# Driver.

## Deployment

To run the app, perform the following steps on both Content Managment (CM) and Content Delivery (CD) servers:

1. In the `\bin\TestMongoDBConnection.exe.config` file, modify the following connecting strings:

   * `analytics`
   * `tracking.live`
   * `tracking.history`
   * `tracking.contact`
  
2. Run the `\bin\TestMongoDBConnection.exe` file.

> The log is saved into the `\bin\Sitecore.Log.{Data.Time}.txt` file.

## Content 

Sitecore Diagnostics app includes the following files:

1. `\bin\MongoDB.Bson.dll`
2. `\bin\MongoDB.Driver.dll`
3. `\bin\TestMongoDBConnection.exe`
4. `\bin\TestMongoDBConnection.exe.config`

## License

This tool is licensed under the [Sitecore Corporation A/S License](./LICENSE).

## Download

Downloads are available via [GitHub Releases](https://github.com/SitecoreSupport/TestMongoDBConnection/releases).

[![Total downloads](https://img.shields.io/github/downloads/SitecoreSupport/TestMongoDBConnection/total.svg)](https://github.com/SitecoreSupport/TestMongoDBConnection/releases)
