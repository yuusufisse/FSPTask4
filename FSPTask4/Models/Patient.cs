using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask4.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? PatientName { get; set; }
        public DateTime? ReceptionTime { get; set; }
        public List<Doctor>? Doctors { get; set; }
    }
}
