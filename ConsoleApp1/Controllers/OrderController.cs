using System;
using System.Collections.Generic;

using Views;
using Models;
using Repository;
using System.IO;


namespace Controllers
{
    public class OrderController
    {
        private ClientController cController;
        private ProductController pController;
        public List<Order> orderList = new List<Order>(); //es para crear una orden 

        public OrderController()
        {
            this.pController = new ProductController();
            this.cController = new ClientController();
            LoadOrder();
        }
        private void LoadOrder()
        {
            orderList = Repository<Order>.ObtenerTodos(Path.Combine("Repository", "Data", "Ordenes"));
        }
        private void SaveOrders()
        {
            Repository<Order>.GuardarLista(Path.Combine("Repository", "Data", "Ordenes"), orderList);
        }
        public void CreateOrden()
        {
            var client = cController.loadClient();
            if (client == null)
            {
                OrderView.ShowMag("ERROR. Try again");
                return;
            }
            var product = pController.loadProduct();
            if (product == null)
            {
                OrderView.ShowMag("ERROR. TRY AGAIN");
                return;
            }
            Order newOrder = new Order
            {
                client = client
            };
            newOrder.productList = product;
            orderList.Add(newOrder);
            SaveOrders();
            OrderView.ShowMag("Create order correct");
        }
        public void ShowOrder()
        {
            if (orderList.Count > 0)
            {
                OrderView.ShowMag("");
                return;
            }
            int i = 0;
            foreach (var o in orderList)
            {
                Console.WriteLine($"Number to the index {i}");
                cController.ShowClient(o.client);
                Console.WriteLine("\n product: ");
                pController.ShowProductList(o.productList);
                Console.WriteLine($"Product total: {o.CalculateTotal():0.00}  Total iva: {o.CalculateTotalIVA():0.00} ");
                i++;
            }
        }
        public void ModifyOrder()
        {
            ShowOrder();
            Console.WriteLine("Enter the index to modify");
            int i = int.Parse(Console.ReadLine());
            if (i < 0 ||  i >= orderList.Count )
            {
                OrderView.ShowMag("ERROR. Intentelo de nuevo.");
                return;
            }
            var newClient = cController.loadClient();
            var newProduct = pController.loadProduct();
            orderList[i].client = newClient;
            orderList[i].productList = newProduct;
            SaveOrders();
            OrderView.ShowMag("Change correct");

        }
        public void DelateOrder()
        {
            ShowOrder();
            Console.WriteLine("Enter the index to modify");
            int i = int.Parse(Console.ReadLine());
            if (i < 0 || i >= orderList.Count)
            {
                OrderView.ShowMag("ERROR. Tray agan");
                return;
            }
            orderList.RemoveAt(i);
            SaveOrders();
            OrderView.ShowMag("Delate correct.");
        }
    }
}