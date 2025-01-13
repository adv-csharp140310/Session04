using System.ComponentModel.DataAnnotations;

namespace session04.Model;

public class User
{
    public int ID { get; set; }
    [Display(Name = "نام")]
    public string FirstName { get; set; }
    public string Family { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }

    private string password;

    public User()
    {
        password = "yechizi";
    }
}