namespace EcomStatSender
{
    partial class EcomStatSender
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_Login = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.B_Login = new System.Windows.Forms.Button();
            this.B_StartStop = new System.Windows.Forms.Button();
            this.L_Czas = new System.Windows.Forms.Label();
            this.L_CzasText = new System.Windows.Forms.Label();
            this.L_Artykuly = new System.Windows.Forms.Label();
            this.L_ArtykulyText = new System.Windows.Forms.Label();
            this.L_Error = new System.Windows.Forms.Label();
            this.L_Wersja = new System.Windows.Forms.Label();
            this.L_Haslo = new System.Windows.Forms.Label();
            this.TB_Haslo = new System.Windows.Forms.TextBox();
            this.L_Procesy = new System.Windows.Forms.Label();
            this.B_PakowanieMONO = new System.Windows.Forms.Button();
            this.B_ZmienProces = new System.Windows.Forms.Button();
            this.B_SortowanieVOLU = new System.Windows.Forms.Button();
            this.B_SortowanieBPIC = new System.Windows.Forms.Button();
            this.B_PakowanieBPIC = new System.Windows.Forms.Button();
            this.B_PakowanieVOLU = new System.Windows.Forms.Button();
            this.B_PakowanieMVOL = new System.Windows.Forms.Button();
            this.B_Zwroty = new System.Windows.Forms.Button();
            this.B_Entropy = new System.Windows.Forms.Button();
            this.B_Logout = new System.Windows.Forms.Button();
            this.L_Active = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Login.Location = new System.Drawing.Point(131, 72);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(65, 26);
            this.L_Login.TabIndex = 0;
            this.L_Login.Text = "Login";
            this.L_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Login.Visible = false;
            // 
            // TB_Login
            // 
            this.TB_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_Login.Location = new System.Drawing.Point(62, 101);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(199, 30);
            this.TB_Login.TabIndex = 1;
            this.TB_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Login.Visible = false;
            // 
            // B_Login
            // 
            this.B_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_Login.Location = new System.Drawing.Point(110, 199);
            this.B_Login.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(100, 30);
            this.B_Login.TabIndex = 3;
            this.B_Login.Text = "Zaloguj";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Visible = false;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // B_StartStop
            // 
            this.B_StartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_StartStop.ForeColor = System.Drawing.Color.Green;
            this.B_StartStop.Location = new System.Drawing.Point(110, 381);
            this.B_StartStop.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.B_StartStop.Name = "B_StartStop";
            this.B_StartStop.Size = new System.Drawing.Size(100, 30);
            this.B_StartStop.TabIndex = 5;
            this.B_StartStop.TabStop = false;
            this.B_StartStop.Text = "START";
            this.B_StartStop.UseVisualStyleBackColor = true;
            this.B_StartStop.Visible = false;
            this.B_StartStop.Click += new System.EventHandler(this.B_StartStop_MouseClick);
            // 
            // L_Czas
            // 
            this.L_Czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Czas.Location = new System.Drawing.Point(21, 312);
            this.L_Czas.Name = "L_Czas";
            this.L_Czas.Size = new System.Drawing.Size(127, 46);
            this.L_Czas.TabIndex = 6;
            this.L_Czas.Text = "0:00";
            this.L_Czas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Czas.Visible = false;
            // 
            // L_CzasText
            // 
            this.L_CzasText.AutoSize = true;
            this.L_CzasText.Location = new System.Drawing.Point(66, 299);
            this.L_CzasText.Name = "L_CzasText";
            this.L_CzasText.Size = new System.Drawing.Size(30, 13);
            this.L_CzasText.TabIndex = 7;
            this.L_CzasText.Text = "Czas";
            this.L_CzasText.Visible = false;
            // 
            // L_Artykuly
            // 
            this.L_Artykuly.AutoSize = true;
            this.L_Artykuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Artykuly.Location = new System.Drawing.Point(227, 312);
            this.L_Artykuly.Name = "L_Artykuly";
            this.L_Artykuly.Size = new System.Drawing.Size(43, 46);
            this.L_Artykuly.TabIndex = 8;
            this.L_Artykuly.Text = "0";
            this.L_Artykuly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Artykuly.Visible = false;
            // 
            // L_ArtykulyText
            // 
            this.L_ArtykulyText.AutoSize = true;
            this.L_ArtykulyText.Location = new System.Drawing.Point(224, 299);
            this.L_ArtykulyText.Name = "L_ArtykulyText";
            this.L_ArtykulyText.Size = new System.Drawing.Size(46, 13);
            this.L_ArtykulyText.TabIndex = 9;
            this.L_ArtykulyText.Text = "Artykuły";
            this.L_ArtykulyText.Visible = false;
            // 
            // L_Error
            // 
            this.L_Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Error.ForeColor = System.Drawing.Color.Red;
            this.L_Error.Location = new System.Drawing.Point(2, 22);
            this.L_Error.Name = "L_Error";
            this.L_Error.Size = new System.Drawing.Size(310, 50);
            this.L_Error.TabIndex = 10;
            this.L_Error.Text = "Błędne dane!";
            this.L_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Error.Visible = false;
            // 
            // L_Wersja
            // 
            this.L_Wersja.AutoSize = true;
            this.L_Wersja.Location = new System.Drawing.Point(270, 9);
            this.L_Wersja.Name = "L_Wersja";
            this.L_Wersja.Size = new System.Drawing.Size(0, 13);
            this.L_Wersja.TabIndex = 11;
            // 
            // L_Haslo
            // 
            this.L_Haslo.AutoSize = true;
            this.L_Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Haslo.Location = new System.Drawing.Point(128, 134);
            this.L_Haslo.Name = "L_Haslo";
            this.L_Haslo.Size = new System.Drawing.Size(68, 26);
            this.L_Haslo.TabIndex = 12;
            this.L_Haslo.Text = "Hasło";
            this.L_Haslo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Haslo.Visible = false;
            // 
            // TB_Haslo
            // 
            this.TB_Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_Haslo.Location = new System.Drawing.Point(62, 163);
            this.TB_Haslo.Name = "TB_Haslo";
            this.TB_Haslo.PasswordChar = '*';
            this.TB_Haslo.Size = new System.Drawing.Size(199, 30);
            this.TB_Haslo.TabIndex = 2;
            this.TB_Haslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Haslo.Visible = false;
            // 
            // L_Procesy
            // 
            this.L_Procesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Procesy.Location = new System.Drawing.Point(3, 82);
            this.L_Procesy.Name = "L_Procesy";
            this.L_Procesy.Size = new System.Drawing.Size(309, 33);
            this.L_Procesy.TabIndex = 14;
            this.L_Procesy.Text = "WYBIERZ PROCES";
            this.L_Procesy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Procesy.Visible = false;
            // 
            // B_PakowanieMONO
            // 
            this.B_PakowanieMONO.Location = new System.Drawing.Point(12, 129);
            this.B_PakowanieMONO.Name = "B_PakowanieMONO";
            this.B_PakowanieMONO.Size = new System.Drawing.Size(136, 28);
            this.B_PakowanieMONO.TabIndex = 15;
            this.B_PakowanieMONO.Text = "Pakowanie MONO";
            this.B_PakowanieMONO.UseVisualStyleBackColor = true;
            this.B_PakowanieMONO.Visible = false;
            this.B_PakowanieMONO.Click += new System.EventHandler(this.B_PakowanieMONO_Click);
            // 
            // B_ZmienProces
            // 
            this.B_ZmienProces.Location = new System.Drawing.Point(194, 273);
            this.B_ZmienProces.Name = "B_ZmienProces";
            this.B_ZmienProces.Size = new System.Drawing.Size(95, 23);
            this.B_ZmienProces.TabIndex = 18;
            this.B_ZmienProces.Text = "Zmień proces";
            this.B_ZmienProces.UseVisualStyleBackColor = true;
            this.B_ZmienProces.Visible = false;
            this.B_ZmienProces.Click += new System.EventHandler(this.B_ZmienProces_Click);
            // 
            // B_SortowanieVOLU
            // 
            this.B_SortowanieVOLU.Location = new System.Drawing.Point(166, 129);
            this.B_SortowanieVOLU.Name = "B_SortowanieVOLU";
            this.B_SortowanieVOLU.Size = new System.Drawing.Size(136, 28);
            this.B_SortowanieVOLU.TabIndex = 19;
            this.B_SortowanieVOLU.Text = "Sortowanie VOLU";
            this.B_SortowanieVOLU.UseVisualStyleBackColor = true;
            this.B_SortowanieVOLU.Visible = false;
            this.B_SortowanieVOLU.Click += new System.EventHandler(this.B_SortowanieVOLU_Click);
            // 
            // B_SortowanieBPIC
            // 
            this.B_SortowanieBPIC.Location = new System.Drawing.Point(12, 163);
            this.B_SortowanieBPIC.Name = "B_SortowanieBPIC";
            this.B_SortowanieBPIC.Size = new System.Drawing.Size(136, 28);
            this.B_SortowanieBPIC.TabIndex = 20;
            this.B_SortowanieBPIC.Text = "Sortowanie BPIC";
            this.B_SortowanieBPIC.UseVisualStyleBackColor = true;
            this.B_SortowanieBPIC.Visible = false;
            this.B_SortowanieBPIC.Click += new System.EventHandler(this.B_SortowanieBPIC_Click);
            // 
            // B_PakowanieBPIC
            // 
            this.B_PakowanieBPIC.Location = new System.Drawing.Point(12, 197);
            this.B_PakowanieBPIC.Name = "B_PakowanieBPIC";
            this.B_PakowanieBPIC.Size = new System.Drawing.Size(136, 28);
            this.B_PakowanieBPIC.TabIndex = 21;
            this.B_PakowanieBPIC.Text = "Pakowanie BPIC";
            this.B_PakowanieBPIC.UseVisualStyleBackColor = true;
            this.B_PakowanieBPIC.Visible = false;
            this.B_PakowanieBPIC.Click += new System.EventHandler(this.B_PakowanieBPIC_Click);
            // 
            // B_PakowanieVOLU
            // 
            this.B_PakowanieVOLU.Location = new System.Drawing.Point(166, 163);
            this.B_PakowanieVOLU.Name = "B_PakowanieVOLU";
            this.B_PakowanieVOLU.Size = new System.Drawing.Size(136, 28);
            this.B_PakowanieVOLU.TabIndex = 22;
            this.B_PakowanieVOLU.Text = "Pakowanie VOLU";
            this.B_PakowanieVOLU.UseVisualStyleBackColor = true;
            this.B_PakowanieVOLU.Visible = false;
            this.B_PakowanieVOLU.Click += new System.EventHandler(this.B_PakowanieVOLU_Click);
            // 
            // B_PakowanieMVOL
            // 
            this.B_PakowanieMVOL.Location = new System.Drawing.Point(166, 197);
            this.B_PakowanieMVOL.Name = "B_PakowanieMVOL";
            this.B_PakowanieMVOL.Size = new System.Drawing.Size(136, 28);
            this.B_PakowanieMVOL.TabIndex = 23;
            this.B_PakowanieMVOL.Text = "Pakowanie MVOL";
            this.B_PakowanieMVOL.UseVisualStyleBackColor = true;
            this.B_PakowanieMVOL.Visible = false;
            this.B_PakowanieMVOL.Click += new System.EventHandler(this.B_PakowanieMVOL_Click);
            // 
            // B_Zwroty
            // 
            this.B_Zwroty.Location = new System.Drawing.Point(12, 231);
            this.B_Zwroty.Name = "B_Zwroty";
            this.B_Zwroty.Size = new System.Drawing.Size(136, 28);
            this.B_Zwroty.TabIndex = 25;
            this.B_Zwroty.Text = "Zwroty";
            this.B_Zwroty.UseVisualStyleBackColor = true;
            this.B_Zwroty.Visible = false;
            this.B_Zwroty.Click += new System.EventHandler(this.B_Zwroty_Click);
            // 
            // B_Entropy
            // 
            this.B_Entropy.Location = new System.Drawing.Point(166, 231);
            this.B_Entropy.Name = "B_Entropy";
            this.B_Entropy.Size = new System.Drawing.Size(136, 28);
            this.B_Entropy.TabIndex = 26;
            this.B_Entropy.Text = "Entropy";
            this.B_Entropy.UseVisualStyleBackColor = true;
            this.B_Entropy.Visible = false;
            this.B_Entropy.Click += new System.EventHandler(this.B_Entropy_Click);
            // 
            // B_Logout
            // 
            this.B_Logout.Location = new System.Drawing.Point(8, 4);
            this.B_Logout.Name = "B_Logout";
            this.B_Logout.Size = new System.Drawing.Size(75, 23);
            this.B_Logout.TabIndex = 27;
            this.B_Logout.Text = "Wyloguj";
            this.B_Logout.UseVisualStyleBackColor = true;
            this.B_Logout.Visible = false;
            this.B_Logout.Click += new System.EventHandler(this.B_Logout_Click);
            // 
            // L_Active
            // 
            this.L_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Active.Location = new System.Drawing.Point(89, 4);
            this.L_Active.Name = "L_Active";
            this.L_Active.Size = new System.Drawing.Size(151, 23);
            this.L_Active.TabIndex = 28;
            this.L_Active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EcomStatSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(314, 439);
            this.Controls.Add(this.L_Active);
            this.Controls.Add(this.B_Logout);
            this.Controls.Add(this.B_Entropy);
            this.Controls.Add(this.B_Zwroty);
            this.Controls.Add(this.B_PakowanieMVOL);
            this.Controls.Add(this.B_PakowanieVOLU);
            this.Controls.Add(this.B_PakowanieBPIC);
            this.Controls.Add(this.B_SortowanieBPIC);
            this.Controls.Add(this.B_SortowanieVOLU);
            this.Controls.Add(this.B_ZmienProces);
            this.Controls.Add(this.B_PakowanieMONO);
            this.Controls.Add(this.L_Procesy);
            this.Controls.Add(this.TB_Haslo);
            this.Controls.Add(this.L_Haslo);
            this.Controls.Add(this.L_Wersja);
            this.Controls.Add(this.L_Error);
            this.Controls.Add(this.L_ArtykulyText);
            this.Controls.Add(this.L_Artykuly);
            this.Controls.Add(this.L_CzasText);
            this.Controls.Add(this.L_Czas);
            this.Controls.Add(this.B_StartStop);
            this.Controls.Add(this.B_Login);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.L_Login);
            this.Name = "EcomStatSender";
            this.Text = "Liczpak";
            this.Load += new System.EventHandler(this.EcomStatSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Button B_StartStop;
        private System.Windows.Forms.Label L_Czas;
        private System.Windows.Forms.Label L_CzasText;
        private System.Windows.Forms.Label L_Artykuly;
        private System.Windows.Forms.Label L_ArtykulyText;
        private System.Windows.Forms.Label L_Error;
        private System.Windows.Forms.Label L_Wersja;
        private System.Windows.Forms.Label L_Haslo;
        private System.Windows.Forms.TextBox TB_Haslo;
        private System.Windows.Forms.Label L_Procesy;
        private System.Windows.Forms.Button B_PakowanieMONO;
        private System.Windows.Forms.Button B_ZmienProces;
        private System.Windows.Forms.Button B_SortowanieVOLU;
        private System.Windows.Forms.Button B_SortowanieBPIC;
        private System.Windows.Forms.Button B_PakowanieBPIC;
        private System.Windows.Forms.Button B_PakowanieVOLU;
        private System.Windows.Forms.Button B_PakowanieMVOL;
        private System.Windows.Forms.Button B_Zwroty;
        private System.Windows.Forms.Button B_Entropy;
        private System.Windows.Forms.Button B_Logout;
        private System.Windows.Forms.Label L_Active;
    }
}

