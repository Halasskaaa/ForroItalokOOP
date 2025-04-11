namespace ForroItalok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<ForroItal> lista = new List<ForroItal>();

			ForroItal f1 = new ForroItal("forrócsoki", 3, 150);
			Console.WriteLine(f1);
			f1.Aremeles();
			lista.Add(f1);

			Kave kave1 = new Kave("Hosszú kávé", 2, 250, "tejjel");
            Console.WriteLine(kave1);
			lista.Add(kave1);

			Tea tea1 = new Tea("Gyömbér tea", 0, 300, true);
            Console.WriteLine(tea1);
			lista.Add(tea1);

			foreach (var item in lista)
			{
                Console.WriteLine($"{item.Nev} - {((Tea)(item)).Citrommal}");
            }
        }
	}
}
