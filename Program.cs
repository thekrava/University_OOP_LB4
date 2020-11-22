using System;
using System.Text;

namespace KravchenkoD2_12FIT4
{
    class Program
    {
		static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.Unicode;
			Console.Title = "KravchenkoD2_12FIT4";

			Console.WriteLine("Генеруємо декілька випадкових чисел типу int...");
			Random random = new Random();
			int[] vs = {
				random.Next(),
				random.Next(),
				random.Next(),
				random.Next(),
				random.Next(),
			};
			for (int i = 0; i < vs.Length; i++)
				Console.WriteLine(vs[i]);
			Console.WriteLine("Надсилаємо їх до методу класу A...");
			new A().DebugInfo(vs[0], vs[1], vs[2], vs[3], vs[4]);
			Console.WriteLine("Надсилаємо їх до методу класу, що успадковується від A...");
			new A_B().DebugInfo(vs[0], vs[1], vs[2], vs[3], vs[4]);
			Console.WriteLine("Готово. Перегляньте вивід Debug.");
		}
	}
}

