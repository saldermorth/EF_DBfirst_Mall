using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_DBfirst.Models
{
    [Index("Name", Name = "UQ__Categori__737584F6B3D533F7", IsUnique = true)]
    public partial class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; } = null!;
    }
}
