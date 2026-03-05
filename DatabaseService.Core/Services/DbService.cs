using DatabaseService.Core.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DatabaseService.Core.Service
{
    public class DbService(IConfiguration configuration) : IDbservice
    {
        private SqlConnection _connection;

        public async Task ConnectAsync()
        {
            if (IsConnected) return;

            var connectionString = configuration.GetConnectionString("SqlConnection");
            _connection = new SqlConnection(connectionString);
            await _connection.OpenAsync();
        }

        public async Task<string> GetVersionAsync()
        {
            if (!IsConnected)
                throw new InvalidOperationException("DB is not connected");

            using var cmd = _connection.CreateCommand();
            cmd.CommandText = "SELECT @@VERSION";
            var result = await cmd.ExecuteScalarAsync();
            return result?.ToString();
        }

        public async Task DisconnectAsync()
        {
            if (!IsConnected) return;

            await _connection.CloseAsync();
            _connection.Dispose();
            _connection = null;
        }
        public bool IsConnected => _connection?.State == ConnectionState.Open;
    }
}