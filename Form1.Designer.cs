namespace UC_Helper
{
    partial class MainScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ActorSwitch = new System.Windows.Forms.RadioButton();
            this.UseCaseSwitch = new System.Windows.Forms.RadioButton();
            this.LineSwitch = new System.Windows.Forms.RadioButton();
            this.createSwitch = new System.Windows.Forms.RadioButton();
            this.selectSwitch = new System.Windows.Forms.RadioButton();
            this.createAllBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LineSwitch);
            this.groupBox1.Controls.Add(this.UseCaseSwitch);
            this.groupBox1.Controls.Add(this.ActorSwitch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectSwitch);
            this.groupBox2.Controls.Add(this.createSwitch);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modes";
            // 
            // ActorSwitch
            // 
            this.ActorSwitch.AutoSize = true;
            this.ActorSwitch.Location = new System.Drawing.Point(7, 20);
            this.ActorSwitch.Name = "ActorSwitch";
            this.ActorSwitch.Size = new System.Drawing.Size(50, 17);
            this.ActorSwitch.TabIndex = 0;
            this.ActorSwitch.TabStop = true;
            this.ActorSwitch.Text = "Actor";
            this.ActorSwitch.UseVisualStyleBackColor = true;
            // 
            // UseCaseSwitch
            // 
            this.UseCaseSwitch.AutoSize = true;
            this.UseCaseSwitch.Location = new System.Drawing.Point(7, 44);
            this.UseCaseSwitch.Name = "UseCaseSwitch";
            this.UseCaseSwitch.Size = new System.Drawing.Size(71, 17);
            this.UseCaseSwitch.TabIndex = 1;
            this.UseCaseSwitch.TabStop = true;
            this.UseCaseSwitch.Text = "Use Case";
            this.UseCaseSwitch.UseVisualStyleBackColor = true;
            // 
            // LineSwitch
            // 
            this.LineSwitch.AutoSize = true;
            this.LineSwitch.Location = new System.Drawing.Point(7, 68);
            this.LineSwitch.Name = "LineSwitch";
            this.LineSwitch.Size = new System.Drawing.Size(45, 17);
            this.LineSwitch.TabIndex = 2;
            this.LineSwitch.TabStop = true;
            this.LineSwitch.Text = "Line";
            this.LineSwitch.UseVisualStyleBackColor = true;
            // 
            // createSwitch
            // 
            this.createSwitch.AutoSize = true;
            this.createSwitch.Location = new System.Drawing.Point(7, 20);
            this.createSwitch.Name = "createSwitch";
            this.createSwitch.Size = new System.Drawing.Size(56, 17);
            this.createSwitch.TabIndex = 0;
            this.createSwitch.TabStop = true;
            this.createSwitch.Text = "Create";
            this.createSwitch.UseVisualStyleBackColor = true;
            // 
            // selectSwitch
            // 
            this.selectSwitch.AutoSize = true;
            this.selectSwitch.Location = new System.Drawing.Point(7, 44);
            this.selectSwitch.Name = "selectSwitch";
            this.selectSwitch.Size = new System.Drawing.Size(55, 17);
            this.selectSwitch.TabIndex = 1;
            this.selectSwitch.TabStop = true;
            this.selectSwitch.Text = "Select";
            this.selectSwitch.UseVisualStyleBackColor = true;
            // 
            // createAllBtn
            // 
            this.createAllBtn.Location = new System.Drawing.Point(746, 32);
            this.createAllBtn.Name = "createAllBtn";
            this.createAllBtn.Size = new System.Drawing.Size(130, 28);
            this.createAllBtn.TabIndex = 2;
            this.createAllBtn.Text = "Create All";
            this.createAllBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(746, 73);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(130, 30);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // PaintPanel
            // 
            this.PaintPanel.BackColor = System.Drawing.Color.White;
            this.PaintPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PaintPanel.Location = new System.Drawing.Point(12, 130);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(875, 406);
            this.PaintPanel.TabIndex = 4;
            this.PaintPanel.Click += new System.EventHandler(this.PaintPanel_Click);
            this.PaintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel_Paint);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 548);
            this.Controls.Add(this.PaintPanel);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.createAllBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UC Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LineSwitch;
        private System.Windows.Forms.RadioButton UseCaseSwitch;
        private System.Windows.Forms.RadioButton ActorSwitch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton selectSwitch;
        private System.Windows.Forms.RadioButton createSwitch;
        private System.Windows.Forms.Button createAllBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Panel PaintPanel;
    }
}

