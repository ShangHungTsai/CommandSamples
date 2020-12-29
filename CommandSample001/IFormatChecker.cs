namespace CommandSample001
{
    public interface IFormatChecker
    {
        CheckResult CheckFirstDate(string source);
        CheckResult CheckHead(string source);
        CheckResult CheckLength(string source);
        CheckResult CheckSecondDate(string source);
    }
}