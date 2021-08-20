using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Country.Models.CountryModel
{
    public class Regions
    {

        public int Id { get; set; }

        [Required]
        [DisplayName("Регион")]
        public string Name {get;set;}
    }
}
