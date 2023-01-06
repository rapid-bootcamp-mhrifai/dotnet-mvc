namespace WebMvc.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public String Jurusan { get; set; }
        public StudentViewModel()
        {

        }

        public StudentViewModel(int id, String studentName, int age, String address, String jurusan)
        {
            Id = id;
            StudentName = studentName;
            Age = age;
            Address = address;
            Jurusan = jurusan;
        }
    }
}
