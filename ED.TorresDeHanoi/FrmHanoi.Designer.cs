namespace ED.TorresDeHanoi
{
    partial class FrmHanoi
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
            this.areaPosteA = new System.Windows.Forms.FlowLayoutPanel();
            this.areaPosteB = new System.Windows.Forms.FlowLayoutPanel();
            this.areaPosteC = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // areaPosteA
            // 
            this.areaPosteA.BackColor = System.Drawing.Color.Silver;
            this.areaPosteA.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.areaPosteA.Location = new System.Drawing.Point(47, 95);
            this.areaPosteA.Margin = new System.Windows.Forms.Padding(0);
            this.areaPosteA.Name = "areaPosteA";
            this.areaPosteA.Size = new System.Drawing.Size(190, 253);
            this.areaPosteA.TabIndex = 0;
            this.areaPosteA.Tag = "A";
            this.areaPosteA.Click += new System.EventHandler(this.areaPoste_Click);
            // 
            // areaPosteB
            // 
            this.areaPosteB.BackColor = System.Drawing.Color.Silver;
            this.areaPosteB.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.areaPosteB.Location = new System.Drawing.Point(248, 95);
            this.areaPosteB.Name = "areaPosteB";
            this.areaPosteB.Size = new System.Drawing.Size(190, 253);
            this.areaPosteB.TabIndex = 0;
            this.areaPosteB.Tag = "B";
            this.areaPosteB.Click += new System.EventHandler(this.areaPoste_Click);
            // 
            // areaPosteC
            // 
            this.areaPosteC.BackColor = System.Drawing.Color.Silver;
            this.areaPosteC.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.areaPosteC.Location = new System.Drawing.Point(453, 95);
            this.areaPosteC.Name = "areaPosteC";
            this.areaPosteC.Size = new System.Drawing.Size(190, 253);
            this.areaPosteC.TabIndex = 0;
            this.areaPosteC.Tag = "C";
            this.areaPosteC.Click += new System.EventHandler(this.areaPoste_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Location = new System.Drawing.Point(3, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 53);
            this.panel1.TabIndex = 1;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(12, 421);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(664, 25);
            this.lblMensaje.TabIndex = 2;
            // 
            // FrmHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.areaPosteC);
            this.Controls.Add(this.areaPosteB);
            this.Controls.Add(this.areaPosteA);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHanoi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHanoi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel areaPosteA;
        private FlowLayoutPanel areaPosteB;
        private FlowLayoutPanel areaPosteC;
        private Panel panel1;
        private Label lblMensaje;
    }
}