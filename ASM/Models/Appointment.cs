﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASM.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Location")]
        public int LocationId { get; set; }
        [Required]
        [DisplayName("Hospital")]
        public int HospitalId { get; set; }
        [DisplayName("Catagory")]
        public int CatagoryId { get; set; }
        [ForeignKey("Doctor")]
        [DisplayName("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        [Required]
        public string Note { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
