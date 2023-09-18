using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Messages.Commands.UserCommands
{
    public class RestartPasswordCommand
    {
        public string NewPassword { get; set; }
        public string UserNameOrPassword { get; set; }
    }
}
