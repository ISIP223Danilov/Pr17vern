using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr17vern
{
    public partial class Appointment
    {
        public string p_master
        {
            get { return this.AppointmentAvailable.User.dname; }
        }
        public string p_payment_type
        {
            get { return PaymentType.dtype; }
        }
        public DateTime p_datetime
        {
            get { return AppointmentAvailable.datetime; }
        }
        public string p_service_type
        {
            get { return AppointmentAvailable.ServiceType.dname; }
        }
    }
}
}
