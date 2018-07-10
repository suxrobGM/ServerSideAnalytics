using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServerSideAnalytics.Mongo
{
    internal class MongoGeoIpRange
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public CountryCode CountryCode { get; set; }
    }
}
