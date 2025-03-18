namespace MareaUnire {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelText = new System.Windows.Forms.Label();
            this.raspuns1 = new System.Windows.Forms.Button();
            this.raspuns2 = new System.Windows.Forms.Button();
            this.raspuns3 = new System.Windows.Forms.Button();
            this.raspuns4 = new System.Windows.Forms.Button();
            this.LabelCounter = new System.Windows.Forms.Label();
            this.LabelCounterIntrebari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonStart.BackColor = System.Drawing.Color.Silver;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(300, 100);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(200, 50);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start Quiz";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            this.ButtonStart.MouseEnter += new System.EventHandler(this.ButtonStart_MouseEnter);
            this.ButtonStart.MouseLeave += new System.EventHandler(this.ButtonStart_MouseLeave);
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelText.Location = new System.Drawing.Point(79, 36);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(106, 37);
            this.LabelText.TabIndex = 1;
            this.LabelText.Text = "label1";
            this.LabelText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // raspuns1
            // 
            this.raspuns1.Location = new System.Drawing.Point(45, 120);
            this.raspuns1.Name = "raspuns1";
            this.raspuns1.Size = new System.Drawing.Size(337, 23);
            this.raspuns1.TabIndex = 2;
            this.raspuns1.Text = "button1";
            this.raspuns1.UseVisualStyleBackColor = true;
            this.raspuns1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRaspuns_Click);
            // 
            // raspuns2
            // 
            this.raspuns2.Location = new System.Drawing.Point(45, 149);
            this.raspuns2.Name = "raspuns2";
            this.raspuns2.Size = new System.Drawing.Size(337, 23);
            this.raspuns2.TabIndex = 3;
            this.raspuns2.Text = "button2";
            this.raspuns2.UseVisualStyleBackColor = true;
            this.raspuns2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRaspuns_Click);
            // 
            // raspuns3
            // 
            this.raspuns3.Location = new System.Drawing.Point(430, 149);
            this.raspuns3.Name = "raspuns3";
            this.raspuns3.Size = new System.Drawing.Size(335, 23);
            this.raspuns3.TabIndex = 4;
            this.raspuns3.Text = "button3";
            this.raspuns3.UseVisualStyleBackColor = true;
            this.raspuns3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRaspuns_Click);
            // 
            // raspuns4
            // 
            this.raspuns4.Location = new System.Drawing.Point(430, 120);
            this.raspuns4.Name = "raspuns4";
            this.raspuns4.Size = new System.Drawing.Size(335, 23);
            this.raspuns4.TabIndex = 5;
            this.raspuns4.Text = "button4";
            this.raspuns4.UseVisualStyleBackColor = true;
            this.raspuns4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRaspuns_Click);
            // 
            // LabelCounter
            // 
            this.LabelCounter.AutoSize = true;
            this.LabelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCounter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCounter.Location = new System.Drawing.Point(79, 217);
            this.LabelCounter.Name = "LabelCounter";
            this.LabelCounter.Size = new System.Drawing.Size(106, 37);
            this.LabelCounter.TabIndex = 6;
            this.LabelCounter.Text = "label1";
            this.LabelCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelCounterIntrebari
            // 
            this.LabelCounterIntrebari.AutoSize = true;
            this.LabelCounterIntrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCounterIntrebari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCounterIntrebari.Location = new System.Drawing.Point(79, 263);
            this.LabelCounterIntrebari.Name = "LabelCounterIntrebari";
            this.LabelCounterIntrebari.Size = new System.Drawing.Size(106, 37);
            this.LabelCounterIntrebari.TabIndex = 7;
            this.LabelCounterIntrebari.Text = "label1";
            this.LabelCounterIntrebari.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelCounterIntrebari);
            this.Controls.Add(this.LabelCounter);
            this.Controls.Add(this.raspuns4);
            this.Controls.Add(this.raspuns3);
            this.Controls.Add(this.raspuns2);
            this.Controls.Add(this.raspuns1);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.ButtonStart);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Button raspuns1;
        private System.Windows.Forms.Button raspuns2;
        private System.Windows.Forms.Button raspuns3;
        private System.Windows.Forms.Button raspuns4;
        private System.Windows.Forms.Label LabelCounter;
        private System.Windows.Forms.Label LabelCounterIntrebari;
    }
}

