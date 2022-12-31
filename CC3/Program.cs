
using CC3;
using Microsoft.Extensions.DependencyInjection;

var builder = new ServiceCollection()
    .AddSingleton<Application, Application>()
    .AddSingleton<IParser, Parser>()
    .BuildServiceProvider();

Application app = builder.GetRequiredService<Application>();
Console.WriteLine("Please input a sentence:");
Console.WriteLine($"Output: {app.ParseSentence(Console.ReadLine())}");