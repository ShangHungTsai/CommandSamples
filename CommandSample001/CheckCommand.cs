using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001
{
    public abstract class CheckCommand
    {
        protected FormatChecker Checker
        { get; private set; }
        protected CheckCommand(FormatChecker checker)
        {
            Checker = checker;
        }
        public abstract CheckResult Execute(string source);
    }

    public class CheckLengthCommand : CheckCommand
    {
        public CheckLengthCommand(FormatChecker checker) : base(checker)
        {
        }

        public override CheckResult Execute(string source)
        {
            return Checker.CheckLength(source);
        }
    }

    public class CheckHeadCommand : CheckCommand
    {
        public CheckHeadCommand(FormatChecker checker) : base(checker)
        {
        }

        public override CheckResult Execute(string source)
        {
            return Checker.CheckHead(source);
        }
    }

    public class CheckFirstDateCommand : CheckCommand
    {
        public CheckFirstDateCommand(FormatChecker checker) : base(checker)
        {
        }

        public override CheckResult Execute(string source)
        {
            return Checker.CheckFirstDate(source);
        }
    }

    public class CheckSecondDateCommand : CheckCommand
    {
        public CheckSecondDateCommand(FormatChecker checker) : base(checker)
        {
        }

        public override CheckResult Execute(string source)
        {
            return Checker.CheckSecondDate(source);
        }
    }

    public class Check3DateCommand : CheckCommand
    {
        public Check3DateCommand(FormatChecker checker) : base(checker)
        {
        }

        public override CheckResult Execute(string source)
        {
            return Checker.CheckSecondDate(source);
        }
    }
}
