using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Data;

public class StudentMetadata{
    
    [StringLength(50)]
    [Display(Name="First Name")]
    public string Firstname { get; set; } = null!;

    [Display(Name="Last Name")]
    public string LastName { get; set; } = null!;

   [Display(Name="Date Of Birth")]
    public DateOnly? DateOfBirth { get; set;}
}

[ModelMetadataType(typeof(StudentMetadata))]
public partial class Students{}