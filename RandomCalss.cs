using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_11
{
    public class RandomCalss
    {
        static Random rand = new Random();
        static public string GetRandomString()
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
           
            string result = "";
            for (int i = 0; i < 10; i++)
                result += alpha[rand.Next(26)];
            return result;
        }
        static public Person GetRandom(int type)
        {
            if (type == -1) 
             type = rand.Next(4); 
            if (type == 0)
            {
                Student result = new Student();
                result.Name = GetRandomString();
                result.Age = rand.Next(0, 100);
                result.Section = "SW";
                result.Salary = rand.Next(0,0);
                result.Id = rand.Next(0,0);
                result.GenderMale = rand.Next(0, 100) % 2 == 0;
             
                return result;
            }
            else if (type == 1)
            {
                Person result = new Person();
                result.Name = GetRandomString();
                result.Age = rand.Next(1, 100);
                result.GenderMale = rand.Next(0, 100) % 2 == 0;
                return result;
            }
            else if (type == 2)
            {
                Teacher result = new Teacher();
                result.Name = GetRandomString();
                result.Age = rand.Next(0, 100);
                result.GenderMale = rand.Next(0, 1) % 2 == 0;
                result.Experience = rand.Next(0, 7);
                result.Id = rand.Next(100,1000);
                result.Section= "SW";
                result.Salary= rand.Next(2000, 5000);
                return result;
            }
            else
            {

                Employee result = new Employee();
                result.Name = GetRandomString();
                result.Age = rand.Next(0, 100);
                result.GenderMale = rand.Next(0, 100) % 2 == 0;
                result.Salary = rand.Next(2000, 5000);
                result.Id = rand.Next(100, 1000);
                return result;
            }
        }
    }
}