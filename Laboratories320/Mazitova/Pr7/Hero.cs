using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace Laboratories320.Mazitova.Pr7
{
    class Hero
    {
        [BsonId]
        public int HeroId;
        [BsonIgnoreIfNull]
        public string HeroName { get; set; }
        [BsonIgnoreIfDefault]
        public int Victories { get; set; }
        [BsonIgnoreIfDefault]
        private int GamePoints { get; set; }



    }
       
}
