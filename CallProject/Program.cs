using ClassLibrary1;

//var person = new Person();
//person.Name = "Farhod";

var user = new User(12, "Suhrob");
Console.WriteLine(user.Name);

Person user2 = new User(13, "Shavkat");
Console.WriteLine(((User)user2).Money);



//var user = new User();
//user.Name = "Kamoliddin";
//user.Age = 30;
//user.Sozlashish();

//var student = new Student(12,"Laylo");
//student.Name = "Sitora";
////user.Age = 22;
////user.Sozlashish();
//CheckObject(user);
//CheckObject(student);


//void CheckObject1(Person p1)
//{
//    Console.WriteLine($"Name: {p1.Name} Age: {p1.Age}");
//}
//void CheckObject(User p1)
//{
//    Console.WriteLine($"Name: {p1.Money} Age: {p1.Age}");

//}

//CheckObject12(user);

//void CheckObject12(object obj)
//{
//    Console.WriteLine("Classlar bu obyekt");
//}