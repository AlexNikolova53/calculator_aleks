
namespace calculator_alex
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(290, 49);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.Click += new System.EventHandler(this.Numeric_Value);
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(12, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 59);
            this.button5.TabIndex = 1;
            this.button5.Text = "%";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(86, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "M-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(234, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "MC";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(160, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "MR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "M+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(86, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 59);
            this.button6.TabIndex = 1;
            this.button6.Text = "CE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(160, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 59);
            this.button7.TabIndex = 1;
            this.button7.Text = "C";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(233, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 59);
            this.button8.TabIndex = 1;
            this.button8.Text = "⌫";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BtnBS_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(234, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 59);
            this.button9.TabIndex = 1;
            this.button9.Text = "/";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Operational_Function);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(12, 176);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 59);
            this.button13.TabIndex = 1;
            this.button13.Text = "7";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(159, 176);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 59);
            this.button14.TabIndex = 1;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(85, 176);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 59);
            this.button15.TabIndex = 1;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(86, 241);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 59);
            this.button16.TabIndex = 1;
            this.button16.Text = "5";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(86, 306);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 59);
            this.button17.TabIndex = 1;
            this.button17.Text = "2";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(234, 306);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(68, 59);
            this.button18.TabIndex = 1;
            this.button18.Text = "-";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Operational_Function);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(160, 241);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(68, 59);
            this.button19.TabIndex = 1;
            this.button19.Text = "6";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(12, 241);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(68, 59);
            this.button20.TabIndex = 1;
            this.button20.Text = "4";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(234, 241);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(68, 59);
            this.button21.TabIndex = 1;
            this.button21.Text = "*";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Operational_Function);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(234, 371);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(68, 59);
            this.button23.TabIndex = 1;
            this.button23.Text = "+";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Operational_Function);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(159, 306);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(68, 59);
            this.button24.TabIndex = 1;
            this.button24.Text = "3";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button25.Location = new System.Drawing.Point(160, 436);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(142, 59);
            this.button25.TabIndex = 1;
            this.button25.Text = "=";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.Location = new System.Drawing.Point(85, 371);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(68, 59);
            this.button26.TabIndex = 1;
            this.button26.Text = "0";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.Location = new System.Drawing.Point(160, 371);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(68, 59);
            this.button27.TabIndex = 1;
            this.button27.Text = ".";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.Location = new System.Drawing.Point(12, 371);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(68, 59);
            this.button28.TabIndex = 1;
            this.button28.Text = "+/-";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.ButtonPM_Click);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button33.Location = new System.Drawing.Point(12, 306);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(68, 59);
            this.button33.TabIndex = 1;
            this.button33.Text = "1";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button35.Location = new System.Drawing.Point(-87, 371);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(68, 59);
            this.button35.TabIndex = 1;
            this.button35.Text = "1";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button39.Location = new System.Drawing.Point(-87, 436);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(68, 59);
            this.button39.TabIndex = 1;
            this.button39.Text = "M+";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button26_Click);
            // 
            // button41
            // 
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button41.Location = new System.Drawing.Point(-86, 306);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(68, 59);
            this.button41.TabIndex = 1;
            this.button41.Text = "4";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(313, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button41;
    }
}

