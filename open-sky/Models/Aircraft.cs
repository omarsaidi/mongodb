using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OpenSky.Models
{
	public class Aircraft 
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id {get; set;}
		public string Icao24 {get; set;}
		public string Registration {get; set;}
		public string Manufacturericao {get; set;}
		public string Manufacturername {get; set;}
		public string Model {get; set;}
		public string Typecode {get; set;}
		public string Serialnumber {get; set;}
		public string Linenumber {get; set;}
		public string Icaoaircrafttype {get; set;}
		public string Operator {get; set;}
		public string Operatorcallsign {get; set;}
		public string Operatoricao {get; set;}
		public string Operatoriata {get; set;}
		public string Owner {get; set;}
		public string Testreg {get; set;}
		public string Registered {get; set;}
		public string Reguntil {get; set;}
		public string Status {get; set;}
		public string Built {get; set;}
		public string Firstflightdate {get; set;}
		public string Seatconfiguration {get; set;}
		public string Engines {get; set;}
		public string Modes {get; set;}
		public string Adsb {get; set;}
	}
} 
