using System.ComponentModel.DataAnnotations;

namespace Vivaldikafe1.Models;

public class  Musteri
{
    [Key]

    public int id { get; set; }
    public string Ad {get; set;}="";
    public string Soyad {get;set;}="";
    public string Mail {get;set;}="";
    public string Mesaj {get;set;}="";
    
}