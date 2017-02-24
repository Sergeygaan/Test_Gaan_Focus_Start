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

namespace Test_Gaan_Focus_Start
{
    public partial class MainForm : Form
    {
        private List<String> _string = new List<String>();
        private List<String> _stringSave = new List<String>();

        private ReadFile _readFile = new ReadFile();
        private InsertionSort _sortList = new InsertionSort();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _string.Clear();
            Stream MyStream = null;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

            OpenFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            OpenFileDialog1.Filter = "text files (*.txt)|*.txt";
            OpenFileDialog1.FilterIndex = 2;
            OpenFileDialog1.RestoreDirectory = true;

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((MyStream = OpenFileDialog1.OpenFile()) != null)
                    {
                        using (MyStream)
                        {
                            MyStream.Close();
                            _string = _readFile.ReadList(OpenFileDialog1.FileName, _string);
                            _stringSave = _string.GetRange(0, _string.Count);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка. Файл не может быть считан: " + ex.Message);
                }
            }

            PrintList(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream MyStream;
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            SaveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            SaveFileDialog1.Filter = "text files (*.txt)|*.txt";
            SaveFileDialog1.FilterIndex = 2;
            SaveFileDialog1.RestoreDirectory = true;

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((MyStream = SaveFileDialog1.OpenFile()) != null)
                {
                    MyStream.Close();
                    WriteFile _writeFile = new WriteFile(SaveFileDialog1.FileName, _string);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //_string = _stringSave.GetRange(0, _stringSave.Count);
            _sortList.Sorting(_string, comboBox1.SelectedIndex);
            PrintList(listBox2);
        }


        private void PrintList(ListBox ListPrint)
        {
            ListPrint.Items.Clear();
            foreach (var item in _string)
            {
                ListPrint.Items.Add(item);
            }
          
        }
    }
}
