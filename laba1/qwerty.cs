using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    internal class qwerty
    {
        static List<Class> classes = new List<Class>();
        
        public void Lists()
        {
         
            Class class1 = new Class("ФП-01", 5, "Понедельник");

            Class class2 = new Class("ФП-02", 5, "Вторник");

            Class class3 = new Class("ФП-03", 5, "Среда");

            Class class4 = new Class("ФП-04", 5, "Четверг");

            Class class5 = new Class("ФП-05", 5, "Пятница");

            classes.Add(class1);
            classes.Add(class2);
            classes.Add(class3);
            classes.Add(class4);
            classes.Add(class5);
        }
       
        public static string GetInfo(string d)
        {
            string result = "";
            foreach(var a in classes)
            {
                if(d == a.day)
                {
                    result += a.name + kids.Name + kids.age + a.day + "/n";

                }
                
            }
            return result;
        }
    }
}
