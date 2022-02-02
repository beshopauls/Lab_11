using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Lab_11;
namespace TestsClasses
{
    [TestClass]
    public class Tests
    {
       
        [TestMethod]
        public void Test_Constructor_Person_withoutParameters()
        {
            Person person = new Person();
            Assert.AreEqual(0, person.Age);
            Assert.IsNull(person.Name);
            Assert.AreEqual(true, person.GenderMale);
        }
        [TestMethod]
        public void Test_Constructor_Person_withParameters()
        {
            Person person1 = new Person(26, "Bisho", true);
            Person person2 = new Person(26, "Bisho", true);
            Assert.IsTrue(AssertObjectAreEqual(person1, person2));
        }
        [TestMethod]
        public void Test_clone()
        {
            Person person1 = new Person(26, "Bisho", false);
            Person person2 = (Person)person1.Clone();
            Assert.AreEqual("Bisho", person2.Name);
        }
        [TestMethod]
        public void Test_counting_gender()
        {
            Student[] student = new Student[10];
            student[0] = new Student(101, 0, 26, "Bisho", true, "SW");
            student[1] = new Student(101, 0, 26, "Makarious", true, "SW");
            student[2] = new Student(101, 0, 26, "Verina", false, "SW");
            student[3] = new Student(101, 0, 26, "Marina", false, "SW");
            student[4] = new Student(101, 0, 26, "Marina", false, "SW");
            student[5] = new Student(101, 0, 26, "Marina", false, "SW");
            student[6] = new Student(101, 0, 26, "Marina", false, "SW");
            student[7] = new Student(101, 0, 26, "Marina", false, "SW");
            student[8] = new Student(101, 0, 26, "Marina", false, "SW");
            student[9] = new Student(101, 0, 26, "Marina", false, "SW");
            student[9] = new Student(101, 0, 26, "Marina", false, "SW");
            student[9] = new Student(101, 0, 26, "Marina", false, "SW");
            student[9] = new Student(101, 0, 26, "Marina", false, "SW");
            Assert.AreEqual(Student.countMale, Student.countFemale);
        }
        [TestMethod]
        public void Test_CompatTo()
        {
            Person person1 = new Person(26, "Bishoo", true);
            Person person2 = new Person(26, "Bisho", false);
            Assert.AreEqual(1, String.Compare(person1.Name, person2.Name));
        }
        [TestMethod]
        public void Test_Comparing()
        {
            Person person1 = new Person(26, "Bisho", true);
            Person person2 = new Person(26, "Bisho", false);
            Assert.AreEqual(1, person1.Compare(person1, person2));
        }
        [TestMethod]
        public void Test_Constructor_Employee_withoutParameters()
        {
            Employee employee = new Employee();
            Assert.AreEqual(0, employee.Id);
            Assert.AreEqual(0, employee.Age);
            Assert.IsNull(employee.Name);
            Assert.AreEqual(true, employee.GenderMale);
            Assert.AreEqual(0, employee.Salary);
        }
        [TestMethod]
        public void Test_Constructor_Employee_withParameters()
        {
            Employee employee1 = new Employee(1, 2000, 26, "Bisho", true);
            Employee employee2 = new Employee(1, 2000, 26, "Bisho", true);
            Assert.IsTrue(AssertObjectAreEqual(employee1, employee2));
        }
        [TestMethod]
        public void Test_Constructor_Student_withoutParameters()
        {
            Student student = new Student();
            Assert.AreEqual(0, student.Id);
            Assert.AreEqual(0, student.Age);
            Assert.IsNull(student.Name);
            Assert.AreEqual(true, student.GenderMale);
            Assert.AreEqual(0, student.Salary);
            Assert.IsNull(student.Name);
            Assert.IsNull(student.Section);
        }
        [TestMethod]
        public void Test_Constructor_Student_withParameters()
        {
            Student student1 = new Student(1, 2000, 26, "Bisho", true, "SW");
            Student student2 = new Student(1, 2000, 26, "Bisho", true, "CS");
            Assert.IsTrue(AssertObjectAreEqual(student1, student2));
        }
        [TestMethod]
        public void Test_counting_number_student_by_section()
        {
            Student[] student = new Student[10];
            student[0] = new Student(101, 0, 26, "Bisho", true, "SW");
            student[1] = new Student(101, 0, 26, "Makarious", false, "CS");
            student[2] = new Student(101, 0, 26, "Verina", true, "SW");
            student[3] = new Student(101, 0, 26, "Marina", false, "CS");
            student[4] = new Student(101, 0, 26, "Marina", true, "SW");
            student[5] = new Student(101, 0, 26, "Marina", false, "CS");
            student[6] = new Student(101, 0, 26, "Marina", true, "SW");
            student[7] = new Student(101, 0, 26, "Marina", false, "CS");
            student[8] = new Student(101, 0, 26, "Marina", true, "SW");
            student[9] = new Student(101, 0, 26, "Marina", false, "CS");
            Assert.AreEqual(5, student[0].Count_number_student_by_section(student, "SW"));
        }
        [TestMethod]
        public void Test_Constructor_Teacher_withoutParameters()
        {
            Teacher teacher = new Teacher();
            Assert.AreEqual(0, teacher.Id);
            Assert.AreEqual(0, teacher.Age);
            Assert.IsNull(teacher.Name);
            Assert.AreEqual(true, teacher.GenderMale);
            Assert.AreEqual(0, teacher.Salary);
            Assert.IsNull(teacher.Name);
            Assert.IsNull(teacher.Section);
            Assert.AreEqual(0, teacher.Experience);
        }
        [TestMethod]
        public void Test_Constructor_Teacher_withParameters()
        {
            Teacher teacher1 = new Teacher(1, 2000, 26, "Bisho", true, "SW", 3);
            Teacher teacher2 = new Teacher(1, 2000, 26, "Bisho", true, "CS", 3);
            Assert.IsTrue(AssertObjectAreEqual(teacher1, teacher2));
        }
        private static bool AssertObjectAreEqual(Person expected, Person actual)
        {
            return expected.Age == actual.Age && expected.Name == actual.Name && expected.GenderMale == actual.GenderMale;
        }
        [TestMethod]
        public void Test_Sort()
        {
            IExecutable[] prints = new IExecutable[4];
            Person person = new Person(26, "Bisho", true);
            Student student = new Student(102, 0, -22, "Makarious", true, "SW");
            Employee employee = new Employee(101, 2500, 27, "Marina", false);
            Teacher teacher = new Teacher(102, 3500, 24, "Verina", false, "CS", 4);
            prints[0] = teacher;
            prints[1] = student;
            prints[2] = employee;
            prints[3] = person;
            Person[] people = new Person[4];
            for (int i = 0; i < 4; i++)
                people[i] = (Person)prints[i];
            Array.Sort(people);
            Assert.AreEqual("Bisho", people[0].Name);
        }
        [TestMethod]
        public void SortICompare()
        {
            IExecutable[] prints = new IExecutable[4];
            Person person = new Person(26, "Bisho", true);
            Student student = new Student(102, 0, -22, "Makarious", true, "SW");
            Employee employee = new Employee(101, 2500, 27, "Marina", false);
            Teacher teacher = new Teacher(102, 3500, 24, "Verina", false, "CS", 4);
            prints[0] = teacher;
            prints[1] = student;
            prints[2] = employee;
            prints[3] = person;
            Person[] people = new Person[4];
            for (int i = 0; i < 4; i++)
                people[i] = (Person)prints[i];
            Array.Sort(people, new Comparing());
            Assert.AreEqual("Verina", people[0].Name);
        }
      

    }
}
