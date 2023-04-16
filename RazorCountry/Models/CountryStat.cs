using System.ComponentModel.DataAnnotations;

namespace RazorCountry.Models
{
    public class CountryStat : Country
    {
        [Display(Name = "Ppl/SqMi")]
        public float? Density { get; set; }
    }
}
