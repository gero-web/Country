using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Country.Models.CountryModel
{
    public class Countrys
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Страна")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Код страны")]
        public string CodeCountry { get; set; }

        [Required]
        public int CapitalId { get; set; }

        [DisplayName("Столица")]
        public Cities Capital { get; set; }


        [Required]
        [DisplayName("Площедь")]
        public double Square { get; set; }

        [Required]
        [DisplayName("Население")]
        public int Population { get; set; }

        [Required]
        public int RegionId { get; set; }
        [DisplayName("Регион")]
        public Regions Region { get; set; }




    }
}
