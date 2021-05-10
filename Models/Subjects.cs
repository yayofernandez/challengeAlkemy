using System.ComponentModel.DataAnnotations;

namespace Universidad.Models 
{
  public class Subjects 
  {
      [Key]
    public int idSubjects {get; set;}
    public string NameSubjects { get ; set;}

    public int TimeSubjects { get; set;}

    public string Teacher { get; set;}

    public int MaxNumberStudent { get; set;} 

  }


}  