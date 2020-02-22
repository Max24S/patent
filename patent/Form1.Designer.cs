namespace patent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberT = new System.Windows.Forms.TextBox();
            this.diameterT = new System.Windows.Forms.TextBox();
            this.thicknessT = new System.Windows.Forms.TextBox();
            this.widthT = new System.Windows.Forms.TextBox();
            this.stepT = new System.Windows.Forms.TextBox();
            this.SigTt = new System.Windows.Forms.TextBox();
            this.modulusT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultT = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.viT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.XioT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Hmin = new System.Windows.Forms.TextBox();
            this.Hmax = new System.Windows.Forms.TextBox();
            this.Gmax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Aost_text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberT
            // 
            this.numberT.Location = new System.Drawing.Point(191, 66);
            this.numberT.Name = "numberT";
            this.numberT.Size = new System.Drawing.Size(66, 22);
            this.numberT.TabIndex = 0;
            this.numberT.Text = "11";
            // 
            // diameterT
            // 
            this.diameterT.Location = new System.Drawing.Point(191, 112);
            this.diameterT.Name = "diameterT";
            this.diameterT.Size = new System.Drawing.Size(66, 22);
            this.diameterT.TabIndex = 1;
            this.diameterT.Text = "260";
            // 
            // thicknessT
            // 
            this.thicknessT.Location = new System.Drawing.Point(191, 171);
            this.thicknessT.Name = "thicknessT";
            this.thicknessT.Size = new System.Drawing.Size(66, 22);
            this.thicknessT.TabIndex = 2;
            this.thicknessT.Text = "10";
            // 
            // widthT
            // 
            this.widthT.AutoCompleteCustomSource.AddRange(new string[] {
            "23",
            "4214",
            "545",
            "6546",
            "1231",
            "5435",
            "12312",
            "6546",
            "123",
            "65"});
            this.widthT.Location = new System.Drawing.Point(191, 212);
            this.widthT.Name = "widthT";
            this.widthT.Size = new System.Drawing.Size(66, 22);
            this.widthT.TabIndex = 3;
            this.widthT.Text = "2000";
            // 
            // stepT
            // 
            this.stepT.AutoCompleteCustomSource.AddRange(new string[] {
            "ццуццуйуйуйуйууууууууууууууууууууууууууууууууууууууууууууууууууууууууууууууууу",
            "кйкккккккккккк"});
            this.stepT.Location = new System.Drawing.Point(191, 255);
            this.stepT.Name = "stepT";
            this.stepT.Size = new System.Drawing.Size(66, 22);
            this.stepT.TabIndex = 4;
            this.stepT.Text = "275";
            // 
            // SigTt
            // 
            this.SigTt.Location = new System.Drawing.Point(191, 299);
            this.SigTt.Name = "SigTt";
            this.SigTt.Size = new System.Drawing.Size(66, 22);
            this.SigTt.TabIndex = 5;
            this.SigTt.Text = "450";
            // 
            // modulusT
            // 
            this.modulusT.Location = new System.Drawing.Point(191, 343);
            this.modulusT.Name = "modulusT";
            this.modulusT.Size = new System.Drawing.Size(66, 22);
            this.modulusT.TabIndex = 6;
            this.modulusT.Text = "210000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "количество роликов,n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "диаметр роликов,d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "толщина,h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ширина,B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "E,модуль упругости";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "шаг,t";
            // 
            // resultT
            // 
            this.resultT.Location = new System.Drawing.Point(291, 178);
            this.resultT.Name = "resultT";
            this.resultT.Size = new System.Drawing.Size(265, 187);
            this.resultT.TabIndex = 13;
            this.resultT.Text = "Высчитать";
            this.resultT.UseVisualStyleBackColor = true;
            this.resultT.Click += new System.EventHandler(this.ResultT_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(630, 117);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(659, 388);
            this.res.TabIndex = 14;
            this.res.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "vi";
            // 
            // viT
            // 
            this.viT.Location = new System.Drawing.Point(191, 395);
            this.viT.Name = "viT";
            this.viT.Size = new System.Drawing.Size(66, 22);
            this.viT.TabIndex = 15;
            this.viT.Text = "0,3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "A0";
            // 
            // XioT
            // 
            this.XioT.Location = new System.Drawing.Point(191, 451);
            this.XioT.Name = "XioT";
            this.XioT.Size = new System.Drawing.Size(66, 22);
            this.XioT.TabIndex = 17;
            this.XioT.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "SigT";
            // 
            // Hmin
            // 
            this.Hmin.Location = new System.Drawing.Point(811, 66);
            this.Hmin.Name = "Hmin";
            this.Hmin.Size = new System.Drawing.Size(100, 22);
            this.Hmin.TabIndex = 20;
            // 
            // Hmax
            // 
            this.Hmax.Location = new System.Drawing.Point(990, 66);
            this.Hmax.Name = "Hmax";
            this.Hmax.Size = new System.Drawing.Size(100, 22);
            this.Hmax.TabIndex = 21;
            // 
            // Gmax
            // 
            this.Gmax.Location = new System.Drawing.Point(1141, 66);
            this.Gmax.Name = "Gmax";
            this.Gmax.Size = new System.Drawing.Size(100, 22);
            this.Gmax.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(808, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "hmin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1009, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "hmax";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1156, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Gmax";
            // 
            // Aost_text
            // 
            this.Aost_text.Location = new System.Drawing.Point(644, 69);
            this.Aost_text.Name = "Aost_text";
            this.Aost_text.Size = new System.Drawing.Size(100, 22);
            this.Aost_text.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(609, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Допуск плоскостности,мм/м";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 539);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Aost_text);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Gmax);
            this.Controls.Add(this.Hmax);
            this.Controls.Add(this.Hmin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.XioT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.viT);
            this.Controls.Add(this.res);
            this.Controls.Add(this.resultT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modulusT);
            this.Controls.Add(this.SigTt);
            this.Controls.Add(this.stepT);
            this.Controls.Add(this.widthT);
            this.Controls.Add(this.thicknessT);
            this.Controls.Add(this.diameterT);
            this.Controls.Add(this.numberT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberT;
        private System.Windows.Forms.TextBox diameterT;
        private System.Windows.Forms.TextBox thicknessT;
        private System.Windows.Forms.TextBox widthT;
        private System.Windows.Forms.TextBox stepT;
        private System.Windows.Forms.TextBox SigTt;
        private System.Windows.Forms.TextBox modulusT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SigT;
        private System.Windows.Forms.Button resultT;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox viT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XioT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Hmin;
        private System.Windows.Forms.TextBox Hmax;
        private System.Windows.Forms.TextBox Gmax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Aost_text;
        private System.Windows.Forms.Label label13;
    }
}

