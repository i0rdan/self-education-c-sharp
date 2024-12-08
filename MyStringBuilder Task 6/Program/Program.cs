using MyStringBuilder_Library;

var s = new MyStringBuilder("test");
s.Append("1");
s.Append("2");
s.AppendLine();
s.Append("3");

Console.WriteLine(s);

s.Undo();

Console.WriteLine(s);

s.Undo();
s.Undo();

Console.WriteLine(s);
