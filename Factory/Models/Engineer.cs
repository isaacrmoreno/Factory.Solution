using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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
    public string Name { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}