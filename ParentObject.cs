using System.ComponentModel.DataAnnotations;

namespace FormTest;
    
public class ParentObject
{
    public int ParentObjAInt { get; set; }
    [Required]
    public string ParentObjStringA { get; set; } = "";
     [Required, MinLength(5)]
    public string ParentObjStringB { get; set; } = "";
    [ValidateComplexType]
    public ChildObjectA ChildA { get; set; } = new();
    [ValidateComplexType]
    public ChildObjectB ChildB {get; set;} = new();
    //public List<ListItem> ChildList { get; set; } = new();
}