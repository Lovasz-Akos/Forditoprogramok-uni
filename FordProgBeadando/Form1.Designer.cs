namespace FordProgBeadando
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       

      
        private void InitializeComponent()
        {
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.tBInput = new System.Windows.Forms.TextBox();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTablazatBetolt = new System.Windows.Forms.Button();
            this.BTNTablaTorol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofp = new System.Windows.Forms.OpenFileDialog();
            this.testrtb = new System.Windows.Forms.RichTextBox();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(11, 11);
            this.dGV1.Margin = new System.Windows.Forms.Padding(2);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(737, 335);
            this.dGV1.TabIndex = 0;
            // 
            // tBInput
            // 
            this.tBInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tBInput.ForeColor = System.Drawing.Color.Black;
            this.tBInput.Location = new System.Drawing.Point(126, 400);
            this.tBInput.Margin = new System.Windows.Forms.Padding(2);
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(214, 19);
            this.tBInput.TabIndex = 1;
            this.tBInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rTB
            // 
            this.rTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rTB.ForeColor = System.Drawing.Color.White;
            this.rTB.Location = new System.Drawing.Point(464, 406);
            this.rTB.Margin = new System.Windows.Forms.Padding(2);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(293, 166);
            this.rTB.TabIndex = 2;
            this.rTB.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(185, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Számolás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnTablazatBetolt
            // 
            this.btnTablazatBetolt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTablazatBetolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablazatBetolt.Location = new System.Drawing.Point(44, 469);
            this.btnTablazatBetolt.Margin = new System.Windows.Forms.Padding(2);
            this.btnTablazatBetolt.Name = "btnTablazatBetolt";
            this.btnTablazatBetolt.Size = new System.Drawing.Size(187, 36);
            this.btnTablazatBetolt.TabIndex = 4;
            this.btnTablazatBetolt.Text = "Tábla betöltése";
            this.btnTablazatBetolt.UseVisualStyleBackColor = false;
            this.btnTablazatBetolt.Click += new System.EventHandler(this.BtnTablazatBetolt_Click);
            // 
            // BTNTablaTorol
            // 
            this.BTNTablaTorol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTNTablaTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.BTNTablaTorol.Location = new System.Drawing.Point(44, 515);
            this.BTNTablaTorol.Margin = new System.Windows.Forms.Padding(2);
            this.BTNTablaTorol.Name = "BTNTablaTorol";
            this.BTNTablaTorol.Size = new System.Drawing.Size(187, 36);
            this.BTNTablaTorol.TabIndex = 5;
            this.BTNTablaTorol.Text = "Betöltött tábla törlése";
            this.BTNTablaTorol.UseVisualStyleBackColor = false;
            this.BTNTablaTorol.Click += new System.EventHandler(this.BTNTablaTorol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(577, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kimenet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(196, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bemenet";
            // 
            // ofp
            // 
            this.ofp.FileName = "openFileDialog1";
            // 
            // testrtb
            // 
            this.testrtb.BackColor = System.Drawing.Color.Honeydew;
            this.testrtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.testrtb.Location = new System.Drawing.Point(11, 351);
            this.testrtb.Name = "testrtb";
            this.testrtb.Size = new System.Drawing.Size(110, 113);
            this.testrtb.TabIndex = 8;
            this.testrtb.Text = "";
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveOutput.Location = new System.Drawing.Point(236, 469);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(187, 36);
            this.btnSaveOutput.TabIndex = 9;
            this.btnSaveOutput.Text = "Kimenet Mentése";
            this.btnSaveOutput.UseVisualStyleBackColor = false;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveTable.Location = new System.Drawing.Point(236, 516);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(187, 36);
            this.btnSaveTable.TabIndex = 10;
            this.btnSaveTable.Text = "Tábla mentése";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(768, 582);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.testrtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNTablaTorol);
            this.Controls.Add(this.btnTablazatBetolt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rTB);
            this.Controls.Add(this.tBInput);
            this.Controls.Add(this.dGV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.TextBox tBInput;
        private System.Windows.Forms.RichTextBox rTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTablazatBetolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofp;
        private System.Windows.Forms.RichTextBox testrtb;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button BTNTablaTorol;
    }
}

