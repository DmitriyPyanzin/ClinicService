namespace ClinicService.Models
{
    public class Pet
    {

        public int PetId { get; set; }

        public int ClientId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Breed { get; set; }

        public DateTime Birthday { get; set; }
    }
}
