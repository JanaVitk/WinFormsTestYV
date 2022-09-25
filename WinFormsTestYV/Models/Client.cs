

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WinFormsTestYV.Models
{
    public class Client : INotifyPropertyChanged
    {
        static long nextId = 1;
        public Client()
        {
            ID = nextId++;
        }
       
        [ReadOnly(true)]
        [Key, Display(AutoGenerateField = false)]
        public long ID { private set; get; }

        string name;
        [Required(ErrorMessage = "Укажите имя")]
        [DisplayName("Имя")]
        public string Name 
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        string address;
        [Required(ErrorMessage = "Укажите адрес")]
        [DisplayName("Адрес")]
        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }

        string phone;
        [Required(ErrorMessage = "Укажите телефон")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Телефон")]
        public string Phone 
        {
            get => phone;
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged();
                }
            }
        }

        decimal sum;
        [ReadOnly(true)]
        [DataType(DataType.Currency)]
        [DisplayName("Сумма покупок")]
        public decimal Sum 
        {
            get => sum;
            set
            {
                if (sum != value)
                {
                    sum = value;
                    OnPropertyChanged();
                }
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
