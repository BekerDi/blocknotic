using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocknotic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private string file = "";
        private void Form1_Shown(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ToolTipText = "Работа с файлом";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fORMATToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Text Files |*.txt";
            if (dr == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                read.Close();
                file = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName); 
                write.Write(richTextBox1.Text);
                write.Close();
               
            }
            else
            {
                try 
                {
                    StreamReader read = new StreamReader(openFileDialog1.FileName);
                    read.Close();
                    file = openFileDialog1.FileName;

                }
                catch 
                {

                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if(dr == DialogResult.OK) 
            {

            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Этот блокнот был разработан Дианой Бекер 21.02.2024 года. Вы можете использовать данное приложение как для учебы, так и для работы и развлечений. В блокноте есть все необходимые функции: копировать, вставить, удалить, сохранить, закрыть, напечатать. Также предусмотрена возможность изменять размер, вид, жирность и цвет шрифта. По всем вопросам обращайтесь на почту d.beker.04@mail.ru");
        
        }



        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

       

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }
    }
}