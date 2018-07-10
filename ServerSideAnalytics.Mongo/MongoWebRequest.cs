using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServerSideAnalytics.Mongo
{
    internal class MongoWebRequest
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime Timestamp { get; set; }

        public string Identity { get; set; }

        public string RemoteIpAddress { get; set; }

        public string Method { get; set; }

        public string Path { get; set; }

        public string UserAgent { get; set; }

        public string Referer { get; set; }

        public bool IsWebSocket { get; set; }

        public CountryCode CountryCode { get; set; }
    }
}