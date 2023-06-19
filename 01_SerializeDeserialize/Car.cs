namespace _01_SerializeDeserialize
{
    public class Car
    {
        public string Year { get; set; }
        public string Model { get; set; }

        public Car(string year, string model)
        {
            Year = year;
            Model = model;
        }
        public override string ToString()
        {
            return $"Year: {Year}, Model: {Model}";
        }
    }
}