using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Country.Models.CountryModel
{
    public class Cities
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Столица")]
        public string Name { get; set; }
    }
}
