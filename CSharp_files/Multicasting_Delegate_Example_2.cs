using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastingDelegate
{
    public class RectangleHelper
    {
        public void GetParameter(int x, int y)
        {
            Console.WriteLine($"The parameter is : 2 *( {x} + {y}) = {2 * (x + y)}");
        }
        public void GetArea(int x, int y)
        {
            Console.WriteLine($"The area is : {x} * {y} = {x * y}");
        }
    }
    public class Program
    {

        public static void CalculateDimensions(int x, int y, string Message, Func<int, int, int> GetDimensions)
        {
            Console.WriteLine($"{Message} {GetDimensions(x,y)}");
        }
        static void Main(string[] args)
        {
            RectangleHelper helper = new RectangleHelper();
            helper.GetParameter(10, 10);
            helper.GetArea(10, 10);

            Action<int, int> rectDelegate;
            rectDelegate = helper.GetParameter;
            rectDelegate += helper.GetArea;
            rectDelegate(10, 10);

            Func<int, int, int> GetArea = (x, y) => x * y;
            Func<int, int, int> GetParametersArea = (x, y) => 2*(x + y);

            CalculateDimensions(10, 10, "The area of width =10 and Depth =10 is : ", GetArea);
            CalculateDimensions(10, 10, "The parameter of width =10 and Depth =10 is : ", GetParametersArea);

            Console.ReadLine();

        }
    }

    
}
