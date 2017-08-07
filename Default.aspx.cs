using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NamesBattleCounts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";
            string[] names = new string[] { "Tosin", "Emmanuel", "yemisi" , "Temitope", "Tolulope", "monioluwa", "Ayomide", "stephen", "Raja", "Bayo" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };
            int smallestIndex = 0;
            int largestIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[smallestIndex])
                {
                    smallestIndex = i;
                    result += string.Format("{0} {1} ", names[smallestIndex], numbers[smallestIndex]);

                }
               if (numbers[i] > numbers[largestIndex])
                {
                    largestIndex = i;

                    result = string.Format("{0} {1} <br/>", names[largestIndex], numbers[largestIndex]);
                }
               
             /* or  
                if (numbers[i] == numbers.Min())
                {
                    smallestIndex = i;
                    result += string.Format("Least battles belong to: {0} {1} ", names[smallestIndex], numbers[smallestIndex]);

                }
                if (numbers[i] == numbers.Max())
                {
                    largestIndex = i;

                    result = string.Format("Most battles belong to: {0} {1} <br/>", names[largestIndex], numbers[largestIndex]);
                }
                */

                resultLabel.Text = result;
                
            }
                          
            }
        
    }
}
