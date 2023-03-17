﻿using ShapeFactory;

var app = new App(new Provider(), new Painter(),
                  new Checker(), new Printer());

Welcome();
Console.WriteLine("");
app.Run();
Console.WriteLine("");
Wait();
Console.WriteLine("");
SeeYouSoon();


static void Welcome()
{
    Console.WriteLine("Welcome to ShapesApp.");
}

static void Wait()
{
    Console.WriteLine("Waiting Input.");
    Console.ReadKey();
    Console.WriteLine("");
}

static void SeeYouSoon()
{
    Console.WriteLine("See You Soon.");
}