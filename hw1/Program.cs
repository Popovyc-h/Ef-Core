namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        using var context = new ShopContext();

        var p1 = new Product
        {
            Name = "Телефон",
            Price = 3999.99m,
            Category = "Електроніка",
            InStock = true
        };

        var p2 = new Product
        {
            Name = "Ноутбук",
            Price = 10999.99m,
            Category = "Електроніка",
            InStock = true
        };

        var p3 = new Product
        {
            Name = "Пісталєтік",
            Price = 109.00m,
            Category = "Іграшки",
            InStock = false
        };

        //context.Products.AddRange(p1, p2, p3);

        context.SaveChanges();

        var products = context.Products.ToList();

        Console.WriteLine("Список всіх продуктів:");
        foreach (var p in products)
            Console.WriteLine($"{p.Id} | {p.Name} | {p.Price} | {p.Category} | {p.InStock}");

        Console.WriteLine("\nПошук за Id (Find)");

        var found = context.Products.Find(21);
        Console.WriteLine($"Знайдено: {found.Id} | {found.Name} | {found.Price} | {found.Category}");

        if (found != null)
        {
            found.Price = 333.33m;
            context.SaveChanges();
        }

        Console.WriteLine($"\nЦіну змінено: {found.Id} | {found.Name} | {found.Price}");

        if (found != null)
        {
            context.Products.Remove(found);
            context.SaveChanges();
            Console.WriteLine("\nПродукт видалено");
        }

        Console.WriteLine($"Кількість продуктів: {context.Products.Count()}");
    }
}
