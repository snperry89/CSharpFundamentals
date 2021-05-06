using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        //Vehicle
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);

        }

        [TestMethod]
        public void IndicatorVehicleTests()
        {
            Indicator indicator = new Indicator();
            // Cannot be set outside of class, private set
            //indicator.IsFlashing = true;
            Console.WriteLine(indicator.isFlashing);
            indicator.TurnOn();
            Console.WriteLine(indicator.isFlashing);
        }

        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 100000, VehicleType.Plane);
            Console.WriteLine($" I rode on a spaceship, it was the {rocket.Make}");
            // When you set a property manually (below) it overrides the above contructor
            rocket.Model = "Constellation";
            Console.WriteLine($"That ship is a {rocket.Model}");
        }


        // Greeter
        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Brad");

            List<string> students = new List<string>();
            students.Add("Hanna");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach (string student in students)
            {
                greeterInstance.SayHello(student);
            }

            string greeting = greeterInstance.GetRandomGreeting();
            Console.WriteLine(greeting);
            greeterInstance.SaySomething(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.GetSum(3.5, 100.9);
            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1989, 02, 18));
            Console.WriteLine(age);
        }

        // Person
        [TestMethod]
        public void PersonTests()
        {
            Person person = new Person("Samuel", "Perry", new DateTime(1989, 02, 18));
            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.Age);

            Person jake = new Person("Jacob", "Brown", new DateTime(1991, 05, 04));
            Console.WriteLine(jake.FullName);
            Console.WriteLine(jake.Age);

            Person baby = new Person("Tobias", "Milton", new DateTime(2018, 01, 01));
            Console.WriteLine(baby.FullName + " is " + baby.Age + " years old!");

            // Single statement instance of new'ing up a person

            Person andrew = new Person()
            {
                FirstName = "Andrew",
                LastName = "Torr",
                DateOfBirth = new DateTime(1950, 12, 25)
            };

            // Asserting with a test that these two are equal
            Assert.AreEqual("Jacob", jake.FirstName);
            // Asserting that these are not equal
            // Using this code will result in an error
            // Assert.AreNotEqual("Jacob", jake.FirstName);


            Console.WriteLine(andrew.FullName);
            Console.WriteLine(andrew.Age);
        }

        // Within the scope of the namespace, but outside of a method
        // Field is a variable that the whole class has access to
        Person _person = new Person("Luke", "Skywalker", new DateTime(2000, 01, 31));

        // Methods will grab from things within the same class, but ignore other methods in the class?

        [TestMethod]
        public void PersonTransportTest()
        {
            _person.Transport = new Vehicle("X-Wing", "Starship", 1000, VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make} {_person.Transport.Model}");

            _person.Transport.Make = "T16 Skyhopper";

            Console.WriteLine(_person.Transport.Make);

            Person blank = new Person();
            Console.WriteLine($"Fullname: {blank.FullName}");
            Console.WriteLine($"Unset class: {blank.Transport}");
            Console.WriteLine($"Unset struct: {blank.DateOfBirth}");
            Console.WriteLine($"Age: {blank.Age}");
        }
    }
}
