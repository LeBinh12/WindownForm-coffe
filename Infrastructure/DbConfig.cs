using System;
using System.IO;
using System.Text.Json;

namespace QuanLyQuanCafe.Infrastructure
{
    public static class DbConfig
    {
        public static string GetConnectionString()
        {
            string defaultConnection = @"Server=(localdb)\MSSQLLocalDB;Database=QuanLyQuanCafe;Trusted_Connection=True;TrustServerCertificate=True;";
            try
            {
                string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                if (File.Exists(jsonPath))
                {
                    string jsonString = File.ReadAllText(jsonPath);
                    using (JsonDocument doc = JsonDocument.Parse(jsonString))
                    {
                        if (doc.RootElement.TryGetProperty("ConnectionStrings", out JsonElement connSection))
                        {
                            if (connSection.TryGetProperty("DefaultConnection", out JsonElement connProp))
                            {
                                string connStr = connProp.GetString();
                                if (!string.IsNullOrEmpty(connStr))
                                {
                                    return connStr;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                // Fallback to default connection string if anything goes wrong
            }
            return defaultConnection;
        }
    }
}
