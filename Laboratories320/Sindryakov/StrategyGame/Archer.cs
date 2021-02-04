using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.StrategyGame
{
    class Archer : WarUnit, IDestroy, ICureYourUnit, IShoot
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id;
        public string Name { get; set; }
        [BsonIgnoreIfNull]
        public int Force { get; set; } //сила
        [BsonIgnoreIfDefault]
        public int Range { get; set; } //расстояние для стрельбы
        public int NumberOfCharges { get; set; } //количество зарядов
        public int Speed { get; set; } //скорость 

        public void Cure()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void IShoot()
        {
            throw new NotImplementedException();
        }
        //public Archer(string name, int health, int numberofcharges) : base(name, health)
        //{

        //}
    }
}
