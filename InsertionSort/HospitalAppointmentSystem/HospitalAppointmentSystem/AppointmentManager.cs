using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem
{
    public class AppointmentManager
    {
        private List<Appointment> appointments=new List<Appointment>();

        // add appointemnts 
        public void AddAppointment(string name ,DateTime time , int urgency)
        {
            appointments.Add(new Appointment(name,time,urgency));
            Console.WriteLine("added successufly");

        }

        // Update an existing appointment
        public void UpdateAppointment(int index, DateTime newTime,int newUrgency)
        {
            if(index>0 && index < appointments.Count)
            {
                appointments[index].Time = newTime;
                appointments[index].Urgency = newUrgency;
                Console.WriteLine(" Update appointment successfully ");
            }
            else
            {
                Console.WriteLine("❌ Invalid appointment index!");
            }
        }


        //Display all appointment
        public void DisplayAppointment()
        {
            Console.WriteLine("\n Appointemnt");
            Console.WriteLine("Patient \t\tTime\t\tUrgency");
            Console.WriteLine("--------------------------------------------");
            foreach (var appt in appointments)
            {
                Console.WriteLine($"{appt.Name}\t\t{appt.Time}\t\t{appt.Urgency}");
            }
        }


        //sort Appointement by time 
        public void SortByTime()
        {
            for(int i = 1; i < appointments.Count; i++)
            {
                Appointment key = appointments[i];
                int j = i - 1;
                while (j >= 0 && appointments[j].Time>key.Time)
                {
                    appointments[j+1]=appointments[j];
                    j--;
                }
                appointments[j+1]=key;

            }
            Console.WriteLine("Appointments sorted by time ......");
        }


        //sort Appointement by uge
        public void SortByUrgency()
        {
            for(int i = 1; i < appointments.Count; i++)
            {
                Appointment key= appointments[i];
                int j = i - 1;
                while(j>0 && appointments[j].Urgency<key.Urgency)
                {
                    appointments[j + 1] = appointments[i];
                    j--;
                }
                appointments[j+1]=key;
            }
            Console.WriteLine(" Appointments sorted by urgency");
        }
    }
}
