using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }

        public void afisareDataTimp()
        {
            Calendar c = new Calendar();

            /*
            Text = c.gasesteNumarulZilei(Calendar.lunaAnului.Ianuarie).ToString();
            MessageBox.Show(c.afiseazaToateZileleSaptamanii());
            MessageBox.Show(c.afiseazaOraCurenta());
            MessageBox.Show(c.afiseazaTimpulCurent());
            MessageBox.Show(c.afiseazaDataCurenta());
            */

            for (; ; )
            {


                c.UpdateazaOraCurenta();
                //Text = c.OraCurenta.ToString();
                //MessageBox.Show( c.OraCurenta.ToString());

                Thread.Sleep(10);
            }

        }


        public delegate void MyDelegate();


        void RunlnThread()
        {
            MyDelegate dellnstatnce = new MyDelegate(Addcontrol);
            this.Invoke(dellnstatnce);
            MessageBox.Show("Hello");

        }
        void Addcontrol()
        {
            TextBox textBox1 = new TextBox();
            Controls.Add(textBox1);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {



            //Thread x = new Thread(new ThreadStart(afisareDataTimp));
            // x.Start();




            Thread t = new Thread(new ThreadStart(RunlnThread));
            t.Start();



        }
    }
}
