using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public class ClientView
    {

        public static Client InputCLient()
        {
            try
            {
                Console.Write("Name: ");
                string Name = getValidInput();
                Console.Write("LastName: ");
                string LastName = getValidInput();
                Console.Write("Dni: ");
                string ID = getValidInput();
                Console.Write("Address: ");
                string Address = getValidInput();
                Console.Write("Email: ");
                string Email = getValidInput();

                return new Client(Name, LastName, ID, Address, Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] No se puedo cargar el cliente {ex.Message}");
                return null;
            }
        }
         public static void ShowClient(Client c)
        {
            Console.WriteLine($"{c.Name} {c.LastName}|{c.ID}|{c.Adress}|{c.Email}");
        }

        public static string getValidInput(bool isNumeric = false, bool isEmail = false)
        {
            bool valueIsGood = false;
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                if (isNumeric && double.TryParse(userInput, out double parsedValue) && !string.IsNullOrEmpty(userInput))
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
                    Console.WriteLine("Invalid, intente nuevamente");
                }

            }while (!valueIsGood);

            return userInput;
        }
    }
}
