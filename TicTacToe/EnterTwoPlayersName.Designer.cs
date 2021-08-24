namespace TicTacToe
{
    partial class EnterTwoPlayersName
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
            this.BTNOK = new System.Windows.Forms.Button();
            this.txtnameOne = new System.Windows.Forms.TextBox();
            this.lblplayerone = new System.Windows.Forms.Label();
            this.txtnameTwo = new System.Windows.Forms.TextBox();
            this.lblplayertwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNOK
            // 
            this.BTNOK.BackColor = System.Drawing.Color.LightCyan;
            this.BTNOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BTNOK.Location = new System.Drawing.Point(572, 231);
            this.BTNOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(62, 51);
            this.BTNOK.TabIndex = 1;
            this.BTNOK.Text = "OK";
            this.BTNOK.UseVisualStyleBackColor = false;
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
            // 
            // txtnameOne
            // 
            this.txtnameOne.BackColor = System.Drawing.Color.LightCyan;
            this.txtnameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameOne.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtnameOne.Location = new System.Drawing.Point(366, 60);
            this.txtnameOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnameOne.Name = "txtnameOne";
            this.txtnameOne.Size = new System.Drawing.Size(265, 32);
            this.txtnameOne.TabIndex = 4;
            // 
            // lblplayerone
            // 
            this.lblplayerone.AutoSize = true;
            this.lblplayerone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayerone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblplayerone.Location = new System.Drawing.Point(18, 65);
            this.lblplayerone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplayerone.Name = "lblplayerone";
            this.lblplayerone.Size = new System.Drawing.Size(238, 26);
            this.lblplayerone.TabIndex = 3;
            this.lblplayerone.Text = "Enter player one name:";
            // 
            // txtnameTwo
            // 
            this.txtnameTwo.BackColor = System.Drawing.Color.LightCyan;
            this.txtnameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameTwo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtnameTwo.Location = new System.Drawing.Point(366, 138);
            this.txtnameTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnameTwo.Name = "txtnameTwo";
            this.txtnameTwo.Size = new System.Drawing.Size(265, 32);
            this.txtnameTwo.TabIndex = 6;
            // 
            // lblplayertwo
            // 
            this.lblplayertwo.AutoSize = true;
            this.lblplayertwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayertwo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblplayertwo.Location = new System.Drawing.Point(18, 143);
            this.lblplayertwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplayertwo.Name = "lblplayertwo";
            this.lblplayertwo.Size = new System.Drawing.Size(236, 26);
            this.lblplayertwo.TabIndex = 5;
            this.lblplayertwo.Text = "Enter player two name:";
            // 
            // EnterTwoPlayersName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(651, 300);
            this.Controls.Add(this.txtnameTwo);
            this.Controls.Add(this.lblplayertwo);
            this.Controls.Add(this.txtnameOne);
            this.Controls.Add(this.lblplayerone);
            this.Controls.Add(this.BTNOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnterTwoPlayersName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EnterTwoPlayersName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNOK;
        private System.Windows.Forms.TextBox txtnameOne;
        private System.Windows.Forms.Label lblplayerone;
        private System.Windows.Forms.TextBox txtnameTwo;
        private System.Windows.Forms.Label lblplayertwo;
    }
}