namespace ClinicService.Models.Request
{
    public class CreatePetRequest
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Breed { get; set; }

        public DateTime Birthday { get; set; }
    }
}
