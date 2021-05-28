using System.ComponentModel.DataAnnotations;

namespace SillyFactory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }
    public int MachineId { get; set; }
    public int EngineerId { get; set; }
    [Required]
    public virtual Machine Machine { get; set; }
    public virtual Engineer Engineer { get; set; }
  }
}