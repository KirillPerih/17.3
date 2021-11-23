using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace ConsoleApp21
{
    class students
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string otestvo { get; set; }
        public string group { get; set; }
        public int groupnum { get; set; }
        public decimal ball { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.Clear();
            StreamReader reader = new StreamReader("rew.txt", Encoding.GetEncoding(1251));
            List<students> chels = new List<students>();
            string str; 
           
            while ((str = reader.ReadLine()) != null)
            {
                string[] q = str.Split(' ','-');
                chels.Add(new students { Surname = q[0], Name = q[1], otestvo = q[2], group = q[3], groupnum = Convert.ToInt32(q[4]), ball = Convert.ToDecimal(q[5]) });
            }
            decimal qwe = chels.Min(n => n.ball);
            Console.WriteLine("Минимальный балл - "+qwe);
            decimal ewq = chels.Max(n => n.ball);
            Console.WriteLine("Максимальный балл - " + ewq);
            decimal wqe = chels.Average(n => n.ball);
            Console.WriteLine("Средний балл - " + wqe);
            Console.WriteLine("Напишите способ сортировки(desc,up)");
            string rer = Console.ReadLine();
            switch (rer)
            {
                case "desc":
                    {
                        var sort = from r in chels
                                   orderby r.ball descending
                                   select r;
                        foreach (var s in sort)
                        {
                            Console.WriteLine(s.Name +" "+ s.ball);
                        }
                        break;
                    }
                case "up":
                    {
                        var sort1 = from r in chels
                                   orderby r.ball
                                   select r;
                        foreach (var s in sort1)
                        {
                            Console.WriteLine(s.Name +" "+ s.ball);
                        }
                        break;
                    }
            break;
            }
        }
    }
}
