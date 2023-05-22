namespace Operatorok; 

internal class Program
{
    static void Main(string[] args)
    {
        List<Kifejezes> kifejezesek = File.ReadAllLines("../../../kifejezesek.txt").Select(G => new Kifejezes(G.Split())).ToList();

        Console.WriteLine($"2. feladat: Kifejezések száma: {kifejezesek.Count}");
        Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {kifejezesek.Count(G=>G.Operator=="mod")}");
        Console.WriteLine($"4. feladat: {(kifejezesek.Any(G=>G.ASzam%10 == 0 && G.BSzam%10 == 0) ? "Van" : "Nincs")} ilyen kifejezés!");
        Console.WriteLine($"5. feladat: Statisztika");
        kifejezesek.Where(G => Kifejezes.HasznalhatoOperatorok.Contains(G.Operator)).GroupBy(G => G.Operator).ToList().ForEach(G => Console.WriteLine($"\t{G.Key} -> {G.Count()}"));
        string kifejezes = "";
        while (kifejezes != "vége")
        {
            Console.Write($"7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
            kifejezes = Console.ReadLine() ?? "vége";
            if(kifejezes != "vége")
                Console.WriteLine(Kifejezes.KifejezesMeghatarozasa(new(kifejezes.Split())));
        };
        File.WriteAllLines("../../../eredmenyek.txt", kifejezesek.Select(G=> Kifejezes.KifejezesMeghatarozasa(G)));
        Console.WriteLine($"8. feladat: eredmenyek.txt");
    }
}