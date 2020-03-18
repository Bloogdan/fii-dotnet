using System.Drawing;
using System.Windows.Forms;

namespace Calculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonDot = new Calculator.CustomButton();
            this.buttonDigitZero = new Calculator.CustomButton();
            this.buttonBackspace = new Calculator.CustomButton();
            this.buttonDigitOne = new Calculator.CustomButton();
            this.buttonDigitTwo = new Calculator.CustomButton();
            this.buttonDigitThree = new Calculator.CustomButton();
            this.buttonDigitFour = new Calculator.CustomButton();
            this.buttonDigitFive = new Calculator.CustomButton();
            this.buttonDigitSix = new Calculator.CustomButton();
            this.buttonDigitSeven = new Calculator.CustomButton();
            this.buttonDigitEight = new Calculator.CustomButton();
            this.buttonDigitNine = new Calculator.CustomButton();
            this.buttonOperationDivide = new Calculator.CustomButton();
            this.buttonOperationMultiply = new Calculator.CustomButton();
            this.buttonOperationMinus = new Calculator.CustomButton();
            this.buttonOperationPlus = new Calculator.CustomButton();
            this.buttonOperationEquals = new Calculator.CustomButton();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(279, 35);
            this.textBox.TabIndex = 17;
            // 
            // buttonDot
            // 
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDot.Location = new System.Drawing.Point(12, 263);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 63);
            this.buttonDot.TabIndex = 16;
            this.buttonDot.Text = "DOT";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitZero
            // 
            this.buttonDigitZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitZero.Location = new System.Drawing.Point(93, 263);
            this.buttonDigitZero.Name = "buttonDigitZero";
            this.buttonDigitZero.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitZero.TabIndex = 1;
            this.buttonDigitZero.Text = "0";
            this.buttonDigitZero.UseVisualStyleBackColor = true;
            this.buttonDigitZero.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBackspace.Location = new System.Drawing.Point(174, 263);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(75, 63);
            this.buttonBackspace.TabIndex = 2;
            this.buttonBackspace.Text = "DEL";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitOne
            // 
            this.buttonDigitOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitOne.Location = new System.Drawing.Point(12, 194);
            this.buttonDigitOne.Name = "buttonDigitOne";
            this.buttonDigitOne.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitOne.TabIndex = 3;
            this.buttonDigitOne.Text = "1";
            this.buttonDigitOne.UseVisualStyleBackColor = true;
            this.buttonDigitOne.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitTwo
            // 
            this.buttonDigitTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitTwo.Location = new System.Drawing.Point(93, 194);
            this.buttonDigitTwo.Name = "buttonDigitTwo";
            this.buttonDigitTwo.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitTwo.TabIndex = 4;
            this.buttonDigitTwo.Text = "2";
            this.buttonDigitTwo.UseVisualStyleBackColor = true;
            this.buttonDigitTwo.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitThree
            // 
            this.buttonDigitThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitThree.Location = new System.Drawing.Point(174, 194);
            this.buttonDigitThree.Name = "buttonDigitThree";
            this.buttonDigitThree.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitThree.TabIndex = 5;
            this.buttonDigitThree.Text = "3";
            this.buttonDigitThree.UseVisualStyleBackColor = true;
            this.buttonDigitThree.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitFour
            // 
            this.buttonDigitFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitFour.Location = new System.Drawing.Point(12, 125);
            this.buttonDigitFour.Name = "buttonDigitFour";
            this.buttonDigitFour.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitFour.TabIndex = 6;
            this.buttonDigitFour.Text = "4";
            this.buttonDigitFour.UseVisualStyleBackColor = true;
            this.buttonDigitFour.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitFive
            // 
            this.buttonDigitFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitFive.Location = new System.Drawing.Point(93, 125);
            this.buttonDigitFive.Name = "buttonDigitFive";
            this.buttonDigitFive.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitFive.TabIndex = 7;
            this.buttonDigitFive.Text = "5";
            this.buttonDigitFive.UseVisualStyleBackColor = true;
            this.buttonDigitFive.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitSix
            // 
            this.buttonDigitSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitSix.Location = new System.Drawing.Point(174, 125);
            this.buttonDigitSix.Name = "buttonDigitSix";
            this.buttonDigitSix.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitSix.TabIndex = 8;
            this.buttonDigitSix.Text = "6";
            this.buttonDigitSix.UseVisualStyleBackColor = true;
            this.buttonDigitSix.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitSeven
            // 
            this.buttonDigitSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitSeven.Location = new System.Drawing.Point(12, 56);
            this.buttonDigitSeven.Name = "buttonDigitSeven";
            this.buttonDigitSeven.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitSeven.TabIndex = 9;
            this.buttonDigitSeven.Text = "7";
            this.buttonDigitSeven.UseVisualStyleBackColor = true;
            this.buttonDigitSeven.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitEight
            // 
            this.buttonDigitEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitEight.Location = new System.Drawing.Point(93, 56);
            this.buttonDigitEight.Name = "buttonDigitEight";
            this.buttonDigitEight.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitEight.TabIndex = 10;
            this.buttonDigitEight.Text = "8";
            this.buttonDigitEight.UseVisualStyleBackColor = true;
            this.buttonDigitEight.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonDigitNine
            // 
            this.buttonDigitNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigitNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDigitNine.Location = new System.Drawing.Point(174, 56);
            this.buttonDigitNine.Name = "buttonDigitNine";
            this.buttonDigitNine.Size = new System.Drawing.Size(75, 63);
            this.buttonDigitNine.TabIndex = 11;
            this.buttonDigitNine.Text = "9";
            this.buttonDigitNine.UseVisualStyleBackColor = true;
            this.buttonDigitNine.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonOperationDivide
            // 
            this.buttonOperationDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperationDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOperationDivide.Location = new System.Drawing.Point(255, 56);
            this.buttonOperationDivide.Name = "buttonOperationDivide";
            this.buttonOperationDivide.Size = new System.Drawing.Size(75, 63);
            this.buttonOperationDivide.TabIndex = 12;
            this.buttonOperationDivide.Text = "/";
            this.buttonOperationDivide.UseVisualStyleBackColor = true;
            this.buttonOperationDivide.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonOperationMultiply
            // 
            this.buttonOperationMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperationMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOperationMultiply.Location = new System.Drawing.Point(255, 125);
            this.buttonOperationMultiply.Name = "buttonOperationMultiply";
            this.buttonOperationMultiply.Size = new System.Drawing.Size(75, 63);
            this.buttonOperationMultiply.TabIndex = 13;
            this.buttonOperationMultiply.Text = "*";
            this.buttonOperationMultiply.UseVisualStyleBackColor = true;
            this.buttonOperationMultiply.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonOperationMinus
            // 
            this.buttonOperationMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperationMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOperationMinus.Location = new System.Drawing.Point(255, 194);
            this.buttonOperationMinus.Name = "buttonOperationMinus";
            this.buttonOperationMinus.Size = new System.Drawing.Size(75, 63);
            this.buttonOperationMinus.TabIndex = 14;
            this.buttonOperationMinus.Text = "-";
            this.buttonOperationMinus.UseVisualStyleBackColor = true;
            this.buttonOperationMinus.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonOperationPlus
            // 
            this.buttonOperationPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperationPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOperationPlus.Location = new System.Drawing.Point(255, 263);
            this.buttonOperationPlus.Name = "buttonOperationPlus";
            this.buttonOperationPlus.Size = new System.Drawing.Size(75, 63);
            this.buttonOperationPlus.TabIndex = 15;
            this.buttonOperationPlus.Text = "+";
            this.buttonOperationPlus.UseVisualStyleBackColor = true;
            this.buttonOperationPlus.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // buttonOperationEquals
            // 
            this.buttonOperationEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperationEquals.Location = new System.Drawing.Point(293, 12);
            this.buttonOperationEquals.Name = "buttonOperationEquals";
            this.buttonOperationEquals.Size = new System.Drawing.Size(37, 37);
            this.buttonOperationEquals.TabIndex = 0;
            this.buttonOperationEquals.Text = "=";
            this.buttonOperationEquals.UseVisualStyleBackColor = true;
            this.buttonOperationEquals.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 337);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonOperationEquals);
            this.Controls.Add(this.buttonOperationPlus);
            this.Controls.Add(this.buttonOperationMinus);
            this.Controls.Add(this.buttonOperationMultiply);
            this.Controls.Add(this.buttonOperationDivide);
            this.Controls.Add(this.buttonDigitNine);
            this.Controls.Add(this.buttonDigitEight);
            this.Controls.Add(this.buttonDigitSeven);
            this.Controls.Add(this.buttonDigitSix);
            this.Controls.Add(this.buttonDigitFive);
            this.Controls.Add(this.buttonDigitFour);
            this.Controls.Add(this.buttonDigitThree);
            this.Controls.Add(this.buttonDigitTwo);
            this.Controls.Add(this.buttonDigitOne);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonDigitZero);
            this.Controls.Add(this.buttonDot);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(360, 376);
            this.MinimumSize = new System.Drawing.Size(360, 376);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private CustomButton buttonDot;
        private CustomButton buttonDigitZero;
        private CustomButton buttonBackspace;
        private CustomButton buttonDigitOne;
        private CustomButton buttonDigitTwo;
        private CustomButton buttonDigitThree;
        private CustomButton buttonDigitFour;
        private CustomButton buttonDigitFive;
        private CustomButton buttonDigitSix;
        private CustomButton buttonDigitSeven;
        private CustomButton buttonDigitEight;
        private CustomButton buttonDigitNine;
        private CustomButton buttonOperationDivide;
        private CustomButton buttonOperationMultiply;
        private CustomButton buttonOperationMinus;
        private CustomButton buttonOperationPlus;
        private CustomButton buttonOperationEquals;
    }
}

