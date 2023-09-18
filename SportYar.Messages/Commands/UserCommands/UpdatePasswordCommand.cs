using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Messages.Commands.UserCommands
{
    public class UpdatePasswordCommand
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }


    }
}
