﻿namespace Disunity.App
{
    partial class RenderForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rotateModelRadioButton = new System.Windows.Forms.RadioButton();
            this.rotateLightRadioButton = new System.Windows.Forms.RadioButton();
            this.viewportScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lastBenchmarkRunLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastBenchmarkTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startBenchmarkButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textureRadioButton = new System.Windows.Forms.RadioButton();
            this.solidColorRadioButton = new System.Windows.Forms.RadioButton();
            this.perspectiveProjectionCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.normalMappingRadioButton = new System.Windows.Forms.RadioButton();
            this.phongRadioButton = new System.Windows.Forms.RadioButton();
            this.gouraudRadioButton = new System.Windows.Forms.RadioButton();
            this.simpleRadioButton = new System.Windows.Forms.RadioButton();
            this.flatRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bordersAndFillRadioButton = new System.Windows.Forms.RadioButton();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.bordersRadioButton = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewportScaleNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.groupBox5);
            this.mainPanel.Controls.Add(this.viewportScaleNumericUpDown);
            this.mainPanel.Controls.Add(this.groupBox4);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.groupBox3);
            this.mainPanel.Controls.Add(this.perspectiveProjectionCheckBox);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(766, 776);
            this.mainPanel.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rotateModelRadioButton);
            this.groupBox5.Controls.Add(this.rotateLightRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(3, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 69);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mouse Mode";
            // 
            // rotateModelRadioButton
            // 
            this.rotateModelRadioButton.AutoSize = true;
            this.rotateModelRadioButton.Location = new System.Drawing.Point(7, 43);
            this.rotateModelRadioButton.Name = "rotateModelRadioButton";
            this.rotateModelRadioButton.Size = new System.Drawing.Size(89, 17);
            this.rotateModelRadioButton.TabIndex = 1;
            this.rotateModelRadioButton.Text = "Rotate Model";
            this.rotateModelRadioButton.UseVisualStyleBackColor = true;
            this.rotateModelRadioButton.CheckedChanged += new System.EventHandler(this.rotateModelRadioButton_CheckedChanged);
            // 
            // rotateLightRadioButton
            // 
            this.rotateLightRadioButton.AutoSize = true;
            this.rotateLightRadioButton.Checked = true;
            this.rotateLightRadioButton.Location = new System.Drawing.Point(7, 20);
            this.rotateLightRadioButton.Name = "rotateLightRadioButton";
            this.rotateLightRadioButton.Size = new System.Drawing.Size(83, 17);
            this.rotateLightRadioButton.TabIndex = 0;
            this.rotateLightRadioButton.TabStop = true;
            this.rotateLightRadioButton.Text = "Rotate Light";
            this.rotateLightRadioButton.UseVisualStyleBackColor = true;
            this.rotateLightRadioButton.CheckedChanged += new System.EventHandler(this.rotateLightRadioButton_CheckedChanged);
            // 
            // viewportScaleNumericUpDown
            // 
            this.viewportScaleNumericUpDown.DecimalPlaces = 1;
            this.viewportScaleNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.viewportScaleNumericUpDown.Location = new System.Drawing.Point(3, 3);
            this.viewportScaleNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.viewportScaleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.viewportScaleNumericUpDown.Name = "viewportScaleNumericUpDown";
            this.viewportScaleNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.viewportScaleNumericUpDown.TabIndex = 3;
            this.viewportScaleNumericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.viewportScaleNumericUpDown.ValueChanged += new System.EventHandler(this.CameraZPositionHandler);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lastBenchmarkRunLabel);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lastBenchmarkTimeLabel);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.startBenchmarkButton);
            this.groupBox4.Location = new System.Drawing.Point(3, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 92);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Benchmark";
            // 
            // lastBenchmarkRunLabel
            // 
            this.lastBenchmarkRunLabel.AutoSize = true;
            this.lastBenchmarkRunLabel.Location = new System.Drawing.Point(59, 43);
            this.lastBenchmarkRunLabel.Name = "lastBenchmarkRunLabel";
            this.lastBenchmarkRunLabel.Size = new System.Drawing.Size(36, 13);
            this.lastBenchmarkRunLabel.TabIndex = 4;
            this.lastBenchmarkRunLabel.Text = "Never";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Run on:";
            // 
            // lastBenchmarkTimeLabel
            // 
            this.lastBenchmarkTimeLabel.AutoSize = true;
            this.lastBenchmarkTimeLabel.Location = new System.Drawing.Point(59, 20);
            this.lastBenchmarkTimeLabel.Name = "lastBenchmarkTimeLabel";
            this.lastBenchmarkTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.lastBenchmarkTimeLabel.TabIndex = 2;
            this.lastBenchmarkTimeLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Run:";
            // 
            // startBenchmarkButton
            // 
            this.startBenchmarkButton.Location = new System.Drawing.Point(135, 63);
            this.startBenchmarkButton.Name = "startBenchmarkButton";
            this.startBenchmarkButton.Size = new System.Drawing.Size(75, 23);
            this.startBenchmarkButton.TabIndex = 0;
            this.startBenchmarkButton.Text = "Start";
            this.startBenchmarkButton.UseVisualStyleBackColor = true;
            this.startBenchmarkButton.Click += new System.EventHandler(this.startBenchmarkButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(226, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textureRadioButton);
            this.groupBox3.Controls.Add(this.solidColorRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(0, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 71);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fill Mode";
            // 
            // textureRadioButton
            // 
            this.textureRadioButton.AutoSize = true;
            this.textureRadioButton.Checked = true;
            this.textureRadioButton.Location = new System.Drawing.Point(9, 43);
            this.textureRadioButton.Name = "textureRadioButton";
            this.textureRadioButton.Size = new System.Drawing.Size(61, 17);
            this.textureRadioButton.TabIndex = 1;
            this.textureRadioButton.TabStop = true;
            this.textureRadioButton.Text = "Texture";
            this.textureRadioButton.UseVisualStyleBackColor = true;
            this.textureRadioButton.CheckedChanged += new System.EventHandler(this.textureRadioButton_CheckedChanged);
            // 
            // solidColorRadioButton
            // 
            this.solidColorRadioButton.AutoSize = true;
            this.solidColorRadioButton.Location = new System.Drawing.Point(9, 20);
            this.solidColorRadioButton.Name = "solidColorRadioButton";
            this.solidColorRadioButton.Size = new System.Drawing.Size(75, 17);
            this.solidColorRadioButton.TabIndex = 0;
            this.solidColorRadioButton.Text = "Solid Color";
            this.solidColorRadioButton.UseVisualStyleBackColor = true;
            this.solidColorRadioButton.CheckedChanged += new System.EventHandler(this.solidColorRadioButton_CheckedChanged);
            // 
            // perspectiveProjectionCheckBox
            // 
            this.perspectiveProjectionCheckBox.AutoSize = true;
            this.perspectiveProjectionCheckBox.Checked = true;
            this.perspectiveProjectionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.perspectiveProjectionCheckBox.Location = new System.Drawing.Point(3, 30);
            this.perspectiveProjectionCheckBox.Name = "perspectiveProjectionCheckBox";
            this.perspectiveProjectionCheckBox.Size = new System.Drawing.Size(132, 17);
            this.perspectiveProjectionCheckBox.TabIndex = 4;
            this.perspectiveProjectionCheckBox.Text = "Perspective Projection";
            this.perspectiveProjectionCheckBox.UseVisualStyleBackColor = true;
            this.perspectiveProjectionCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.normalMappingRadioButton);
            this.groupBox2.Controls.Add(this.phongRadioButton);
            this.groupBox2.Controls.Add(this.gouraudRadioButton);
            this.groupBox2.Controls.Add(this.simpleRadioButton);
            this.groupBox2.Controls.Add(this.flatRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 137);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light Mode";
            // 
            // normalMappingRadioButton
            // 
            this.normalMappingRadioButton.AutoSize = true;
            this.normalMappingRadioButton.Location = new System.Drawing.Point(6, 112);
            this.normalMappingRadioButton.Name = "normalMappingRadioButton";
            this.normalMappingRadioButton.Size = new System.Drawing.Size(102, 17);
            this.normalMappingRadioButton.TabIndex = 4;
            this.normalMappingRadioButton.Text = "Normal Mapping";
            this.normalMappingRadioButton.UseVisualStyleBackColor = true;
            this.normalMappingRadioButton.CheckedChanged += new System.EventHandler(this.normalMappingRadioButton_CheckedChanged);
            // 
            // phongRadioButton
            // 
            this.phongRadioButton.AutoSize = true;
            this.phongRadioButton.Location = new System.Drawing.Point(6, 89);
            this.phongRadioButton.Name = "phongRadioButton";
            this.phongRadioButton.Size = new System.Drawing.Size(56, 17);
            this.phongRadioButton.TabIndex = 3;
            this.phongRadioButton.Text = "Phong";
            this.phongRadioButton.UseVisualStyleBackColor = true;
            this.phongRadioButton.CheckedChanged += new System.EventHandler(this.phongRadioButton_CheckedChanged);
            // 
            // gouraudRadioButton
            // 
            this.gouraudRadioButton.AutoSize = true;
            this.gouraudRadioButton.Checked = true;
            this.gouraudRadioButton.Location = new System.Drawing.Point(6, 66);
            this.gouraudRadioButton.Name = "gouraudRadioButton";
            this.gouraudRadioButton.Size = new System.Drawing.Size(66, 17);
            this.gouraudRadioButton.TabIndex = 2;
            this.gouraudRadioButton.TabStop = true;
            this.gouraudRadioButton.Text = "Gouraud";
            this.gouraudRadioButton.UseVisualStyleBackColor = true;
            this.gouraudRadioButton.CheckedChanged += new System.EventHandler(this.gouraudRadioButton_CheckedChanged);
            // 
            // simpleRadioButton
            // 
            this.simpleRadioButton.AutoSize = true;
            this.simpleRadioButton.Location = new System.Drawing.Point(6, 43);
            this.simpleRadioButton.Name = "simpleRadioButton";
            this.simpleRadioButton.Size = new System.Drawing.Size(56, 17);
            this.simpleRadioButton.TabIndex = 1;
            this.simpleRadioButton.Text = "Simple";
            this.simpleRadioButton.UseVisualStyleBackColor = true;
            this.simpleRadioButton.CheckedChanged += new System.EventHandler(this.simpleRadioButton_CheckedChanged);
            // 
            // flatRadioButton
            // 
            this.flatRadioButton.AutoSize = true;
            this.flatRadioButton.Location = new System.Drawing.Point(6, 20);
            this.flatRadioButton.Name = "flatRadioButton";
            this.flatRadioButton.Size = new System.Drawing.Size(42, 17);
            this.flatRadioButton.TabIndex = 0;
            this.flatRadioButton.Text = "Flat";
            this.flatRadioButton.UseVisualStyleBackColor = true;
            this.flatRadioButton.CheckedChanged += new System.EventHandler(this.flatRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bordersAndFillRadioButton);
            this.groupBox1.Controls.Add(this.fillRadioButton);
            this.groupBox1.Controls.Add(this.bordersRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Render Mode";
            // 
            // bordersAndFillRadioButton
            // 
            this.bordersAndFillRadioButton.AutoSize = true;
            this.bordersAndFillRadioButton.Location = new System.Drawing.Point(6, 65);
            this.bordersAndFillRadioButton.Name = "bordersAndFillRadioButton";
            this.bordersAndFillRadioButton.Size = new System.Drawing.Size(98, 17);
            this.bordersAndFillRadioButton.TabIndex = 2;
            this.bordersAndFillRadioButton.Text = "Borders And Fill";
            this.bordersAndFillRadioButton.UseVisualStyleBackColor = true;
            this.bordersAndFillRadioButton.CheckedChanged += new System.EventHandler(this.bordersAndFillRadioButton_CheckedChanged);
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.AutoSize = true;
            this.fillRadioButton.Checked = true;
            this.fillRadioButton.Location = new System.Drawing.Point(6, 42);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(37, 17);
            this.fillRadioButton.TabIndex = 1;
            this.fillRadioButton.TabStop = true;
            this.fillRadioButton.Text = "Fill";
            this.fillRadioButton.UseVisualStyleBackColor = true;
            this.fillRadioButton.CheckedChanged += new System.EventHandler(this.fillRadioButton_CheckedChanged);
            // 
            // bordersRadioButton
            // 
            this.bordersRadioButton.AutoSize = true;
            this.bordersRadioButton.Location = new System.Drawing.Point(6, 19);
            this.bordersRadioButton.Name = "bordersRadioButton";
            this.bordersRadioButton.Size = new System.Drawing.Size(61, 17);
            this.bordersRadioButton.TabIndex = 0;
            this.bordersRadioButton.Text = "Borders";
            this.bordersRadioButton.UseVisualStyleBackColor = true;
            this.bordersRadioButton.CheckedChanged += new System.EventHandler(this.bordersRadioButton_CheckedChanged);
            // 
            // RenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 800);
            this.Controls.Add(this.mainPanel);
            this.Name = "RenderForm";
            this.Text = "Disunity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewportScaleNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rotateModelRadioButton;
        private System.Windows.Forms.RadioButton rotateLightRadioButton;
        private System.Windows.Forms.NumericUpDown viewportScaleNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lastBenchmarkTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBenchmarkButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton textureRadioButton;
        private System.Windows.Forms.RadioButton solidColorRadioButton;
        private System.Windows.Forms.CheckBox perspectiveProjectionCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton normalMappingRadioButton;
        private System.Windows.Forms.RadioButton phongRadioButton;
        private System.Windows.Forms.RadioButton gouraudRadioButton;
        private System.Windows.Forms.RadioButton simpleRadioButton;
        private System.Windows.Forms.RadioButton flatRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bordersAndFillRadioButton;
        private System.Windows.Forms.RadioButton fillRadioButton;
        private System.Windows.Forms.RadioButton bordersRadioButton;
        private System.Windows.Forms.Label lastBenchmarkRunLabel;
        private System.Windows.Forms.Label label2;

    }
}

