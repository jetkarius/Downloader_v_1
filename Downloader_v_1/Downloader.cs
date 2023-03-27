using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader_v_1
{
    class Downloader : Command
    {
        Receiver receiver;

        public Downloader(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public override void Run()
        {
            receiver.Operation();
        }
    }
}
