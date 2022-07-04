using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Strategy
{
    class MatchSession : ISession
    {

        public void ShowSessionList()
        {
            TeamDbContext teamDbContext = new TeamDbContext();
            Console.Clear();
            foreach (var item in teamDbContext.Matches)
            {
                Console.WriteLine($"\nMatch Date: {item.SessionDate.ToShortDateString()}\nField: {item.Field}" +
                    $"\nSession length: {item.SessionStart} to {item.SessionEnd}\n" +
                    $"________________________________");
            }
        }
    }
}
