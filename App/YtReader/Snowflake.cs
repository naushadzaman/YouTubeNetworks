﻿using System.Threading.Tasks;
using Snowflake.Data.Client;
using SysExtensions.Security;

namespace YtReader {
  public class SnowflakeCfg {
    public NameSecret Creds     { get; set; } = new NameSecret();
    public string     Account   { get; set; } = "MUTUO";
    public string     Warehouse { get; set; } = "YT";
    public string     Db        { get; set; } = "YT";
    public string     Schema    { get; set; } = "PUBLIC";
  }

  public static class SnowflakeEx {
    public static async Task<SnowflakeDbConnection> OpenConnection(this SnowflakeCfg cfg) {
      var conn = new SnowflakeDbConnection {ConnectionString = cfg.ConnectionStirng(), Password = cfg.Creds.SecureString()};
      await conn.OpenAsync();
      return conn;
    }

    public static string ConnectionStirng(this SnowflakeCfg cfg) =>
      $"account={cfg.Account};user={cfg.Creds.Name};db={cfg.Db};schema={cfg.Schema};warehouse={cfg.Warehouse}";
  }
}