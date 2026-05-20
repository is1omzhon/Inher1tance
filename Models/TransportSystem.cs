namespace Models.TransportSystem
{
    class TransportSystem
    {
        public string Brand {get; set;}

        public void Move()
        {
            Console.WriteLine($"{Brand} is moving");
        }
    }

    class Car : TransportSystem
    {
        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving");
        }
    }

    class Bike : TransportSystem
    {
        public void Ride()
        {
            Console.WriteLine($"{Brand} is riding");
        }
    }

    class Train : TransportSystem
    {
        public void CarryPassengers()
        {
            Console.WriteLine($"{Brand} is carrying passengers");
        }
    }
}