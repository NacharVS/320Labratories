using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Laboratories320.Zakirov._1Praktika
{
    class Barbarian : WarUnit //варвар
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnore]
        public int Level { get; set; }
        [BsonElement("Amount resource")]
        public int AmountResources { get; set; } //объем ресурсов, которых крадет варвар
        [BsonElement("Damage done")]
        public int DamageDone { get; set; } //нанесенный урон

        public Barbarian(string Name, int Health, int AttackSpeed, int MovementSpeed, int Speed, int AmountResources, int DamageDone) : base(Name, Health, AttackSpeed, MovementSpeed, Speed)
        {
            this.AmountResources = AmountResources;
            this.DamageDone = DamageDone;
        }

        public void Assault()
        {
            Console.WriteLine("Герой напал");
        }

        public void Destroy()
        {
            Console.WriteLine("Герой уничтожил");
        }
    }
}
