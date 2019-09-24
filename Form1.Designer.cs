namespace FM1
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
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.inputNumberTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateTextBoxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(47, 81);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 0;
            this.startTime.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(47, 130);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 20);
            this.endTime.TabIndex = 1;
            this.endTime.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // textBox1
            // 
            this.inputNumberTB.Location = new System.Drawing.Point(105, 43);
            this.inputNumberTB.Name = "inputNumber";
            this.inputNumberTB.Size = new System.Drawing.Size(100, 20);
            this.inputNumberTB.TabIndex = 2;
            this.inputNumberTB.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.buttonCreateTextBoxes.Location = new System.Drawing.Point(234, 40);
            this.buttonCreateTextBoxes.Name = "buttonCreateTextBoxes";
            this.buttonCreateTextBoxes.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateTextBoxes.TabIndex = 4;
            this.buttonCreateTextBoxes.Text = "buttonCreateTextBoxes";
            this.buttonCreateTextBoxes.UseVisualStyleBackColor = true;
            this.buttonCreateTextBoxes.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateTextBoxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNumberTB);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Name = "Form1";
            this.Text = "Laboratory work №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.TextBox inputNumberTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateTextBoxes;
    }
}

