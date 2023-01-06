namespace WebMvc.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        public CustomerViewModel()
        {

        }

        public CustomerViewModel(int id, string name, string address, string gender, string city)
        { 
            Id = id;    
            Name = name;
            Address = address;
            Gender = gender;
            City = city;
        }
    }
}
