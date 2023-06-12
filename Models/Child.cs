using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace VaccineAPI.Models
{

    public class Child
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Child()
        {
            this.FollowUps = new HashSet<FollowUp>();
            this.Schedules = new HashSet<Schedule>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Guardian { get; set; } = "Father";
        public string FatherName { get; set; }
        public string Email { get; set; }
        public System.DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string City { get; set; } = "Rawalpindi";
        public string CNIC { get; set; } = "6110115935691";
        public int PreferredDayOfReminder { get; set; }
        public string PreferredDayOfWeek { get; set; }
        public string PreferredSchedule { get; set; }  = "Any";
        public bool? IsEPIDone { get; set; }
        public bool? IsVerified { get; set; }
        public bool? IsInactive { get; set; }
        public long ClinicId { get; set; }
        public virtual Clinic Clinic { get; set; }

        public long UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FollowUp> FollowUps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }

    }

}