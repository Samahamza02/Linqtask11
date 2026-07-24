using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Linqtask.Models;

[Table("petient")]
public partial class Petient
{
    [Key]
    [Column("ur_number")]
    public int UrNumber { get; set; }

    [Column("name")]
    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("adderess")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Adderess { get; set; }

    [Column("age")]
    public int? Age { get; set; }

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("phone")]
    [StringLength(11)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("card_number")]
    public int? CardNumber { get; set; }

    [Column("doctor_id")]
    public int? DoctorId { get; set; }

    [ForeignKey("DoctorId")]
    [InverseProperty("Petients")]
    public virtual Doctor? Doctor { get; set; }
}
