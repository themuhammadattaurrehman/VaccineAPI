using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace VaccineAPI.Models
{

    public class Clinic
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int ConsultationFee { get; set; }
        public string OffDays { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsOnline { get; set; }
        public string Address { get; set; }
        public long DoctorId { get; set; }
       // [JsonIgnore]
        public Doctor Doctor { get; set; }
        public virtual ICollection<Child> Children { get; set; }
        public virtual ICollection<ClinicTiming> ClinicTimings { get; set; }
         
    }

}