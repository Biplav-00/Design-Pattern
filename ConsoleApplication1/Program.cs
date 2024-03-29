﻿using System;
using ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle;
using ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Demo_Program;
using ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Truenary_Solution_Problem;
using ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Vehicle_Example;
using ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Computer__Simulation_Example;
using ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Music_App;
using ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Example_1;
using ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example;
using ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example_2;
using ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.chat_application;
using ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Ecommerce_Example;
using ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Game_Task_1;
using ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Stock_Notifier;
using ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Youtube_Example;
using ConsoleApplication1.Design_Pattern.SOLID_Design.Single_Responsibility_Principle;
using IVehicle = ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example_2.IVehicle;
using VehicleFactory = ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle.VehicleFactory;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //this code is for the Decorator Design Pattern-> Demo Program
            /*IComponent component = new ConcreteComponent();
            IDecorator decorator = new ConcreteDecorator(component);
           // component.Build();
            decorator.Build();*/
            
            
            //this code is for the Vehicle example of Decorator Design Pattern
            /*HondaCity  car = new HondaCity();
            Console.WriteLine("Model is : "+car.Make);
            Console.WriteLine("Actual Price is "+car.Price);
            SpecialOffer specialOffer = new SpecialOffer(car);
            Console.WriteLine(specialOffer.offer = "Dashian offer");
            specialOffer.discountPercentage = 25;
            Console.WriteLine("Your offer price for  "+car.Make+ " is Rs. " +specialOffer.price);*/
            
            //this code is for the Truenary solution problem
            /*ITruenarySolution truenarySolution = new NewIntern();
            AddSpecificStudent addSpecificStudent = new AddSpecificStudentImpl(truenarySolution);
            addSpecificStudent.webDevelopmentIntern();*/




            /*
            CommedyChannel commedyChannel = new CommedyChannel();

            Suscriber1 suscriber1 = new Suscriber1();
            Suscriber2 suscriber2 = new Suscriber2();
            Suscriber3 suscriber3 = new Suscriber3();
            commedyChannel.registerObserver(suscriber1);
            commedyChannel.registerObserver(suscriber2);
            commedyChannel.registerObserver(suscriber3);
            
            commedyChannel.addNewVideo("heloo hahha");
            */



            /*ChatRoom chatRoom = new ChatRoom("hello chat");
            Person1 animesh = new Person1("animesh");
            Person2 biplav = new Person2("biplav");
            Person3 suraj = new Person3("suraj");
            
            
            chatRoom.addUser(animesh);
            chatRoom.addUser(biplav);
            chatRoom.addUser(suraj);
            
            chatRoom.notifyToUser();
            
            
            chatRoom.deleteUser(suraj);
            chatRoom.notifyToUser();*/


            
            //this code is for the game task 1 (Observer Design pattern)
            /*Ball ballgame = new Ball();
            Person player = new Person(ballgame);
           ballgame.addObserver(player);
            Console.WriteLine("Welcome to the guessing game ");
            while (true)
            {
                
                Console.WriteLine("Please enter the guess (0-4) ");
                int guess;
                if (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 4)
                {
                    Console.WriteLine("Invalid input please input the value of range (0-4)");   
                    continue;
                }
                   bool isGameOver = ballgame.guess(guess);
                if (isGameOver)
                {
                    break;
                }
            }*/
            
            
            //this code is for the observer design pattern => stock notifier
            /*VoteKosiStock appleStock = new VoteKosiStock("Apple Corp", 110);
            VoteKosiStock microsoftStock = new VoteKosiStock("Microsoft corp", 102);
            User sailesh = new User("Sailesh");
            User biplav = new User("Biplav");
            
            appleStock.addStockObserver(sailesh);
            microsoftStock.addStockObserver(sailesh);
            microsoftStock.addStockObserver(biplav);

            appleStock.Price = 120;
            microsoftStock.Price = 220;*/
            
            //this code is for the Design pattern ->Observer design pattern-> Ecommerce Example
            /*Product LifeBoy = new Product("LifeBoy", 40);
            Product Lux = new Product("Lux", 45);

            User1 sailesh = new User1("sailesh");
            User1 biplav = new User1("Biplav");
            User1 ashraf = new User1("Ashraf");
            
            LifeBoy.addUser(sailesh);
            LifeBoy.addUser(biplav);
            LifeBoy.addUser(ashraf);
            
            Lux.addUser(sailesh);
            Lux.addUser(biplav);



            LifeBoy.ProductPrice = 35;
            Lux.ProductPrice = 50;*/
            
            
            //this code is for the facade design pattern -> computer simulation example
            /*Client client = new Client();
            client.runSimulation();*/
            
            //this code is for the design pattern-> facade design pattern -> music app
            /*MusicFacade musicFacade = new MusicFacade();
            //musicFacade.displayAllSong();
            musicFacade.addSong("Timi nai ta hau sathi");
            musicFacade.playSong("timi nai ta hau sathy");
            musicFacade.paushSong("timi nai ta hau sathy");
            musicFacade.displayAllSong();*/
            
            //this code is for the Factory Design Pattern Example1

            /*ShapeFactory allShapeFactory = new ShapeFactory();
            Shape rectangleShape = new Rectangle();
            Shape traingleShape = new Traingle();
            Shape squareShape = new Square();
            traingleShape=allShapeFactory.performTask("traingle");
            Console.WriteLine(traingleShape.drawShape());
            rectangleShape = allShapeFactory.performTask("rectangle");
            Console.WriteLine(rectangleShape.drawShape());
            squareShape = allShapeFactory.performTask("square");
            Console.WriteLine(squareShape.drawShape());*/
            
           
            
            //this code is for the Factory Design Patten Vehicle Example

            /*VehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle car = new Car();
            car.build("Honda Car",1500.00);
            vehicleFactory.sale("car");*/
            
            
            //this code is for Design Pattern -> Factory Design Pattern -> vehicle Example 2
            /*VehicleFactory1 vehicleFactory1 = new VehicleFactory1();
            IVehicle motrocycle =vehicleFactory1.createVehicle("motorcycle");
            motrocycle.startEngine();
            motrocycle.stopEngine();

            IVehicle truck = vehicleFactory1.createVehicle("truck");
            truck.startEngine();
            truck.stopEngine();*/
            
            
            //this code is for the design pattern -> abstract factory design patten -> Game Vehicle

            /*VehicleFactory urbanVehicleFactory = new UrbanVehicleFactor();
            IVehicle2 urbanCar=urbanVehicleFactory.createVehicle("car");
            Console.WriteLine("The urban car ");
            urbanCar.speed(120);
            urbanCar.wheels();
            urbanCar.comfort("Luxurious feel");

            Console.WriteLine("The urban truck");
            IVehicle2 urbanTruck = urbanVehicleFactory.createVehicle("truck");
            urbanTruck.speed(75);
            urbanTruck.wheels();
            urbanTruck.comfort("not zigzag");

            Console.WriteLine("The urban Bus");
            IVehicle2 urbanBus = urbanVehicleFactory.createVehicle("bus");
            urbanBus.speed(90);
            urbanBus.wheels();
            urbanBus.comfort("Best feeling ever");
            */


            //this code is for Solid Design -> Single Responsibility Principle
            Employee employee = new Employee()
            {
                address = "Hetauda",
                name = "animesh",
                salary = 2400
            };
            EmployeeDatabase employeeDatabase = new EmployeeDatabase();
            employeeDatabase.saveEmployee(employee);

            SalaryCalculator salaryCalculator = new SalaryCalculator();
            salaryCalculator.calculateSalary(employee);
            Console.WriteLine($"salary of employee : {employee.name} is  {salaryCalculator.calculateSalary(employee)}");

            GenerateReport generateReport = new GenerateReport();
            generateReport.generateEmployeeReport(employee);








        }
    }
}
