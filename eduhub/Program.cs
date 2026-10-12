using eduhub.docs;
using System;

namespace ClinicManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = Patient.Create(
                "BN01", "Nguyen Van A", "0901234567");

            Doctor doctor = Doctor.Create(
                "BS01", "Tran Van B", "Noi khoa");

            Appointment appointment = Appointment.Create(
                "LH01", patient.Id, doctor.Id, DateTime.Now.AddDays(1));

            Console.WriteLine("Tao benh nhan: " + patient.Name);
            Console.WriteLine("Bac si: " + doctor.Name);
            Console.WriteLine("Ma lich hen: " + appointment.Id);

            Console.ReadKey();
        }
    }
}