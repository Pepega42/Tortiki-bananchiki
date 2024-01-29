namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Заказ тортов");
                Console.WriteLine("Выберите параметр");
                Console.WriteLine("-----------------");
                Console.WriteLine("  Выбор формы торта");
                Console.WriteLine("  Выбор размера торта");
                Console.WriteLine("  Выбор вкуса коржей");
                Console.WriteLine("  Выбор количества коржей");
                Console.WriteLine("  Выбор глазури");
                Console.WriteLine("  Выбор декора");
                Console.WriteLine("  Завершить заказ");
                Console.WriteLine("Итоговая цена: " + Order.itogCost);
                Console.WriteLine("Ваш торт: " + Order.itogName);
                int pos = Menu.Show(3, 9);
                Order order = new Order();
                order.Or(pos);
                if (pos == 9)
                {
                    ConsoleKeyInfo key;
                    Console.WriteLine("Благодарим за заказ! Если хотите сделать ещё один, нажмите Escape");
                    do
                    {
                        key = Console.ReadKey();
                    } while (key.Key != ConsoleKey.Escape);
                    Console.Clear();
                }
            }
        }
    }
}