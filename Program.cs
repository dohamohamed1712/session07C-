namespace session07C_
{
    internal class Program
    {
        static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
        }
        static void Main(string[] args)
        {
            #region Q3
            Shape shape = new Shape(2, 3);
            Console.WriteLine("shape.Area() = " + shape.Area());

            Cube cube = new Cube(2, 3, 4);
            Console.WriteLine("cube.Area() = " + cube.Area());

            Shape shapeRef = new Cube(2, 3, 4);
            Console.WriteLine("shapeRef.Area() = " + shapeRef.Area());
            #endregion

            #region Q4
            object obj = new Cube(1, 2, 3);
            Console.WriteLine(obj.ToString());
            #endregion

            #region Q7
            Person doc = new Doctor(1, "Ahmed", 35, "Cardiology");
            ProcessPerson(doc);

            Console.WriteLine("--------------------------------");

            Person eng = new Engineer(2, "Sara", 30, "Software", 5);
            ProcessPerson(eng);
            #endregion

            #region Q12
            // Using concrete types
            Car car = new Car();
            car.MoveForward();
            car.MoveBackward();

            Ship ship = new Ship();
            
            ship.MoveBackward();

            Airplane airplane = new Airplane();
            airplane.MoveForward();
            airplane.MoveUp();

            Console.WriteLine("--------------------------------");

            // Using interface references
            IMoveable carRef = new Car();
            IMoveable planeRef = new Airplane();

            carRef.MoveForward();
            carRef.MoveBackward();

            planeRef.MoveForward();
            planeRef.MoveBackward();

            // planeRef.MoveUp(); //  Compile Error
            IFlyable flyRef = (IFlyable)planeRef;
            flyRef.MoveUp();
            #endregion

          
        }
    }
}
