using OpenSky.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace OpenSky.Services
{
    public class AircraftService
    {
        private readonly IMongoCollection<Aircraft> _aircrafts;

        public AircraftService(IOpenSkyDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _aircrafts = database.GetCollection<Aircraft>(settings.AircraftsCollectionName);
        }

        public List<Aircraft> Get(int page) =>
            _aircrafts.Find(aircraft => true).ToList();

        public Aircraft Get(string id) =>
            _aircrafts.Find<Aircraft>(aircraft => aircraft.Id == id).FirstOrDefault();
	
	public Aircraft Create(Aircraft aircraft)
        {
            _aircrafts.InsertOne(aircraft);
            return aircraft;
        }

        public void Update(string id, Aircraft aircraftIn) =>
            _aircrafts.ReplaceOne(aircraft => aircraft.Id == id, aircraftIn);

        public void Remove(Aircraft aircraftIn) =>
            _aircrafts.DeleteOne(aircraft => aircraft.Id == aircraftIn.Id);

        public void Remove(string id) =>
            _aircrafts.DeleteOne(aircraft => aircraft.Id == id);
    }
}
