using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001
{
    public class Client
    {
        public static Invoker CreateInvoker()
        {
            FormatChecker checker = new FormatChecker();
            Invoker invoker = new Invoker();
            invoker.AddCommand(new CheckLengthCommand(checker));
            invoker.AddCommand(new CheckHeadCommand(checker));
            invoker.AddCommand(new CheckFirstDateCommand(checker));
            invoker.AddCommand(new CheckSecondDateCommand(checker));
            return invoker;
        }


    }
}
