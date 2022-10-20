using FSPTask4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask4.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FSPTask4Context(serviceProvider.GetRequiredService<
                    DbContextOptions<FSPTask4Context>>()))
            {
                DateTime today = DateTime.Now;
                // Look for any doctors.
                if (context.Doctor.Any())
                {
                    return;   // DB has been seeded
                }

                var doctors = new List<Doctor>
                {
                    new Doctor{DoctorName = "Carson Alexander"},
                    new Doctor{DoctorName = "Arturo Justice"},
                    new Doctor{DoctorName = "Laura Norman"},
                };
                doctors.ForEach(d => context.Doctor.Add(d));
                context.SaveChanges();



                var patients = new List<Patient>
                {
                    new Patient{ PatientName="John Wick", ReceptionTime=new DateTime(2022, 11, 9, 10, 55, 0),
                        Doctors=new List<Doctor>{doctors.Find(d=>d.DoctorName== "Carson Alexander") } },
                    new Patient{ PatientName="Meredith Anand", ReceptionTime=today.AddDays(3).Date+new TimeSpan(15, 45, 0),
                        Doctors=new List<Doctor>{doctors.Find(d=>d.DoctorName== "Arturo Justice") } },
                    new Patient{ PatientName="Gytis Barzdukas", ReceptionTime=today.AddDays(4).Date+new TimeSpan(16, 10, 0),
                        Doctors=new List<Doctor>{doctors.Find(d=>d.DoctorName== "Laura Norman") } },
                    new Patient{ PatientName="Yan Li", ReceptionTime=today.AddDays(5).Date+new TimeSpan(16, 25, 0),
                        Doctors=new List<Doctor>{doctors.Find(d=>d.DoctorName== "Laura Norman") } },
                    new Patient{ PatientName="Nino Olivetto", ReceptionTime=today.AddDays(6).Date+new TimeSpan(16, 40, 0),
                        Doctors=new List<Doctor>{doctors.Find(d=>d.DoctorName== "Arturo Justice") } }
                };
                patients.ForEach(p => context.Patient.Add(p));
                context.SaveChanges();
            }
        }

    }
}
