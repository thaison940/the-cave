namespace CaveCore.Settings
{
    public class AppSettings : IAppSettings
    {
        public string JwtSecret { get; set; }
    }

    public interface IAppSettings
    {
        string JwtSecret { get; set; }
    }
}
