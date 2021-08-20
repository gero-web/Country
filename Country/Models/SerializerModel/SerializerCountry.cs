using System.ComponentModel;


namespace Country.Models.SerializerModel
{
    public class SerializerCountry
    {
        [DisplayName("Страна")]
        public string name { get; set; }

        [DisplayName("Столица")]
        public string capital { get; set; }

        [DisplayName("Население")]
        public int? population { get; set; }

        [DisplayName("Площадь")]
        public double? area { get; set; }

        [DisplayName("Регион")]
        public string region { get; set; }

        [DisplayName("Код страны")]
        public string numericCode { get; set; }

    }


  
}
