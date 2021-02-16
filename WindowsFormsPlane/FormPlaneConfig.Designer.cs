namespace WindowsFormsPlane
{
    partial class FormPlaneConfig
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
            this.groupBoxPlane = new System.Windows.Forms.GroupBox();
            this.labelWarplane = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxFoguete = new System.Windows.Forms.CheckBox();
            this.checkBoxMissele = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Button();
            this.labelMainColor = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxPlane.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.panelPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPlane
            // 
            this.groupBoxPlane.Controls.Add(this.labelWarplane);
            this.groupBoxPlane.Controls.Add(this.labelPlane);
            this.groupBoxPlane.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlane.Name = "groupBoxPlane";
            this.groupBoxPlane.Size = new System.Drawing.Size(148, 195);
            this.groupBoxPlane.TabIndex = 0;
            this.groupBoxPlane.TabStop = false;
            this.groupBoxPlane.Text = "Тип самолёта";
            // 
            // labelWarplane
            // 
            this.labelWarplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarplane.Location = new System.Drawing.Point(18, 126);
            this.labelWarplane.Name = "labelWarplane";
            this.labelWarplane.Size = new System.Drawing.Size(113, 40);
            this.labelWarplane.TabIndex = 1;
            this.labelWarplane.Text = "Самолёт войны";
            this.labelWarplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarplane_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(18, 46);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(113, 36);
            this.labelPlane.TabIndex = 1;
            this.labelPlane.Text = "Обычный самолёт";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxFoguete);
            this.groupBoxParameters.Controls.Add(this.checkBoxMissele);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 245);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(409, 130);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxFoguete
            // 
            this.checkBoxFoguete.AutoSize = true;
            this.checkBoxFoguete.Location = new System.Drawing.Point(202, 93);
            this.checkBoxFoguete.Name = "checkBoxFoguete";
            this.checkBoxFoguete.Size = new System.Drawing.Size(65, 17);
            this.checkBoxFoguete.TabIndex = 4;
            this.checkBoxFoguete.Text = "Foguete";
            this.checkBoxFoguete.UseVisualStyleBackColor = true;
            // 
            // checkBoxMissele
            // 
            this.checkBoxMissele.AutoSize = true;
            this.checkBoxMissele.Location = new System.Drawing.Point(202, 40);
            this.checkBoxMissele.Name = "checkBoxMissele";
            this.checkBoxMissele.Size = new System.Drawing.Size(61, 17);
            this.checkBoxMissele.TabIndex = 3;
            this.checkBoxMissele.Text = "Missele";
            this.checkBoxMissele.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(61, 92);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownWeight.TabIndex = 2;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(61, 39);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вес авто:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Макс. скорость:";
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(165, 12);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(256, 227);
            this.panelPlane.TabIndex = 2;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(248, 219);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelFuchsia);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelAqua);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(427, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(176, 195);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(133, 133);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(35, 35);
            this.panelGray.TabIndex = 8;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(92, 132);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(35, 35);
            this.panelBlack.TabIndex = 7;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.Location = new System.Drawing.Point(51, 133);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(35, 35);
            this.panelFuchsia.TabIndex = 4;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(10, 133);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(35, 35);
            this.panelGreen.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(132, 90);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(35, 35);
            this.panelYellow.TabIndex = 6;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(90, 90);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(35, 35);
            this.panelBlue.TabIndex = 5;
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(50, 90);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(35, 35);
            this.panelAqua.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(9, 90);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(35, 35);
            this.panelRed.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.Location = new System.Drawing.Point(91, 30);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(75, 34);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.UseVisualStyleBackColor = true;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.Location = new System.Drawing.Point(10, 30);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(75, 34);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.UseVisualStyleBackColor = true;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(427, 285);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(86, 48);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(519, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 48);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxPlane);
            this.Name = "FormPlaneConfig";
            this.Text = "FormPlaneConfig";
            this.groupBoxPlane.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.panelPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlane;
        private System.Windows.Forms.Label labelWarplane;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxFoguete;
        private System.Windows.Forms.CheckBox checkBoxMissele;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button labelDopColor;
        private System.Windows.Forms.Button labelMainColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}