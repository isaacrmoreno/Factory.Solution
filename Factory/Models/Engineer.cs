using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;


namespace SillyFactory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    [Required]
    [DisplayName("First Name: ")]
    public string FirstName { get; set; }
    [DisplayName("Last Name: ")]

    public string LastName { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}