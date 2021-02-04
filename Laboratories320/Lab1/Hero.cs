using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Hero : IMovable, IDestroyable
    {
        [BsonId]
        public int HeroId;
        [BsonIgnoreIfNull]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public double Cost { get; set; }
        [BsonIgnoreIfDefault]
        public int NumberOfLife { get; set; }
        

        public void Move()
        {

        }

        public void Destroy()
        {

        }
    }

    static async Task HeroInsert(Hero h)
    {
        string connectionString = "mongo"
    }


}
