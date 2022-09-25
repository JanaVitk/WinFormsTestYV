
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WinFormsTestYV.Models
{
    public class OrderItem : INotifyPropertyChanged
    {
        static long nextId = 1;
        public event Action<long> setSumForClient;
        public event Func<long, decimal> getPriceFromProduct;

        public event Func<long, Client> getClient;
        public event Func<long, Product> getProduct;
        public event Func<long, Order> getOrder;
        public OrderItem()
        {
            ID = nextId++;
            Count = 1;
        }
        [ReadOnly(true)]
        [Key, Display(AutoGenerateField = false)]
        public long ID { get; private set; }

        long orderId;
        [Required(ErrorMessage = "Укажите заказ")]
        [DisplayName("Заказ")]
        public long OrderID
        {
            get => orderId;
            set
            {
                if (orderId != value)
                {
                    orderId = value;
                    var oldId = orderId;
                    if (setSumForClient != null) 
                    {
                        setSumForClient(orderId);
                        setSumForClient(oldId);
                    }  

                    OnPropertyChanged();
                }
            }
        }

        long productID = 0;
        [Required(ErrorMessage = "Укажите продукт")]
        [Range(1, long.MaxValue, ErrorMessage = "Укажите продукт")]
        [DisplayName("Продукты")]
        public long ProductID
        {
            get => productID;
            set
            {
                if (productID != value)
                {
                    long oldId = productID;
                    productID = value;
                    if(getPriceFromProduct != null &&
                        (Price == 0 || oldId > 0))
                        Price = getPriceFromProduct(ProductID);
                    OnPropertyChanged();
                }
            }
        }

        int count;
        [Required(ErrorMessage = "Укажите количество")]
        [Range(1, int.MaxValue)]
        [DisplayName("Количество")]
        public int Count
        {
            get => count;
            set
            {
                if (count != value)
                {
                    count = value;
                    if(setSumForClient != null)
                        setSumForClient(orderId);
                    OnPropertyChanged();
                }
            }
        }

        decimal price;
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Укажите цену")]
        [Range(0, long.MaxValue)]
        [DisplayName("Цена")]
        public decimal Price
        {
            get => price;
            set
            {
                if (price != value)
                {
                    price = value;
                    if (setSumForClient != null)
                        setSumForClient(orderId);
                    OnPropertyChanged();
                }
            }
        }

        public Client Client
        {
            get 
            {
                if (Order != null && getClient != null)
                    return getClient(Order.ClientID);
                return null;
            }
        }

        public Product Product
        {
            get {
                if (getProduct != null)
                    return getProduct(ProductID);
                return null;
            }
        }

        public Order Order
        {
            get 
            {
                if (getOrder != null)
                    return getOrder(OrderID);
                return null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
