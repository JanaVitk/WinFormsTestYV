using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WinFormsTestYV.Models
{
    public class Product
    {
        static long nextId = 1;
        public Product()
        {
            ID = nextId++;
        }

        [ReadOnly(true)]
        [Key, Display(AutoGenerateField = false)]
        public long ID { get; private set; }

        [Required(ErrorMessage = "Укажите найменование")]
        [DisplayName("Найменование")]
        public string Name { set; get; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Укажите цену")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Цена должна быть больше или равно 0.01")]
        [DisplayName("Цена в текущий момент")]
        public decimal PriceNow { set; get; }
    }
}
