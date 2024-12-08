using MyStringBuilder_Library.MyStringBuilderCommands;

namespace MyStringBuilder_Library
{
    public static class MyStringBuilderExtensions
    {
        public static MyStringBuilder Append(this MyStringBuilder mySb, string text)
        {
            mySb.ExecuteCommand(new AppendCommand(text));

            return mySb;
        }

        public static MyStringBuilder AppendLine(this MyStringBuilder mySb)
        {
            mySb.ExecuteCommand(new AppendLineCommand());

            return mySb;
        }

        public static MyStringBuilder Clear(this MyStringBuilder mySb)
        {
            mySb.ExecuteCommand(new ClearCommand(mySb.ToString()));

            return mySb;
        }
    }
}
