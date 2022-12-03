using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipp.DTO
{
    public class FirmaDTO
    {
        public FirmaDTO()
        {
            IletisimList = new List<IletisimDTO>();
            AdresList = new List<AdresDTO>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string Yetkili { get; set; }
        public string Iletisim { get; set; }
        public string Adres { get; set; }

        public List<IletisimDTO> IletisimList { get; set; }
        public List<AdresDTO> AdresList { get; set; }
        public bool IsDeleted { get; set; }
        public class IletisimDTO
        {
            public int Id { get; set; }
            public int FirmaId { get; set; }
            public string Tip { get; set; }
            public string Deger { get; set; }
            public bool Varsayilan { get; set; }
            public bool IsDeleted { get; set; }

        }
        public class AdresDTO
        {
            public int Id { get; set; }
            public int FirmaId { get; set; }
            public bool Varsayilan { get; set; }
            public string Tip { get; set; }
            public string Deger { get; set; }
            public string Il { get; set; }
            public string Ilce { get; set; }            
            public bool IsDeleted { get; set; }
            
        }
    }
}
