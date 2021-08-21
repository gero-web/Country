using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Country.Models.SerializerModel
{
    public class SerializerCountry
    {
        [Required(ErrorMessage = "Поле не должно быть пустым!")]
        [DisplayName("Страна")]
        public string name { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым!")]
        [DisplayName("Столица")]
        public string capital { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым!")]
        [DisplayName("Население")]
        public int? population { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым!")]
        [DisplayName("Площадь")]
        public double? area { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым!")]
        [DisplayName("Регион")]
        public string region { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым!")]
        [DisplayName("Код страны")]
        public string numericCode { get; set; }

    }


  
}
