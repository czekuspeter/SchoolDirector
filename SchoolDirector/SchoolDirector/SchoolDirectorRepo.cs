using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolDirector
{
    public class SchoolDirectorRepo
    {
        private List<SchoolDirector> directors = new List<SchoolDirector>();

        public void Add(SchoolDirector director)
        {
            directors.Add(director);
        }

        public decimal AverageSalary()
        {
            return directors.Average(director => director.Salary);
        }

        public string GetMostExperiencedDirectorName()
        {
            var mostExperienced = directors.OrderBy(director => director.AppointmentDate).FirstOrDefault();
            return mostExperienced?.Name ?? "Nincs vezető az adatbázisban.";
        }
    }
}