
namespace InBetween
{
    partial class frm1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblComputer1 = new System.Windows.Forms.Label();
            this.lblComputer2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl1.Location = new System.Drawing.Point(116, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(406, 59);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "In Between Game";
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Gray;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDraw.Location = new System.Drawing.Point(48, 430);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(84, 45);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "&Draw";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Gray;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPass.Location = new System.Drawing.Point(151, 430);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(90, 45);
            this.btnPass.TabIndex = 7;
            this.btnPass.Text = "&Pass";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(377, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 45);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(485, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer.Font = new System.Drawing.Font("Rockwell", 50F);
            this.lblPlayer.Location = new System.Drawing.Point(25, 115);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(173, 225);
            this.lblPlayer.TabIndex = 10;
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(68, 368);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(91, 29);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "Player";
            // 
            // lblComputer1
            // 
            this.lblComputer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputer1.Font = new System.Drawing.Font("Rockwell", 50F);
            this.lblComputer1.Location = new System.Drawing.Point(254, 115);
            this.lblComputer1.Name = "lblComputer1";
            this.lblComputer1.Size = new System.Drawing.Size(173, 225);
            this.lblComputer1.TabIndex = 14;
            this.lblComputer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputer2
            // 
            this.lblComputer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputer2.Font = new System.Drawing.Font("Rockwell", 55F);
            this.lblComputer2.Location = new System.Drawing.Point(441, 115);
            this.lblComputer2.Name = "lblComputer2";
            this.lblComputer2.Size = new System.Drawing.Size(173, 225);
            this.lblComputer2.TabIndex = 16;
            this.lblComputer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(372, 368);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(132, 29);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "Computer";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 499);
            this.ControlBox = false;
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblComputer2);
            this.Controls.Add(this.lblComputer1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lbl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.Text = "In Between Game";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblComputer1;
        private System.Windows.Forms.Label lblComputer2;
        private System.Windows.Forms.Label lbl3;
    }
}

