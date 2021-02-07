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
            this.buttonLandPlane = new System.Windows.Forms.Button();
            this.buttonLandWarplane = new System.Windows.Forms.Button();
            this.groupBoxPlane = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAeroplane)).BeginInit();
            this.groupBoxPlane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAeroplane
            // 
            this.pictureBoxAeroplane.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAeroplane.Name = "pictureBoxAeroplane";
            this.pictureBoxAeroplane.Size = new System.Drawing.Size(1350, 749);
            this.pictureBoxAeroplane.TabIndex = 0;
            this.pictureBoxAeroplane.TabStop = false;
            // 
            // buttonLandPlane
            // 
            this.buttonLandPlane.Location = new System.Drawing.Point(1112, 48);
            this.buttonLandPlane.Name = "buttonLandPlane";
            this.buttonLandPlane.Size = new System.Drawing.Size(190, 36);
            this.buttonLandPlane.TabIndex = 1;
            this.buttonLandPlane.Text = "Посадить самолёт";
            this.buttonLandPlane.UseVisualStyleBackColor = true;
            this.buttonLandPlane.Click += new System.EventHandler(this.buttonLandPlane_Click);
            // 
            // buttonLandWarplane
            // 
            this.buttonLandWarplane.Location = new System.Drawing.Point(1112, 114);
            this.buttonLandWarplane.Name = "buttonLandWarplane";
            this.buttonLandWarplane.Size = new System.Drawing.Size(190, 41);
            this.buttonLandWarplane.TabIndex = 2;
            this.buttonLandWarplane.Text = "Посадить Аэроплан";
            this.buttonLandWarplane.UseVisualStyleBackColor = true;
            this.buttonLandWarplane.Click += new System.EventHandler(this.buttonLandWarplane_Click);
            // 
            // groupBoxPlane
            // 
            this.groupBoxPlane.Controls.Add(this.buttonTakePlane);
            this.groupBoxPlane.Controls.Add(this.maskedTextBox);
            this.groupBoxPlane.Controls.Add(this.labelPlace);
            this.groupBoxPlane.Location = new System.Drawing.Point(1112, 189);
            this.groupBoxPlane.Name = "groupBoxPlane";
            this.groupBoxPlane.Size = new System.Drawing.Size(190, 139);
            this.groupBoxPlane.TabIndex = 3;
            this.groupBoxPlane.TabStop = false;
            this.groupBoxPlane.Text = "Забрать самолёт";
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
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(99, 29);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(43, 20);
            this.maskedTextBox.TabIndex = 1;
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
            // FormAeroplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.groupBoxPlane);
            this.Controls.Add(this.buttonLandWarplane);
            this.Controls.Add(this.buttonLandPlane);
            this.Controls.Add(this.pictureBoxAeroplane);
            this.Name = "FormAeroplane";
            this.Text = "FormAeroplane";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAeroplane)).EndInit();
            this.groupBoxPlane.ResumeLayout(false);
            this.groupBoxPlane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAeroplane;
        private System.Windows.Forms.Button buttonLandPlane;
        private System.Windows.Forms.Button buttonLandWarplane;
        private System.Windows.Forms.GroupBox groupBoxPlane;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
    }
}