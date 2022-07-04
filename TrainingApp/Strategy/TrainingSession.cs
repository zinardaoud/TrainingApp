using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Strategy
{
    internal class TrainingSession : ISession
    {
        

        public void ShowSessionList()
        {
            TeamDbContext teamDbContext = new TeamDbContext();
            Console.Clear();
            foreach (var item in teamDbContext.Trainings)
            {
                Console.WriteLine($"\nTraining Date: {item.SessionDate.ToShortDateString()}\nField: {item.Field}" +
                    $"\nSession length: {item.SessionStart} to {item.SessionEnd}\n" +
                    $"________________________________");
            }
        }
    }
}
