namespace WeatherForecast
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
            this.uxState = new System.Windows.Forms.Label();
            this.uxCountry = new System.Windows.Forms.Label();
            this.uxCurrentPic = new System.Windows.Forms.PictureBox();
            this.uxTemp = new System.Windows.Forms.Label();
            this.uxForecastPic = new System.Windows.Forms.PictureBox();
            this.uxForecast = new System.Windows.Forms.Label();
            this.uxDays = new System.Windows.Forms.Label();
            this.uxConditions = new System.Windows.Forms.Label();
            this.uxDescription = new System.Windows.Forms.Label();
            this.uxWindSpeed = new System.Windows.Forms.Label();
            this.uxForecastTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxCurrentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxForecastPic)).BeginInit();
            this.SuspendLayout();
            // 
            // uxState
            // 
            this.uxState.AutoSize = true;
            this.uxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxState.ForeColor = System.Drawing.Color.Red;
            this.uxState.Location = new System.Drawing.Point(67, 44);
            this.uxState.Name = "uxState";
            this.uxState.Size = new System.Drawing.Size(160, 42);
            this.uxState.TabIndex = 0;
            this.uxState.Text = "Location";
            this.uxState.Click += new System.EventHandler(this.uxLocation_Click);
            // 
            // uxCountry
            // 
            this.uxCountry.AutoSize = true;
            this.uxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCountry.ForeColor = System.Drawing.Color.Blue;
            this.uxCountry.Location = new System.Drawing.Point(69, 86);
            this.uxCountry.Name = "uxCountry";
            this.uxCountry.Size = new System.Drawing.Size(47, 25);
            this.uxCountry.TabIndex = 1;
            this.uxCountry.Text = "Loc";
            // 
            // uxCurrentPic
            // 
            this.uxCurrentPic.Location = new System.Drawing.Point(74, 138);
            this.uxCurrentPic.Name = "uxCurrentPic";
            this.uxCurrentPic.Size = new System.Drawing.Size(153, 127);
            this.uxCurrentPic.TabIndex = 2;
            this.uxCurrentPic.TabStop = false;
            // 
            // uxTemp
            // 
            this.uxTemp.AutoSize = true;
            this.uxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTemp.Location = new System.Drawing.Point(233, 165);
            this.uxTemp.Name = "uxTemp";
            this.uxTemp.Size = new System.Drawing.Size(196, 73);
            this.uxTemp.TabIndex = 3;
            this.uxTemp.Text = "Temp";
            // 
            // uxForecastPic
            // 
            this.uxForecastPic.Location = new System.Drawing.Point(503, 166);
            this.uxForecastPic.Name = "uxForecastPic";
            this.uxForecastPic.Size = new System.Drawing.Size(102, 87);
            this.uxForecastPic.TabIndex = 4;
            this.uxForecastPic.TabStop = false;
            // 
            // uxForecast
            // 
            this.uxForecast.AutoSize = true;
            this.uxForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxForecast.ForeColor = System.Drawing.Color.Red;
            this.uxForecast.Location = new System.Drawing.Point(496, 44);
            this.uxForecast.Name = "uxForecast";
            this.uxForecast.Size = new System.Drawing.Size(164, 42);
            this.uxForecast.TabIndex = 5;
            this.uxForecast.Text = "Forecast";
            // 
            // uxDays
            // 
            this.uxDays.AutoSize = true;
            this.uxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDays.ForeColor = System.Drawing.Color.Red;
            this.uxDays.Location = new System.Drawing.Point(498, 86);
            this.uxDays.Name = "uxDays";
            this.uxDays.Size = new System.Drawing.Size(61, 25);
            this.uxDays.TabIndex = 6;
            this.uxDays.Text = "Days";
            // 
            // uxConditions
            // 
            this.uxConditions.AutoSize = true;
            this.uxConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxConditions.ForeColor = System.Drawing.Color.Red;
            this.uxConditions.Location = new System.Drawing.Point(498, 111);
            this.uxConditions.Name = "uxConditions";
            this.uxConditions.Size = new System.Drawing.Size(114, 25);
            this.uxConditions.TabIndex = 7;
            this.uxConditions.Text = "Conditions";
            // 
            // uxDescription
            // 
            this.uxDescription.AutoSize = true;
            this.uxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDescription.ForeColor = System.Drawing.Color.Red;
            this.uxDescription.Location = new System.Drawing.Point(498, 138);
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.Size = new System.Drawing.Size(120, 25);
            this.uxDescription.TabIndex = 8;
            this.uxDescription.Text = "Description";
            // 
            // uxWindSpeed
            // 
            this.uxWindSpeed.AutoSize = true;
            this.uxWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWindSpeed.ForeColor = System.Drawing.Color.Red;
            this.uxWindSpeed.Location = new System.Drawing.Point(639, 86);
            this.uxWindSpeed.Name = "uxWindSpeed";
            this.uxWindSpeed.Size = new System.Drawing.Size(61, 25);
            this.uxWindSpeed.TabIndex = 9;
            this.uxWindSpeed.Text = "Wind";
            // 
            // uxForecastTemp
            // 
            this.uxForecastTemp.AutoSize = true;
            this.uxForecastTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxForecastTemp.ForeColor = System.Drawing.Color.Red;
            this.uxForecastTemp.Location = new System.Drawing.Point(639, 111);
            this.uxForecastTemp.Name = "uxForecastTemp";
            this.uxForecastTemp.Size = new System.Drawing.Size(150, 25);
            this.uxForecastTemp.TabIndex = 10;
            this.uxForecastTemp.Text = "ForecastTemp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxForecastTemp);
            this.Controls.Add(this.uxWindSpeed);
            this.Controls.Add(this.uxDescription);
            this.Controls.Add(this.uxConditions);
            this.Controls.Add(this.uxDays);
            this.Controls.Add(this.uxForecast);
            this.Controls.Add(this.uxForecastPic);
            this.Controls.Add(this.uxTemp);
            this.Controls.Add(this.uxCurrentPic);
            this.Controls.Add(this.uxCountry);
            this.Controls.Add(this.uxState);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uxCurrentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxForecastPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxState;
        private System.Windows.Forms.Label uxCountry;
        private System.Windows.Forms.PictureBox uxCurrentPic;
        private System.Windows.Forms.Label uxTemp;
        private System.Windows.Forms.PictureBox uxForecastPic;
        private System.Windows.Forms.Label uxForecast;
        private System.Windows.Forms.Label uxDays;
        private System.Windows.Forms.Label uxConditions;
        private System.Windows.Forms.Label uxDescription;
        private System.Windows.Forms.Label uxWindSpeed;
        private System.Windows.Forms.Label uxForecastTemp;
    }
}

