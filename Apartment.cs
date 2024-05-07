namespace HomeWork11
{
    public class Apartment
    {
        public int Rooms { get; set; }
        public int People { get; set; }
        public Apartment() { }
        public Apartment(int rooms, int people)
        {
            Rooms = rooms;
            People = people;
        }
        public override string ToString()
        {
            return ($"rooms:{Rooms}, people:{People}");
        }
    }
}
