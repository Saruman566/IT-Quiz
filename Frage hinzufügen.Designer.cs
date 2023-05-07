namespace Lern_Quiz
{
    partial class Frage_hinzufügen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frage_hinzufügen));
            this.neueFrage = new System.Windows.Forms.TextBox();
            this.antwort1 = new System.Windows.Forms.TextBox();
            this.antwort2 = new System.Windows.Forms.TextBox();
            this.antwort3 = new System.Windows.Forms.TextBox();
            this.antwort4 = new System.Windows.Forms.TextBox();
            this.richtigeAntwort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hinzufuegen = new System.Windows.Forms.Button();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // neueFrage
            // 
            this.neueFrage.BackColor = System.Drawing.Color.SkyBlue;
            this.neueFrage.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neueFrage.ForeColor = System.Drawing.Color.Teal;
            this.neueFrage.Location = new System.Drawing.Point(249, 150);
            this.neueFrage.Multiline = true;
            this.neueFrage.Name = "neueFrage";
            this.neueFrage.Size = new System.Drawing.Size(529, 152);
            this.neueFrage.TabIndex = 0;
            this.neueFrage.Text = "Neue Frage";
            this.neueFrage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neueFrage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // antwort1
            // 
            this.antwort1.BackColor = System.Drawing.Color.SkyBlue;
            this.antwort1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort1.ForeColor = System.Drawing.Color.Teal;
            this.antwort1.Location = new System.Drawing.Point(37, 335);
            this.antwort1.Multiline = true;
            this.antwort1.Name = "antwort1";
            this.antwort1.Size = new System.Drawing.Size(455, 51);
            this.antwort1.TabIndex = 1;
            this.antwort1.Text = "Antwort 1";
            this.antwort1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // antwort2
            // 
            this.antwort2.BackColor = System.Drawing.Color.SkyBlue;
            this.antwort2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort2.ForeColor = System.Drawing.Color.Teal;
            this.antwort2.Location = new System.Drawing.Point(534, 335);
            this.antwort2.Multiline = true;
            this.antwort2.Name = "antwort2";
            this.antwort2.Size = new System.Drawing.Size(455, 51);
            this.antwort2.TabIndex = 2;
            this.antwort2.Text = "Antwort 2";
            this.antwort2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.antwort2.TextChanged += new System.EventHandler(this.antwort2_TextChanged);
            // 
            // antwort3
            // 
            this.antwort3.BackColor = System.Drawing.Color.SkyBlue;
            this.antwort3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort3.ForeColor = System.Drawing.Color.Teal;
            this.antwort3.Location = new System.Drawing.Point(37, 413);
            this.antwort3.Multiline = true;
            this.antwort3.Name = "antwort3";
            this.antwort3.Size = new System.Drawing.Size(455, 51);
            this.antwort3.TabIndex = 3;
            this.antwort3.Text = "Antwort 3";
            this.antwort3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // antwort4
            // 
            this.antwort4.BackColor = System.Drawing.Color.SkyBlue;
            this.antwort4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort4.ForeColor = System.Drawing.Color.Teal;
            this.antwort4.Location = new System.Drawing.Point(534, 413);
            this.antwort4.Multiline = true;
            this.antwort4.Name = "antwort4";
            this.antwort4.Size = new System.Drawing.Size(455, 51);
            this.antwort4.TabIndex = 4;
            this.antwort4.Text = "Antwort 4";
            this.antwort4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richtigeAntwort
            // 
            this.richtigeAntwort.BackColor = System.Drawing.Color.SkyBlue;
            this.richtigeAntwort.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtigeAntwort.ForeColor = System.Drawing.Color.Teal;
            this.richtigeAntwort.Location = new System.Drawing.Point(286, 498);
            this.richtigeAntwort.Multiline = true;
            this.richtigeAntwort.Name = "richtigeAntwort";
            this.richtigeAntwort.Size = new System.Drawing.Size(455, 51);
            this.richtigeAntwort.TabIndex = 5;
            this.richtigeAntwort.Text = "Richtige Antwort";
            this.richtigeAntwort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(892, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hinzufuegen
            // 
            this.hinzufuegen.BackColor = System.Drawing.Color.SkyBlue;
            this.hinzufuegen.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinzufuegen.ForeColor = System.Drawing.Color.Teal;
            this.hinzufuegen.Location = new System.Drawing.Point(26, 563);
            this.hinzufuegen.Name = "hinzufuegen";
            this.hinzufuegen.Size = new System.Drawing.Size(151, 42);
            this.hinzufuegen.TabIndex = 7;
            this.hinzufuegen.Text = "Hinzufügen";
            this.hinzufuegen.UseVisualStyleBackColor = false;
            this.hinzufuegen.Click += new System.EventHandler(this.hinzufuegen_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.welcomelabel.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.welcomelabel.Location = new System.Drawing.Point(318, 9);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(393, 45);
            this.welcomelabel.TabIndex = 9;
            this.welcomelabel.Text = "Fragen hinzufügen";
            this.welcomelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomelabel.Click += new System.EventHandler(this.welcomelabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.Teal;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IT Sicherheit",
            "IT Systeme",
            "Programmieren",
            "Datenbanken",
            "Linux",
            "Cyberphysischesysteme",
            "Netzwerk",
            "WISO"});
            this.comboBox1.Location = new System.Drawing.Point(384, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 34);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Thema wählen";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Frage_hinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 623);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.hinzufuegen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richtigeAntwort);
            this.Controls.Add(this.antwort4);
            this.Controls.Add(this.antwort3);
            this.Controls.Add(this.antwort2);
            this.Controls.Add(this.antwort1);
            this.Controls.Add(this.neueFrage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frage_hinzufügen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frage_hinzufügen";
            this.Load += new System.EventHandler(this.Frage_hinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox neueFrage;
        private System.Windows.Forms.TextBox antwort1;
        private System.Windows.Forms.TextBox antwort2;
        private System.Windows.Forms.TextBox antwort3;
        private System.Windows.Forms.TextBox antwort4;
        private System.Windows.Forms.TextBox richtigeAntwort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hinzufuegen;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}