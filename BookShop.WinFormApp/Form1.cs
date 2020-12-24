using BookShop.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BookShop.DataAccessLayer.Concrete.EntityFramework;
using BookShop.DataAccessLayer.Concrete.ADONET;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bookManager = new BookManager(new AdoBookDal());
            dataGridView1.DataSource = bookManager.GetAll();
        }
    }
}
