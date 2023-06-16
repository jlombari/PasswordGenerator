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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LengthBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            checkBoxUpper = new CheckBox();
            checkBoxNumerals = new CheckBox();
            checkBoxSpecial = new CheckBox();
            buttonGenerate = new Button();
            textBoxGenerated = new TextBox();
            labelVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)LengthBar).BeginInit();
            SuspendLayout();
            // 
            // LengthBar
            // 
            LengthBar.BackColor = SystemColors.ButtonHighlight;
            LengthBar.Location = new Point(19, 88);
            LengthBar.Margin = new Padding(10);
            LengthBar.Maximum = 20;
            LengthBar.Minimum = 8;
            LengthBar.Name = "LengthBar";
            LengthBar.Size = new Size(296, 45);
            LengthBar.TabIndex = 0;
            LengthBar.TickStyle = TickStyle.Both;
            LengthBar.Value = 8;
            LengthBar.Scroll += LengthBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 9);
            label1.Margin = new Padding(50, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 23);
            label1.TabIndex = 1;
            label1.Text = "Random Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 143);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 2;
            label2.Text = "Length: 8";
            // 
            // checkBoxUpper
            // 
            checkBoxUpper.AutoSize = true;
            checkBoxUpper.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUpper.Location = new Point(19, 199);
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
            checkBoxNumerals.Location = new Point(19, 228);
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
            checkBoxSpecial.Location = new Point(19, 257);
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
            buttonGenerate.Location = new Point(81, 319);
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
            textBoxGenerated.Location = new Point(19, 368);
            textBoxGenerated.MaxLength = 20;
            textBoxGenerated.Name = "textBoxGenerated";
            textBoxGenerated.Size = new Size(296, 27);
            textBoxGenerated.TabIndex = 7;
            textBoxGenerated.WordWrap = false;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(275, 32);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(46, 14);
            labelVersion.TabIndex = 8;
            labelVersion.Text = "v0.1.0.2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(labelVersion);
            Controls.Add(textBoxGenerated);
            Controls.Add(buttonGenerate);
            Controls.Add(checkBoxSpecial);
            Controls.Add(checkBoxNumerals);
            Controls.Add(checkBoxUpper);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LengthBar);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)LengthBar).EndInit();
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
    }
}