namespace TicTacToe
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            pButton1 = new PlayButton(components);
            pButton3 = new PlayButton(components);
            pButton4 = new PlayButton(components);
            pButton5 = new PlayButton(components);
            pButton6 = new PlayButton(components);
            pButton7 = new PlayButton(components);
            pButton8 = new PlayButton(components);
            pButton9 = new PlayButton(components);
            pButton2 = new PlayButton(components);
            button1 = new Button();
            winnerText = new TextBox();
            turnText = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(pButton1, 0, 0);
            tableLayoutPanel1.Controls.Add(pButton3, 2, 0);
            tableLayoutPanel1.Controls.Add(pButton4, 0, 1);
            tableLayoutPanel1.Controls.Add(pButton5, 1, 1);
            tableLayoutPanel1.Controls.Add(pButton6, 2, 1);
            tableLayoutPanel1.Controls.Add(pButton7, 0, 2);
            tableLayoutPanel1.Controls.Add(pButton8, 1, 2);
            tableLayoutPanel1.Controls.Add(pButton9, 2, 2);
            tableLayoutPanel1.Controls.Add(pButton2, 1, 0);
            tableLayoutPanel1.Location = new Point(15, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(300, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pButton1
            // 
            pButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton1.BackColor = Color.White;
            pButton1.Location = new Point(3, 3);
            pButton1.Name = "pButton1";
            pButton1.Size = new Size(94, 94);
            pButton1.TabIndex = 1;
            pButton1.UseVisualStyleBackColor = false;
            // 
            // pButton3
            // 
            pButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton3.BackColor = Color.White;
            pButton3.Location = new Point(203, 3);
            pButton3.Name = "pButton3";
            pButton3.Size = new Size(94, 94);
            pButton3.TabIndex = 1;
            pButton3.UseVisualStyleBackColor = false;
            // 
            // pButton4
            // 
            pButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton4.BackColor = Color.White;
            pButton4.Location = new Point(3, 103);
            pButton4.Name = "pButton4";
            pButton4.Size = new Size(94, 94);
            pButton4.TabIndex = 1;
            pButton4.UseVisualStyleBackColor = false;
            // 
            // pButton5
            // 
            pButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton5.BackColor = Color.White;
            pButton5.Location = new Point(103, 103);
            pButton5.Name = "pButton5";
            pButton5.Size = new Size(94, 94);
            pButton5.TabIndex = 1;
            pButton5.UseVisualStyleBackColor = false;
            // 
            // pButton6
            // 
            pButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton6.BackColor = Color.White;
            pButton6.Location = new Point(203, 103);
            pButton6.Name = "pButton6";
            pButton6.Size = new Size(94, 94);
            pButton6.TabIndex = 1;
            pButton6.UseVisualStyleBackColor = false;
            // 
            // pButton7
            // 
            pButton7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton7.BackColor = Color.White;
            pButton7.Location = new Point(3, 203);
            pButton7.Name = "pButton7";
            pButton7.Size = new Size(94, 94);
            pButton7.TabIndex = 1;
            pButton7.UseVisualStyleBackColor = false;
            // 
            // pButton8
            // 
            pButton8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton8.BackColor = Color.White;
            pButton8.Location = new Point(103, 203);
            pButton8.Name = "pButton8";
            pButton8.Size = new Size(94, 94);
            pButton8.TabIndex = 1;
            pButton8.UseVisualStyleBackColor = false;
            // 
            // pButton9
            // 
            pButton9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton9.BackColor = Color.White;
            pButton9.Location = new Point(203, 203);
            pButton9.Name = "pButton9";
            pButton9.Size = new Size(94, 94);
            pButton9.TabIndex = 1;
            pButton9.UseVisualStyleBackColor = false;
            // 
            // pButton2
            // 
            pButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pButton2.BackColor = Color.White;
            pButton2.Location = new Point(103, 3);
            pButton2.Name = "pButton2";
            pButton2.Size = new Size(94, 94);
            pButton2.TabIndex = 1;
            pButton2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(218, 340);
            button1.Name = "button1";
            button1.Size = new Size(97, 25);
            button1.TabIndex = 1;
            button1.Text = "Reset Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ResetAll;
            // 
            // winnerText
            // 
            winnerText.BackColor = SystemColors.Control;
            winnerText.BorderStyle = BorderStyle.None;
            winnerText.ForeColor = Color.ForestGreen;
            winnerText.Location = new Point(18, 12);
            winnerText.Name = "winnerText";
            winnerText.Size = new Size(294, 16);
            winnerText.TabIndex = 2;
            // 
            // turnText
            // 
            turnText.BackColor = SystemColors.Control;
            turnText.BorderStyle = BorderStyle.None;
            turnText.Location = new Point(18, 340);
            turnText.Name = "turnText";
            turnText.Size = new Size(194, 16);
            turnText.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 377);
            Controls.Add(turnText);
            Controls.Add(winnerText);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Tic-Tac-Toe";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PlayButton pButton1;
        private PlayButton pButton2;
        private PlayButton pButton3;
        private PlayButton pButton4;
        private PlayButton pButton5;
        private PlayButton pButton6;
        private PlayButton pButton7;
        private PlayButton pButton8;
        private PlayButton pButton9;
        private Button button1;
        private TextBox winnerText;
        private TextBox turnText;
    }
}
