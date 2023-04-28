namespace ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Example_1
{
    public class ShapeFactory 
    {
        public Shape  performTask(string shapeName)
        {
            switch (shapeName)
            {
                case"traingle":
                    return new Traingle();
                case "square":
                    return new Square();
                case "rectangle":
                    return new Rectangle();
                

            }

            return null;
        }
        
    }
}