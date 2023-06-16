using Library_management;
using LibraryManagement;
var libManage = new lib_management_core(DataSource.Books, DataSource.Users);
libManage.DisplayAllBooks();
libManage.DisplayAllUsers();