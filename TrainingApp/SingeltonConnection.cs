using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    //Using Singelton to return string as db connection
    public sealed class SingeltonConnection
    {
        private static string connection;
        private static SingeltonConnection instance  = null;

        private SingeltonConnection()
        {
            connection = @"Data Source=DESKTOP-7OVMGAR\SQLEXPRESS;Initial Catalog=FootballTeamDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        private static object synclock = new object();

        public static SingeltonConnection Instance
        {
            get
            {
                lock (synclock)
                {
                    if (instance == null)
                    {
                        instance = new SingeltonConnection();
                    }
                    return instance;
                }
               
            }
        }

        public string Con()
        {
            return connection;
        }
       
    }
}
