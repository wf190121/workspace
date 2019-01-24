using System.Collections.Generic;

namespace BookWeb.Models.Logic
{
    public class ForTest
    {

        public int? test(string a, string b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            int ifToInta = 0;
            int.TryParse(a, out ifToInta);
            int ifToIntb = 0;
            int.TryParse(b, out ifToIntb);
            if (ifToInta == 0 || ifToIntb == 0)
            {
                return null;
            }
            var inta = int.Parse(a);
            var intb = int.Parse(b);
            if (inta > intb) {
                return inta - intb;
            }
            if (inta == intb)
            {
                return inta * intb;
            }
                return inta + intb;
            
        }
    }
}