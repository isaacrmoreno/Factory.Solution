using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SillyFactory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    [Required]
    public string Description { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}