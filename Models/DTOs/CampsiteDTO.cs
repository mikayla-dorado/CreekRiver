namespace CreekRiver.Models.DTOs;

public class CampsiteDTO
{
    public int Id { get; set; }
    public string Nickname { get; set; }
    public string ImageUrl { get; set; }
    public int CampsiteTypeId { get; set; }
    public CampsiteTypeDTO CampsiteType { get; set; }
    public List<ReservationDTO> Reservations { get; set; }
}

//DTOS do not need the Require attribute like the og Models bc
//DTOs are describing how data will be represented to the client,
//not describing how it is stored in the database