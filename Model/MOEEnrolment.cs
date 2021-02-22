using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoolExplorer.Model
{

    public class API_Model
    {
        public string help { get; set; }
        public bool success { get; set; }
    }


    ////---------  Enrolment - MOE Kindergartens  --------------
    public class MOEEnrolment_raw: API_Model
    {
        public abc result { get; set; }
    }

    public class abc
    {
        public List<MOEEnrolment> records { get; set; }
    }

    public class MOEEnrolment
    {
        public int _id { get; set; }
        public string enrolment { get; set; }
        public string year { get; set; }
    }

    //------------  Enrolment Rate  --------------
    public class EnrolmentRate_raw: API_Model
    {
        public Enrolement result { get; set; }
    }

    public class Enrolement
    {
        public List<EnrolementSet> records { get; set; }
    }

    public class EnrolementSet
    {
        public int _id { get; set; }
        public string total_net_enrolment_rate { get; set; }
        public string sex { get; set; }
        public string level_of_education { get; set; }
        public string year { get; set; }

    }

    //------------  CentreServices  --------------
    public class CentreServices_raw : API_Model
    {
        public CentreService result { get; set; }
    }

    public class CentreService
    {
        public List<CentreServiceSet> records { get; set; }
    }

    public class CentreServiceSet
    {
        public string centre_code { get; set; }
        public string centre_name { get; set; }
        public string class_of_licence { get; set; }
        public string type_of_service { get; set; }
        public string levels_offered { get; set; }
        public string fees { get; set; }
        public string type_of_citizenship { get; set; }
        public string last_updated { get; set; }
        public string remarks { get; set; }
    }
}
