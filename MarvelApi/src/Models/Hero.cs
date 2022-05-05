namespace src.Models
{
    public class Hero
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string RealName { get; set; }
        public DateTime CreatedAt   { get; set; }

        public int GroupId { get; set; }
        public Group group { get; set; }



    }
}
