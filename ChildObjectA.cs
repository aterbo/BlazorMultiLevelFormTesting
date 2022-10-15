using System.ComponentModel.DataAnnotations;

namespace FormTest;

public class ChildObjectA
{
    public int ChildObjAInt { get; set; }
         [Required, MinLength(5)]
    public string ChildObjAStringA { get; set; } = "";
    public string ChildObjAStringB { get; set; } = "";
}