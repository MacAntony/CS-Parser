namespace Parser
{
    partial class WeatherForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.temperatureButton = new System.Windows.Forms.Button();
            this.outputF = new System.Windows.Forms.TextBox();
            this.labelF = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.outputC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // temperatureButton
            // 
            this.temperatureButton.Location = new System.Drawing.Point(28, 139);
            this.temperatureButton.Name = "temperatureButton";
            this.temperatureButton.Size = new System.Drawing.Size(160, 27);
            this.temperatureButton.TabIndex = 0;
            this.temperatureButton.Text = "Узнать температуру";
            this.temperatureButton.UseVisualStyleBackColor = true;
            this.temperatureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputF
            // 
            this.outputF.Location = new System.Drawing.Point(47, 84);
            this.outputF.Name = "outputF";
            this.outputF.Size = new System.Drawing.Size(118, 20);
            this.outputF.TabIndex = 2;
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(171, 84);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(17, 13);
            this.labelF.TabIndex = 3;
            this.labelF.Text = "F°";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(174, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Название города (на англиском)";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(47, 29);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(118, 20);
            this.input.TabIndex = 7;
            // 
            // outputC
            // 
            this.outputC.Location = new System.Drawing.Point(47, 110);
            this.outputC.Name = "outputC";
            this.outputC.Size = new System.Drawing.Size(118, 20);
            this.outputC.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "C°";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Определить город";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputC);
            this.Controls.Add(this.label);
            this.Controls.Add(this.input);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.outputF);
            this.Controls.Add(this.temperatureButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherForm";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.Resize += new System.EventHandler(this.WeatherForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button temperatureButton;
        private System.Windows.Forms.TextBox outputF;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox outputC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
    }
}

