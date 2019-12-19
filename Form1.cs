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

        static string DATABASE_CONNECTION = "datasource=localhost;port=3306;username=30908302_ec;password=rvrlkEC_;database=30908302_ec";
        string sql = "SELECT Version FROM ver WHERE Program='"+PROGRAM_NAME+"'";

        int sek;
        int min;
        bool isRunning;
        bool isReading = false;
        string proces;

        bool goodLogin = false;
        string login = "";

        int lart = 1;
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

            label1.Text = "Wersja: " + PROGRAM_VERSION;

            // TIMER
            myTimer.Stop();
            myTimer.Tick += new EventHandler(SekPlusPlus);
            // -----

            // ZLICZANIE KLAWISZY
            keyTimer.Stop();
            keyTimer.Interval = 500;
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
            }
            // -----

            CB_Proces.Focus();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            login = this.TB_Login.Text.ToString();

            goodLogin = isGoodLogin(login);

            // JEŻELI DOBRY LOGIN TO ZALOGUJ SIĘ
            if(goodLogin)
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
                this.L_Proces.Visible = false;
                this.CB_Proces.Visible = false;
                this.L_Czas.Visible = false;
                this.L_CzasText.Visible = false;
                this.L_Artykuly.Visible = false;
                this.L_ArtykulyText.Visible = false;
                this.B_StartStop.Visible = false;
            }
        }

        private void CB_Proces_KeyDown(object sender, KeyEventArgs e)
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
                if(keys > 29)
                {
                    lart++;
                    keys = 0;
                    isReading = false;
                    this.L_Artykuly.Text = lart.ToString();
                }
            }
        }

        bool isGoodLogin(string possibleLogin)
        {
            sql = "SELECT ID FROM users WHERE Login='"+possibleLogin+"'";

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
                string statProces = CB_Proces.SelectedItem.ToString();
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
    }
}