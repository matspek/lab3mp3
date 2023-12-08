using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3mp3
{
    public class Quiz
    {
        [BsonId]
        public Guid Id { get; set; }
        public List<Question> _questions;
        public string _title {get; set;} = string.Empty;
            public string Title => _title;

            public Quiz()
            {
                _questions = new List<Question>();
            }

        }
    }
