using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.Core.Model
{
   public class OrderDetails
    {
        public int OrderId           { get; set; }
        public int SId               { get; set; }
        public string OrderNum          { get; set; }
        public DateTime OrderCreateTime   { get; set; }
        public string ShippingMay       { get; set; }
        public int State             { get; set; }
        public int GoodNum           { get; set; }
        public double GoodPrefer        { get; set; }
        public int OrderOperId       { get; set; }
        public int Uid               { get; set; }
        public int PTid              { get; set; }
       
    }
}
