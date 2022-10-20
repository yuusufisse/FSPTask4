using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask4.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? DoctorName { get; set; }
        public List<Patient>? Patients { get; set; }
    }
}
