using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Linqtask.Models;

[Table("company")]
public partial class Company
{
    [Key]
    [Column("c_name")]
    [StringLength(20)]
    [Unicode(false)]
    public string CName { get; set; } = null!;

    [Column("adderess")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Adderess { get; set; }

    [Column("phone")]
    [StringLength(11)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [InverseProperty("CNameNavigation")]
    public virtual ICollection<Drug> Drugs { get; set; } = new List<Drug>();
}
