namespace Shop.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string img { get; set; }
        public ushort price{ get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int categoyID { get; set; }

        public virtual Category Category { get; set; }
    }
}
