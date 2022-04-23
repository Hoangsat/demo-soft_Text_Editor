using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_editor
{
    public partial class FormTextProcessor : Form
    {
        public FormTextProcessor()
        {
            InitializeComponent();
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            if (open_fd.ShowDialog() == DialogResult.Cancel)
            return;

            try
            { 
            text_editor.Text = File.ReadAllText(open_fd.FileName, System.Text.Encoding.UTF8);
  
            }
            catch
            {
                MessageBox.Show("Error");   
            }

}

        private void button_save_file_Click(object sender, EventArgs e)
        {
            if (save_fd.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                File.WriteAllText(save_fd.FileName, text_editor.Text, System.Text.Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button_replace_Click(object sender, EventArgs e)
        {

            if (text_pattern.Text == "")
                return;
            
            text_editor.Text = text_editor.Text.Replace(text_pattern.Text, text_replace.Text);
        }

     
        
    }
}
