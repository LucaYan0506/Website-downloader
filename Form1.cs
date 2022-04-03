using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Website_downloader
{
    public partial class Form1 : Form
    {
        string app_data_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\website_downloader";
        public Form1()
        {
            InitializeComponent();
            protocolComboBx.Items.Add("HTTPS");
            protocolComboBx.Items.Add("HTTP");
            f_nameTxt.ForeColor = Color.Gray;
            //create "website_downloader" directory, if it doens't exists 
            System.IO.Directory.CreateDirectory(app_data_path);
        }

        private void check_url()
        {
            if (urlTxt.Text.Length > 8)
            {
                if (urlTxt.Text.Substring(0, 8).ToLower() == "https://")
                {
                    protocolComboBx.SelectedIndex = 0;
                    urlTxt.Text = urlTxt.Text.Substring(8);
                }
                else if (urlTxt.Text.Substring(0, 7).ToLower() == "http://")
                {
                    protocolComboBx.SelectedIndex = 1;
                    urlTxt.Text = urlTxt.Text.Substring(7);
                }
            }

            if (urlTxt.Text.Length > 3)
            {
                if (urlTxt.Text.Substring(0, 3).ToLower() != "www")
                {
                    urlTxt.Text = "www." + urlTxt.Text;
                }
            }
        }

        private void generete_file_name()
        {
            //output a suggested file name if f_nameTxt is empty
            if (f_nameTxt.Text == "" || f_nameTxt.Text == "name of the html file")
            {
                int name_length = urlTxt.Text.IndexOf('.', urlTxt.Text.IndexOf('.') + 1) - urlTxt.Text.IndexOf('.') - 1;
                f_nameTxt.ForeColor = Color.Black;

                if (name_length <= 0)
                    f_nameTxt.Text = urlTxt.Text.Substring(urlTxt.Text.IndexOf('.') + 1);
                else
                    f_nameTxt.Text = urlTxt.Text.Substring(urlTxt.Text.IndexOf('.') + 1, name_length);
            }
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            check_url();
            
            //output a suggested file name if f_nameTxt is empty
            generete_file_name();

            //check if file name already exists
            if (System.IO.File.Exists(app_data_path + @"\" + f_nameTxt.Text + ".html"))
            {
                DialogResult confirm = MessageBox.Show($"{f_nameTxt.Text} already exists. Do you want to delete the previous one?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (confirm == DialogResult.No)
                {
                    return;
                }
            }

            //download url
            string url = protocolComboBx.Text + "://" + urlTxt.Text;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {
                    client.DownloadFile(url, app_data_path + "/" + f_nameTxt.Text + ".html");
                    MessageBox.Show("HTML file downloaded", "Success", MessageBoxButtons.OK);
                }
                catch (Exception error)
                {
                    if (error.Message == "" || error.Message == "f")
                        MessageBox.Show("Url not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    else
                        MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Websites(*.html)|*.html";
            fileDialog.InitialDirectory = app_data_path;
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = fileDialog.FileName;
                webBrowser1.Url = new Uri(String.Format(sFileName));

            }
        }

        private void urlTxt_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                downloadBtn.PerformClick();
        }
        
        private void f_nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                downloadBtn.PerformClick();
        }

        private void urlTxt_KeyUp(object sender, KeyEventArgs e)
        {
            //if key == ctrl + v
            if (e.KeyCode == Keys.V && e.Control)
            {
                check_url();

                //output a suggested file name if f_nameTxt is empty
                generete_file_name();
            }
        }

        private void f_nameTxt_Enter(object sender, EventArgs e)
        {
            if (f_nameTxt.Text == "name of the html file" && f_nameTxt.ForeColor == Color.Gray)
            {
                f_nameTxt.ForeColor = Color.Black;
                f_nameTxt.Text = "";
            }
        }

        private void f_nameTxt_Leave(object sender, EventArgs e)
        {
            if (f_nameTxt.Text == "" && f_nameTxt.ForeColor == Color.Black)
            {
                f_nameTxt.ForeColor = Color.Gray;
                f_nameTxt.Text = "name of the html file";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            webBrowser1.Size = new Size(webBrowser1.Size.Width,this.Size.Height - 131);
        }
    }
}
