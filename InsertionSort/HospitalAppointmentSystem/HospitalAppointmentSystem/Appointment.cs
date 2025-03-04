using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem
{
    public class Appointment
    {

        public string Name { get; set; }
        public DateTime Time { get; set; }
        public int Urgency {  get; set; }

        public Appointment(string name, DateTime time, int urgency)
        {
            Name = name;
            Time = time;
            Urgency = urgency;
        }

    }
}
