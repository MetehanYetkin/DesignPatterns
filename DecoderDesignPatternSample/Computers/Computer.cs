namespace DecoderDesignPatternSample.Computers
{

     // Since 1940 First Computer is Created
    public class Computer
    {
        public void Start()
        {
          
            Console.WriteLine("Computer is starting");
        }
        public void ShutDown()
        {
           
            Console.WriteLine("Computer is shutting down");
        }

    }

     // Since 1970 First Laptop is Created
    public class Laptop:Computer
    {

        public void OpenLid()
        {
            Console.WriteLine($"{GetType().Name} ' lid is opening");
        }
        public void CloseLid()
        {
            Console.WriteLine($"{GetType().Name} ' lid is closing");
        }

    }

    public class LaptopDecoder:Laptop
    {
        public virtual void OpenLid()
        {
            base.OpenLid();
        }
        public virtual void CloseLid()
        {
            base.CloseLid();
        }
    }

    // Since 1980 Dell is development first Laptop

    public class DellLaptop: LaptopDecoder
    {
        public override void OpenLid()
        {
            Console.WriteLine("DellLaptop Said Hello");
            base.OpenLid();
        }

        public override void CloseLid()
        {
            Console.WriteLine("Dell Laptop Is Sleeping ");
            base.CloseLid(); 

        }
          
    }
    public class AppleLaptop : LaptopDecoder
    {
        public override void OpenLid()
        {
            Console.WriteLine("Siri Said Hello");
            base.OpenLid();

        }
        public override void CloseLid()
        {
            Console.WriteLine("Siri Said Bye Bye");

            base.CloseLid();
        }
    }

}
