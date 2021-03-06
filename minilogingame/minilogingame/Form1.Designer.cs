
namespace minilogingame
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btn_Cupcake = new System.Windows.Forms.Button();
            this.btn_Pie = new System.Windows.Forms.Button();
            this.btn_Cake = new System.Windows.Forms.Button();
            this.btn_Cakepop = new System.Windows.Forms.Button();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Mini Login page Game";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(99, 101);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(223, 22);
            this.textBox_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(95, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(99, 160);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(223, 22);
            this.textBox_Password.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picbox
            // 
            this.picbox.Image = global::minilogingame.Properties.Resources.gg;
            this.picbox.Location = new System.Drawing.Point(445, 54);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(220, 220);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 3;
            this.picbox.TabStop = false;
            // 
            // btn_Cupcake
            // 
            this.btn_Cupcake.Location = new System.Drawing.Point(429, 290);
            this.btn_Cupcake.Name = "btn_Cupcake";
            this.btn_Cupcake.Size = new System.Drawing.Size(100, 33);
            this.btn_Cupcake.TabIndex = 4;
            this.btn_Cupcake.Text = "cupcake";
            this.btn_Cupcake.UseVisualStyleBackColor = true;
            this.btn_Cupcake.Click += new System.EventHandler(this.btn_Cupcake_Click);
            // 
            // btn_Pie
            // 
            this.btn_Pie.Location = new System.Drawing.Point(429, 329);
            this.btn_Pie.Name = "btn_Pie";
            this.btn_Pie.Size = new System.Drawing.Size(100, 33);
            this.btn_Pie.TabIndex = 4;
            this.btn_Pie.Text = "pie";
            this.btn_Pie.UseVisualStyleBackColor = true;
            this.btn_Pie.Click += new System.EventHandler(this.btn_Pie_Click);
            // 
            // btn_Cake
            // 
            this.btn_Cake.Location = new System.Drawing.Point(580, 290);
            this.btn_Cake.Name = "btn_Cake";
            this.btn_Cake.Size = new System.Drawing.Size(100, 33);
            this.btn_Cake.TabIndex = 4;
            this.btn_Cake.Text = "cake";
            this.btn_Cake.UseVisualStyleBackColor = true;
            this.btn_Cake.Click += new System.EventHandler(this.btn_Cake_Click);
            // 
            // btn_Cakepop
            // 
            this.btn_Cakepop.Location = new System.Drawing.Point(580, 329);
            this.btn_Cakepop.Name = "btn_Cakepop";
            this.btn_Cakepop.Size = new System.Drawing.Size(100, 33);
            this.btn_Cakepop.TabIndex = 4;
            this.btn_Cakepop.Text = "cakepop";
            this.btn_Cakepop.UseVisualStyleBackColor = true;
            this.btn_Cakepop.Click += new System.EventHandler(this.btn_Cakepop_Click);
            // 
            // btn_Done
            // 
            this.btn_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Done.Location = new System.Drawing.Point(129, 260);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(179, 50);
            this.btn_Done.TabIndex = 5;
            this.btn_Done.Text = "DONE";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Restart.Location = new System.Drawing.Point(129, 352);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(179, 50);
            this.btn_Restart.TabIndex = 5;
            this.btn_Restart.Text = "RESTART";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.btn_Cakepop);
            this.Controls.Add(this.btn_Cake);
            this.Controls.Add(this.btn_Pie);
            this.Controls.Add(this.btn_Cupcake);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btn_Cupcake;
        private System.Windows.Forms.Button btn_Pie;
        private System.Windows.Forms.Button btn_Cake;
        private System.Windows.Forms.Button btn_Cakepop;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_Restart;
    }
}

