
namespace mp3extract
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.convert_button = new System.Windows.Forms.Button();
            this.checkBox_samepath = new System.Windows.Forms.CheckBox();
            this.file_location = new System.Windows.Forms.Button();
            this.file_destination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filename_field = new System.Windows.Forms.TextBox();
            this.fileLocation_textBox = new System.Windows.Forms.RichTextBox();
            this.fileDestination_textBox = new System.Windows.Forms.RichTextBox();
            this.filename_label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(498, 325);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(116, 41);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 415);
            this.panel1.TabIndex = 3;
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(184, 325);
            this.convert_button.Margin = new System.Windows.Forms.Padding(2);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(116, 41);
            this.convert_button.TabIndex = 4;
            this.convert_button.Text = "CONVERT";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // checkBox_samepath
            // 
            this.checkBox_samepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.checkBox_samepath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_samepath.Location = new System.Drawing.Point(464, 94);
            this.checkBox_samepath.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_samepath.Name = "checkBox_samepath";
            this.checkBox_samepath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_samepath.Size = new System.Drawing.Size(150, 30);
            this.checkBox_samepath.TabIndex = 5;
            this.checkBox_samepath.Text = "same path destination";
            this.checkBox_samepath.UseVisualStyleBackColor = true;
            this.checkBox_samepath.CheckedChanged += new System.EventHandler(this.checkBox_samepath_CheckedChanged);
            // 
            // file_location
            // 
            this.file_location.AccessibleDescription = "Select MP4 file";
            this.file_location.AccessibleName = "Select MP4 file";
            this.file_location.Location = new System.Drawing.Point(619, 63);
            this.file_location.Margin = new System.Windows.Forms.Padding(2);
            this.file_location.Name = "file_location";
            this.file_location.Size = new System.Drawing.Size(26, 24);
            this.file_location.TabIndex = 8;
            this.file_location.Text = "...";
            this.file_location.UseVisualStyleBackColor = true;
            this.file_location.Click += new System.EventHandler(this.file_location_Click);
            // 
            // file_destination
            // 
            this.file_destination.Location = new System.Drawing.Point(619, 146);
            this.file_destination.Margin = new System.Windows.Forms.Padding(2);
            this.file_destination.Name = "file_destination";
            this.file_destination.Size = new System.Drawing.Size(26, 24);
            this.file_destination.TabIndex = 9;
            this.file_destination.Text = "...";
            this.file_destination.UseVisualStyleBackColor = true;
            this.file_destination.Click += new System.EventHandler(this.file_destination_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(182, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "File location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(182, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "File destination";
            // 
            // filename_field
            // 
            this.filename_field.Location = new System.Drawing.Point(184, 223);
            this.filename_field.Margin = new System.Windows.Forms.Padding(2);
            this.filename_field.Name = "filename_field";
            this.filename_field.Size = new System.Drawing.Size(145, 20);
            this.filename_field.TabIndex = 12;
            // 
            // fileLocation_textBox
            // 
            this.fileLocation_textBox.AutoWordSelection = true;
            this.fileLocation_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileLocation_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLocation_textBox.Location = new System.Drawing.Point(184, 57);
            this.fileLocation_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileLocation_textBox.Name = "fileLocation_textBox";
            this.fileLocation_textBox.ReadOnly = true;
            this.fileLocation_textBox.Size = new System.Drawing.Size(431, 37);
            this.fileLocation_textBox.TabIndex = 13;
            this.fileLocation_textBox.Text = "";
            // 
            // fileDestination_textBox
            // 
            this.fileDestination_textBox.AutoWordSelection = true;
            this.fileDestination_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileDestination_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileDestination_textBox.Location = new System.Drawing.Point(184, 140);
            this.fileDestination_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileDestination_textBox.Name = "fileDestination_textBox";
            this.fileDestination_textBox.ReadOnly = true;
            this.fileDestination_textBox.Size = new System.Drawing.Size(431, 37);
            this.fileDestination_textBox.TabIndex = 14;
            this.fileDestination_textBox.Text = "";
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.filename_label.Location = new System.Drawing.Point(182, 204);
            this.filename_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(65, 17);
            this.filename_label.TabIndex = 15;
            this.filename_label.Text = "Filename";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(184, 260);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(431, 19);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 415);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.filename_label);
            this.Controls.Add(this.fileDestination_textBox);
            this.Controls.Add(this.fileLocation_textBox);
            this.Controls.Add(this.filename_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.file_destination);
            this.Controls.Add(this.file_location);
            this.Controls.Add(this.checkBox_samepath);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.CheckBox checkBox_samepath;
        private System.Windows.Forms.Button file_location;
        private System.Windows.Forms.Button file_destination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filename_field;
        private System.Windows.Forms.RichTextBox fileLocation_textBox;
        private System.Windows.Forms.RichTextBox fileDestination_textBox;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

