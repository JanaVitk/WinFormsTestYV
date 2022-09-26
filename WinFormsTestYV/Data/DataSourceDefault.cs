using DevExpress.Mvvm.Native;
using System;
using System.ComponentModel;
using System.Linq;
using WinFormsTestYV.Models;

namespace WinFormsTestYV.Data
{
    public class DataSourceDefault
    {
        public BindingList<Client> Clients = new BindingList<Client>
        {
            new Client{ Name = "Петров Михаил", Address = "Краснодар", Phone = "(777)124-3345"  },
            new Client{ Name = "Иванова Дарья", Address = "Уфа", Phone = "(734)589-4546"  },
            new Client{ Name = "Сидоров Константин", Address = "Москва", Phone = "(123)454-3345"  },
            new Client{ Name = "Горохов Василий", Address = "Енергодар", Phone = "(111)588-3345"  },
            new Client{ Name = "Рабочий Слава", Address = "Краснодар", Phone = "(887)696-3345"  }
        };

        public BindingList<Product> Products = new BindingList<Product>
        {
            new Product{ Name = "Сахар", PriceNow = 66},
            new Product{ Name = "Соль", PriceNow = 22},
            new Product{ Name = "Хлеб", PriceNow = 32.5M},
            new Product{ Name = "Колбаса", PriceNow = 200},
            new Product{ Name = "Макороны", PriceNow = 60},
            new Product{ Name = "Гречка", PriceNow = 72},
            new Product{ Name = "Мясо", PriceNow = 245},
            new Product{ Name = "Картофель", PriceNow = 35},
            new Product{ Name = "Лук", PriceNow = 21},
            new Product{ Name = "Морковь", PriceNow = 32}
        };

        public BindingList<Order> Orders = new BindingList<Order>();
        public BindingList<OrderItem> OrderItems = new BindingList<OrderItem>();

        public DataSourceDefault()
        {

            Order order = new Order()
            {
                Date = DateTime.Now.AddDays(-5),
                ClientID = Clients.FirstOrDefault().ID
            };
            order.setSumForClient += SetSumClient;

            OrderItem oi = new OrderItem()
            {
                Count = 2,
                Price = 40,
                OrderID = order.ID,
                ProductID = Products.FirstOrDefault().ID
            };
            oi.getPriceFromProduct += GetPrice;
            oi.setSumForClient += SetSumClientFromOrder;
            oi.getClient += GetClient;
            oi.getOrder += GetOrder;
            oi.getProduct += GetProduct;

            Orders.Add(order);
            order.OrderItems.Add(oi);
            OrderItems.Add(oi);
            Orders.ForEach(o => SetSumClient(o.ClientID));
        }

        public bool UsedCliend(long id)
        {
            return Orders.FirstOrDefault(e => e.ClientID == id) != null;
        }

        public bool UsedProduct(long id)
        {
            return OrderItems.FirstOrDefault(e => e.ProductID == id) != null;
        }

        public void SetSumClient(long idClient)
        {
            Client client = Clients.Where(e => e.ID == idClient).FirstOrDefault();
            if (client == null)
                return;
            client.Sum = OrderItems
                .Join(Orders,
                    orderI => orderI.OrderID,
                    order => order.ID,
                    (oi, o) => new { idClient = o.ClientID, count = oi.Count, price = oi.Price })
                .Where(o => o.idClient == idClient)
                .Sum(o => o.count * o.price);
        }

        public void SetSumClientFromOrder(long idOrder)
        {
            Order order = Orders.FirstOrDefault(o => o.ID == idOrder);
            if (order != null)
                SetSumClient(order.ClientID);
        }
        public decimal GetPrice(long idProduct)
        {
            Product product = Products
                .Where(p => p.ID == idProduct)
                .FirstOrDefault();
            return product == null ? 0 : product.PriceNow;
        }

        public Product GetProduct(long idProduct)
        {
            return Products
                .Where(p => p.ID == idProduct)
                .FirstOrDefault();
        }

        public Client GetClient(long idClient)
        {
            return Clients
                .Where(c => c.ID == idClient)
                .FirstOrDefault();
        }

        public Order GetOrder(long idOrder)
        {
            return Orders
                .Where(o => o.ID == idOrder)
                .FirstOrDefault();
        }

    }
}
