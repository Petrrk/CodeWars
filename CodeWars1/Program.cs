using CodeWars1.Factory;
using CodeWars1.Factory.Entities;
using CodeWars1.Utilities;
using System.Reflection;

internal class Program
{
    private static ConsoleHelper consoleHelper = new ConsoleHelper();

    private static void Main(string[] args)
    {
        var types = GetAllTypesThatImplementKataInterface<IKata>();
        var classes = CreateDictionaryAndPrint(types);
        IKata kata = GetKataFromFactory(classes);
        
        while (true)
        {
            string input = Console.ReadLine();

            if (input != null)
            {
                Console.WriteLine(kata.Execute(input));
            }
        }
    }

    private static IKata GetKataFromFactory(Dictionary<int, KataName> classes)
    {
        var chosenKata = Console.ReadLine();
        
        if (int.TryParse(chosenKata, out int i) || chosenKata is not null)
        {
            var kataFactory = new KataFactory();

            var kata = kataFactory.GetKata(classes[Convert.ToInt32(chosenKata)]);

            return kata ?? null;
        };
        
        throw new Exception("CISLO!!!!");
    }

    private static Dictionary<int, KataName> CreateDictionaryAndPrint(IEnumerable<Type> types)
    {
        int count = 0;
        Dictionary<int, KataName> classes = new Dictionary<int, KataName>();
        KataName kataName;

        foreach (var type in types)
        {
            IKata instance = (IKata)Activator.CreateInstance(type);
            kataName = instance.GetKataName();
            classes.Add(count, kataName);
            Console.WriteLine(count + " " + kataName.GetDescription() + " - " + instance.CompletionStatus.GetDescription());
            count++;
        }
        Console.WriteLine("\n");

        return classes;
    }

    private static IEnumerable<Type> GetAllTypesThatImplementKataInterface<T>()
    {
        return Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => typeof(T).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);
    }
}