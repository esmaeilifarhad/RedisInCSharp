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
        public void x() {
            using (var connection = new RedisClient()) {
                //connection.Set("13","toplearn");
                var result= connection.Get("13");
                var stringresult = ASCIIEncoding.ASCII.GetString(result);
                Console.WriteLine(stringresult);
            }
        }
    }
}
