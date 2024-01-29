using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Order
    {
        static public string itogName = "";
        static public int itogCost = 0;

        Podpunkt formCircle = new Podpunkt("Круглый", 500);
        Podpunkt formQuad = new Podpunkt("В виде сердечка", 500);
        Podpunkt formRect = new Podpunkt("прямоугольный", 500);
        Podpunkt formHeart = new Podpunkt("Исокадодекаэдр", 700);

        Podpunkt sizeSmall = new Podpunkt("Маленький (Диаметр - 12 см, 4 порции)", 1000);
        Podpunkt sizeMed = new Podpunkt("Обычный (Диаметр - 32 см, 8 порций)", 1200);
        Podpunkt sizeBig = new Podpunkt("Большой (Диаметр - 28 см, 24 порций)", 2000);

        Podpunkt tasteVan = new Podpunkt("Клубничный", 100);
        Podpunkt tasteChoc = new Podpunkt("Малиновый", 100);
        Podpunkt tasteCar = new Podpunkt("Мультифруктовый", 150);
        Podpunkt tasteBer = new Podpunkt("Шоколадный", 200);
        Podpunkt tasteCoc = new Podpunkt("Бананчики", 250);

        Podpunkt count1 = new Podpunkt("1 корж", 200);
        Podpunkt count2 = new Podpunkt("2 коржа", 400);
        Podpunkt count3 = new Podpunkt("3 коржа", 600);
        Podpunkt count4 = new Podpunkt("4 коржа", 800);

        Podpunkt glazeChoc = new Podpunkt("Ягоды", 100);
        Podpunkt glazeCream = new Podpunkt("Крем", 100);
        Podpunkt glazeBeze = new Podpunkt("Бананчики", 150);
        Podpunkt glazeDrage = new Podpunkt("Орехи", 150);
        Podpunkt glazeBer = new Podpunkt("Цитрусы", 200);

        Podpunkt decChoc = new Podpunkt("Шоколадный", 150);
        Podpunkt decBer = new Podpunkt("Ягодный", 150);
        Podpunkt decCream = new Podpunkt("Бананчики", 150);

        
        public void Or(int p)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт");
            Console.WriteLine("--------------------------");
            if (p == 3)
            {
                Console.WriteLine("  " + formCircle.name + " - " + formCircle.cost);
                Console.WriteLine("  " + formQuad.name + " - " + formQuad.cost);
                Console.WriteLine("  " + formRect.name + " - " + formRect.cost);
                Console.WriteLine("  " + formHeart.name + " - " + formHeart.cost);
                int pospod = Menu.Show(3, 6);
                if (pospod == 3)
                {
                    itogCost += formCircle.cost;
                    itogName += formCircle.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 4)
                {
                    itogCost += formQuad.cost;
                    itogName += formQuad.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 5)
                {
                    itogCost += formRect.cost;
                    itogName += formRect.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 6)
                {
                    itogCost += formHeart.cost;
                    itogName += formHeart.name + "; ";
                    Console.Clear();
                }
            }
            else if (p == 4)
            {
                Console.WriteLine("  " + sizeSmall.name + " - " + sizeSmall.cost);
                Console.WriteLine("  " + sizeMed.name + " - " + sizeMed.cost);
                Console.WriteLine("  " + sizeBig.name + " - " + sizeBig.cost);
                int pospod = Menu.Show(3, 5);
                if (pospod == 3)
                {
                    itogCost += sizeSmall.cost;
                    itogName += sizeSmall.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 4)
                {
                    itogCost += sizeMed.cost;
                    itogName += sizeMed.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 5)
                {
                    itogCost += sizeBig.cost;
                    itogName += sizeBig.name + "; ";
                    Console.Clear();
                }
            }
            else if (p == 5)
            {
                Console.WriteLine("  " + tasteVan.name + " - " + tasteVan.cost);
                Console.WriteLine("  " + tasteChoc.name + " - " + tasteChoc.cost);
                Console.WriteLine("  " + tasteCar.name + " - " + tasteCar.cost);
                Console.WriteLine("  " + tasteBer.name + " - " + tasteBer.cost);
                Console.WriteLine("  " + tasteCoc.name + " - " + tasteCoc.cost);
                int pospod = Menu.Show(3, 7);
                if (pospod == 3)
                {
                    itogCost += tasteVan.cost;
                    itogName += tasteVan.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 4)
                {
                    itogCost += tasteChoc.cost;
                    itogName += tasteChoc.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 5)
                {
                    itogCost += tasteCar.cost;
                    itogName += tasteCar.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 6)
                {
                    itogCost += tasteBer.cost;
                    itogName += tasteBer.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 7)
                {
                    itogCost += tasteCoc.cost;
                    itogName += tasteCoc.name + "; ";
                    Console.Clear();
                }
            }
            else if (p == 6)
            {
                Console.WriteLine("  " + count1.name + " - " + count1.cost);
                Console.WriteLine("  " + count2.name + " - " + count2.cost);
                Console.WriteLine("  " + count3.name + " - " + count3.cost);
                Console.WriteLine("  " + count4.name + " - " + count4.cost);
                int pospod = Menu.Show(3, 6);
                if (pospod == 3)
                {
                    itogCost += count1.cost;
                    itogName += count1.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 4)
                {
                    itogCost += count2.cost;
                    itogName += count2.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 5)
                {
                    itogCost += count3.cost;
                    itogName += count3.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 6)
                {
                    itogCost += count4.cost;
                    itogName += count4.name + "; ";
                    Console.Clear();
                }
            }
            else if (p == 7)
            {
                Console.WriteLine("  " + glazeChoc.name + " - " + glazeChoc.cost);
                Console.WriteLine("  " + glazeCream.name + " - " + glazeCream.cost);
                Console.WriteLine("  " + glazeBeze.name + " - " + glazeBeze.cost);
                Console.WriteLine("  " + glazeDrage.name + " - " + glazeDrage.cost);
                Console.WriteLine("  " + glazeBer.name + " - " + glazeBer.cost);
                int pospod = Menu.Show(3, 7);
                if (pospod == 3)
                {
                    itogCost += glazeChoc.cost;
                    itogName += glazeChoc.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 4)
                {
                    itogCost += glazeCream.cost;
                    itogName += glazeCream.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 5)
                {
                    itogCost += glazeBeze.cost;
                    itogName += glazeBeze.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 6)
                {
                    itogCost += glazeDrage.cost;
                    itogName += glazeDrage.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 7)
                {
                    itogCost += glazeBer.cost;
                    itogName += glazeBer.name + "; ";
                    Console.Clear();
                }
            }
            else if (p == 8)
            {
                Console.WriteLine("  " + decChoc.name + " - " + decChoc.cost);
                Console.WriteLine("  " + decBer.name + " - " + decBer.cost);
                Console.WriteLine("  " + decCream.name + " - " + decCream.cost);
                int pospod = Menu.Show(3, 5);
                if (pospod == 3)
                {
                    itogCost += decChoc.cost;
                    itogName += decChoc.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 4)
                {
                    itogCost += decBer.cost;
                    itogName += decBer.name + "; ";
                    Console.Clear();
                }
                else if (pospod == 5)
                {
                    itogCost += decCream.cost;
                    itogName += decCream.name + "; ";
                    Console.Clear();
                }
            }
            else if (p == 9)
            {
                Zapis();
                Console.Clear();
            }
        }
        private void Zapis()
        {
            File.AppendAllText("История заказов.txt", "\nЗаказ от " + DateTime.Now);
            File.AppendAllText("История заказов.txt", "\nЗаказ: " + itogName);
            File.AppendAllText("История заказов.txt", "\nЦена заказа: " + itogCost);
        }
    }
}
