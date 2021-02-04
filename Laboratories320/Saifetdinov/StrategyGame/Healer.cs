using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Healer : Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public int HealingSpeed { get; set; }
        public int PercentageOfAllysSkillGain { get; set; }
        public int TimeToStunEnemies { get; set; }

        public Healer(string name, int level, int health, int race, int damage, int speed, int healingSpeed, int percentageOfAllysSkillGain, int timeToStunEnemies) : base(name, level, health, race, damage, speed)
        {
            this.HealingSpeed = healingSpeed;
            this.PercentageOfAllysSkillGain = percentageOfAllysSkillGain;
            this.TimeToStunEnemies = timeToStunEnemies;
        }

        public void Healing()
        {
            Console.WriteLine("Running to treat");
        }
    }
}
