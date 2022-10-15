using System.ComponentModel.DataAnnotations;

namespace FormTest;
public class ChildObjectB
{
    public int ChildObjBInt { get; set; }
    public string ChildObjBStringA { get; set; } = "";
         [Required, MinLength(5)]
    public string ChildObjBStringB { get; set; } = "";
    public ListItem ChildObjBListItem { get; set; } = new();
}