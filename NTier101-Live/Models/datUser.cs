using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier101_Live.Models
{
    // VT tarafındaki tablomun class görüntüsü
    public class datUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassw { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKimlik { get; set; }
        public int MudurlukID { get; set; }
    }
}
