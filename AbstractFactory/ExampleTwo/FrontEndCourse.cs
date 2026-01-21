namespace AbstractFactory.ExampleTwo
{
    // The ProductA1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following FrontEndCourse Product Belongs to the Course product family
    public class FrontEndCourse : ICourse
    {
        public string GetCourseName()
        {
            return "Front End Development Course";
        }
        public int GetCourseFee()
        {
            return 2000;
        }
        public string GetCourseDuration()
        {
            return "6 Months";
        }
    }
}
