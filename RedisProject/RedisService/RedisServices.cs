using RedisProject.Repositories;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisProject.RedisService
{
    public class RedisServices
    {
        public void x()
        {

            var personelId = "100";
            //do
            //{
            //    Console.Write("please inter person number : ");
            //    //  personelId = Console.ReadLine();
            //    personelId = "100";
            //}
            //while (personelId != "0");


            using (var connection = new RedisClient())
            {

                var result = connection.Get(personelId);//ASCIIEncoding.ASCII.GetString(connection.Get(personelId));
                if (result != null)
                {
                    Console.WriteLine("Person is : ", ASCIIEncoding.ASCII.GetString(result));
                    Console.WriteLine("this data Come from cache");
                }
                else
                {
                    var repo = new PersonRepository();
                    var repoResult = repo.GetPersonById(personelId);

                    connection.Set(personelId, repoResult.FullName);
                    Console.WriteLine("Person is : ", repoResult.FullName);
                    Console.WriteLine("this data come from database");

                }
                //connection.Set("13","toplearn");
                var result2 = connection.Get("13");
                var stringresult = ASCIIEncoding.ASCII.GetString(result2);
                Console.WriteLine(stringresult);


            }


        }
    }
}
