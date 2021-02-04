using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Smirnov.StrategyGame_1_.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units.War_units
{
    class Assasin : Unit, IDestroy, IAttack, IMove
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id;
        [BsonIgnoreIfDefault]
        public int Speed { get; set; }
        [BsonIgnoreIfNull]
        public int Armor { get; set; }
        [BsonIgnoreIfDefault]
        public int Agility { get; set; }

        public Assasin(string name, int health, int speed, int armor, int agility) : base(name, health)
        {
            Speed = speed;
            Armor = armor;
            Agility = agility;
        }

        public void Attack(Unit unit)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
