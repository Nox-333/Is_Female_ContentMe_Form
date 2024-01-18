namespace Is_Fe_content_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textN = new TextBox();
            textA = new TextBox();
            textP = new TextBox();
            checkS = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkF = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(551, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Click Me !!!";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // textN
            // 
            textN.Location = new Point(158, 69);
            textN.Name = "textN";
            textN.Size = new Size(157, 23);
            textN.TabIndex = 1;
            // 
            // textA
            // 
            textA.Location = new Point(158, 125);
            textA.Name = "textA";
            textA.Size = new Size(157, 23);
            textA.TabIndex = 2;
            textA.Leave += illAge;
            textA.MouseLeave += illAge;
            // 
            // textP
            // 
            textP.Location = new Point(158, 181);
            textP.Name = "textP";
            textP.Size = new Size(157, 23);
            textP.TabIndex = 3;
            textP.Visible = false;
            // 
            // checkS
            // 
            checkS.AutoSize = true;
            checkS.BackgroundImageLayout = ImageLayout.None;
            checkS.Location = new Point(450, 68);
            checkS.Name = "checkS";
            checkS.Size = new Size(66, 19);
            checkS.TabIndex = 4;
            checkS.Text = "Single ?";
            checkS.UseVisualStyleBackColor = true;
            checkS.Visible = false;
            checkS.CheckedChanged += checkBox1_CheckedChanged;
            checkS.Leave += no_single_fe;
            checkS.MouseLeave += no_single_fe;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 72);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 128);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 189);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "Phone Number";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // checkF
            // 
            checkF.AutoSize = true;
            checkF.Location = new Point(554, 68);
            checkF.Name = "checkF";
            checkF.Size = new Size(72, 19);
            checkF.TabIndex = 8;
            checkF.Text = "Female ?";
            checkF.UseVisualStyleBackColor = true;
            checkF.Visible = false;
            checkF.Leave += no_single_fe;
            checkF.MouseLeave += no_single_fe;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(71, 312);
            label4.Name = "label4";
            label4.Size = new Size(2, 17);
            label4.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(checkF);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkS);
            Controls.Add(textP);
            Controls.Add(textA);
            Controls.Add(textN);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textN;
        private TextBox textA;
        private TextBox textP;
        private CheckBox checkS;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkF;
        private Label label4;
    }
}
