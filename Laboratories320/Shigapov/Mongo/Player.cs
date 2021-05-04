using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.Mongo
{
    class Player
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id;
        public string Name { get; set; }
        public int Speed { get; set; }
        [BsonIgnoreIfNull]
        public int Armor { get; set; }
        [BsonIgnoreIfDefault]
        public int Damage;
        public int Health;
    }
}
