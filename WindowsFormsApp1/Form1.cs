using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        public void button1_Click(object sender, EventArgs e)
        {
            // создаем банковский счет
            Class1 account = new Class1 (200);
            Class1 name = new Class1();
            // Добавляем в делегат ссылку на метод PrintSimpleMessage
            account.RegisterHandler(PrintSimpleMessage);
            // Два раза подряд пытаемся снять деньги
            account.Take(100);
            account.Take(150);

            void PrintSimpleMessage(string message) => MessageBox.Show(message);
        }
    }
}
