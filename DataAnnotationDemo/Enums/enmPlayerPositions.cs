using System.ComponentModel.DataAnnotations;

namespace DataAnnotationDemo.Enums
{
    public enum enmPlayerPositions
    {
        [Display(Name = "Torhüter")]
        Goalkeeper,
        [Display(Name = "Verteidiger")]
        Defender,
        [Display(Name = "Mittelfeld")]
        Midfield,
        [Display(Name = "Stürmer")]
        Striker
    }
}