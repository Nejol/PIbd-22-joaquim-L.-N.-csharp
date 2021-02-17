namespace WindowsFormsPlane
{
    partial class FormAeroplane
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
            this.pictureBoxAeroplane = new System.Windows.Forms.PictureBox();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.groupBoxPlane = new System.Windows.Forms.GroupBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelPark = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddAeroplane = new System.Windows.Forms.Button();
            this.listBoxAeroplanes = new System.Windows.Forms.ListBox();
            this.buttonDeleteAeroplane = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAeroplane)).BeginInit();
            this.groupBoxPlane.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAeroplane
            // 
            this.pictureBoxAeroplane.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxAeroplane.Name = "pictureBoxAeroplane";
            this.pictureBoxAeroplane.Size = new System.Drawing.Size(1350, 722);
            this.pictureBoxAeroplane.TabIndex = 0;
            this.pictureBoxAeroplane.TabStop = false;
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(1108, 499);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(190, 36);
            this.buttonSetPlane.TabIndex = 1;
            this.buttonSetPlane.Text = "Посадить самолёт";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // groupBoxPlane
            // 
            this.groupBoxPlane.Controls.Add(this.buttonTakePlane);
            this.groupBoxPlane.Controls.Add(this.maskedTextBox);
            this.groupBoxPlane.Controls.Add(this.labelPlace);
            this.groupBoxPlane.Location = new System.Drawing.Point(1108, 567);
            this.groupBoxPlane.Name = "groupBoxPlane";
            this.groupBoxPlane.Size = new System.Drawing.Size(190, 139);
            this.groupBoxPlane.TabIndex = 3;
            this.groupBoxPlane.TabStop = false;
            this.groupBoxPlane.Text = "Забрать самолёт";
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(86, 86);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(77, 23);
            this.buttonTakePlane.TabIndex = 2;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(99, 29);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(43, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(20, 29);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // labelPark
            // 
            this.labelPark.AutoSize = true;
            this.labelPark.Location = new System.Drawing.Point(1173, 43);
            this.labelPark.Name = "labelPark";
            this.labelPark.Size = new System.Drawing.Size(59, 13);
            this.labelPark.TabIndex = 4;
            this.labelPark.Text = "Аэроплан:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1108, 80);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(190, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddAeroplane
            // 
            this.buttonAddAeroplane.Location = new System.Drawing.Point(1108, 109);
            this.buttonAddAeroplane.Name = "buttonAddAeroplane";
            this.buttonAddAeroplane.Size = new System.Drawing.Size(190, 36);
            this.buttonAddAeroplane.TabIndex = 6;
            this.buttonAddAeroplane.Text = "Добавить аэроплан";
            this.buttonAddAeroplane.UseVisualStyleBackColor = true;
            this.buttonAddAeroplane.Click += new System.EventHandler(this.buttonAddAeroplane_Click);
            // 
            // listBoxAeroplanes
            // 
            this.listBoxAeroplanes.FormattingEnabled = true;
            this.listBoxAeroplanes.Location = new System.Drawing.Point(1108, 172);
            this.listBoxAeroplanes.Name = "listBoxAeroplanes";
            this.listBoxAeroplanes.Size = new System.Drawing.Size(190, 173);
            this.listBoxAeroplanes.TabIndex = 7;
            this.listBoxAeroplanes.Click += new System.EventHandler(this.listBoxAeroplanes_SelectedIndexChanged);
            this.listBoxAeroplanes.SelectedIndexChanged += new System.EventHandler(this.listBoxAeroplanes_SelectedIndexChanged);
            // 
            // buttonDeleteAeroplane
            // 
            this.buttonDeleteAeroplane.Location = new System.Drawing.Point(1108, 367);
            this.buttonDeleteAeroplane.Name = "buttonDeleteAeroplane";
            this.buttonDeleteAeroplane.Size = new System.Drawing.Size(190, 36);
            this.buttonDeleteAeroplane.TabIndex = 8;
            this.buttonDeleteAeroplane.Text = "Удалить аэроплан";
            this.buttonDeleteAeroplane.UseVisualStyleBackColor = true;
            this.buttonDeleteAeroplane.Click += new System.EventHandler(this.buttonDeleteAeroplane_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.загрузитьToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.файлToolStripMenuItem.Text = "Фаыл";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem1
            // 
            this.загрузитьToolStripMenuItem1.Name = "загрузитьToolStripMenuItem1";
            this.загрузитьToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem1.Text = "Загрузить";
            this.загрузитьToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(1108, 436);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(190, 35);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Соритровать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormAeroplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonDeleteAeroplane);
            this.Controls.Add(this.listBoxAeroplanes);
            this.Controls.Add(this.buttonAddAeroplane);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.labelPark);
            this.Controls.Add(this.groupBoxPlane);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.pictureBoxAeroplane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAeroplane";
            this.Text = "FormAeroplane";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAeroplane)).EndInit();
            this.groupBoxPlane.ResumeLayout(false);
            this.groupBoxPlane.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAeroplane;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.GroupBox groupBoxPlane;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelPark;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddAeroplane;
        private System.Windows.Forms.ListBox listBoxAeroplanes;
        private System.Windows.Forms.Button buttonDeleteAeroplane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}