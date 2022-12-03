using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipp
{
    public class KullaniciDTO
    {

        public KullaniciDTO()
        {
            Ekrans = new List<EkranDTO>();           
        }
        public int Id { get; set; }
        public string Rol { get; set; }
        public string AdSoyad { get; set; }
        public string Sifre { get; set; }
        public string Mail { get; set; }
        public bool Aktif { get; set; }                        
        public List<EkranDTO> Ekrans { get; set; }
        public bool IsDeleted { get; set; }
        
        public class EkranDTO
        {            
            public int EkranId { get; set; }
            public string EkranAdi { get; set; }
            public bool Yetkili { get; set; }       
        }
        public class KullaniciEkranYetkiDTO
        {
            public int Id { get; set; }
            public int KullaniciId { get; set; }
            public int EkranId { get; set; }            
            public bool Yetki { get; set; }          
        }

    }
}
