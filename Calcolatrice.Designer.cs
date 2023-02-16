using System.Runtime.CompilerServices;

namespace Calculator
{
    partial class Calcolatrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calcolatrice));
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.pnlHistory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.tableLayoutPanel1);
            this.pnlHistory.Controls.Add(this.txtResult);
            this.pnlHistory.Controls.Add(this.txtHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.pnlHistory.Size = new System.Drawing.Size(404, 466);
            this.pnlHistory.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelOperation, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtract, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNegate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button16, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnComma, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(303, 24);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 70);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelOperation.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancelOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelOperation.Location = new System.Drawing.Point(202, 24);
            this.btnCancelOperation.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(101, 70);
            this.btnCancelOperation.TabIndex = 34;
            this.btnCancelOperation.Text = "C";
            this.btnCancelOperation.UseVisualStyleBackColor = false;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.DimGray;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquare.Location = new System.Drawing.Point(0, 24);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(101, 70);
            this.btnSquare.TabIndex = 33;
            this.btnSquare.Text = "x^2\r\n";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(303, 94);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 70);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.DimGray;
            this.btnSubtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubtract.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(303, 164);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(101, 70);
            this.btnSubtract.TabIndex = 31;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.DimGray;
            this.btnMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(101, 24);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(101, 70);
            this.btnMultiply.TabIndex = 30;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DimGray;
            this.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(303, 234);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(101, 70);
            this.btnDivide.TabIndex = 29;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(303, 304);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(101, 73);
            this.btnEquals.TabIndex = 28;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(0, 234);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 70);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(101, 234);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(101, 70);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(202, 234);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(101, 70);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(0, 94);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(101, 70);
            this.btn7.TabIndex = 19;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(0, 164);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(101, 70);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(101, 164);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(101, 70);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(202, 164);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(101, 70);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(101, 94);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(101, 70);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(202, 94);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(101, 70);
            this.btn9.TabIndex = 24;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNegate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNegate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNegate.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNegate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegate.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNegate.Location = new System.Drawing.Point(0, 304);
            this.btnNegate.Margin = new System.Windows.Forms.Padding(0);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(101, 73);
            this.btnNegate.TabIndex = 25;
            this.btnNegate.Text = "+/-";
            this.btnNegate.UseVisualStyleBackColor = false;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(101, 304);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(101, 73);
            this.button16.TabIndex = 27;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btn_NumPad_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnComma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnComma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComma.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComma.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComma.Location = new System.Drawing.Point(202, 304);
            this.btnComma.Margin = new System.Windows.Forms.Padding(0);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(101, 73);
            this.btnComma.TabIndex = 26;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.ForeColor = System.Drawing.SystemColors.Info;
            this.txtResult.Location = new System.Drawing.Point(0, 46);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(404, 43);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHistory.ForeColor = System.Drawing.SystemColors.Info;
            this.txtHistory.Location = new System.Drawing.Point(0, 24);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHistory.Size = new System.Drawing.Size(404, 22);
            this.txtHistory.TabIndex = 0;
            this.txtHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calcolatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(404, 466);
            this.Controls.Add(this.pnlHistory);
            this.MinimumSize = new System.Drawing.Size(420, 440);
            this.Name = "Calcolatrice";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calculator";
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHistory;
        private TextBox txtHistory;
        private TextBox txtResult;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDelete;
        private Button btnCancelOperation;
        private Button btnSquare;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn7;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn8;
        private Button btn9;
        private Button btnNegate;
        private Button button16;
        private Button btnComma;
    }
}
