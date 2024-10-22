using System.Drawing;

namespace lab_ex6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car{Name="Toyota",color="Red" },
                new Car{Name="Honda",color="yellow" },
                new Car{Name="Hyundai",color="pink" },
                new Car{Name="VF9",color="Red" },
                new Car{Name="Mazda CX-5",color="green" },
                new Car{Name="Kia Seltos",color="black" },
                new Car{Name="Ford Ranger",color="black" },
                new Car{Name="VF3",color="blue" },
                new Car{Name="BMW 3 Series",color="white" },
                new Car{Name="Audi A4",color="black" },
            };
            //remove
            cars.RemoveAll(c => c.color.Equals("Red", StringComparison.OrdinalIgnoreCase));
            // In ra danh sách xe hơi
            foreach (var car in cars)
            {
                Console.WriteLine($"Car Name: {car.Name}, Color: {car.color}");
            }

        }
    }
}
