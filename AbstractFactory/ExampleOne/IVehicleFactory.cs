namespace AbstractFactory.ExampleOne
{
    // The AbstractFactory interface
    // The Abstract Factory interface declares a set of methods that return different abstract products. 
    // These products are called a family. 
    // A family of products may have several variants
    public interface IVehicleFactory
    {
        //Abstract ProductA
        IBike CreateBike();
        //Abstract ProductB
        ICar CreateCar();
    }
}
