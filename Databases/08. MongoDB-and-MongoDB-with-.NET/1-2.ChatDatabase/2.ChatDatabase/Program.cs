using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ChatDatabase
{
    using MongoDB.Driver;
    class Program
    {
        static void Main(string[] args)
        {

           

                var mongoClient = new MongoClient("mongodb://<dbuser>:<dbpassword>@ds031561.mongolab.com:31561/chatdatabase");
                var server = mongoClient.GetServer();
                var db = server.GetDatabase("chatdatabase");
                var chatdatabaseCollection = db.GetCollection<Message>("chatdatabase");

                chatdatabaseCollection.Insert(new Message()
                {
                    Text = "Hello!",
                    DateOfSent = DateTime.Parse("17.01.2015"),
                    UserPersonality = new User()
                    {
                        FirstName = "Teodor",
                        LastName = "Georgiev"
                    }

                });

                chatdatabaseCollection.Insert(new Message()
                {
                    Text = "Happy B-day!",
                    DateOfSent = DateTime.Parse("17.01.2015"),
                    UserPersonality = new User()
                    {
                        FirstName = "Petko",
                        LastName = "Kolev"
                    }
                });

                Console.WriteLine(chatdatabaseCollection.FindAll().First().UserPersonality.FirstName + " " + chatdatabaseCollection.FindAll().First().UserPersonality.LastName);
            }
        }          
    }
