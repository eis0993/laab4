using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        string commandText = "";
        List<DataGridView> comp = new List<DataGridView>();
        List<ToolStripMenuItem> comp1 = new List<ToolStripMenuItem>();
        List<BindingNavigator> comp2 = new List<BindingNavigator>();

        public Form1()
        {
            InitializeComponent();

            comp.Add(dataGridView1);
            comp.Add(dataGridView2);
            comp.Add(dataGridView3);
            comp2.Add(bindingNavigator1);
       
            comp2.Add(bindingNavigator2);

            comp2.Add(bindingNavigator3);


        }

        



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbdemosDataSet.items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.dbdemosDataSet.items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbdemosDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.dbdemosDataSet.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbdemosDataSet.customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.dbdemosDataSet.customer);

        }
         


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About.....", "About WHAT?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandText = @"F:\Новая папка\help\HTMLPage1.html";
            this.HTMLINFO();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           /* foreach (DataGridView b in comp)
            {



                if ((e.KeyCode == Keys.F1) && (b.Focused))
                {

                    commandText = @"F:\WindowsFormsApplication4\WindowsFormsApplication4\HTMLPage3.html";
                    HTMLINFO();
                }
            }

         
                
            
            */
            }

        
        public void HTMLINFO() {
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            
        }

        private void bindingNavigator2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void bindingNavigator1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (bindingNavigator1.Focused|| bindingNavigator2.Focused || bindingNavigator3.Focused )
            {
                commandText = @"F:\Новая папка\help\HTMLPage2.html";
                HTMLINFO();
            }
        }

        private void menuStrip2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (menuStrip2.Focused)
            {
                commandText = @"F:\Новая папка\help\HTMLPage4.html";
                HTMLINFO();
            }
        }

        private void bindingNavigator1_MouseMove(object sender, MouseEventArgs e)
        {
            bindingNavigator1.Focus();
            bindingNavigator2.Focus();
            bindingNavigator3.Focus();
        }

        private void dataGridView1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            commandText = @"F:\Новая папка\help\HTMLPage3.html";
            HTMLINFO();
        }

        private void menuStrip2_MouseHover(object sender, EventArgs e)
        {
            menuStrip2.Focus();
        }

    }
}
