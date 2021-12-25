
namespace Sclad
{
    partial class Manu
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Tap = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.DelManu = new System.Windows.Forms.Button();
            this.AddMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Name,
            this.Inform,
            this.Status});
            this.List.HideSelection = false;
            this.List.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.List.Location = new System.Drawing.Point(39, 103);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(809, 375);
            this.List.TabIndex = 8;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 29;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 228;
            // 
            // Inform
            // 
            this.Inform.Text = "Inform";
            this.Inform.Width = 273;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 272;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(148, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Gold;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(34, 501);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(97, 29);
            this.Next.TabIndex = 14;
            this.Next.Text = "Назад";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Tap
            // 
            this.Tap.BackColor = System.Drawing.Color.Gold;
            this.Tap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tap.Location = new System.Drawing.Point(264, 501);
            this.Tap.Name = "Tap";
            this.Tap.Size = new System.Drawing.Size(103, 29);
            this.Tap.TabIndex = 13;
            this.Tap.Text = "Обновить";
            this.Tap.UseVisualStyleBackColor = false;
            this.Tap.Click += new System.EventHandler(this.Tap_Click);
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.Gold;
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Del.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.Location = new System.Drawing.Point(404, 501);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(97, 29);
            this.Del.TabIndex = 12;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // DelManu
            // 
            this.DelManu.BackColor = System.Drawing.Color.Gold;
            this.DelManu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelManu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelManu.Location = new System.Drawing.Point(589, 502);
            this.DelManu.Name = "DelManu";
            this.DelManu.Size = new System.Drawing.Size(109, 29);
            this.DelManu.TabIndex = 11;
            this.DelManu.Text = "Изменить";
            this.DelManu.UseVisualStyleBackColor = false;
            this.DelManu.Click += new System.EventHandler(this.DelManu_Click);
            // 
            // AddMenu
            // 
            this.AddMenu.BackColor = System.Drawing.Color.Gold;
            this.AddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMenu.Location = new System.Drawing.Point(735, 502);
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(113, 29);
            this.AddMenu.TabIndex = 10;
            this.AddMenu.Text = "Добавить";
            this.AddMenu.UseVisualStyleBackColor = false;
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(296, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(552, 28);
            this.textBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Sclad.Properties.Resources.Одежда_для_ручек;
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Manu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(889, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Tap);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.DelManu);
            this.Controls.Add(this.AddMenu);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Manu";
            this.Text = "Manu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Inform;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Tap;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button DelManu;
        private System.Windows.Forms.Button AddMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}