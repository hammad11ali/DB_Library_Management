using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace LibraryManageentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string con = "Data Source=DESKTOP-R43HTDM\\SQLEXPRESS;Initial Catalog=LibraryMangementSystem;Integrated Security=True";
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public bool adminLogin(string name, string password)
        {
            if (name == "Haseeb" && password == "123")
            {
                return true;
            }
            return false;
        }
        public bool userLogin(string name, string password)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select count(*) from tb_User where name='" + name + "'and password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            var count = cmd.ExecuteScalar();
            if (Convert.ToInt32(count) > 0)
            {
                return true;
            }
            connection.Close();
            return false;

        }
        public List<int> getUserId()
        {
            List<int> ids = new List<int>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select id from tb_User";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ids.Add(Convert.ToInt32(reader[0]));
                
            }
            return ids;
        }
        public List<string> getUserName()
        {
            
            List<string> name = new List<string>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select name from tb_User";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
                name.Add(Convert.ToString(reader[0]));
               
            }
            return name;
         
        }
        public List<string> getUserPassword()
        {
           
            List<string> password = new List<string>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select password from tb_User";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
            
                password.Add(Convert.ToString(reader[0]));
               
            }
            return password;
        }
        public bool adUser(string name, string password)
        {
            bool flag=userLogin(name, password);
            if(flag)
            {
                return false;
            }
            else
            {
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "Insert into tb_User (name,password)values('" + name + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
       public bool editUserData(string name, string password, int id)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            bool flag = userLogin(name, password);
            if (flag)
            {
                return false;
            }
            else
            {
                string query = "update tb_User set name='" + name + "',password='" + password + "'where id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public void deleteUser(int id)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "delete from tb_User where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public List<string> getCategoryName()
        {
            List<string> name = new List<string>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select name from tb_Categories ";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                name.Add(Convert.ToString(reader[0]));

            }
            return name;

        }
        public bool addCategory(string name)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            int count=checkCategory(name);   
            if (count>0)
            {
                return false;
            }
            else
            {
                string query1 = "Insert into tb_Categories (name) values('" + name + "')";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }
        public int checkCategory(string name)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select count(*) from tb_Categories where name='" + name + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            var count = cmd.ExecuteScalar();
            return Convert.ToInt32(count);
        }
        public bool editCategory(string name)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            int count = checkCategory(name);
            if(count>0)
            {
                return false;
            }
            else
            {
                string query = "ubdate tb_Categories set name='" + name + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public void deleteCategory(string name)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "delete from tb_Categories where name='" + name + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public List<int> getBookId()
        {
            List<int> ISBN_No = new List<int>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select ISBN_No from tb_Books";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ISBN_No.Add(Convert.ToInt32(reader[0]));
            }
            return ISBN_No;
        }
        public List<string> getCategoriesName()
        {
            List<int> CId = new List<int>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select category from tb_Books";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CId.Add(Convert.ToInt32(reader[0]));
            }
            List<string> CName = new List<string>();
            CName = getCNamefromId(CId);
            return CName;
           
        }
        List<string> getCNamefromId(List<int> id)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            List<string> Cname = new List<string>();
            string query;
            for (int i=0;i<id.Count;i++)
            {
             query="Select name from tb_Categories where id='"+id[i]+"'";
                SqlCommand cmd = new SqlCommand(query, connection);
                var reader=cmd.ExecuteScalar();
                Cname.Add(Convert.ToString(reader));
            }
            return Cname;
        }
        public List<string> getBookName()
        {
            List<string> bookName = new List<string>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select name from tb_Books";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bookName.Add(Convert.ToString(reader[0]));
            }

            return bookName;
        }
        public List<int> getQuantity()
        {

            List<int> booKQuantity = new List<int>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select quantity from tb_Books";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                booKQuantity.Add(Convert.ToInt32(reader[0]));
            }
            return booKQuantity;
        }
        public List<string> getBookAuthor()
        {
            List<string> bookAuthor = new List<string>();
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select author from tb_Books";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bookAuthor.Add(Convert.ToString(reader[0]));
            }

            return bookAuthor;

        }
        public List<string> getallCategories()
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            List<string> Cname = new List<string>();
            string query = "Select name from tb_Categories";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Cname.Add(Convert.ToString(reader[0]));
            }
                
            
            return Cname;
        }
        public bool addBook(int bookId, string bookName, string author, int quantity, string category)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query;
            query="Select id from tb_Categories where name='"+category+"'";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteScalar();
            int id = Convert.ToInt32(reader);
            bool check=checkBook(bookName);
            if(check)
            {
                query = "insert into tb_Books (ISBN_No,name,author,quantity,category)values('" + bookId + "','" + bookName + "','" + author + "','" + quantity + "','" + id + "')";
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
           

        }
        public bool checkBook(string bookName)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select count(*) from tb_Books where name='" + bookName + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int count=Convert.ToInt32(cmd.ExecuteScalar());
            if(count>0)
            {
                return false;
            }
            return true;
        }
        public void editBook( string bookName, string author, int quantity, string category)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query;
            query = "Select id from tb_Categories where name='" + category + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            var reader = cmd.ExecuteScalar();
            int id = Convert.ToInt32(reader);
                query = "update tb_Books set name='" + bookName + "',author='" + author + "',quantity='" + quantity + "',category='" + id + "'";
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
        }
        public void delete(int bookId)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "delete from tb_Books where ISBN_No='" + bookId + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        public int getUser(string name)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query = "Select id from tb_User where name='" + name + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int id=Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }
        public bool addBookToUser(int userId, string bookName, int quantity)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            string query;
            int q;
            int bookId;
            int newQuantity;
            bool check = checkBook(bookName);
            if(check)
            {
                query = "Select quantity from tb_Books where name='" + bookName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                q=Convert.ToInt32(cmd.ExecuteScalar());
                if(q>quantity)
                {
                    newQuantity = q - quantity;
                    query = "select id from tb_Books where name='" + bookName + "'";
                    SqlCommand cmd1 = new SqlCommand(query, connection);
                    bookId = Convert.ToInt32(cmd1.ExecuteScalar());
                    query="insert into tb_IssuedBooks (userId,bookId,quantity,issueDate)values('"+userId+"','"+bookId+"','"+quantity+"','"+DateTime.Now+"')";
                    SqlCommand cmd2 = new SqlCommand(query, connection);
                    cmd2.ExecuteNonQuery();
                    query = "update tb_Books set quantity='" + newQuantity + "'";
                    SqlCommand cmd3 = new SqlCommand(query, connection);
                    cmd3.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }

    
}