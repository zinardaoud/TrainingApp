using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Strategy
{
    class Session
    {
        private ISession _sessionInterface;

        public Session()
        {

        }

        public Session(ISession session)
        {
            _sessionInterface = session;
        }
        public void SetSession(ISession sessionInterface)
        {
            _sessionInterface = sessionInterface;

        }
        public void Show()
        {
            _sessionInterface.ShowSessionList();
        }
    }
}
