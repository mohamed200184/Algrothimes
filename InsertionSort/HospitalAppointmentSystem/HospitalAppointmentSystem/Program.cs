namespace HospitalAppointmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppointmentManager manger =new AppointmentManager();
            bool running = true;
            while (running) 
            {
                Console.WriteLine("Hospital Appointment system");
                Console.WriteLine("1.Add appointemnt ");
                Console.WriteLine("2. Update appointemnt ");
                Console.WriteLine("3. Display Appointemnt ");
                Console.WriteLine("4. sort by time");
                Console.WriteLine("5. sort by Urgency");
                Console.WriteLine("6. Exist ");
                Console.WriteLine("choose option (1 - 6 )");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter patient  name ");
                        string name = Console.ReadLine();
                        Console.Write("Enter appointment time (yyyy-MM-dd HH:mm):");
                        DateTime time = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter urgency level (1-10): ");
                        int urgency =int.Parse(Console.ReadLine());
                        manger.AddAppointment(name, time, urgency);
                        break;
                    case "2":
                        Console.Write("Enter appointment index to update: ");
                        int index  = int.Parse(Console.ReadLine());
                        Console.Write("Enter  new appointment time (yyyy-MM-dd HH:mm):");
                        DateTime newTime = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter  new urgency level (1-10): ");
                        int newUrgency = int.Parse(Console.ReadLine());
                        manger.UpdateAppointment(index, newTime, newUrgency);
                        break;
                    case "3":
                        manger.DisplayAppointment();
                        break;
                    case "4":
                        manger.SortByTime();
                        manger.DisplayAppointment();
                        break;
                    case "5":
                        manger.SortByUrgency();
                        manger.DisplayAppointment();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("🏥 Exiting... Stay Healthy ");
                        break;
                    default:
                        Console.WriteLine("invalid option please try agin");
                        break;


                }


            }
        }
    }
}
