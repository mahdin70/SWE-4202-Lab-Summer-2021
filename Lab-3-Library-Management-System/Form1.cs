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
        List<Book> books = new List<Book>();
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UserSaveOnClick(object sender, EventArgs e)
        {
            User user = new User();
            user.UserID = UIDTextBox.Text;
            user.UserName = NameTextBox.Text;
            user.Address = AddressTextBox.Text;
            user.BookID = "";
            user.BookName = "";
            users.Add(user);
            MessageBox.Show("User added");
        }

        private void BookSaveOnClick(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookID = BookIDTextBox.Text;
            book.BookName = BookNameTextBox.Text;
            book.Publisher = PublisherTextBox.Text;
            book.BookAuthor = AuthorTextBox.Text;
            book.Quantity = Convert.ToInt32(QuantityTextBox.Text);
            books.Add(book);
            MessageBox.Show("Book added.");
        }

        private void BorrowBookOnClick(object sender, EventArgs e)
        {
            foreach(User user in users)
            {
                foreach(Book book in books)
                {
                    if((user.UserID==UIDTextBox3.Text)&&(book.BookID==BookIDTextBox3.Text))
                    {
                        user.BookID = BookIDTextBox3.Text;
                        user.BookName = BookNameTextBox.Text;
                        //users.Add(user);
                        book.Quantity--;
                    }
                }
            }
        }

        private void ShowUserHistoryOnClick(object sender, EventArgs e)
        {
            UserHistoryListBox.Items.Clear();
            foreach(User user in users)
            {
                if (user.UserID == UIDTextBox2.Text)
                    UserHistoryListBox.Items.Add(user.GetInfo());
            }
        }

        private void ShowBookHistoryOnClick(object sender, EventArgs e)
        {
            foreach(Book book in books)
            {
                if (book.BookID == BookIDTextBox2.Text)
                {
                    NameLabel.Text = "Name: " + book.BookName;
                    IDLabel.Text = "ID: " + book.BookID;
                    AuthorLabel.Text = "Author: " + book.BookAuthor;
                    PublisherLabel.Text = "Publisher: " + book.Publisher;
                    QuantityLabel.Text = "Quantity: " + Convert.ToString(book.Quantity);
                }
            }
        }
    }
}
