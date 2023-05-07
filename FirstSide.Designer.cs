namespace ITQuiz
{
    partial class FirstSide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstSide));
            this.Menu = new System.Windows.Forms.Label();
            this.updater = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Bold);
            this.Menu.ForeColor = System.Drawing.Color.Cyan;
            this.Menu.Location = new System.Drawing.Point(138, 26);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(153, 45);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menue";
            // 
            // updater
            // 
            this.updater.BackColor = System.Drawing.Color.SkyBlue;
            this.updater.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updater.ForeColor = System.Drawing.Color.Teal;
            this.updater.Location = new System.Drawing.Point(115, 138);
            this.updater.Name = "updater";
            this.updater.Size = new System.Drawing.Size(208, 51);
            this.updater.TabIndex = 5;
            this.updater.Text = "IT-Quiz Updater";
            this.updater.UseVisualStyleBackColor = false;
            this.updater.Click += new System.EventHandler(this.back_Click);
            // 
            // Quiz
            // 
            this.Quiz.BackColor = System.Drawing.Color.SkyBlue;
            this.Quiz.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz.ForeColor = System.Drawing.Color.Teal;
            this.Quiz.Location = new System.Drawing.Point(127, 250);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(187, 51);
            this.Quiz.TabIndex = 6;
            this.Quiz.Text = "IT-Quiz";
            this.Quiz.UseVisualStyleBackColor = false;
            this.Quiz.Click += new System.EventHandler(this.Quiz_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.updater);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Button updater;
        private System.Windows.Forms.Button Quiz;
    }
}