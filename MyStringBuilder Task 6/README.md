## Undo string builder

### Short Description
Create a string builder with support for undo operation.

### Requirements
1. Code style
2. Write your StringBuilder class with support for the undo operation.
3. Delegate all methods to the standard StringBuilder, and in your own class store a list of all operations for executing `undo()`.
4. Use the [Command pattern](https://www.csharptutorial.net/csharp-design-patterns/csharp-command-pattern/).

### Example
```cs
var stringBuilder = new StringBuilder("test");
stringBuilder.Append("1");
stringBuilder.Append("2");
stringBuilder.Append("3");

stringBuilder.Undo();
stringBuilder.Undo();

stringBuilder.ToString(); //test1
```
