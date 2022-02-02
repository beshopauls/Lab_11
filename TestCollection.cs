using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Lab_11
{
    public class TestCollection 
    {
        Queue<Student> QueueStudent;
        Dictionary<int,Student> DictionaryStudent;
        public List<Person> CollectionListPerson;
        public List<string> CollectionListString;
        public Dictionary<Person, Student> CollectionDictionaryPerson_Student;
        public Dictionary<string, Student> CollectionDictionaryString_Student;
        public List<Student> CollectionListStudent;
        public int _count { get; set; }

        public TestCollection()
        {
            QueueStudent = new Queue<Student>();
            DictionaryStudent = new Dictionary<int,Student>();
            CollectionListPerson = new List<Person>();
            CollectionListString = new List<string>() { };
            CollectionDictionaryPerson_Student = new Dictionary<Person, Student>();
            CollectionDictionaryString_Student = new Dictionary<string, Student>();
            CollectionListStudent = new List<Student>();
        }
        public void menu()
        {
            int choice =0;
            bool success;
            while (choice != 4)
            {
                Console.WriteLine(" 1 - Task 1 Queue<TValue> ");
                Console.WriteLine(" 2 - Task 2 Dictionary<Tkey,TValue> ");
                Console.WriteLine(" 3 - Task 3 List<T> Dictionary<T> ");
                Console.WriteLine(" 4 - Exite ");

                success = int.TryParse(Console.ReadLine(), out choice);
                if (success)
                {

                    switch (choice)
                    {
                        case 1:
                            {
                                WorkWithQueue();
                                break;
                            }
                        case 2:
                            {
                                WorkWithDictionary();
                                break;
                            }
                        case 3:
                            {
                                WorkWithTask3();
                                break;
                            }
                        case 4:
                            {
                                Console.ReadKey();                           
                                break;
                            }
                        default:
                            {
                                Console.WriteLine(" Please try againe");
                                break;
                            }

                    }
                }

            }
        }
        public void WorkWithQueue()
        {
            int choice = 0;
            bool success;
            while (choice != 4)
            {
                Console.WriteLine(" 1 - Add element ");
                Console.WriteLine(" 2 - Remove element ");
                Console.WriteLine(" 3 - Print Queue ");
                Console.WriteLine(" 4 - back ");
                success = int.TryParse(Console.ReadLine(), out choice);
                if (success)
                {
                    switch(choice)
                    {
                        case 1:
                        {
                                Student student1 = new Student(101,0,26, "Bisho", true,"SW");
                                Student student2 = new Student(102,0,29, "Makarious", true,"CS");
                                Student student3 = new Student(103,0,24, "Marina", false,"IT");
                                Student student4 = new Student(104,0,22, "Verina", false,"AI");
                                QueueStudent.Enqueue(student1);
                                QueueStudent.Enqueue(student2);
                                QueueStudent.Enqueue(student3);
                                QueueStudent.Enqueue(student4);
                               
                           break;
                        }
                        case 2:
                            {
                                if (QueueStudent.Count != 0)
                                {
                                    Console.WriteLine(" Enter number of element you need deleting it");
                                    success = int.TryParse(Console.ReadLine(), out choice);
                                    for (int i = 0; i < choice; i++)
                                        QueueStudent.Dequeue();
                                }
                                else
                                    Console.WriteLine(" This Queue is Empty");
                                break;
                            }
                        case 3:
                            {
                                if(QueueStudent.Count != 0)
                                foreach (Student student in QueueStudent)
                                    Console.WriteLine(" " + student.Id + " "+student.Name + " " +" "+student.Age +" "+ student.GenderMale + " "+ student.Section );
                               else
                                    Console.WriteLine(" This Queue is Empty");
                                break;
                            }
                        case 4:
                            {
                                menu();
                                break;
                            }
                    }
                }
            }
        }
        public void WorkWithDictionary()
        {
            int choice = 0;
            bool success;
            while (choice != 4)
            {
                Console.WriteLine(" 1 - Add element ");
                Console.WriteLine(" 2 - Remove element ");
                Console.WriteLine(" 3 - Print Dictionary ");
                Console.WriteLine(" 4 - back ");
                success = int.TryParse(Console.ReadLine(), out choice);
                if (success)
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Student student1 = new Student(101, 0, 26, "Bisho", true, "SW");
                                Student student2 = new Student(102, 0, 29, "Makarious", true, "CS");
                                Student student3 = new Student(103, 0, 24, "Marina", false, "IT");
                                Student student4 = new Student(104, 0, 22, "Verina", false, "AI");
                                DictionaryStudent.Add(student1.Id, student1);
                                DictionaryStudent.Add(student2.Id, student2);
                                DictionaryStudent.Add(student3.Id, student3);
                                DictionaryStudent.Add(student4.Id, student4);
                                break;
                            }
                        case 2:
                            {
                                if (DictionaryStudent.Count != 0)
                                {
                                    Console.WriteLine(" Enter ID of student you need deleting it");
                                    success = int.TryParse(Console.ReadLine(), out choice);
                                    if (DictionaryStudent.ContainsKey(choice))
                                             DictionaryStudent.Remove(choice);
                                }
                                else
                                    Console.WriteLine(" This Dictionary is Empty");
                                break;
                            }
                        case 3:
                            {
                                if (DictionaryStudent.Count != 0)
                                    foreach (KeyValuePair<int , Student> student in DictionaryStudent)
                                        Console.WriteLine(" " + student.Key + " " + student.Value.Name + " " 
                                            + " " + student.Value.Age + " " + student.Value.GenderMale + " " + student.Value.Section);                               
                                else
                                    Console.WriteLine(" This Dictionary is Empty");
                                break;
                            }
                        case 4:
                            {
                                menu();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine(" Please try againe");
                                break;
                            }
                    }
                }
            }
        }
        public void WorkWithTask3()
        {
            Console.WriteLine(" Dictionary<K,T>   List<T>");
            int Choice = 0, obj;
            bool success;
            TestCollection data = new TestCollection();
     
          
            while (Choice != 4)
            {
                Console.WriteLine(" 1 - Add Element");
                Console.WriteLine(" 2 - Delete Element");
                Console.WriteLine(" 3 - Anlize");
                Console.WriteLine(" 4 - back");
                success = int.TryParse(Console.ReadLine(), out Choice);
                switch (Choice)
                {
                    case 1:
                        {
                            success = int.TryParse(Console.ReadLine(), out obj);
                            data.Add(obj);
                            Console.WriteLine("Operation completed successfully");
                            break;
                        }
                    case 2:
                        {
                            success = int.TryParse(Console.ReadLine(), out obj);
                            data.Delete(obj);                           
                            break;
                        }
                    case 3:
                        {
                            if (data._count >= 3)
                                data.Analis();
                            else
                                Console.WriteLine("Not enough items");
                            break;
                        }
                    case 4:
                        {
                            menu();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine( " Please try againe");
                            break;
                        }
                } 
            }
        }
        public void Add(int num)
        {
            int count = 0;
            while (count != num)
            {

                Student student = (Student)RandomCalss.GetRandom(0);
                Person person = student.Person_index;
                if (!CollectionDictionaryString_Student.ContainsKey(person.Name) && !CollectionDictionaryPerson_Student.ContainsKey(person))
                {
               
                    CollectionListPerson.Add(person);
                    CollectionListString.Add(person.Name);
                    CollectionDictionaryPerson_Student.Add(person, student);
                    CollectionDictionaryString_Student.Add(person.Name, student);
                    CollectionListStudent.Add(student);
                    count++;
                }
                this._count = CollectionListStudent.Count;
            }

            this._count = CollectionListStudent.Count;
        }
        public bool Delete(int numberStudent)
        {
            if (CollectionListStudent.Contains(CollectionListStudent[numberStudent]))
            {
                
                CollectionListPerson.Remove(CollectionListStudent[numberStudent].Person_index);
                CollectionListString.Remove(CollectionListStudent[numberStudent].Person_index.Name);
                CollectionDictionaryPerson_Student.Remove(CollectionListStudent[numberStudent].Person_index);
                CollectionDictionaryString_Student.Remove(CollectionListStudent[numberStudent].Person_index.Name);
                CollectionListStudent.Remove(CollectionListStudent[numberStudent]);
                this._count = CollectionListPerson.Count;
                return true;
            }
            else
                return false;
        }
        public  void Print_Collection()
        {
            foreach (Person person in CollectionListPerson)
                Console.WriteLine(person.Name +" "+ person.Age + " "+ person.GenderMale) ;
        }
        public void Analis()
        {
            Stopwatch stopwatch = new Stopwatch();

            Student FirstStudent = ((Student)CollectionListStudent[0].Clone());
            Student LastStuent = (Student)CollectionListStudent[CollectionListStudent.Count - 1].Clone();
            Student MiddelStudent = (Student)CollectionListStudent[CollectionListStudent.Count / 2].Clone();
            Student NonStudent = (Student)RandomCalss.GetRandom(0);

            Person FirstPerson = FirstStudent.Person_index;
            Person LastPerson = LastStuent.Person_index;
            Person MiddelPerson = LastStuent.Person_index;
            Person NonPerson = NonStudent.Person_index;
            string FirstStudentString = FirstStudent.Name;
            string LastStuentString = LastStuent.Name;
            string MiddelStudentString = MiddelStudent.Name;
            string NonStudentString = NonStudent.Name;
            bool IsFind;//For seacrching (linear search)

            stopwatch.Start();
            IsFind = CollectionListPerson.Contains(CollectionListPerson[0]);
            stopwatch.Stop();
            Console.WriteLine(" First  => List<T>                       : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionListPerson.Contains(CollectionListPerson[CollectionListPerson.Count() - 1]);
            stopwatch.Stop();
            Console.WriteLine(" Last  => List<T>                        : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);


            stopwatch.Restart();
            IsFind = CollectionListPerson.Contains(CollectionListPerson[CollectionListPerson.Count() / 2]);
            stopwatch.Stop();
            Console.WriteLine(" Middel  => List<T>                      : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionListPerson.Contains(NonPerson);
            stopwatch.Stop();
            Console.WriteLine("non-existent  => List<T>                 : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);


            //List<string>
            stopwatch.Restart();
            IsFind = CollectionListString.Contains(CollectionListString[0]);
            stopwatch.Stop();
            Console.WriteLine(" First  => List<string>                  : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionListString.Contains(CollectionListString[CollectionListString.Count() - 1]);
            stopwatch.Stop();
            Console.WriteLine(" Last  => List<string>                   : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionListString.Contains(CollectionListString[CollectionListString.Count() / 2]);
            stopwatch.Stop();
            Console.WriteLine(" Middel  => List<string>                 : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionListString.Contains(NonStudentString);
            stopwatch.Stop();
            Console.WriteLine("non-existent  => List<string>            : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            //SortedDictionary<TKey,TValue> Key Person,Student
            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsKey(FirstPerson);
            stopwatch.Stop();
            Console.WriteLine(" First  => Dictionary<TKey,TValue> Key   : {0}   Result : {1} ", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsKey(LastPerson);
            stopwatch.Stop();
            Console.WriteLine(" Last  => Dictionary<TKey,TValue> Key    : {0}   Result : {1} ", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsKey(MiddelPerson);
            stopwatch.Stop();
            Console.WriteLine(" Middel  => Dictionary<TKey,TValue> Key  : {0}   Resuslt: {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsKey(NonPerson);
            stopwatch.Stop();
            Console.WriteLine("non-existent, Dictionary<TKey,TValue> Key: {0}   Result : {1} ", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            //SortedDictionary<TKey,TValue> Value Person,Student
            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsValue(FirstStudent);
            stopwatch.Stop();
            Console.WriteLine(" First  => Dictionary<TKey,TValue> Key   : {0}   Result : {1} ", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsValue(LastStuent);
            stopwatch.Stop();
            Console.WriteLine(" Last  => Dictionary<TKey,TValue> Key    : {0}   Result : {1} ", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsValue(MiddelStudent);
            stopwatch.Stop();
            Console.WriteLine(" Middel  => Dictionary<TKey,TValue> Key  : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryPerson_Student.ContainsValue(NonStudent);
            stopwatch.Stop();
            Console.WriteLine("non-existent=>Dictionary<TKey,TValue> Key: {0}   Result : {1} ", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            //SortedDictionary<string,TValue> Key
            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsKey(FirstStudentString);
            stopwatch.Stop();
            Console.WriteLine(" First => Dictionary<string,TValue> Key  : {0}   Result : {1}", stopwatch.ElapsedTicks.ToString().PadRight(6), IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsKey(LastStuentString);
            stopwatch.Stop();
            Console.WriteLine(" Last  => Dictionary<string,TValue> Key  :  {0}" , stopwatch.ElapsedTicks.ToString().PadRight(6) + "  Result : "+ IsFind);


            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsKey(MiddelStudentString);
            stopwatch.Stop();
            Console.WriteLine(" Middel=> Dictionary<string,TValue> Key  : {0}",stopwatch.ElapsedTicks.ToString().PadRight(6)+"   Result : "+IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsKey(NonStudentString);
            stopwatch.Stop();
            Console.WriteLine("non-existent=>Dictionary<string,TValue>Key:{0}   Result : {1} ",stopwatch.ElapsedTicks.ToString().PadRight(6),IsFind);

           // SortedDictionary<string, TValue> Value;
            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsValue(FirstStudent);
            stopwatch.Stop();
            Console.WriteLine(" First=> Dictionary<string,TValue> Value : {0}", stopwatch.ElapsedTicks.ToString().PadRight(6) +"   Result : "+ IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsValue(LastStuent);
            stopwatch.Stop();
            Console.WriteLine(" Last=> Dictionary<string,TValue> Value  : {0}   Result : {1}",stopwatch.ElapsedTicks.ToString().PadRight(6),IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsValue(MiddelStudent);
            stopwatch.Stop();
            Console.WriteLine(" Middel=> Dictionary<string,TValue> Value: {0}   Result : {1}",stopwatch.ElapsedTicks.ToString().PadRight(6),IsFind);

            stopwatch.Restart();
            IsFind = CollectionDictionaryString_Student.ContainsValue(NonStudent);
            stopwatch.Stop();
            Console.WriteLine("non-existent=>Dictionary<string,TValue> Value:"+ stopwatch.ElapsedTicks.ToString().PadRight(6)+"Result : "+ IsFind);
        }

    }
}