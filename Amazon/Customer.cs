using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
          var caclulator=new RateCalculator();
            var rating = caclulator.Calculate(this);
            Console.WriteLine("changed");
        }
        ////private can be called inside class itself/if changed to protected , the Gold Customer class can access it
        //private int CalculateRating(bool execludeOrders)
        //{
        //    return 0;
        //}

    }
}