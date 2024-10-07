using CodeWars1.Factory;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var types = GetAllTypesThatImplementKataInterface<IKata>();
        var classes = CreateDictionaryAndPrint(types);
        //PrintPrompt(types, classes);
        IKata kata = GetKataFromFactory(classes, Convert.ToInt16(Console.ReadLine()));
        
        while (true)
        {
            string input = Console.ReadLine();

            if (input != null)
            {
                Console.WriteLine(kata.Execute(input));
            }
        }
    }

    private static IKata GetKataFromFactory(Dictionary<int, string> classes, int chosenKata)
    {
        var kataFactory = new KataFactory();

        var kata = kataFactory.GetKata(classes[chosenKata]);

        if (kata == null)
        {
            return null;
        }

        return kata;
    }

    private static Dictionary<int, string> CreateDictionaryAndPrint(IEnumerable<Type> types)
    {
        int count = 0;
        Dictionary<int, string> classes = new Dictionary<int, string>();

        foreach (var type in types)
        {
            IKata instance = (IKata)Activator.CreateInstance(type);
            classes.Add(count, instance.GetKataName());
            Console.WriteLine(count + " " + type.Name);
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