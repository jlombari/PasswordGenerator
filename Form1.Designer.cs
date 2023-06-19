namespace PasswordGenerator
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LengthBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            checkBoxUpper = new CheckBox();
            checkBoxNumerals = new CheckBox();
            checkBoxSpecial = new CheckBox();
            buttonGenerate = new Button();
            textBoxGenerated = new TextBox();
            labelVersion = new Label();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            buttonStrong = new Button();
            buttonSimple = new Button();
            ((System.ComponentModel.ISupportInitialize)LengthBar).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LengthBar
            // 
            LengthBar.BackColor = SystemColors.ButtonHighlight;
            LengthBar.Location = new Point(10, 29);
            LengthBar.Margin = new Padding(10);
            LengthBar.Maximum = 20;
            LengthBar.Minimum = 8;
            LengthBar.Name = "LengthBar";
            LengthBar.Size = new Size(158, 45);
            LengthBar.TabIndex = 0;
            LengthBar.TickStyle = TickStyle.Both;
            LengthBar.Value = 8;
            LengthBar.Scroll += LengthBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(50, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 23);
            label1.TabIndex = 1;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 2;
            label2.Text = "Length: 8";
            // 
            // checkBoxUpper
            // 
            checkBoxUpper.AutoSize = true;
            checkBoxUpper.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUpper.Location = new Point(3, 87);
            checkBoxUpper.Name = "checkBoxUpper";
            checkBoxUpper.Size = new Size(165, 23);
            checkBoxUpper.TabIndex = 3;
            checkBoxUpper.Text = "Include Lowercase";
            checkBoxUpper.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumerals
            // 
            checkBoxNumerals.AutoSize = true;
            checkBoxNumerals.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNumerals.Location = new Point(3, 116);
            checkBoxNumerals.Name = "checkBoxNumerals";
            checkBoxNumerals.Size = new Size(152, 23);
            checkBoxNumerals.TabIndex = 4;
            checkBoxNumerals.Text = "Include Numbers";
            checkBoxNumerals.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecial
            // 
            checkBoxSpecial.AutoSize = true;
            checkBoxSpecial.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSpecial.Location = new Point(3, 145);
            checkBoxSpecial.Name = "checkBoxSpecial";
            checkBoxSpecial.Size = new Size(139, 23);
            checkBoxSpecial.TabIndex = 5;
            checkBoxSpecial.Text = "Include Special";
            checkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            buttonGenerate.AutoSize = true;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerate.Location = new Point(8, 186);
            buttonGenerate.Margin = new Padding(8, 15, 3, 3);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(164, 31);
            buttonGenerate.TabIndex = 6;
            buttonGenerate.Text = "Generate Password";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxGenerated
            // 
            textBoxGenerated.BorderStyle = BorderStyle.FixedSingle;
            textBoxGenerated.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGenerated.Location = new Point(18, 323);
            textBoxGenerated.MaxLength = 20;
            textBoxGenerated.Multiline = true;
            textBoxGenerated.Name = "textBoxGenerated";
            textBoxGenerated.Size = new Size(296, 76);
            textBoxGenerated.TabIndex = 7;
            textBoxGenerated.WordWrap = false;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(285, 9);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(46, 14);
            labelVersion.TabIndex = 8;
            labelVersion.Text = "v0.1.0.3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 247);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Random Characters";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(LengthBar);
            flowLayoutPanel1.Controls.Add(checkBoxUpper);
            flowLayoutPanel1.Controls.Add(checkBoxNumerals);
            flowLayoutPanel1.Controls.Add(checkBoxSpecial);
            flowLayoutPanel1.Controls.Add(buttonGenerate);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(183, 226);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(207, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(115, 247);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Human Readable";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonStrong);
            panel1.Controls.Add(buttonSimple);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 226);
            panel1.TabIndex = 0;
            // 
            // buttonStrong
            // 
            buttonStrong.BackColor = SystemColors.ButtonFace;
            buttonStrong.Dock = DockStyle.Right;
            buttonStrong.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonStrong.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            buttonStrong.FlatStyle = FlatStyle.Flat;
            buttonStrong.Location = new Point(54, 0);
            buttonStrong.Name = "buttonStrong";
            buttonStrong.Size = new Size(55, 226);
            buttonStrong.TabIndex = 1;
            buttonStrong.Text = "Strong";
            buttonStrong.UseVisualStyleBackColor = false;
            buttonStrong.Click += buttonStrong_Click;
            // 
            // buttonSimple
            // 
            buttonSimple.BackColor = SystemColors.ButtonFace;
            buttonSimple.Dock = DockStyle.Left;
            buttonSimple.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            buttonSimple.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            buttonSimple.FlatStyle = FlatStyle.Flat;
            buttonSimple.Location = new Point(0, 0);
            buttonSimple.Name = "buttonSimple";
            buttonSimple.Size = new Size(53, 226);
            buttonSimple.TabIndex = 0;
            buttonSimple.Text = "Simple";
            buttonSimple.UseVisualStyleBackColor = false;
            buttonSimple.Click += buttonSimple_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelVersion);
            Controls.Add(textBoxGenerated);
            Controls.Add(label1);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)LengthBar).EndInit();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar LengthBar;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxUpper;
        private CheckBox checkBoxNumerals;
        private CheckBox checkBoxSpecial;
        private Button buttonGenerate;
        private TextBox textBoxGenerated;
        private Label labelVersion;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button buttonStrong;
        private Button buttonSimple;
    }
}