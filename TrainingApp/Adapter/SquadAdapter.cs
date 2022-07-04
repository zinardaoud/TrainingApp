using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Adapter
{
    
    public class SquadAdapter : ITarget
    {
        private readonly SquadAdaptee _squad;

        public SquadAdapter(SquadAdaptee squad)
        {
            _squad = squad;
        }
        public void GetPlayersList()
        {
            _squad.GetSquad();
        }
    }
}
