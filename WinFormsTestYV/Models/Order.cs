using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WinFormsTestYV.Models
{
    public class Order : INotifyPropertyChanged
    {
        static long nextId = 1;
        public event Action<long> setSumForClient;

        public Order()
        {
            ID = nextId++;
            DateAll = DateTime.Now;
        }
        [ReadOnly(true)]
        [Key, Display(AutoGenerateField = false)]
        public long ID { get; private set; }

        DateTime date { set; get; }
        public DateTime DateAll 
        {
            get => date;
            set 
            {
                if (date != value) 
                {
                    date = value;
                    OnPropertyChanged("Date");
                    OnPropertyChanged("Time");
                    OnPropertyChanged();
                }
            }
        }

        [Required(ErrorMessage = "Укажите дату")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [DisplayName("Дата")]
        public DateTime Date
        {
            get => date.Date;
            set
            {
                if (date.Date != value.Date)
                {
                    date = value.Date.Add(date.TimeOfDay);
                    OnPropertyChanged();
                }
            }
        }

        [Required(ErrorMessage = "Укажите время")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:t}")]
        [DisplayName("Время")]
        public DateTime Time
        {
            get => DateTime.MinValue.Add(date.TimeOfDay);
            set
            {
                if (date.TimeOfDay != value.TimeOfDay)
                {
                    date = date.Date.Add(value.TimeOfDay);
                    OnPropertyChanged();
                }
            }
        }

        long clientID = 0;
        [Required(ErrorMessage = "Укажите клиента")]
        [Range(1, long.MaxValue, ErrorMessage = "Укажите клиента")]
        [DisplayName("Клиент")]
        public long ClientID
        {
            get => clientID;
            set
            {
                if (clientID != value)
                {
                    long oldId = clientID;
                    clientID = value;
                    if (setSumForClient != null) 
                    {
                        setSumForClient(clientID);
                        setSumForClient(oldId);
                    }

                    OnPropertyChanged();
                }
            }
        }

        BindingList<OrderItem> oIs = new BindingList<OrderItem>();
        [DisplayName("Продукты")]
        public BindingList<OrderItem> OrderItems => oIs;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
