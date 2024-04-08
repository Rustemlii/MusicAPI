using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.EntityDTO
{
    public class MusicDTO
    {
        public int ID { get; set; }
        public string Singer { get; set; }
        public string MusicName { get; set; }
        public string Minute { get; set; }
        public DateTime Date { get; set; }
    }
}
