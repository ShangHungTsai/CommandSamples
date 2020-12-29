using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001
{
    public class Invoker
    {
        private List<CheckCommand> _commands = new List<CheckCommand>();

        public void AddCommand(CheckCommand command)
        {
            _commands.Add(command);
        }

        public void RemoveCommand(CheckCommand command)
        {
            _commands.Remove(command);
        }

        public CheckResult Action(string source)
        {
            CheckResult result = null;
            foreach (var command in _commands)
            {
                result = command.Execute(source);
                if (result.Result == false)
                {
                    break;
                }
            }
            return result;
        }
    }
}
