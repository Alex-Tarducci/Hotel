namespace Hotel
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
            lbl_n1 = new Label();
            chk_n1 = new CheckBox();
            cmb_n1 = new ComboBox();
            txt_n1 = new TextBox();
            btn_n1 = new Button();
            lbl_n2 = new Label();
            SuspendLayout();
            // 
            // lbl_n1
            // 
            lbl_n1.AutoSize = true;
            lbl_n1.Location = new Point(180, 94);
            lbl_n1.Name = "lbl_n1";
            lbl_n1.Size = new Size(268, 15);
            lbl_n1.TabIndex = 0;
            lbl_n1.Text = "benvenuto nell hotel, inserisci i tuoi dati per unirti";
            // 
            // chk_n1
            // 
            chk_n1.AutoSize = true;
            chk_n1.Location = new Point(575, 209);
            chk_n1.Name = "chk_n1";
            chk_n1.Size = new Size(142, 19);
            chk_n1.TabIndex = 1;
            chk_n1.Text = "parcheggio compreso";
            chk_n1.UseVisualStyleBackColor = true;
            // 
            // cmb_n1
            // 
            cmb_n1.FormattingEnabled = true;
            cmb_n1.Location = new Point(575, 130);
            cmb_n1.Name = "cmb_n1";
            cmb_n1.Size = new Size(121, 23);
            cmb_n1.TabIndex = 2;
            cmb_n1.SelectedIndexChanged += cmb_n1_SelectedIndexChanged;
            // 
            // txt_n1
            // 
            txt_n1.Location = new Point(248, 147);
            txt_n1.Name = "txt_n1";
            txt_n1.Size = new Size(100, 23);
            txt_n1.TabIndex = 3;
            // 
            // btn_n1
            // 
            btn_n1.Location = new Point(248, 187);
            btn_n1.Name = "btn_n1";
            btn_n1.Size = new Size(75, 23);
            btn_n1.TabIndex = 4;
            btn_n1.Text = "button1";
            btn_n1.UseVisualStyleBackColor = true;
            // 
            // lbl_n2
            // 
            lbl_n2.AutoSize = true;
            lbl_n2.Location = new Point(239, 117);
            lbl_n2.Name = "lbl_n2";
            lbl_n2.Size = new Size(134, 15);
            lbl_n2.TabIndex = 5;
            lbl_n2.Text = "quanti giorni vuoi stare?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_n2);
            Controls.Add(btn_n1);
            Controls.Add(txt_n1);
            Controls.Add(cmb_n1);
            Controls.Add(chk_n1);
            Controls.Add(lbl_n1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_n1;
        private CheckBox chk_n1;
        private ComboBox cmb_n1;
        private TextBox txt_n1;
        private Button btn_n1;
        private Label lbl_n2;
    }
}
