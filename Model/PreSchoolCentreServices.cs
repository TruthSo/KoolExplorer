using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoolExplorer.Model
{
    public class PreSchoolCentreServices
    {
        public string centre_code { get; set; }
        public string centre_name { get; set; }
        public string class_of_licence { get; set; }
        public string type_of_service { get; set; }
        public string levels_offered { get; set; }
        public decimal fees { get; set; }
        public int type_of_citizenship { get; set; }
        public DateTime last_updated { get; set; }
        public string remarks { get; set; }
    }
}
