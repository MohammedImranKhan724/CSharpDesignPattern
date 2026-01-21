//// Fetch the Regular Bike and Car Details
//// Creating RegularVehicleFactory instance

//using AbstractFactory.Example1;

//IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

////regularVehicleFactory.CreateBike() will create and return Regular Bike

//IBike regularBike = regularVehicleFactory.CreateBike();
//regularBike.GetDetails();

////regularVehicleFactory.CreateCar() will create and return Regular Car

//ICar regularCar = regularVehicleFactory.CreateCar();
//regularCar.GetDetails();

//// Fetch the Sports Bike and Car Details
//// Creating SportsVehicleFactory instance

//IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
////sportsVehicleFactory.CreateBike() will create and return Sports Bike
//IBike sportsBike = sportsVehicleFactory.CreateBike();
//sportsBike.GetDetails();

////sportsVehicleFactory.CreateCar() will create and return Sports Car
//ICar sportsCar = sportsVehicleFactory.CreateCar();
//sportsCar.GetDetails();

//Console.ReadKey();

// Fetch the Front End Course and Source Details
// Creating OfflineSourceCourseFactory instance

using AbstractFactory.Example2;

ISourceCourseFactory offlineSourceCourseFactory = new OfflineSourceCourseFactory();

//offlineSourceCourseFactory.GetCourse() will create and return FrondEndCourse object

var course = offlineSourceCourseFactory.GetCourse();

Console.WriteLine("Front End Course and Source Details");
Console.WriteLine(course.GetCourseName());
Console.WriteLine(course.GetCourseFee());
Console.WriteLine(course.GetCourseDuration());

//offlineSourceCourseFactory.GetSource() will create and return Offline object
var source = offlineSourceCourseFactory.GetSource();
Console.WriteLine(source.GetSourceName());


//Same steps for Online Course and Source Details
Console.WriteLine("\n----------------------\n");
Console.WriteLine("Back End Course and Source Details");
ISourceCourseFactory onlineSourceCourseFactory = new OnlineSourceCourseFactory();
course = onlineSourceCourseFactory.GetCourse();
Console.WriteLine(course.GetCourseName());
Console.WriteLine(course.GetCourseFee());
Console.WriteLine(course.GetCourseDuration());
source = onlineSourceCourseFactory.GetSource();
Console.WriteLine(source.GetSourceName());
Console.ReadKey();
