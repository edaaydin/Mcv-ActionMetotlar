using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _07_MVC_ActionMetotlar.Models
{
    public class Product
    {
        [Required]
        [DisplayName("No")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Urun adi alanı bos gecilemez!")]
        [DisplayName("Urun Adi")]
        public string Name { get; set; }
        [DisplayName("Stok")]
        [Range(minimum: 0, maximum: 1000)]
        [Required(ErrorMessage = "Fiyat alanı bos gecilemez!")]
        public int Stock { get; set; }

        private double _price;

        [DisplayName("Fiyat")]
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("sıfırdan kucuk deger girilmez");
            }
        }

        [DisplayName("Tarih")]
        public DateTime? Date { get; set; }

    }
}
