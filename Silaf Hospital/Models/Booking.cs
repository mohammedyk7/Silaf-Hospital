public class Appointment
{
    public int AppointmentId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime Date { get; set; }

    private static List<Appointment> Appointments = new();
    private static int NextId = 1;

    public static void BookAppointment()
    {
        Console.Clear();
        Console.WriteLine("?? Book Appointment\n");

        try
        {
            Console.Write("Enter Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Appointment newAppointment = new()
            {
                AppointmentId = NextId++,
                PatientId = patientId,
                DoctorId = doctorId,
                Date = date
            };

            Appointments.Add(newAppointment);

            Console.WriteLine("\n? Appointment booked successfully!");
        }
        catch
        {
            Console.WriteLine("? Error: Please enter valid inputs.");
        }

        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }
}
