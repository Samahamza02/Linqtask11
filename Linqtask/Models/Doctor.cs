using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Linqtask.Models;

[Table("doctor")]
public partial class Doctor
{
    [Key]
    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [Column("name")]
    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("phone")]
    [StringLength(11)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("specialty")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Specialty { get; set; }

    [Column("yearsexp")]
    public int? Yearsexp { get; set; }

    [InverseProperty("Doctor")]
    public virtual ICollection<Petient> Petients { get; set; } = new List<Petient>();
}
