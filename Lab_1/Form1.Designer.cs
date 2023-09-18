namespace Lab_1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pnTools = new Panel();
            btnShow = new Button();
            btnHide = new Button();
            btnLeftFar = new Button();
            btnLeft = new Button();
            btnRightFar = new Button();
            btnRight = new Button();
            btnDownFar = new Button();
            btnDown = new Button();
            btnCollapse = new Button();
            btnExpand = new Button();
            btnUp = new Button();
            btnUpFar = new Button();
            btnCreateNew = new Button();
            label1 = new Label();
            cbCircles = new ComboBox();
            pnMain = new Panel();
            tabPage2 = new TabPage();
            pnTools1 = new Panel();
            btnLeftFar1 = new Button();
            btnLeft1 = new Button();
            btnRightFar1 = new Button();
            btnRight1 = new Button();
            btnDownFar1 = new Button();
            btnDown1 = new Button();
            btnCollapse1 = new Button();
            btnExpand1 = new Button();
            btnUp1 = new Button();
            btnUpFar1 = new Button();
            btnShow1 = new Button();
            btnHide1 = new Button();
            btnCreateNew1 = new Button();
            label3 = new Label();
            cbFigure = new ComboBox();
            pnMain1 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pnTools.SuspendLayout();
            tabPage2.SuspendLayout();
            pnTools1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(11, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(853, 558);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pnTools);
            tabPage1.Controls.Add(pnMain);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(845, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Приклад";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnTools
            // 
            pnTools.BackColor = SystemColors.Menu;
            pnTools.Controls.Add(btnShow);
            pnTools.Controls.Add(btnHide);
            pnTools.Controls.Add(btnLeftFar);
            pnTools.Controls.Add(btnLeft);
            pnTools.Controls.Add(btnRightFar);
            pnTools.Controls.Add(btnRight);
            pnTools.Controls.Add(btnDownFar);
            pnTools.Controls.Add(btnDown);
            pnTools.Controls.Add(btnCollapse);
            pnTools.Controls.Add(btnExpand);
            pnTools.Controls.Add(btnUp);
            pnTools.Controls.Add(btnUpFar);
            pnTools.Controls.Add(btnCreateNew);
            pnTools.Controls.Add(label1);
            pnTools.Controls.Add(cbCircles);
            pnTools.Dock = DockStyle.Right;
            pnTools.Location = new Point(511, 3);
            pnTools.Name = "pnTools";
            pnTools.Size = new Size(331, 519);
            pnTools.TabIndex = 1;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(15, 171);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(301, 38);
            btnShow.TabIndex = 4;
            btnShow.Text = "Показати об'єкт";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click_1;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(15, 127);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(301, 38);
            btnHide.TabIndex = 3;
            btnHide.Text = "Приховати об'єкт";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click_1;
            // 
            // btnLeftFar
            // 
            btnLeftFar.Location = new Point(14, 350);
            btnLeftFar.Name = "btnLeftFar";
            btnLeftFar.Size = new Size(97, 33);
            btnLeftFar.TabIndex = 14;
            btnLeftFar.Text = "↞";
            btnLeftFar.UseVisualStyleBackColor = true;
            btnLeftFar.Click += btnLeftFar_Click_1;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(14, 315);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(97, 33);
            btnLeft.TabIndex = 13;
            btnLeft.Text = "←";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click_1;
            // 
            // btnRightFar
            // 
            btnRightFar.Location = new Point(220, 350);
            btnRightFar.Name = "btnRightFar";
            btnRightFar.Size = new Size(97, 33);
            btnRightFar.TabIndex = 12;
            btnRightFar.Text = "↠";
            btnRightFar.UseVisualStyleBackColor = true;
            btnRightFar.Click += btnRightFar_Click_1;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(220, 315);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(97, 33);
            btnRight.TabIndex = 11;
            btnRight.Text = "→";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnDownFar
            // 
            btnDownFar.Location = new Point(117, 420);
            btnDownFar.Name = "btnDownFar";
            btnDownFar.Size = new Size(97, 33);
            btnDownFar.TabIndex = 10;
            btnDownFar.Text = "↡";
            btnDownFar.UseVisualStyleBackColor = true;
            btnDownFar.Click += btnDownFar_Click_1;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(117, 385);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(97, 33);
            btnDown.TabIndex = 9;
            btnDown.Text = "↓";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click_1;
            // 
            // btnCollapse
            // 
            btnCollapse.Location = new Point(117, 350);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(97, 33);
            btnCollapse.TabIndex = 8;
            btnCollapse.Text = "-";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click_1;
            // 
            // btnExpand
            // 
            btnExpand.Location = new Point(117, 315);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(97, 33);
            btnExpand.TabIndex = 7;
            btnExpand.Text = "+";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click_1;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(117, 280);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(97, 33);
            btnUp.TabIndex = 6;
            btnUp.Text = "↑";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click_1;
            // 
            // btnUpFar
            // 
            btnUpFar.Location = new Point(117, 245);
            btnUpFar.Name = "btnUpFar";
            btnUpFar.Size = new Size(97, 33);
            btnUpFar.TabIndex = 5;
            btnUpFar.Text = "↟";
            btnUpFar.UseVisualStyleBackColor = true;
            btnUpFar.Click += btnUpFar_Click_1;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(15, 83);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(301, 38);
            btnCreateNew.TabIndex = 2;
            btnCreateNew.Text = "Створити новий об'єкт";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Перелік об'єктів";
            // 
            // cbCircles
            // 
            cbCircles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCircles.FormattingEnabled = true;
            cbCircles.Location = new Point(15, 40);
            cbCircles.Name = "cbCircles";
            cbCircles.Size = new Size(301, 28);
            cbCircles.TabIndex = 0;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(3, 3);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(839, 519);
            pnMain.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnTools1);
            tabPage2.Controls.Add(pnMain1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(845, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnTools1
            // 
            pnTools1.BackColor = SystemColors.Menu;
            pnTools1.Controls.Add(btnLeftFar1);
            pnTools1.Controls.Add(btnLeft1);
            pnTools1.Controls.Add(btnRightFar1);
            pnTools1.Controls.Add(btnRight1);
            pnTools1.Controls.Add(btnDownFar1);
            pnTools1.Controls.Add(btnDown1);
            pnTools1.Controls.Add(btnCollapse1);
            pnTools1.Controls.Add(btnExpand1);
            pnTools1.Controls.Add(btnUp1);
            pnTools1.Controls.Add(btnUpFar1);
            pnTools1.Controls.Add(btnShow1);
            pnTools1.Controls.Add(btnHide1);
            pnTools1.Controls.Add(btnCreateNew1);
            pnTools1.Controls.Add(label3);
            pnTools1.Controls.Add(cbFigure);
            pnTools1.Location = new Point(483, 5);
            pnTools1.Name = "pnTools1";
            pnTools1.Size = new Size(361, 517);
            pnTools1.TabIndex = 1;
            // 
            // btnLeftFar1
            // 
            btnLeftFar1.Location = new Point(33, 382);
            btnLeftFar1.Name = "btnLeftFar1";
            btnLeftFar1.Size = new Size(94, 29);
            btnLeftFar1.TabIndex = 14;
            btnLeftFar1.Text = "↞";
            btnLeftFar1.UseVisualStyleBackColor = true;
            btnLeftFar1.Click += btnLeftFar1_Click;
            // 
            // btnLeft1
            // 
            btnLeft1.Location = new Point(33, 347);
            btnLeft1.Name = "btnLeft1";
            btnLeft1.Size = new Size(94, 29);
            btnLeft1.TabIndex = 13;
            btnLeft1.Text = "←";
            btnLeft1.UseVisualStyleBackColor = true;
            btnLeft1.Click += btnLeft1_Click;
            // 
            // btnRightFar1
            // 
            btnRightFar1.Location = new Point(233, 382);
            btnRightFar1.Name = "btnRightFar1";
            btnRightFar1.Size = new Size(94, 29);
            btnRightFar1.TabIndex = 12;
            btnRightFar1.Text = "↠";
            btnRightFar1.UseVisualStyleBackColor = true;
            btnRightFar1.Click += btnRightFar1_Click;
            // 
            // btnRight1
            // 
            btnRight1.Location = new Point(233, 347);
            btnRight1.Name = "btnRight1";
            btnRight1.Size = new Size(94, 29);
            btnRight1.TabIndex = 11;
            btnRight1.Text = "→";
            btnRight1.UseVisualStyleBackColor = true;
            btnRight1.Click += btnRight1_Click;
            // 
            // btnDownFar1
            // 
            btnDownFar1.Location = new Point(133, 452);
            btnDownFar1.Name = "btnDownFar1";
            btnDownFar1.Size = new Size(94, 29);
            btnDownFar1.TabIndex = 10;
            btnDownFar1.Text = "↡";
            btnDownFar1.UseVisualStyleBackColor = true;
            btnDownFar1.Click += btnDownFar1_Click;
            // 
            // btnDown1
            // 
            btnDown1.Location = new Point(133, 417);
            btnDown1.Name = "btnDown1";
            btnDown1.Size = new Size(94, 29);
            btnDown1.TabIndex = 9;
            btnDown1.Text = "↓";
            btnDown1.UseVisualStyleBackColor = true;
            btnDown1.Click += btnDown1_Click;
            // 
            // btnCollapse1
            // 
            btnCollapse1.Location = new Point(133, 382);
            btnCollapse1.Name = "btnCollapse1";
            btnCollapse1.Size = new Size(94, 29);
            btnCollapse1.TabIndex = 8;
            btnCollapse1.Text = "-";
            btnCollapse1.UseVisualStyleBackColor = true;
            btnCollapse1.Click += btnCollapse1_Click;
            // 
            // btnExpand1
            // 
            btnExpand1.Location = new Point(133, 347);
            btnExpand1.Name = "btnExpand1";
            btnExpand1.Size = new Size(94, 29);
            btnExpand1.TabIndex = 7;
            btnExpand1.Text = "+";
            btnExpand1.UseVisualStyleBackColor = true;
            btnExpand1.Click += btnExpand1_Click;
            // 
            // btnUp1
            // 
            btnUp1.Location = new Point(133, 312);
            btnUp1.Name = "btnUp1";
            btnUp1.Size = new Size(94, 29);
            btnUp1.TabIndex = 6;
            btnUp1.Text = "↑";
            btnUp1.UseVisualStyleBackColor = true;
            btnUp1.Click += btnUp1_Click;
            // 
            // btnUpFar1
            // 
            btnUpFar1.Location = new Point(133, 277);
            btnUpFar1.Name = "btnUpFar1";
            btnUpFar1.Size = new Size(94, 29);
            btnUpFar1.TabIndex = 5;
            btnUpFar1.Text = "↟";
            btnUpFar1.UseVisualStyleBackColor = true;
            btnUpFar1.Click += btnUpFar1_Click;
            // 
            // btnShow1
            // 
            btnShow1.Location = new Point(23, 169);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(315, 29);
            btnShow1.TabIndex = 4;
            btnShow1.Text = "Показати об'єкт";
            btnShow1.UseVisualStyleBackColor = true;
            btnShow1.Click += button3_Click;
            // 
            // btnHide1
            // 
            btnHide1.Location = new Point(23, 134);
            btnHide1.Name = "btnHide1";
            btnHide1.Size = new Size(315, 29);
            btnHide1.TabIndex = 3;
            btnHide1.Text = "Приховати об'єкт";
            btnHide1.UseVisualStyleBackColor = true;
            btnHide1.Click += btnHide1_Click;
            // 
            // btnCreateNew1
            // 
            btnCreateNew1.Location = new Point(23, 99);
            btnCreateNew1.Name = "btnCreateNew1";
            btnCreateNew1.Size = new Size(315, 29);
            btnCreateNew1.TabIndex = 2;
            btnCreateNew1.Text = "Створити новий об'єкт";
            btnCreateNew1.UseVisualStyleBackColor = true;
            btnCreateNew1.Click += btnCreateNew1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 10);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 1;
            label3.Text = "Перелік об'єктів";
            // 
            // cbFigure
            // 
            cbFigure.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFigure.FormattingEnabled = true;
            cbFigure.Location = new Point(23, 33);
            cbFigure.Name = "cbFigure";
            cbFigure.Size = new Size(315, 28);
            cbFigure.TabIndex = 0;
            // 
            // pnMain1
            // 
            pnMain1.Location = new Point(5, 5);
            pnMain1.Name = "pnMain1";
            pnMain1.Size = new Size(470, 514);
            pnMain1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 571);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №1 Андросов";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnTools.ResumeLayout(false);
            pnTools.PerformLayout();
            tabPage2.ResumeLayout(false);
            pnTools1.ResumeLayout(false);
            pnTools1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel pnTools;
        private Button btnLeftFar;
        private Button btnLeft;
        private Button btnRightFar;
        private Button btnRight;
        private Button btnDownFar;
        private Button btnDown;
        private Button btnCollapse;
        private Button btnExpand;
        private Button btnUp;
        private Button btnUpFar;
        private Button btnShow;
        private Button btnHide;
        private Button btnCreateNew;
        private Label label1;
        private ComboBox cbCircles;
        private Panel pnMain;
        private TabPage tabPage2;
        private Panel pnTools1;
        private Label label3;
        private ComboBox cbFigure;
        private Panel pnMain1;
        private Button btnShow1;
        private Button btnHide1;
        private Button btnCreateNew1;
        private Button btnLeftFar1;
        private Button btnLeft1;
        private Button btnRightFar1;
        private Button btnRight1;
        private Button btnDownFar1;
        private Button btnDown1;
        private Button btnCollapse1;
        private Button btnExpand1;
        private Button btnUp1;
        private Button btnUpFar1;
    }
}