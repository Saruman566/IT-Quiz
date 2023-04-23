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
            this.SuspendLayout();
            // 
            // neueFrage
            // 
            this.neueFrage.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neueFrage.Location = new System.Drawing.Point(63, 182);
            this.neueFrage.Name = "neueFrage";
            this.neueFrage.Size = new System.Drawing.Size(895, 33);
            this.neueFrage.TabIndex = 0;
            this.neueFrage.Text = "Neue Frage";
            this.neueFrage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neueFrage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // antwort1
            // 
            this.antwort1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort1.Location = new System.Drawing.Point(63, 221);
            this.antwort1.Name = "antwort1";
            this.antwort1.Size = new System.Drawing.Size(895, 33);
            this.antwort1.TabIndex = 1;
            this.antwort1.Text = "Antwort 1";
            this.antwort1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // antwort2
            // 
            this.antwort2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort2.Location = new System.Drawing.Point(63, 260);
            this.antwort2.Name = "antwort2";
            this.antwort2.Size = new System.Drawing.Size(895, 33);
            this.antwort2.TabIndex = 2;
            this.antwort2.Text = "Antwort 2";
            this.antwort2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // antwort3
            // 
            this.antwort3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort3.Location = new System.Drawing.Point(63, 299);
            this.antwort3.Name = "antwort3";
            this.antwort3.Size = new System.Drawing.Size(895, 33);
            this.antwort3.TabIndex = 3;
            this.antwort3.Text = "Antwort 3";
            this.antwort3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // antwort4
            // 
            this.antwort4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwort4.Location = new System.Drawing.Point(63, 338);
            this.antwort4.Name = "antwort4";
            this.antwort4.Size = new System.Drawing.Size(895, 33);
            this.antwort4.TabIndex = 4;
            this.antwort4.Text = "Antwort 4";
            this.antwort4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richtigeAntwort
            // 
            this.richtigeAntwort.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtigeAntwort.Location = new System.Drawing.Point(63, 377);
            this.richtigeAntwort.Name = "richtigeAntwort";
            this.richtigeAntwort.Size = new System.Drawing.Size(895, 33);
            this.richtigeAntwort.TabIndex = 5;
            this.richtigeAntwort.Text = "Richtige Antwort";
            this.richtigeAntwort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hinzufuegen
            // 
            this.hinzufuegen.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinzufuegen.Location = new System.Drawing.Point(439, 461);
            this.hinzufuegen.Name = "hinzufuegen";
            this.hinzufuegen.Size = new System.Drawing.Size(151, 42);
            this.hinzufuegen.TabIndex = 7;
            this.hinzufuegen.Text = "Hinzufügen";
            this.hinzufuegen.UseVisualStyleBackColor = true;
            this.hinzufuegen.Click += new System.EventHandler(this.hinzufuegen_Click);
            // 
            // Frage_hinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1028, 623);
            this.Controls.Add(this.hinzufuegen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richtigeAntwort);
            this.Controls.Add(this.antwort4);
            this.Controls.Add(this.antwort3);
            this.Controls.Add(this.antwort2);
            this.Controls.Add(this.antwort1);
            this.Controls.Add(this.neueFrage);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frage_hinzufügen";
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
    }
}