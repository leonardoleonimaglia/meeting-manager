using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace MeetingManager.Infra.Data.Configurations
{
    public class MeetingManagerConnectionString
    {
        private static string _connectionString;

        public static string ConnectionString
        {
            get => _connectionString;
            set
            {
                if (string.IsNullOrWhiteSpace(_connectionString))
                    _connectionString = GetSecret();
            }
        }

        private static string GetSecret()
        {
            var configuration = new ConfigurationBuilder().AddDockerSecrets().Build();
            var connectionString = configuration["MEETINGMANAGER"];

            return connectionString;
        }
    }
}
