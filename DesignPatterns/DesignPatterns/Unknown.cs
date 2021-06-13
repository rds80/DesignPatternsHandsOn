using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Unknown: Friend
    {
        public Unknown(IMediator mediator, string name) : base(mediator) => this.Name = name;

        public void Send(string msg) => mediator.Send(this, msg);
    }
}
