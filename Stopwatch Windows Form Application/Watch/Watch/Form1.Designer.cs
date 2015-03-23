namespace Watch
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.action = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lap = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // action
            // 
            this.action.Location = new System.Drawing.Point(12, 12);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(75, 23);
            this.action.TabIndex = 0;
            this.action.Text = "Start";
            this.action.UseVisualStyleBackColor = true;
            this.action.Click += new System.EventHandler(this.button1_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(12, 39);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(64, 79);
            this.time.TabIndex = 1;
            this.time.Text = "0";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lap
            // 
            this.lap.Location = new System.Drawing.Point(93, 12);
            this.lap.Name = "lap";
            this.lap.Size = new System.Drawing.Size(75, 23);
            this.lap.TabIndex = 2;
            this.lap.Text = "Lap";
            this.lap.UseVisualStyleBackColor = true;
            this.lap.Click += new System.EventHandler(this.lap_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display.Location = new System.Drawing.Point(131, 41);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.display.Size = new System.Drawing.Size(117, 105);
            this.display.TabIndex = 3;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(174, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(260, 155);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.display);
            this.Controls.Add(this.lap);
            this.Controls.Add(this.time);
            this.Controls.Add(this.action);
            this.Name = "Form1";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button action;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button lap;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button reset;
    }
}

