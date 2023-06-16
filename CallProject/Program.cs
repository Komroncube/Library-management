using ClassLibrary1;

//var person = new Person();
//person.Name = "Farhod";

var user = new User(12, "Suhrob");
Console.WriteLine(user.Name);

object user2 = new User(12, "Shavkat");
Console.WriteLine(((User)user2).Name);

//var user= new User();
//user.Name = "Kamoliddin";
//user.Age = 30;
//user.Sozlashish();

//var student = new Student();
//student.Name = "Sitora";
//user.Age = 22;
//user.Sozlashish();
//CheckObject(user);
////CheckObject(student);


//void CheckObject1(Person p1)
//{
//    Console.WriteLine($"Name: {p1.Name} Age: {p1.Age}");
//}
//void CheckObject(User p1)
//{
//    Console.WriteLine($"Name: {p1.Name} Age: {p1.Age}");

//}