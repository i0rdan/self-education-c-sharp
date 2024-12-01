## Calculator

### Short Description
Create a console application that simulates a simple calculator.

### Requirements
1. The calculator should have four methods: `Add`, `Subtract`, `Multiply` and `Divide`, each taking two double parameters and returning a double result.
2. The calculator should also have an event called `CalculationPerformed`, which is triggered whenever a calculation is performed.
3. The event should have a delegate type called `CalculationHandler`, which takes one parameter of type `CalculatorEventArgs` and returns `void`.
4. The type `CalculatorEventArgs` is a custom class, which inherits from `EventArgs` and has three properties: `Operand1`, `Operand2` and `Result`.
5. The main program should create an instance of the calculator class and subscribe to the `CalculationPerformed` event with a method called `OnCalculationPerformed`, which prints the operands and the result to the console.
6. The main program should prompt the user to enter two numbers and an operator (+, -, *, /) and perform the corresponding calculation using the calculator methods.
7. The program should handle any invalid input or exceptions gracefully.

### Example
```
Enter two numbers and an operator (+, -, *, /):
5 3 +
The result is 8

Enter two numbers and an operator (+, -, *, /):
10 2 /
The result is 5

Enter two numbers and an operator (+, -, *, /):
6 0 /
Cannot divide by zero

Enter two numbers and an operator (+, -, *, /):
a b *
Invalid input
```
