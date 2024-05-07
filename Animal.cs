namespace HomeWork11
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        public Animal() { }

        public override string ToString()
        {
            return $" name:{Name}, age:{Age}, description:{Description}";
        }
    }
}

