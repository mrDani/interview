using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public int Bvn { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
    }
}
