using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PokemonWeb.Models;

public class Pokemon
{
    [Display(Name = "編號")]
    [Required]
    public string No { get; set; }
    [Display(Name = "中文名稱")]
    [Required]
    public string TwName { get; set; }
    [Display(Name = "英文名稱")]
    [Required]
    public string EnName { get; set; }
    [Display(Name = "日文名稱")]
    [Required]
    public string JpName { get; set; }
    [Column(TypeName = "int")]
    [Display(Name = "屬性1")]
    [Required(ErrorMessage = "屬性1不可為空")]
    public int Type_1 { get; set; }
    [Column(TypeName = "int")]
    [Display(Name = "屬性2")]
    [Required]
    public int Type_2 { get; set; }
}