using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Linqtask.Models;

[Table("drug")]
public partial class Drug
{
    [Key]
    [Column("drug_id")]
    public int DrugId { get; set; }

    [Column("trade_name")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TradeName { get; set; }

    [Column("strngth")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Strngth { get; set; }

    [Column("c_name")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CName { get; set; }

    [ForeignKey("CName")]
    [InverseProperty("Drugs")]
    public virtual Company? CNameNavigation { get; set; }
}
