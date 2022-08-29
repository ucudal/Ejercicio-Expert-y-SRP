using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("1", "Steven Jhonson", "986782342", "32",
            "5555-555-555", DateTime.Now, "Wall Street", "Armand", "Neurologist");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("2", "Ralf Manson", "53697420", "11",
            "5555-555-555", DateTime.Now, "Queen Street", "Soria", "Pediatrist");
            Console.WriteLine(appointmentResult2);
        }
    }
}
