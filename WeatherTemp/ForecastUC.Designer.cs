﻿namespace WeatherTemp
{
    partial class ForecastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labDT = new System.Windows.Forms.Label();
            this.labMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            this.labTempMin = new System.Windows.Forms.Label();
            this.labTempMax = new System.Windows.Forms.Label();
            this.labDAY = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labDT
            // 
            this.labDT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labDT.Location = new System.Drawing.Point(122, 0);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(80, 25);
            this.labDT.TabIndex = 1;
            this.labDT.Text = "Sunday";
            this.labDT.Click += new System.EventHandler(this.labDT_Click);
            // 
            // labMainWeather
            // 
            this.labMainWeather.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labMainWeather.AutoSize = true;
            this.labMainWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainWeather.Location = new System.Drawing.Point(122, 56);
            this.labMainWeather.Name = "labMainWeather";
            this.labMainWeather.Size = new System.Drawing.Size(59, 25);
            this.labMainWeather.TabIndex = 2;
            this.labMainWeather.Text = "Clear";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labWeatherDescription.Location = new System.Drawing.Point(122, 84);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(109, 25);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // labTempMin
            // 
            this.labTempMin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labTempMin.AutoSize = true;
            this.labTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempMin.Location = new System.Drawing.Point(350, 12);
            this.labTempMin.Name = "labTempMin";
            this.labTempMin.Size = new System.Drawing.Size(132, 32);
            this.labTempMin.TabIndex = 4;
            this.labTempMin.Text = "TempMin";
            // 
            // labTempMax
            // 
            this.labTempMax.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labTempMax.AutoSize = true;
            this.labTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempMax.Location = new System.Drawing.Point(350, 56);
            this.labTempMax.Name = "labTempMax";
            this.labTempMax.Size = new System.Drawing.Size(139, 32);
            this.labTempMax.TabIndex = 5;
            this.labTempMax.Text = "TempMax";
            // 
            // labDAY
            // 
            this.labDAY.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labDAY.AutoSize = true;
            this.labDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDAY.Location = new System.Drawing.Point(122, 25);
            this.labDAY.Name = "labDAY";
            this.labDAY.Size = new System.Drawing.Size(86, 25);
            this.labDAY.TabIndex = 6;
            this.labDAY.Text = "mmddyy";
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(3, 12);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(113, 97);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.labDAY);
            this.Controls.Add(this.labTempMax);
            this.Controls.Add(this.labTempMin);
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labMainWeather);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWeatherIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(525, 113);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.Label labMainWeather;
        public System.Windows.Forms.Label labWeatherDescription;
        public System.Windows.Forms.Label labTempMin;
        public System.Windows.Forms.Label labTempMax;
        public System.Windows.Forms.Label labDAY;
    }
}
