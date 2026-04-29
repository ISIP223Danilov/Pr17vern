using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr17vern
{
    public partial class AppointmentAvailable
    {
        public string p_service_type
        {
            get { return ServiceType?.dname; }
        }
    }
}
}
