using System;
using System.Collections.Generic;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public static class ProductView
    {
        public static List<Product> inputProductList()
        {
            List<Product> list = new List<Product>(); 
            
            string input;

            do
            {
                try
                {
                    Console.WriteLine("Nombre del producto: ");
                    string Name = getValidInput();

                    Console.WriteLine("Precio: ");
                    double Price = double.Parse(getValidInput(true));

                    Console.WriteLine("Descripcion: ");
                    string Desc = getValidInput();

                    list.Add(new Product(Name, Price, Desc));
                }
                catch (FormatException)
                {
                    Console.WriteLine("[Error] El precio debe ser un numero valido");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] No se pudo agregar el producto: {ex.Message}");
                }
                Console.Write("Agregar otro producto? (s/n)");
                input = getValidInput().ToLower();
            } while (input == "s");
            return list;
        }
        public static void ShowProductList(List<Product> list)
        {
            foreach (var p in list)
            {
                Console.WriteLine($"{p.Name} - ${p.Price:0.00} ({p.Desc}) | Final con IVA: ${p.FinalPrice():0.00}");
            }
        }
        public static string getValidInput(bool isNumeric = false, bool isEmail = false)
        {
            bool valueIsGood = false;
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if(isNumeric && double.TryParse(userInput, out double parsedValue) && !string.IsNullOrEmpty(userInput))
                {
                    valueIsGood = true;
                }
                else if (!isNumeric && !string.IsNullOrEmpty(userInput) && !isEmail)
                
                {
                    valueIsGood = true;
                }
                else if (!isNumeric && !string.IsNullOrEmpty(userInput) && isEmail && userInput.Contains("@"))

                {
                    valueIsGood = true;
                }
                else
                {
                    Console.WriteLine("Invalido, intente nuevamente");
                }
            } while (!valueIsGood);

            return userInput;
        }
    }
}
