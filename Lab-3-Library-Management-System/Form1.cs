using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUserOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_UserID.Text);
            string name = tb_Name.Text;
            string address = tb_Address.Text;

            User dummy = new User(id,name,address);
            users.Add(dummy);
            MessageBox.Show("User has been added successfully !");
        }
       

        private void AddBookOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_BookID.Text);
            string title = tb_BookTitle.Text;
            string author = tb_Author.Text; 
            string publisher = tb_Publisher.Text;   
            int quantity = Convert.ToInt32(tb_Quantity.Text);   

            if (quantity < 0)
            {
                MessageBox.Show("Quantity can not be negative.");
                return;
            }

            Book dummy = new Book(id,title,author,publisher,quantity);
            books.Add(dummy);
            MessageBox.Show("Book has been added successfully!");
        }

        
        private void ShowBookHistoryOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_ShowBookID.Text);
            bool flag = false;
            foreach (Book book in books)
            {
                if (book.id == id)
                {
                    flag = true;
                    lb_ShowBookID.Text = "Book ID :" + " " + book.id.ToString();
                    lb_ShowBookID.Visible = true;
                    lb_ShowBookTitle.Text = "Book Title :" + " " + book.title;
                    lb_ShowBookTitle.Visible = true;
                    lb_ShowAuthor.Text = "Author :" + " " + book.author;
                    lb_ShowAuthor.Visible = true;
                    lb_ShowPublisher.Text = "Publisher :" + " " + book.publisher;
                    lb_ShowPublisher.Visible = true;
                    lb_ShowQuantity.Text = "Quantity :" + " " + book.quantity.ToString();
                    lb_ShowQuantity.Visible = true;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }

        }
        private void ShowUserHistoryOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_ShowUserID.Text);
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)
            {
                if (user.id == id)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }
            UserListBox.Items.Clear();
            for (int i = 0; i < dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[j].id == id_book)
                    {
                        UserListBox.Items.Add(books[j].history());
                    }
                }
            }

        }


        private bool userExists(int id)
        {
            foreach (User user in users)
            {
                if (user.id == id)
                {
                    return true;
                }
            }
            return false;
        }
        private bool bookExists(int id)
        {
            foreach (Book book in books)
            {
                if (book.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void BorrowOnClick(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(tb_BorrowUserID.Text);
            int bookID = Convert.ToInt32(tb_BorrowBookID.Text);

            if (bookExists(bookID) && userExists(userID))
            {
                foreach (Book book in books)
                {
                    if (book.id == bookID)
                    {
                        if (book.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        book.quantity -= 1;
                        foreach (User user in users)
                        {
                            if (user.id == userID)
                            {
                                user.books.Add(bookID);
                                MessageBox.Show("Book has been added to the user.");
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }
    }
}
