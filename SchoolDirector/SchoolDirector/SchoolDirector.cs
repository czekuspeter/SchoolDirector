using System;

namespace SchoolDirector
{
    public class SchoolDirector
    {
        public string Name { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int YearsTeaching { get; set; }
        public decimal Salary { get; set; }

        public SchoolDirector(string name, DateTime appointmentDate, int yearsTeaching, decimal salary)
        {
            Name = name;
            AppointmentDate = appointmentDate;
            YearsTeaching = yearsTeaching;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} (kinevezés: {AppointmentDate:yyyy.MM.dd}, {YearsTeaching} éve tanár)";
        }
    }
}