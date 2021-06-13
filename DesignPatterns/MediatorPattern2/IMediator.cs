using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    public interface IMediator
    {
        void Send(Friend fromFriend, Friend toFriend, string message);
    }
}
