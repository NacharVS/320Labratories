using Laboratories320.SemSaet;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Laboratories320.mongobd
{
    class Atacker : IHealth, IKill
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public double DistanceAttack { get; set; }
        public double SpeedAttack { get; set; }
        public int Helth { get; set; }

        public Atacker(string Name, int Level, double DistanceAttack, double SpeedAttack, int Helth)
        {
            this.Name = Name;
            this.Level = Level;
            this.DistanceAttack = DistanceAttack;
            this.SpeedAttack = SpeedAttack;
            this.Helth = Helth;
        }
        public void Health()
        {
            throw new NotImplementedException();
        }

        public void Kill()
        {
            throw new NotImplementedException();
        }
    }
}
