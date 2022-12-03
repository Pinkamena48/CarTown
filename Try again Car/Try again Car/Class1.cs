using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Try_again_Car
{
    public class Make_a_car
    {   

        public String Make;
        public String Model;
        public String Bodytype;
     
       
      
        public void DoorOTwo()
        {
            Console.WriteLine("You open both your doors.");
        }
        public void DoorOFour()
        {
            Console.WriteLine("You open your four doors.");
        }
        public void DoorOThree()
        {
            Console.WriteLine("You open your three doors.");
        }
        
        public void EngineOn()
        {
            Console.WriteLine("The engine turns on and the engine hums beautifully.");
        }
        
        public void EngineOff()
        {
            Console.WriteLine("The engine turns off.");
        }
        public void MotionOn()
        {
            Console.WriteLine("You hit the gas and start crusing down the road.");
        }
        public void MotionOff()
        {
            Console.WriteLine("The vehicle comes to a hault.");
        }
        public void KeyOn()
        {
           
            Console.WriteLine("You put the key in the ignition and turn it.");
        }
        public void KeyOff()
        {
            Console.WriteLine("You turn the key");
        }
        public void KeyError()
        {
            Console.WriteLine("Got to apply the breaks first");
        }
        public void BreakOn()
        {
            Console.WriteLine("You hit the breaks");
        }
        public void DescriptionSUV()
        {
           Console.WriteLine("Stylish, sleek looking vehicles that offer elegant city driving but also handle rugged terrain thanks to a typical 4x4 capability");
        }
        public void DescriptionCoupe()
        {
            Console.WriteLine("A stylish passenger car with a sloping or truncated rear roofline and two doors.");
        }
        public void DescriptionSedan()
        {
            Console.WriteLine("A 4-door passenger car with a trunk that is separate from the passengers with a three-box body");
        }
        public void DescriptionTruck()
        {
            Console.WriteLine("A motor vehicle designed to transport cargo, carry specialized payloads, or perform other utilitarian work.");
        }
        public void DescriptionWagon()
        {
            Console.WriteLine("A wagon has a low floor that hangs close to the ground, with its length that is greater than its height, and a long roofline that falls past its rear doors");
        }
        public void DescriptionMinivan()
        {
            Console.WriteLine("A vehicle built atop a platform of a small car with a low body, sliding or hinged rear doors, and 3 rows of seats that fit 8-9 passengers in total.");
        }
        public void DescriptionVan()
        {
            Console.WriteLine("A usually enclosed wagon or motortruck used for transportation of goods or animals.");
        }
        public void DescriptionConvertible()
        {
            Console.WriteLine("A passenger car that can be driven with or without a roof in place.");
        }
        public void DescriptionHatchback()
        {
            Console.WriteLine("A car body configuration with a rear door that swings upward to provide access to a cargo area.");
        }

        public void Tires()
        {
            Console.WriteLine("Your vehicle has 4 brand new Goodyear tires. Not sponsered.TM");
        }

    }
    //public class Toyota
    //{
      //  p


    //}

}
