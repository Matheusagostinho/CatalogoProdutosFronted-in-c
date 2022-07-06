using System.ComponentModel.DataAnnotations;
namespace CatalogoFrontend.Dtos.User;

public class UserCreateUpdateDto
{
    [Required]
    [StringLength(255, MinimumLength = 3)]
    public string Name { get; set; }

    [Required]
    public string Phone { get; set; }

    public string Adress { get; set; }
    [Required]
   
    public string Email { get; set; }
    [Required]
   
    public string Password { get; set; }
     [Required]
   
    public string Type { get; set; }
  
}
