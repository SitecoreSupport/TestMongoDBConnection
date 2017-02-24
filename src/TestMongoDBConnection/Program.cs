using MongoDB.Driver;
using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text;

namespace TestMongoDBConnection
{
  class Program
  {
    private static readonly StringBuilder Log = new StringBuilder();

    private static void Main()
    {
      foreach (ConnectionStringSettings setting in ConfigurationManager.ConnectionStrings)
      {
        if (!setting.Name.Equals("LocalSqlServer"))
        {
          TestConnectionString(setting.Name, setting.ConnectionString);
        }
      }

      DumpLog(Log);

      Console.WriteLine("Press any key to close.");
      Console.ReadKey();
    }

    private static void TestConnectionString(string name, string connectionString)
    {      
      Log.AppendLine();
      Log.AppendLine($"====== Test Date: {DateTime.Now.ToString(CultureInfo.InvariantCulture)} ======");
      Log.AppendLine();
      Log.AppendLine($"Connection Name: {name}.");
      Log.AppendLine($"Connection String: {connectionString}.");

      try
      {
        MongoClient client = new MongoClient(connectionString);
        var mongoServer = client.GetServer();
        mongoServer.Connect();
        var versionString = mongoServer.BuildInfo.VersionString;

        Log.AppendLine();
        Log.AppendLine($"MongoDB version: {versionString}.");
        Log.AppendLine("Connect is successful.");
        Log.AppendLine();
      }
      catch (Exception exception)
      {
        Log.AppendLine($"{exception.Message}{exception.InnerException}{exception.StackTrace}");
      }
    }

    private static void DumpLog(StringBuilder log)
    {
      Console.WriteLine(log);

      var fileName = $"Support.Log.{DateTime.Now.ToString("yyyyMMdd.hhmmss")}.txt";

      using (StreamWriter writer = new StreamWriter(fileName))
      {
        writer.Write(log);
      }       
    }
  }
}