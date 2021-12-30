# C_Sharp_Tutorial

## Table Of Contents

* [Introduction](#Introduction)


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
