# C_Sharp_Tutorial

## Table Of Contents

* [Introduction](#Introduction)
* [Installation](#Installation)
* [Hello-World](#hello-world)
* [variables-Constants](#variables-and-constants)
* [Data-types](#datatypes)
* [Operators](#operators)
* [User-Input](#user-input)
* [Arrays](#arrays)
* [Lists](#lists)
* [Strings](#strings)
* [Conditional Statements](#conditional-statements)
* [Loops](#loops)


## Introduction

- C# is a programming language, while .NET is a framework. 
- .NET framework consists of a common-language run-time environment (CLR) and a class library that we use for building applications.

## CLR (Common Language Runtime)
- .NET provides a run-time environment, called the common language runtime, that runs the code and provides services that make the development process easier.
- When you compile an application, C# compiler compiles your code to IL (Intermediate Language) code. IL code is platform agnostics, which makes it possible to a take a C# program on a different computer with different hardware architecture and operating system and run it. For this to happen, we need CLR. When you run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. This process is called Just-in-time Compilation (JIT).

<img src="https://github.com/Yash-1511/C_Sharp_Tutorial/blob/master/images/Working_CLR.jpg" height="280px">

## Installation

- To write C# code, you need Microsoft Visual Studio. Visual Studio comes in different editions: 
Community, Professional and Ultimate. 
- As an individual, or a student or a small team, you can download Visual Studio Community Edition 
for free and build your free or paid apps with it. To download Visual Studio Community Edition, 
- please visit: [click here](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)

## Hello World
```cs
using System;

namespace Tutorial
{   
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
        }
    }
}
```
## Variables And Constants

- Variables : variables is a container for storing data values.
- Constants : A constant is a value that cannot be changed

To define a variable, We specify a type and a identifier:
```cs
int number = 5;
```
>**Remember:**<br>
> in C#, you cannot read the value of a variable unless you have set it before.

constants:
```cs
const float PI = 3.14;
```
## Datatypes

- [Primitive-types](#primitive-types)
- [Non-Primitive-types](#non-primitive-types)

## Primitive Types

<img src="https://github.com/Yash-1511/C_Sharp_Tutorial/blob/master/images/primitive.png" height="240px">

## Non-primitive Types

<img src="https://github.com/Yash-1511/C_Sharp_Tutorial/blob/master/images/non_primitive.png" height="240px">

## Overflowing
- Each type, depending on the number of types allocated to it, can store a range of values.
- If we 
store a value in a variable, but that value exceeds the boundary of values for the underlying type, 
overflow happens. 

```cs
byte b = 255;
b = b + 1;
```
As a result of the second line, the value of b will be 0.

## Comments

```cs
//this is single line comment.
/* This is multiline 
comment*/
```

<hr>

## Operators

- Arithmetic Operators
- Comparison Operators
- Assignment Operators
- Logical Operators
- Bitwise Opeartors

1. Arithmetic Operators

| Opearator  | Description |
| ------------- | ------------- |
|  +  | Addition  |
|  -  | Subtraction  |
|  *  | Multiplication  |
|  /  | Division  |
|  %  | Modulo  |
|  ++  | Increment by 1  |
|  --  | Decrement by 1  |

2. Comparison Operators

| Opearator  | Description |
| ------------- | ------------- |
|  ==  | Equal to  |
|  != | Not Equal  |
|  >  | Greater than  |
|  < | Less than  |
|  >= | Greater than or equal to  |
|  <=  | Less than or equal to  |

3. Assignment Operators

| Opearator  | Description |
| ------------- | ------------- |
|  =  | Assignment  |
|  += | Addition Assignment  |
|  -=  | Subtraction Assignment  |
|  *= | Multiplication Assignment   |
|  /= | Divisionn Assignment   |

4. Logical Operators

| Opearator  | Description |
| ------------- | ------------- |
|  &&  | AND  |
|   | OR  |
|  ! | NOT | 

<hr>

## User Input

- we will use `Console.ReadLine()` to get user input.

```cs
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

Console.WriteLine("Username is: " + userName);
```
- The `Console.ReadLine()` method returns a string. Therefore, you cannot get information from another data type, such as int.

- you can typecast to get another type input.
```cs
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
```

<hr>


## Conditional Statements

- [if](#the-if-statement) 
- [else](#the-else-statement) 
- [else-if](#the-else-if-statement)
- [switch](#switch-statement)

<hr>

### The if statement

- Use the if statement to specify a block of C# code to be executed if a condition is True.

```cs
if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}
```

<hr>

### The else Statement

- Use the else statement to specify a block of code to be executed if the condition is False.

```cs
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."
```

<hr>

### The else if Statement

- Use the else if statement to specify a new condition if the first condition is False.

```cs
int time = 22;
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."
```

### Short Hand If...Else (Ternary Operator)

syntax
```cs
variable = (condition) ? expressionTrue :  expressionFalse;
```

```cs
string result = (time < 18) ? "Good day." : "Good evening.";
```

<hr>

### Switch Statement

- Use the switch statement to select one of many code blocks to be executed.

```cs
int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)
```

<hr>

## Loops

- Loops can execute a block of code as long as a specified condition is reached.

1. [While Loop](#while-loop)
2. [Do/while Loop](#do/while-loop)
3. [For Loop](#for-loop)
4. [foreach Loop](#foreach-loop)

<hr>

### While Loop

- The while loop loops through a block of code as long as a specified condition is True:

```cs
int i = 0;
while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}
```

>**Note:**<br>
> Do not forget to increase the variable used in the condition, otherwise the loop will never end!

<hr>

### Do/While Loop

- The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

```cs
int i = 0;
do 
{
  Console.WriteLine(i);
  i++;
}
while (i < 5);
```

<hr>

### For Loop

- When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:

```cs
for(int i=0;i<5;i++)
{
  Console.WriteLine(i);
}
```

<hr>

### foreach Loop

- There is also a foreach loop, which is used exclusively to loop through elements in an array

```cs
var item = new int[] {1,2,3,4};
foreach(var i in item)
{
  Console.WriteLine(i);
}
```
<hr>

## Arrays

- Arrays are used to store multiple values in a single variable.

- Declaration

```cs
//First Way
string[] Car = new string[3];
//second way
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
//third way
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
//fourth way
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```
### Access the Elements of an Array

```cs
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
// Outputs Volvo
```
>**Note:**<br>
> Array indexes start with 0: [0] is the first element. [1] is the second element, etc.

### Methods And Property

<hr>

1. Length Property
```cs
var numbers = new[] {3,4,6,5,7,9};
Console.WriteLine("Length: "+numbers.Length);
//output : 6
```

<hr>

2. IndexOf()
- find position of element in an array. return index of the element.
```cs
var index = Array.IndexOf(numbers,4);
Console.WriteLine(index)
//return 1
```

<hr>

3. Clear()
- Sets a range of elements in an array to the default value of each element type.

```cs
Array.Clear(numbers,0,2)
//start index is 0
//end index is 2 (not included)
```

<hr>

4. Copy()
-	Copies a range of elements in one Array to another Array and performs type casting and boxing as required.
```cs
int[] another = new int[3];
Array.Copy(numbers,another,3);
//here numbers is the source array
//destination array is named another.
//3 element will be copied to another array.
```
<hr>

5. Sort()
- Sorts the elements in a one-dimensional array.

```cs
Array.Sort(numbers);
```

<hr>

6. Reverse()

- Reverses the order of the elements in a one-dimensional Array or in a portion of the Array.

```cs
Array.Reverse(numbers)
```

- View Full Methods and Properties of Array Class
* [Microsoft-Documentation-on-Array](https://docs.microsoft.com/en-us/dotnet/api/system.array?view=net-5.0)

<hr>

## Lists

- list is a generic type
- ```Array``` - Fixed Size
- ```List``` - Dynamic Size

### Creating List

```cs
var mylist = new List<int>();
```

<hr>

### Useful Methods

1. Add()
- Add elements in a list

```cs
mylist.Add(1);
mylist.Add(2);
```

<hr>

2. Insert()
- Use the Insert() method inserts an element into the List collection at the specified index.
```cs
mylist.Insert(1,23);
```

<hr>

3. Remove()
- Use Remove() method to remove element from the List
```cs
mylist.Remove(1);
```

<hr>

4. RemoveAt()
- Use RemoveAt() method to remove element from specified index.
```cs
mylist.RemoveAt(2)
//remove third element (index starts from 0)
```

<hr>

5. Check Element in List

- Use the Contains() method to determine whether an element is in the List or not.

```cs
var numbers = new List<int>(){ 10, 20, 30, 40 };
numbers.Contains(10); // returns true
numbers.Contains(11); // returns false
```

<hr>

6. Count
- Returns the total number of elements exists in the List.

```cs
var numbers = new List<int>(){ 10, 20, 30, 40 };
Console.WriteLine("Count : "+numbers.Count);
//return 4
```

<hr>

## Object Oriented Programming

<hr>

### Class

- A Class is like an object constructor, or a "blueprint" for creating objects.
#### Anatomy of a class
- Data (represented by fields)
- Behaviour (representd by methods/function)


### Object

- An instance of a class