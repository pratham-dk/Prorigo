namespace WindowsFormsApp2
{
    partial class Book
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
            this.showbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.binarywriterbutton = new System.Windows.Forms.Button();
            this.binaryreaderbutton = new System.Windows.Forms.Button();
            this.xmlwriterbutton = new System.Windows.Forms.Button();
            this.xmlreaderbutton = new System.Windows.Forms.Button();
            this.soapwriterbutton = new System.Windows.Forms.Button();
            this.soapreaderbutton = new System.Windows.Forms.Button();
            this.jsonwriterbutton = new System.Windows.Forms.Button();
            this.jsonreaderbutton = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.authorlabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.authortextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(260, 300);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 0;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(403, 300);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 1;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // binarywriterbutton
            // 
            this.binarywriterbutton.Location = new System.Drawing.Point(640, 41);
            this.binarywriterbutton.Name = "binarywriterbutton";
            this.binarywriterbutton.Size = new System.Drawing.Size(114, 23);
            this.binarywriterbutton.TabIndex = 2;
            this.binarywriterbutton.Text = "Binary Writer";
            this.binarywriterbutton.UseVisualStyleBackColor = true;
            this.binarywriterbutton.Click += new System.EventHandler(this.binarywriterbutton_Click);
            // 
            // binaryreaderbutton
            // 
            this.binaryreaderbutton.Location = new System.Drawing.Point(640, 70);
            this.binaryreaderbutton.Name = "binaryreaderbutton";
            this.binaryreaderbutton.Size = new System.Drawing.Size(114, 23);
            this.binaryreaderbutton.TabIndex = 3;
            this.binaryreaderbutton.Text = "Binary Reader";
            this.binaryreaderbutton.UseVisualStyleBackColor = true;
            this.binaryreaderbutton.Click += new System.EventHandler(this.binaryreaderbutton_Click);
            // 
            // xmlwriterbutton
            // 
            this.xmlwriterbutton.Location = new System.Drawing.Point(640, 115);
            this.xmlwriterbutton.Name = "xmlwriterbutton";
            this.xmlwriterbutton.Size = new System.Drawing.Size(114, 23);
            this.xmlwriterbutton.TabIndex = 4;
            this.xmlwriterbutton.Text = "XML Writer";
            this.xmlwriterbutton.UseVisualStyleBackColor = true;
            this.xmlwriterbutton.Click += new System.EventHandler(this.xmlwriterbutton_Click);
            // 
            // xmlreaderbutton
            // 
            this.xmlreaderbutton.Location = new System.Drawing.Point(640, 144);
            this.xmlreaderbutton.Name = "xmlreaderbutton";
            this.xmlreaderbutton.Size = new System.Drawing.Size(114, 23);
            this.xmlreaderbutton.TabIndex = 5;
            this.xmlreaderbutton.Text = "XML Reader";
            this.xmlreaderbutton.UseVisualStyleBackColor = true;
            this.xmlreaderbutton.Click += new System.EventHandler(this.xmlreaderbutton_Click);
            // 
            // soapwriterbutton
            // 
            this.soapwriterbutton.Location = new System.Drawing.Point(640, 196);
            this.soapwriterbutton.Name = "soapwriterbutton";
            this.soapwriterbutton.Size = new System.Drawing.Size(114, 23);
            this.soapwriterbutton.TabIndex = 6;
            this.soapwriterbutton.Text = "SOAP Writer";
            this.soapwriterbutton.UseVisualStyleBackColor = true;
            this.soapwriterbutton.Click += new System.EventHandler(this.soapwriterbutton_Click);
            // 
            // soapreaderbutton
            // 
            this.soapreaderbutton.Location = new System.Drawing.Point(640, 225);
            this.soapreaderbutton.Name = "soapreaderbutton";
            this.soapreaderbutton.Size = new System.Drawing.Size(114, 23);
            this.soapreaderbutton.TabIndex = 7;
            this.soapreaderbutton.Text = "SOAP Reader";
            this.soapreaderbutton.UseVisualStyleBackColor = true;
            this.soapreaderbutton.Click += new System.EventHandler(this.soapreaderbutton_Click);
            // 
            // jsonwriterbutton
            // 
            this.jsonwriterbutton.Location = new System.Drawing.Point(640, 271);
            this.jsonwriterbutton.Name = "jsonwriterbutton";
            this.jsonwriterbutton.Size = new System.Drawing.Size(114, 23);
            this.jsonwriterbutton.TabIndex = 8;
            this.jsonwriterbutton.Text = "JSON Writer";
            this.jsonwriterbutton.UseVisualStyleBackColor = true;
            this.jsonwriterbutton.Click += new System.EventHandler(this.jsonwriterbutton_Click);
            // 
            // jsonreaderbutton
            // 
            this.jsonreaderbutton.Location = new System.Drawing.Point(640, 300);
            this.jsonreaderbutton.Name = "jsonreaderbutton";
            this.jsonreaderbutton.Size = new System.Drawing.Size(114, 23);
            this.jsonreaderbutton.TabIndex = 9;
            this.jsonreaderbutton.Text = "JSON Reader";
            this.jsonreaderbutton.UseVisualStyleBackColor = true;
            this.jsonreaderbutton.Click += new System.EventHandler(this.jsonreaderbutton_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(276, 77);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(53, 16);
            this.idlabel.TabIndex = 10;
            this.idlabel.Text = "Book Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(276, 135);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(79, 16);
            this.namelabel.TabIndex = 11;
            this.namelabel.Text = "Book Name";
            // 
            // authorlabel
            // 
            this.authorlabel.AutoSize = true;
            this.authorlabel.Location = new System.Drawing.Point(276, 186);
            this.authorlabel.Name = "authorlabel";
            this.authorlabel.Size = new System.Drawing.Size(45, 16);
            this.authorlabel.TabIndex = 12;
            this.authorlabel.Text = "Author";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(276, 232);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(38, 16);
            this.pricelabel.TabIndex = 13;
            this.pricelabel.Text = "Price";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(378, 71);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 14;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(378, 129);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 15;
            // 
            // authortextBox
            // 
            this.authortextBox.Location = new System.Drawing.Point(378, 180);
            this.authortextBox.Name = "authortextBox";
            this.authortextBox.Size = new System.Drawing.Size(100, 22);
            this.authortextBox.TabIndex = 16;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(378, 226);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 22);
            this.pricetextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            // 
            // HBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.authortextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.authorlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.jsonreaderbutton);
            this.Controls.Add(this.jsonwriterbutton);
            this.Controls.Add(this.soapreaderbutton);
            this.Controls.Add(this.soapwriterbutton);
            this.Controls.Add(this.xmlreaderbutton);
            this.Controls.Add(this.xmlwriterbutton);
            this.Controls.Add(this.binaryreaderbutton);
            this.Controls.Add(this.binarywriterbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.showbutton);
            this.Name = "HBook";
            this.Text = "HBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button binarywriterbutton;
        private System.Windows.Forms.Button binaryreaderbutton;
        private System.Windows.Forms.Button xmlwriterbutton;
        private System.Windows.Forms.Button xmlreaderbutton;
        private System.Windows.Forms.Button soapwriterbutton;
        private System.Windows.Forms.Button soapreaderbutton;
        private System.Windows.Forms.Button jsonwriterbutton;
        private System.Windows.Forms.Button jsonreaderbutton;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label authorlabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox authortextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label label1;
    }
}