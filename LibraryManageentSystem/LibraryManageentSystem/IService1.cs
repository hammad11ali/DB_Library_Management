using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace LibraryManageentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);
        [OperationContract]
        bool adminLogin(string name, string password);
        [OperationContract]
        bool userLogin(string name, string password);
        [OperationContract]
        List<int> getUserId();
        [OperationContract]
        List<string> getUserName();
        [OperationContract]
        List<string> getUserPassword();
        [OperationContract]
        bool adUser(string name, string password);
        [OperationContract]
        bool editUserData(string name, string password, int id);
        [OperationContract]
        void deleteUser(int id);
        [OperationContract]
        List<string> getCategoryName();
        [OperationContract]
        bool addCategory(string name);
        [OperationContract]
        bool editCategory(string name);
        [OperationContract]
        void deleteCategory(string name);
        [OperationContract]
        List<int> getBookId();
        [OperationContract]
        List<string> getCategoriesName();
        [OperationContract]
        List<string> getBookName();
        [OperationContract]
        List<int> getQuantity();
        [OperationContract]
        List<string> getBookAuthor();
        [OperationContract]
        List<string> getallCategories();
        [OperationContract]
        bool addBook(int bookId, string bookName, string author, int quantity, string category);
        [OperationContract]
        void editBook( string bookName, string author, int quantity, string category);
        [OperationContract]
        void delete(int bookId);
        [OperationContract]
        int getUser(string name);
        [OperationContract]
        bool addBookToUser(int userId, string bookName, int quantity);



    }
    }
