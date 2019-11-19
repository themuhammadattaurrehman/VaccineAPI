using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace VaccineAPI.Models
{

    public class FollowUpDTO
    {
        public long Id { get; set; }
        public string Disease { get; set; }
        [JsonConverter(typeof(OnlyDateConverter))]
        public DateTime CurrentVisitDate { get; set; }
        [JsonConverter(typeof(OnlyDateConverter))]
        public DateTime NextVisitDate { get; set; }
        public float? Weight { get; set; }
        public float? Height { get; set; }
        public float? OFC { get; set; }
        public float? BloodPressure { get; set; }
        public float? BloodSugar{ get; set; }
         public long ChildId { get; set; }
         [JsonIgnore]
        public Child Child { get; set; }
       
        public long DoctorId { get; set; }
         [JsonIgnore]
        public Doctor Doctor { get; set; }
    }

}