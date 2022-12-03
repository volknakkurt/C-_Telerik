using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipp.DTO
{
    public class DataResultDTO
    {
        public string Hata { get; set; }
        public bool IsSuccess { get { return string.IsNullOrWhiteSpace(Hata); } }
        public DataTable ResultData { get; set; }
        public object ResultObject { get; set; }
    }
}
