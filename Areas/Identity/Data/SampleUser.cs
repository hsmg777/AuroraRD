using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuroraRD.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SampleUser class
public class SampleUser : IdentityUser
{
    [Required]
    [StringLength(100,ErrorMessage ="Maximo de caracteres alcanzado")]
    public string Name { get; set; }
    [Required]
    [StringLength(10, ErrorMessage ="Numero de celular no valio, asegurese cumplir el formato de 10 caracteres")]
    public string Telefono {  get; set; }
    
}

