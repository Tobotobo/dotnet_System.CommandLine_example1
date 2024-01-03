using System.CommandLine;

var nameOption = new Option<string>(
    "--name",
    "The name of the person to greet")
{
    IsRequired = true
};

var rootCommand = new RootCommand("Sample app for System.CommandLine");
rootCommand.AddOption(nameOption);

rootCommand.SetHandler((name) =>
{
    Console.WriteLine($"Hello {name}!");
}, nameOption);

return await rootCommand.InvokeAsync(args);

