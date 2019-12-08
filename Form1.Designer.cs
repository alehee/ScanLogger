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
            this.CB_Proces = new System.Windows.Forms.ComboBox();
            this.L_Proces = new System.Windows.Forms.Label();
            this.B_StartStop = new System.Windows.Forms.Button();
            this.L_Czas = new System.Windows.Forms.Label();
            this.L_CzasText = new System.Windows.Forms.Label();
            this.L_Artykuly = new System.Windows.Forms.Label();
            this.L_ArtykulyText = new System.Windows.Forms.Label();
            this.L_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Login.Location = new System.Drawing.Point(42, 9);
            this.L_Login.Name = "L_Login";
            this.L_Login.Padding = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.L_Login.Size = new System.Drawing.Size(205, 61);
            this.L_Login.TabIndex = 0;
            this.L_Login.Text = "Twój Login";
            this.L_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Login
            // 
            this.TB_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_Login.Location = new System.Drawing.Point(48, 73);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(199, 30);
            this.TB_Login.TabIndex = 1;
            this.TB_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B_Login
            // 
            this.B_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_Login.Location = new System.Drawing.Point(98, 109);
            this.B_Login.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(100, 30);
            this.B_Login.TabIndex = 2;
            this.B_Login.Text = "Zaloguj";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // CB_Proces
            // 
            this.CB_Proces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Proces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Proces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CB_Proces.FormattingEnabled = true;
            this.CB_Proces.Items.AddRange(new object[] {
            "Proces1",
            "Proces2"});
            this.CB_Proces.Location = new System.Drawing.Point(92, 191);
            this.CB_Proces.Name = "CB_Proces";
            this.CB_Proces.Size = new System.Drawing.Size(150, 24);
            this.CB_Proces.TabIndex = 3;
            this.CB_Proces.Visible = false;
            // 
            // L_Proces
            // 
            this.L_Proces.AutoSize = true;
            this.L_Proces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Proces.Location = new System.Drawing.Point(34, 194);
            this.L_Proces.Name = "L_Proces";
            this.L_Proces.Size = new System.Drawing.Size(52, 17);
            this.L_Proces.TabIndex = 4;
            this.L_Proces.Text = "Proces";
            this.L_Proces.Visible = false;
            // 
            // B_StartStop
            // 
            this.B_StartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_StartStop.ForeColor = System.Drawing.Color.Green;
            this.B_StartStop.Location = new System.Drawing.Point(98, 319);
            this.B_StartStop.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.B_StartStop.Name = "B_StartStop";
            this.B_StartStop.Size = new System.Drawing.Size(100, 30);
            this.B_StartStop.TabIndex = 5;
            this.B_StartStop.Text = "START";
            this.B_StartStop.UseVisualStyleBackColor = true;
            this.B_StartStop.Visible = false;
            this.B_StartStop.Click += new System.EventHandler(this.B_StartStop_Click);
            // 
            // L_Czas
            // 
            this.L_Czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Czas.Location = new System.Drawing.Point(29, 255);
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
            this.L_CzasText.Location = new System.Drawing.Point(78, 242);
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
            this.L_Artykuly.Location = new System.Drawing.Point(199, 255);
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
            this.L_ArtykulyText.Location = new System.Drawing.Point(196, 242);
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
            this.L_Error.Location = new System.Drawing.Point(1, 142);
            this.L_Error.Name = "L_Error";
            this.L_Error.Size = new System.Drawing.Size(281, 46);
            this.L_Error.TabIndex = 10;
            this.L_Error.Text = "Błędne dane!";
            this.L_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_Error.Visible = false;
            // 
            // EcomStatSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.L_Error);
            this.Controls.Add(this.L_ArtykulyText);
            this.Controls.Add(this.L_Artykuly);
            this.Controls.Add(this.L_CzasText);
            this.Controls.Add(this.L_Czas);
            this.Controls.Add(this.B_StartStop);
            this.Controls.Add(this.L_Proces);
            this.Controls.Add(this.CB_Proces);
            this.Controls.Add(this.B_Login);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.L_Login);
            this.Name = "EcomStatSender";
            this.Text = "EcomStatSender";
            this.Load += new System.EventHandler(this.EcomStatSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.ComboBox CB_Proces;
        private System.Windows.Forms.Label L_Proces;
        private System.Windows.Forms.Button B_StartStop;
        private System.Windows.Forms.Label L_Czas;
        private System.Windows.Forms.Label L_CzasText;
        private System.Windows.Forms.Label L_Artykuly;
        private System.Windows.Forms.Label L_ArtykulyText;
        private System.Windows.Forms.Label L_Error;
    }
}

