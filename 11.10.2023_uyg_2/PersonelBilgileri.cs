using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11._10._2023_uyg_2
{
    internal class PersonelBilgileri
    {
        public string PersonelID { get; set; }  
        public string PersonelAd { get; set;}
        public string PersonelSoyad { get; set;}
        public DateTime DogumTarihi { get; set;}  
        public string Telefon {  get; set;}  
        public string Email { get;set;}
        public string Adres { get; set;}
        public DateTime IseGirisTarihi { get; set;}
    }
}
