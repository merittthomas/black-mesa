﻿using MongoDB.Bson.Serialization.Attributes;

namespace WebApp.Models
{
    public class Assessments
    {
        public Assessments()
        {
            Developers = new Assessment();
            Quails = new Assessment();
        }

        [BsonElement("developers")]
        public Assessment Developers { get; set; }

        [BsonElement("quails")]
        public Assessment Quails { get; set; }
    }
}