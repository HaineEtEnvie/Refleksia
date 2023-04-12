public class SamplesArray
{

    public static void Main()
    {
        foreach (var m in typeof(ArraySegment<>).GetMethods())
        {
            Console.WriteLine($"{m.Name} {nameof(m.IsAbstract)} - {m.IsAbstract} {nameof(m.IsFamily)} - {m.IsFamily} {nameof(m.IsFamilyAndAssembly)} - {m.IsFamilyAndAssembly} {nameof(m.IsFamilyOrAssembly)} - {m.IsFamilyOrAssembly} {nameof(m.IsAssembly)} - {m.IsAssembly} {nameof(m.IsPrivate)} - {m.IsPrivate} {nameof(m.IsPublic)} - {m.IsPublic} {nameof(m.IsConstructor)} - {m.IsConstructor} {nameof(m.IsStatic)} - {m.IsStatic} {nameof(m.IsVirtual)} - {m.IsVirtual} {nameof(m.ReturnType)} - {m.ReturnType}");
        }
        foreach (var c in typeof(ArraySegment<>).GetConstructors())
        {
            Console.WriteLine($"{c.Name} {nameof(c.IsFamily)} - {c.IsFamily} {nameof(c.IsFamilyAndAssembly)} - {c.IsFamilyAndAssembly} {nameof(c.IsFamilyOrAssembly)} - {c.IsFamilyOrAssembly} {nameof(c.IsAssembly)} - {c.IsAssembly} {nameof(c.IsPrivate)} - {c.IsPrivate} {nameof(c.IsPublic)} - {c.IsPublic} ");
        }

        foreach (var f in typeof(ArraySegment<>).GetFields())
        {
            Console.WriteLine($"{f.Name} {nameof(f.IsFamily)} - {f.IsFamily} {nameof(f.IsFamilyAndAssembly)} - {f.IsFamilyAndAssembly} {nameof(f.IsFamilyOrAssembly)} - {f.IsFamilyOrAssembly} {nameof(f.IsAssembly)} - {f.IsAssembly} {nameof(f.IsPrivate)} - {f.IsPrivate} {nameof(f.IsPublic)} - {f.IsPublic} ");
        }
        foreach (var v in typeof(ArraySegment<>).GetProperties())
        {
            Console.WriteLine($"{v.Name} {nameof(v.Attributes)} - {v.Attributes} {nameof(v.CanRead)} - {v.CanRead} {nameof(v.CanWrite)} - {v.CanWrite} {nameof(v.GetMethod)} - {v.GetMethod} {nameof(v.SetMethod)} - {v.SetMethod} {nameof(v.PropertyType)} - {v.PropertyType}");
        }
        Console.ReadKey();
    }
}