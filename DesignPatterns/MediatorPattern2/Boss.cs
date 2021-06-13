using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    public class Boss : Friend
    {
        public Boss(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
            this.Status = "On";
        }

        public void Send(Friend intendedFreind, string message) => 
            mediator.Send(this, intendedFreind, message);
    }
}
