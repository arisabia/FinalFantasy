using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Helper
    {
        public static void StampaCollection<T>(ICollection<T> collection) where T : class
        {
            if (collection.Count == 0)
            {
                Console.WriteLine("List Empty");
                return;
            }
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
