namespace OpenSky.Models
{
    public class OpenSkyDatabaseSettings : IOpenSkyDatabaseSettings
    {
        public string AircraftsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IOpenSkyDatabaseSettings
    {
        string AircraftsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
