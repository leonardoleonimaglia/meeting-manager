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
                    _connectionString = value;
            }
        }
    }
}
