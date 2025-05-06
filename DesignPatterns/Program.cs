using PrototypePattern.Classes;

Student s1 = new Student(1, "A", "A@gmail", "123", "1234567890");

var s2 = s1.Clone();

Console.WriteLine(s2.Name);
