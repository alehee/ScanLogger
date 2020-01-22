using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EcomStatSender
{
    public partial class EcomStatSender : Form
    {
        static string PROGRAM_NAME = "EcomStatSender";
        static string PROGRAM_VERSION = "0.1";

        //static string DATABASE_CONNECTION = "datasource=172.19.26.103;port=3306;username=30908302_ec;password=rvrlkEC_;database=30908302_ec";
        static string DATABASE_CONNECTION = "datasource=riverlakestudios.pl;port=3306;username=30908302_ec;password=rvrlkEC_;database=30908302_ec";
        string sql = "SELECT Version FROM ver WHERE Program='"+PROGRAM_NAME+"'";

        int sek;
        int min;
        bool isRunning;
        bool isReading = false;
        string proces;
        string wybranyProces = "none";

        bool goodLogin = false;
        string login = "";
        string password = "";

        int lart = 0;
        int keys = 0;

        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer keyTimer = new System.Windows.Forms.Timer();

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

        // SKRYPT ZLICZANIA
        private void Zliczanie(Object myObject, EventArgs eventArgs)
        {
            isReading = false;
            keys = 0;
        }
        // -----

        private void EcomStatSender_Load(object sender, EventArgs e)
        {
            sek = 0;
            min = 0;
            isRunning = false;

            L_Wersja.Text = "Wersja: " + PROGRAM_VERSION;

            // TIMER
            myTimer.Stop();
            myTimer.Tick += new EventHandler(SekPlusPlus);
            // -----

            // ZLICZANIE KLAWISZY
            keyTimer.Stop();
            keyTimer.Interval = 800;
            keyTimer.Tick += new EventHandler(Zliczanie);
            keyTimer.Start();
            // -----

            // POŁĄCZ Z BAZĄ I ROZPOCZNIJ PROGRAM
            MySqlConnection conn = new MySqlConnection(DATABASE_CONNECTION);
            MySqlCommand query = new MySqlCommand(sql, conn);
            query.CommandTimeout = 30;

            try
            {
                conn.Open();
                MySqlDataReader mySqlDataReader = query.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.GetString(0)==PROGRAM_VERSION)
                        {
                            this.B_Login.Visible = true;
                            this.L_Login.Visible = true;
                            this.TB_Login.Visible = true;
                            this.L_Haslo.Visible = true;
                            this.TB_Haslo.Visible = true;
                        }
                        else
                        {
                            this.L_Error.Text = "Wersja programu jest nieaktualna!";
                            this.L_Error.Visible = true;
                        }
                    }
                }
                else
                {
                    this.L_Error.Text = "Sprawdź połączenie internetowe i zrestartuj program!";
                    this.L_Error.Visible = true;
                }
            }
            catch(Exception e_sql)
            {
                this.L_Error.Text = e_sql.ToString();
                this.L_Error.Visible = true;
            }
            // -----
        }

        private void B_StartStop_MouseClick(object sender, EventArgs e)
        {
            // ZACZNIJ DZIAŁAĆ
            if (isRunning == false)
            {
                try
                {
                    proces = wybranyProces;
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
                    this.B_ZmienProces.Enabled = false;
                    myTimer.Interval = 1000;
                    myTimer.Start();
                }
                else
                {
                    this.L_Error.Text = "Wybierz proces!";
                    this.L_Error.Visible = true;
                }
            }
            // -----

            // PRZESTAŃ DZIAŁAĆ
            else
            {
                myTimer.Stop();
                isRunning = false;

                sendStats(min, sek, lart);
                min = 0;
                sek = 0;
                lart = 0;

                this.L_Artykuly.Text = "0";
                this.L_Czas.Text = "0:00";
                this.B_StartStop.ForeColor = Color.Green;
                this.B_StartStop.Text = "START";
                this.B_ZmienProces.Enabled = true;
            }
            // -----

            B_Handler.Focus();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            login = this.TB_Login.Text.ToString();
            password = this.TB_Haslo.Text.ToString();

            goodLogin = isGoodLogin(login, password);
            goodLogin = true;
            // JEŻELI DOBRY LOGIN TO ZALOGUJ SIĘ
            if(goodLogin)
            {
                this.L_Error.Visible = false;
                this.L_Czas.Visible = false;
                this.L_CzasText.Visible = false;
                this.L_Artykuly.Visible = false;
                this.L_ArtykulyText.Visible = false;
                this.B_StartStop.Visible = false;
                this.L_Login.Visible = false;
                this.TB_Login.Visible = false;
                this.L_Haslo.Visible = false;
                this.TB_Haslo.Visible = false;
                this.B_Login.Visible = false;
                this.L_Procesy.Visible = true;
                this.B_PakowanieMONO.Visible = true;
                this.B_SortowanieBPIC.Visible = true;
                this.B_PakowanieBPIC.Visible = true;
                this.B_SortowanieVOLU.Visible = true;
                this.B_PakowanieVOLU.Visible = true;
                this.B_PakowanieMVOL.Visible = true;
                this.B_ZmienProces.Visible = false;
            }
            // JEŻELI NIE WYŚWIETL ERROR
            else
            {
                this.L_Error.Text = "Błędny login lub hasło!";
                this.L_Error.Visible = true;
                this.L_Czas.Visible = false;
                this.L_CzasText.Visible = false;
                this.L_Artykuly.Visible = false;
                this.L_ArtykulyText.Visible = false;
                this.B_StartStop.Visible = false;
                this.L_Login.Visible = true;
                this.TB_Login.Visible = true;
                this.L_Haslo.Visible = true;
                this.TB_Haslo.Visible = true;
                this.B_Login.Visible = true;
                this.L_Procesy.Visible = false;
                this.B_PakowanieMONO.Visible = false;
                this.B_SortowanieBPIC.Visible = false;
                this.B_PakowanieBPIC.Visible = false;
                this.B_SortowanieVOLU.Visible = false;
                this.B_PakowanieVOLU.Visible = false;
                this.B_PakowanieMVOL.Visible = false;
                this.B_ZmienProces.Visible = false;
            }
        }

        private void B_Handler_KeyDown(object sender, KeyEventArgs e)
        {
            if (isRunning && isReading == false)
            {
                if(e.KeyCode < Keys.D9 || e.KeyCode > Keys.D0)
                {
                    if(isReading == false)
                        isReading = true;
                }
            }
            else if (isReading)
            {
                if (e.KeyCode < Keys.D9 || e.KeyCode > Keys.D0)
                {
                    keys++;
                }
                if(keys > 25)
                {
                    lart++;
                    keys = 0;
                    isReading = false;
                    this.L_Artykuly.Text = lart.ToString();
                }
            }
        }

        bool isGoodLogin(string possibleLogin, string possiblePassword)
        {
            sql = "SELECT ID FROM users WHERE Login='"+possibleLogin+"' AND Password='"+possiblePassword+"'";

            MySqlConnection conn = new MySqlConnection(DATABASE_CONNECTION);
            MySqlCommand query = new MySqlCommand(sql, conn);
            query.CommandTimeout = 30;

            try
            {
                conn.Open();
                MySqlDataReader mySqlDataReader = query.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e_sql)
            {
                return false;
            }
        }

        void sendStats(int statMin, int statSek, int statArt)
        {
            if(statSek<=10 && statMin == 0 || statArt<1)
            {
                this.L_Error.Text = "Czas lub l.art. zbyt mała!";
                this.L_Error.Visible = true;
            }
            else
            {
                string statProces = wybranyProces;
                int statTime = statMin * 60 + statSek;
                sql = "INSERT INTO stats (ID, UserLogin, Proces, Time, Articles, Date) VALUES (NULL, '"+login+"', '"+statProces+"', '"+statTime+"', '"+statArt+"', CURRENT_TIMESTAMP)";

                MySqlConnection conn = new MySqlConnection(DATABASE_CONNECTION);
                MySqlCommand query = new MySqlCommand(sql, conn);
                query.CommandTimeout = 30;

                try
                {
                    conn.Open();
                    MySqlDataReader mySqlDataReader = query.ExecuteReader();
                }
                catch (Exception e_sql)
                {
                    this.L_Error.Text = "Wystąpił błąd podczas wysyłania danych!";
                    this.L_Error.Visible = true;
                }
            }
        }

        private void B_ZmienProces_Click(object sender, EventArgs e)
        {
            wybranyProces = "";
            this.L_Procesy.Visible = true;
            this.B_PakowanieMONO.Visible = true;
            this.B_SortowanieBPIC.Visible = true;
            this.B_PakowanieBPIC.Visible = true;
            this.B_SortowanieVOLU.Visible = true;
            this.B_PakowanieVOLU.Visible = true;
            this.B_PakowanieMVOL.Visible = true;
            this.B_ZmienProces.Visible = false;
            this.L_Czas.Visible = false;
            this.L_CzasText.Visible = false;
            this.L_Artykuly.Visible = false;
            this.L_ArtykulyText.Visible = false;
            this.B_StartStop.Visible = false;
        }

        private void B_PakowanieMONO_Click(object sender, EventArgs e)
        {
            wybranyProces = "Pakowanie MONO";
            this.L_Procesy.Visible = false;
            this.B_PakowanieMONO.Visible = false;
            this.B_SortowanieBPIC.Visible = false;
            this.B_PakowanieBPIC.Visible = false;
            this.B_SortowanieVOLU.Visible = false;
            this.B_PakowanieVOLU.Visible = false;
            this.B_PakowanieMVOL.Visible = false;
            this.B_ZmienProces.Visible = true;
            this.L_Czas.Visible = true;
            this.L_CzasText.Visible = true;
            this.L_Artykuly.Visible = true;
            this.L_ArtykulyText.Visible = true;
            this.B_StartStop.Visible = true;
        }

        private void B_SortowanieBPIC_Click(object sender, EventArgs e)
        {
            wybranyProces = "Sortowanie BPIC";
            this.L_Procesy.Visible = false;
            this.B_PakowanieMONO.Visible = false;
            this.B_SortowanieBPIC.Visible = false;
            this.B_PakowanieBPIC.Visible = false;
            this.B_SortowanieVOLU.Visible = false;
            this.B_PakowanieVOLU.Visible = false;
            this.B_PakowanieMVOL.Visible = false;
            this.B_ZmienProces.Visible = true;
            this.L_Czas.Visible = true;
            this.L_CzasText.Visible = true;
            this.L_Artykuly.Visible = true;
            this.L_ArtykulyText.Visible = true;
            this.B_StartStop.Visible = true;
        }

        private void B_PakowanieBPIC_Click(object sender, EventArgs e)
        {
            wybranyProces = "Pakowanie BPIC";
            this.L_Procesy.Visible = false;
            this.B_PakowanieMONO.Visible = false;
            this.B_SortowanieBPIC.Visible = false;
            this.B_PakowanieBPIC.Visible = false;
            this.B_SortowanieVOLU.Visible = false;
            this.B_PakowanieVOLU.Visible = false;
            this.B_PakowanieMVOL.Visible = false;
            this.B_ZmienProces.Visible = true;
            this.L_Czas.Visible = true;
            this.L_CzasText.Visible = true;
            this.L_Artykuly.Visible = true;
            this.L_ArtykulyText.Visible = true;
            this.B_StartStop.Visible = true;
        }

        private void B_SortowanieVOLU_Click(object sender, EventArgs e)
        {
            wybranyProces = "Sortowanie VOLU";
            this.L_Procesy.Visible = false;
            this.B_PakowanieMONO.Visible = false;
            this.B_SortowanieBPIC.Visible = false;
            this.B_PakowanieBPIC.Visible = false;
            this.B_SortowanieVOLU.Visible = false;
            this.B_PakowanieVOLU.Visible = false;
            this.B_PakowanieMVOL.Visible = false;
            this.B_ZmienProces.Visible = true;
            this.L_Czas.Visible = true;
            this.L_CzasText.Visible = true;
            this.L_Artykuly.Visible = true;
            this.L_ArtykulyText.Visible = true;
            this.B_StartStop.Visible = true;
        }

        private void B_PakowanieVOLU_Click(object sender, EventArgs e)
        {
            wybranyProces = "Pakowanie VOLU";
            this.L_Procesy.Visible = false;
            this.B_PakowanieMONO.Visible = false;
            this.B_SortowanieBPIC.Visible = false;
            this.B_PakowanieBPIC.Visible = false;
            this.B_SortowanieVOLU.Visible = false;
            this.B_PakowanieVOLU.Visible = false;
            this.B_PakowanieMVOL.Visible = false;
            this.B_ZmienProces.Visible = true;
            this.L_Czas.Visible = true;
            this.L_CzasText.Visible = true;
            this.L_Artykuly.Visible = true;
            this.L_ArtykulyText.Visible = true;
            this.B_StartStop.Visible = true;
        }

        private void B_PakowanieMVOL_Click(object sender, EventArgs e)
        {
            wybranyProces = "Pakowanie MVOL";
            this.L_Procesy.Visible = false;
            this.B_PakowanieMONO.Visible = false;
            this.B_SortowanieBPIC.Visible = false;
            this.B_PakowanieBPIC.Visible = false;
            this.B_SortowanieVOLU.Visible = false;
            this.B_PakowanieVOLU.Visible = false;
            this.B_PakowanieMVOL.Visible = false;
            this.B_ZmienProces.Visible = true;
            this.L_Czas.Visible = true;
            this.L_CzasText.Visible = true;
            this.L_Artykuly.Visible = true;
            this.L_ArtykulyText.Visible = true;
            this.B_StartStop.Visible = true;
        }
    }
}