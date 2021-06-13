using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    public class Friend2 : Friend
    {
        public Friend2(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
            this.Status = "On";
        }

        public void Send(Friend intendedFriend, string message) =>
            mediator.Send(this, intendedFriend, message);
    }
}
