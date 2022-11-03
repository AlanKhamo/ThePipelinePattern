// See https://aka.ms/new-console-template for more information

using StringCompression;
using System.Reflection;

SequentialStringCompression num = new SequentialStringCompression("ABC", 25000,100000);

var letters = num.Generate(100000);

var compress = num.Compress("hi world");

var update = num.UpdateCompressionStats(5,"ABC","ABC");

Console.WriteLine(update);

