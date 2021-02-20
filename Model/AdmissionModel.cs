using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoolExplorer.Model
{
    public class AdmissionModel
    {
        public GeneralInfo GeneralInfo { get; set; }
        public ChildInfo ChildInfo { get; set; }
        public ParentInfo ParentInfo { get; set; }
    }
}
