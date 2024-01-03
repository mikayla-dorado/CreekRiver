using System.ComponentModel.DataAnnotations;
using CreekRiver.Models.DTOs;

namespace CreekRiver.Models;

public class CampsiteType
{
    public int Id { get; set; }
    [Required]
    public string CampsiteTypeName { get; set; }
    public int MaxReservationDays { get; set; }
    public decimal FeePerNight { get; set; }

    // public static implicit operator CampsiteType(CampsiteTypeDTO v)
    // {
    //     throw new NotImplementedException();
    // }
}

//The [Required] code above the CampsiteTypeName is called an attribute in C#.
// Attributes allow you to add metadata about entities in C# that your program can use. 
//In this case, Entity Framework can tell from this attribute that the CampsiteTypeName column in the SQL database should have NOT NULL when it is created.