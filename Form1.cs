using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SieveOfEratosthenes
{
    public partial class MainForm : Form
    {
        // Field
        List<int> primeNumbers;
        // Constructa
        public MainForm()
        {
            InitializeComponent();
            primeNumbers = new List<int>();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NumberBox.Text))
                {
                    MessageBox.Show("Please enter an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int entNumber = int.Parse(NumberBox.Text);
                CheckPrimes(entNumber);
                DisplayPrime();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }

            btnEnter.Enabled = false;   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NumberBox.Clear();
            Primelst.Text = "";
            Counter.Text = "";
            primeNumbers.Clear();
            btnEnter.Enabled = true;
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }

        // 入力された数値が素数か調べる処理（エラトステネスの篩を実装）
        private void CheckPrimes(int entNumber)
        {
            bool[] isPrime = new bool[entNumber + 1]; // 0含ませるために+1
            for (int i = 2; i <= entNumber; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= entNumber; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= entNumber; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            // 素数リストに格納する処理
            for (int i = 2; i <= entNumber; i++)
            {
                if (isPrime[i])
                {
                    primeNumbers.Add(i);
                }
            }
        }

        // 素数リストを表示する処理
        private void DisplayPrime()
        {


            if (primeNumbers.Count > 0)
            {
                Primelst.Text = primeNumbers[0].ToString();

                for (int i = 1; i < primeNumbers.Count; i++)
                {
                    Primelst.Text += "," + primeNumbers[i].ToString();
                }


            }
            else
            {
                Primelst.Text = "Nothing";
            }

            Counter.Text = "Prime Count: " + primeNumbers.Count.ToString();
        }
    }
}
