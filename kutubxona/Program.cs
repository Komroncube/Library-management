using Library_management;
//while (true)
//{
//    Console.WriteLine("Enter command" +
//        "\nRegister User - 1" +
//        "\nRemove User - 2" +
//        "\nAdd book - 3" +
//        "\nRemove book - 4" +
//        "\nAll books - 5" +
//        "\nFind books - 6" +
//        "\nMost book-a-holic - 7" +
//        "\nAvailable books - 8\n");

//    var command = Console.ReadLine();
//}


//var emailservice = new EmailService();
//emailservice.SendEmail("komronabdujabbor@gmail.com");

var librarymanagement = new LibraryManagement();
librarymanagement.RegisterUser("Kamronbek", "Abdujabborov", "komronabdujabbor@gmail.com");
librarymanagement.DisplayAllBooks();