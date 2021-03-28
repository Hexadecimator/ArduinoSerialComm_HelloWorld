
namespace ArduinoSerialComm_HelloWorld
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redLEDBUTTON = new System.Windows.Forms.Button();
            this.greenLEDBUTTON = new System.Windows.Forms.Button();
            this.blueLEDBUTTON = new System.Windows.Forms.Button();
            this.blueLEDOFF = new System.Windows.Forms.Button();
            this.greenLEDOFF = new System.Windows.Forms.Button();
            this.redLEDOFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redLEDBUTTON
            // 
            this.redLEDBUTTON.Location = new System.Drawing.Point(21, 33);
            this.redLEDBUTTON.Name = "redLEDBUTTON";
            this.redLEDBUTTON.Size = new System.Drawing.Size(91, 61);
            this.redLEDBUTTON.TabIndex = 0;
            this.redLEDBUTTON.Text = "RED LED ON";
            this.redLEDBUTTON.UseVisualStyleBackColor = true;
            this.redLEDBUTTON.Click += new System.EventHandler(this.redLEDBUTTON_Click);
            // 
            // greenLEDBUTTON
            // 
            this.greenLEDBUTTON.Location = new System.Drawing.Point(116, 33);
            this.greenLEDBUTTON.Name = "greenLEDBUTTON";
            this.greenLEDBUTTON.Size = new System.Drawing.Size(100, 61);
            this.greenLEDBUTTON.TabIndex = 1;
            this.greenLEDBUTTON.Text = "GREEN LED ON";
            this.greenLEDBUTTON.UseVisualStyleBackColor = true;
            this.greenLEDBUTTON.Click += new System.EventHandler(this.greenLEDBUTTON_Click);
            // 
            // blueLEDBUTTON
            // 
            this.blueLEDBUTTON.Location = new System.Drawing.Point(221, 33);
            this.blueLEDBUTTON.Name = "blueLEDBUTTON";
            this.blueLEDBUTTON.Size = new System.Drawing.Size(92, 61);
            this.blueLEDBUTTON.TabIndex = 2;
            this.blueLEDBUTTON.Text = "BLUE LED ON";
            this.blueLEDBUTTON.UseVisualStyleBackColor = true;
            this.blueLEDBUTTON.Click += new System.EventHandler(this.blueLEDBUTTON_Click);
            // 
            // blueLEDOFF
            // 
            this.blueLEDOFF.Location = new System.Drawing.Point(221, 105);
            this.blueLEDOFF.Name = "blueLEDOFF";
            this.blueLEDOFF.Size = new System.Drawing.Size(92, 61);
            this.blueLEDOFF.TabIndex = 5;
            this.blueLEDOFF.Text = "BLUE LED OFF";
            this.blueLEDOFF.UseVisualStyleBackColor = true;
            this.blueLEDOFF.Click += new System.EventHandler(this.blueLEDOFF_Click);
            // 
            // greenLEDOFF
            // 
            this.greenLEDOFF.Location = new System.Drawing.Point(118, 105);
            this.greenLEDOFF.Name = "greenLEDOFF";
            this.greenLEDOFF.Size = new System.Drawing.Size(98, 61);
            this.greenLEDOFF.TabIndex = 4;
            this.greenLEDOFF.Text = "GREEN LED OFF";
            this.greenLEDOFF.UseVisualStyleBackColor = true;
            this.greenLEDOFF.Click += new System.EventHandler(this.greenLEDOFF_Click);
            // 
            // redLEDOFF
            // 
            this.redLEDOFF.Location = new System.Drawing.Point(23, 105);
            this.redLEDOFF.Name = "redLEDOFF";
            this.redLEDOFF.Size = new System.Drawing.Size(89, 61);
            this.redLEDOFF.TabIndex = 3;
            this.redLEDOFF.Text = "RED LED OFF";
            this.redLEDOFF.UseVisualStyleBackColor = true;
            this.redLEDOFF.Click += new System.EventHandler(this.redLEDOFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 197);
            this.Controls.Add(this.blueLEDOFF);
            this.Controls.Add(this.greenLEDOFF);
            this.Controls.Add(this.redLEDOFF);
            this.Controls.Add(this.blueLEDBUTTON);
            this.Controls.Add(this.greenLEDBUTTON);
            this.Controls.Add(this.redLEDBUTTON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redLEDBUTTON;
        private System.Windows.Forms.Button greenLEDBUTTON;
        private System.Windows.Forms.Button blueLEDBUTTON;
        private System.Windows.Forms.Button blueLEDOFF;
        private System.Windows.Forms.Button greenLEDOFF;
        private System.Windows.Forms.Button redLEDOFF;
    }
}

