using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3mp3.Data
{
    internal class MongoCRUD
    {
        internal class MongoCrud
        {
            private IMongoDatabase db;

            public MongoCrud(string Database)
            {
                var client = new MongoClient("");
                db = client.GetDatabase(Database);
            }
            public void AddQuiz(string table, Quiz quiz)
            {
                var collection = db.GetCollection<Quiz>(table);
                collection.InsertOne(quiz);
            }
            public List<Quiz> GetAllQuiz(string table)
            {
                var collection = db.GetCollection<Quiz>(table);
                return collection.Find(_ => true).ToList();
            }
        
            public void UpdateQuiz(string table, Quiz quiz)
            {
                var collection = db.GetCollection<Quiz>(table);
                quiz._title = "potatis";
                collection.ReplaceOne(x => x.Id == quiz.Id, quiz, new ReplaceOptions { IsUpsert = true });
            }
            public void DeteteQuiz(string table, Quiz quiz)
            {
                var collection = db.GetCollection<Quiz>(table);
                collection.DeleteOne(x => x.Id == quiz.Id);
            }
            public void ClearDatabase(string table)
            {
                var collection = db.GetCollection<Quiz>(table);
                collection.DeleteMany(_ => true);
            }
        }
    }

}

