using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcomStatSender
{
    public partial class EcomStatSender : Form
    {
        int sek;
        int min;
        bool isRunning;
        string proces;
        string goodLogin = "aheese11";

        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public EcomStatSender()
        {
            InitializeComponent();
        }

        // SKRYPT CO SEKUNDE TIMERA
        private void SekPlusPlus(Object myObject, EventArgs eventArgs)
        {
            sek++;

            if (sek > 59)
            {
                min++;
                sek = 0;
            }

            string s_sek = "";

            if (sek < 10)
            {
                s_sek = "0" + sek.ToString();
            }
            else
            {
                s_sek = sek.ToString();
            }

            string czas = min.ToString() + ":" + s_sek;

            this.L_Czas.Text = czas;
        }
        // -----

        private void EcomStatSender_Load(object sender, EventArgs e)
        {
            sek = 0;
            min = 0;
            isRunning = false;

            // TIMER
            myTimer.Stop();
            myTimer.Tick += new EventHandler(SekPlusPlus);
            // -----
        }

        private void B_StartStop_Click(object sender, EventArgs e)
        {
            // ZACZNIJ DZIAŁAĆ
            if (isRunning == false)
            {
                try
                {
                    proces = this.CB_Proces.SelectedItem.ToString();
                }
                catch
                {
                    proces = "";
                }
                this.L_Error.Text = proces;

                if (proces != "")
                {
                    this.L_Error.Visible = false;
                    isRunning = true;
                    this.B_StartStop.ForeColor = Color.Red;
                    this.B_StartStop.Text = "STOP";
                    myTimer.Interval = 1000;
                    myTimer.Start();
                }
                else
                {
                    this.L_Error.Text = "Wybierz proces!";
                    this.L_Error.Visible = true;
                }
            }

            // PRZESTAŃ DZIAŁAĆ
            else
            {
                myTimer.Stop();
                isRunning = false;
                this.B_StartStop.ForeColor = Color.Green;
                this.B_StartStop.Text = "START";
            }
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            string login = this.TB_Login.Text.ToString();
            // JEŻELI DOBRY LOGIN TO ZALOGUJ SIĘ
            if(login == goodLogin)
            {
                this.L_Error.Visible = false;
                this.L_Proces.Visible = true;
                this.CB_Proces.Visible = true;
                this.L_Czas.Visible = true;
                this.L_CzasText.Visible = true;
                this.L_Artykuly.Visible = true;
                this.L_ArtykulyText.Visible = true;
                this.B_StartStop.Visible = true;
            }
            // JEŻELI NIE WYŚWIETL ERROR
            else
            {
                this.L_Error.Text = "Błędny login!";
                this.L_Error.Visible = true;
            }
        }
    }
}
