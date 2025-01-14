
namespace OpenTK3_StandardTemplate_WinForms
{
    partial class MainForm
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
            this.showAxes = new System.Windows.Forms.CheckBox();
            this.changeBackground = new System.Windows.Forms.Button();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.lblOz = new System.Windows.Forms.Label();
            this.resetScene = new System.Windows.Forms.Button();
            this.enableRotation = new System.Windows.Forms.CheckBox();
            this.enableObjectRotation = new System.Windows.Forms.CheckBox();
            this.toggleTransparency = new System.Windows.Forms.CheckBox();
            this.rbTexture1 = new System.Windows.Forms.RadioButton();
            this.rbTexture2 = new System.Windows.Forms.RadioButton();
            this.btnLights = new System.Windows.Forms.Button();
            this.btnLight0 = new System.Windows.Forms.Button();
            this.numericLight0Difuse_Green = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Difuse_Blue = new System.Windows.Forms.NumericUpDown();
            this.numericLight0Difuse_Red = new System.Windows.Forms.NumericUpDown();
            this.lbred = new System.Windows.Forms.Label();
            this.lbgreen = new System.Windows.Forms.Label();
            this.lbblue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).BeginInit();
            this.SuspendLayout();
            // 
            // showAxes
            // 
            this.showAxes.AutoSize = true;
            this.showAxes.Checked = true;
            this.showAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAxes.Location = new System.Drawing.Point(1256, 20);
            this.showAxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAxes.Name = "showAxes";
            this.showAxes.Size = new System.Drawing.Size(114, 24);
            this.showAxes.TabIndex = 0;
            this.showAxes.Text = "Show Axes";
            this.showAxes.UseVisualStyleBackColor = true;
            this.showAxes.CheckedChanged += new System.EventHandler(this.showAxes_CheckedChanged);
            // 
            // changeBackground
            // 
            this.changeBackground.Location = new System.Drawing.Point(1256, 426);
            this.changeBackground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(300, 49);
            this.changeBackground.TabIndex = 1;
            this.changeBackground.Text = "Change background color";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // lblOx
            // 
            this.lblOx.BackColor = System.Drawing.Color.Red;
            this.lblOx.Location = new System.Drawing.Point(1288, 54);
            this.lblOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(60, 31);
            this.lblOx.TabIndex = 2;
            this.lblOx.Text = "Ox";
            this.lblOx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOy
            // 
            this.lblOy.BackColor = System.Drawing.Color.Green;
            this.lblOy.Location = new System.Drawing.Point(1358, 54);
            this.lblOy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(60, 31);
            this.lblOy.TabIndex = 3;
            this.lblOy.Text = "Oy";
            this.lblOy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOz
            // 
            this.lblOz.BackColor = System.Drawing.Color.Blue;
            this.lblOz.Location = new System.Drawing.Point(1426, 54);
            this.lblOz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOz.Name = "lblOz";
            this.lblOz.Size = new System.Drawing.Size(60, 31);
            this.lblOz.TabIndex = 4;
            this.lblOz.Text = "Oz";
            this.lblOz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetScene
            // 
            this.resetScene.Location = new System.Drawing.Point(1256, 485);
            this.resetScene.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetScene.Name = "resetScene";
            this.resetScene.Size = new System.Drawing.Size(300, 49);
            this.resetScene.TabIndex = 5;
            this.resetScene.Text = "Reset scene";
            this.resetScene.UseVisualStyleBackColor = true;
            this.resetScene.Click += new System.EventHandler(this.resetScene_Click);
            // 
            // enableRotation
            // 
            this.enableRotation.AutoSize = true;
            this.enableRotation.Location = new System.Drawing.Point(1256, 92);
            this.enableRotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enableRotation.Name = "enableRotation";
            this.enableRotation.Size = new System.Drawing.Size(195, 24);
            this.enableRotation.TabIndex = 6;
            this.enableRotation.Text = "Enable mouse rotation";
            this.enableRotation.UseVisualStyleBackColor = true;
            // 
            // enableObjectRotation
            // 
            this.enableObjectRotation.AutoSize = true;
            this.enableObjectRotation.Location = new System.Drawing.Point(1256, 131);
            this.enableObjectRotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enableObjectRotation.Name = "enableObjectRotation";
            this.enableObjectRotation.Size = new System.Drawing.Size(190, 24);
            this.enableObjectRotation.TabIndex = 7;
            this.enableObjectRotation.Text = "Enable object rotation";
            this.enableObjectRotation.UseVisualStyleBackColor = true;
            // 
            // toggleTransparency
            // 
            this.toggleTransparency.AutoSize = true;
            this.toggleTransparency.Location = new System.Drawing.Point(1256, 169);
            this.toggleTransparency.Name = "toggleTransparency";
            this.toggleTransparency.Size = new System.Drawing.Size(131, 24);
            this.toggleTransparency.TabIndex = 8;
            this.toggleTransparency.Text = "Transparency";
            this.toggleTransparency.UseVisualStyleBackColor = true;
            this.toggleTransparency.CheckedChanged += new System.EventHandler(this.toggleTransparency_Click);
            // 
            // rbTexture1
            // 
            this.rbTexture1.AutoSize = true;
            this.rbTexture1.Location = new System.Drawing.Point(1257, 207);
            this.rbTexture1.Name = "rbTexture1";
            this.rbTexture1.Size = new System.Drawing.Size(92, 24);
            this.rbTexture1.TabIndex = 14;
            this.rbTexture1.TabStop = true;
            this.rbTexture1.Text = "texture1";
            this.rbTexture1.UseVisualStyleBackColor = true;
            this.rbTexture1.CheckedChanged += new System.EventHandler(this.rbTexture_Click);
            // 
            // rbTexture2
            // 
            this.rbTexture2.AutoSize = true;
            this.rbTexture2.Location = new System.Drawing.Point(1257, 237);
            this.rbTexture2.Name = "rbTexture2";
            this.rbTexture2.Size = new System.Drawing.Size(92, 24);
            this.rbTexture2.TabIndex = 15;
            this.rbTexture2.TabStop = true;
            this.rbTexture2.Text = "texture2";
            this.rbTexture2.UseVisualStyleBackColor = true;
            this.rbTexture2.CheckedChanged += new System.EventHandler(this.rbTexture2_Click);
            // 
            // btnLights
            // 
            this.btnLights.Location = new System.Drawing.Point(1256, 277);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(114, 34);
            this.btnLights.TabIndex = 16;
            this.btnLights.Text = "Light";
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.btnLights_Click);
            // 
            // btnLight0
            // 
            this.btnLight0.Location = new System.Drawing.Point(1371, 277);
            this.btnLight0.Name = "btnLight0";
            this.btnLight0.Size = new System.Drawing.Size(125, 34);
            this.btnLight0.TabIndex = 17;
            this.btnLight0.Text = "Source 0";
            this.btnLight0.UseVisualStyleBackColor = true;
            this.btnLight0.Click += new System.EventHandler(this.btnLight0_Click);
            // 
            // numericLight0Difuse_Green
            // 
            this.numericLight0Difuse_Green.Location = new System.Drawing.Point(1376, 351);
            this.numericLight0Difuse_Green.Name = "numericLight0Difuse_Green";
            this.numericLight0Difuse_Green.Size = new System.Drawing.Size(120, 26);
            this.numericLight0Difuse_Green.TabIndex = 18;
            this.numericLight0Difuse_Green.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Green_ValueChanged);
            // 
            // numericLight0Difuse_Blue
            // 
            this.numericLight0Difuse_Blue.Location = new System.Drawing.Point(1376, 383);
            this.numericLight0Difuse_Blue.Name = "numericLight0Difuse_Blue";
            this.numericLight0Difuse_Blue.Size = new System.Drawing.Size(120, 26);
            this.numericLight0Difuse_Blue.TabIndex = 19;
            this.numericLight0Difuse_Blue.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Blue_ValueChanged);
            // 
            // numericLight0Difuse_Red
            // 
            this.numericLight0Difuse_Red.Location = new System.Drawing.Point(1376, 319);
            this.numericLight0Difuse_Red.Name = "numericLight0Difuse_Red";
            this.numericLight0Difuse_Red.Size = new System.Drawing.Size(120, 26);
            this.numericLight0Difuse_Red.TabIndex = 20;
            this.numericLight0Difuse_Red.ValueChanged += new System.EventHandler(this.numericLight0Difuse_Red_ValueChanged);
            // 
            // lbred
            // 
            this.lbred.AutoSize = true;
            this.lbred.Location = new System.Drawing.Point(1263, 321);
            this.lbred.Name = "lbred";
            this.lbred.Size = new System.Drawing.Size(39, 20);
            this.lbred.TabIndex = 21;
            this.lbred.Text = "Red";
            // 
            // lbgreen
            // 
            this.lbgreen.AutoSize = true;
            this.lbgreen.Location = new System.Drawing.Point(1263, 353);
            this.lbgreen.Name = "lbgreen";
            this.lbgreen.Size = new System.Drawing.Size(54, 20);
            this.lbgreen.TabIndex = 22;
            this.lbgreen.Text = "Green";
            // 
            // lbblue
            // 
            this.lbblue.AutoSize = true;
            this.lbblue.Location = new System.Drawing.Point(1263, 385);
            this.lbblue.Name = "lbblue";
            this.lbblue.Size = new System.Drawing.Size(41, 20);
            this.lbblue.TabIndex = 23;
            this.lbblue.Text = "Blue";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 960);
            this.Controls.Add(this.lbblue);
            this.Controls.Add(this.lbgreen);
            this.Controls.Add(this.lbred);
            this.Controls.Add(this.numericLight0Difuse_Red);
            this.Controls.Add(this.numericLight0Difuse_Blue);
            this.Controls.Add(this.numericLight0Difuse_Green);
            this.Controls.Add(this.btnLight0);
            this.Controls.Add(this.btnLights);
            this.Controls.Add(this.rbTexture2);
            this.Controls.Add(this.rbTexture1);
            this.Controls.Add(this.toggleTransparency);
            this.Controls.Add(this.enableObjectRotation);
            this.Controls.Add(this.enableRotation);
            this.Controls.Add(this.resetScene);
            this.Controls.Add(this.lblOz);
            this.Controls.Add(this.lblOy);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.showAxes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "OpenTK 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight0Difuse_Red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showAxes;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.Label lblOz;
        private System.Windows.Forms.Button resetScene;
        private System.Windows.Forms.CheckBox enableRotation;
        private System.Windows.Forms.CheckBox enableObjectRotation;
        private System.Windows.Forms.CheckBox toggleTransparency;
        private System.Windows.Forms.RadioButton rbTexture1;
        private System.Windows.Forms.RadioButton rbTexture2;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.Button btnLight0;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Green;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Blue;
        private System.Windows.Forms.NumericUpDown numericLight0Difuse_Red;
        private System.Windows.Forms.Label lbred;
        private System.Windows.Forms.Label lbgreen;
        private System.Windows.Forms.Label lbblue;
    }
}

