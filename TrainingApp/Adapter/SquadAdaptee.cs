using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Adapter
{
    public class SquadAdaptee
    {
        public void GetSquad()
        {
            TeamDbContext db = new TeamDbContext();

            foreach (var item in db.Players)
            {
                Console.WriteLine($"\nPlayer:{item.FirstName} {item.LastName}\n" +
                    $"Age: {item.Age}\nPosition: {item.Position}\n" +
                    $"________________________________");
            }
        }
    }
}
