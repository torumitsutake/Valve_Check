using System.IO.Ports;

namespace SerialChecker
{
    partial class Form1
    {

        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        public System.Windows.Forms.Label[] IDList;
        public System.Windows.Forms.Label[] StatusList;
        public System.Windows.Forms.Label[] TTmpList;
        public System.Windows.Forms.Label[] VTmpList;
        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ID2 = new System.Windows.Forms.Label();
            this.ID1 = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.status1 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.Vtmp2 = new System.Windows.Forms.Label();
            this.Vtmp1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Vtmp3 = new System.Windows.Forms.Label();
            this.temp3 = new System.Windows.Forms.Label();
            this.status3 = new System.Windows.Forms.Label();
            this.ID3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID2
            // 
            this.ID2.AutoEllipsis = true;
            this.ID2.AutoSize = true;
            this.ID2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ID2.Location = new System.Drawing.Point(72, 243);
            this.ID2.Name = "ID2";
            this.ID2.Size = new System.Drawing.Size(42, 27);
            this.ID2.TabIndex = 8;
            this.ID2.Text = "ID:";
            // 
            // ID1
            // 
            this.ID1.AutoEllipsis = true;
            this.ID1.AutoSize = true;
            this.ID1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ID1.Location = new System.Drawing.Point(72, 179);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(42, 27);
            this.ID1.TabIndex = 1;
            this.ID1.Text = "ID:";
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.status2.Location = new System.Drawing.Point(227, 243);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(82, 27);
            this.status2.TabIndex = 7;
            this.status2.Text = "Ready";
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.status1.Location = new System.Drawing.Point(227, 179);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(82, 27);
            this.status1.TabIndex = 1;
            this.status1.Text = "Ready";
            // 
            // temp2
            // 
            this.temp2.AutoSize = true;
            this.temp2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.temp2.Location = new System.Drawing.Point(369, 243);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(82, 27);
            this.temp2.TabIndex = 9;
            this.temp2.Text = "Ready";
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.temp1.Location = new System.Drawing.Point(369, 179);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(82, 27);
            this.temp1.TabIndex = 2;
            this.temp1.Text = "Ready";
            // 
            // Vtmp2
            // 
            this.Vtmp2.AutoSize = true;
            this.Vtmp2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Vtmp2.Location = new System.Drawing.Point(528, 243);
            this.Vtmp2.Name = "Vtmp2";
            this.Vtmp2.Size = new System.Drawing.Size(82, 27);
            this.Vtmp2.TabIndex = 12;
            this.Vtmp2.Text = "Ready";
            // 
            // Vtmp1
            // 
            this.Vtmp1.AutoSize = true;
            this.Vtmp1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Vtmp1.Location = new System.Drawing.Point(528, 179);
            this.Vtmp1.Name = "Vtmp1";
            this.Vtmp1.Size = new System.Drawing.Size(82, 27);
            this.Vtmp1.TabIndex = 10;
            this.Vtmp1.Text = "Ready";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(446, 38);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "接続";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(72, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(227, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(369, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tank tmp";
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(578, 498);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 23);
            this.Log.TabIndex = 6;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(528, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valve tmp";
            // 
            // Vtmp3
            // 
            this.Vtmp3.AutoSize = true;
            this.Vtmp3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Vtmp3.Location = new System.Drawing.Point(528, 303);
            this.Vtmp3.Name = "Vtmp3";
            this.Vtmp3.Size = new System.Drawing.Size(82, 27);
            this.Vtmp3.TabIndex = 16;
            this.Vtmp3.Text = "Ready";
            // 
            // temp3
            // 
            this.temp3.AutoSize = true;
            this.temp3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.temp3.Location = new System.Drawing.Point(369, 303);
            this.temp3.Name = "temp3";
            this.temp3.Size = new System.Drawing.Size(82, 27);
            this.temp3.TabIndex = 15;
            this.temp3.Text = "Ready";
            // 
            // status3
            // 
            this.status3.AutoSize = true;
            this.status3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.status3.Location = new System.Drawing.Point(227, 303);
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(82, 27);
            this.status3.TabIndex = 13;
            this.status3.Text = "Ready";
            // 
            // ID3
            // 
            this.ID3.AutoEllipsis = true;
            this.ID3.AutoSize = true;
            this.ID3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ID3.Location = new System.Drawing.Point(72, 303);
            this.ID3.Name = "ID3";
            this.ID3.Size = new System.Drawing.Size(42, 27);
            this.ID3.TabIndex = 14;
            this.ID3.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 533);
            this.Controls.Add(this.Vtmp3);
            this.Controls.Add(this.temp3);
            this.Controls.Add(this.status3);
            this.Controls.Add(this.ID3);
            this.Controls.Add(this.Vtmp2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Vtmp1);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.ID2);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.ID1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox comboBox1;
        private SerialPort serialPort1;
        private System.Windows.Forms.Label ID1;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label ID2;
        private System.Windows.Forms.Label Vtmp2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Vtmp1;
        private System.Windows.Forms.Label Vtmp3;
        private System.Windows.Forms.Label temp3;
        private System.Windows.Forms.Label status3;
        private System.Windows.Forms.Label ID3;
    }
}

