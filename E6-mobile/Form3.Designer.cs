namespace E6_Mobile
{
    partial class Form3
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnModify = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(342, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(433, 268);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(9, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(137, 71);
            btnModify.TabIndex = 0;
            btnModify.Text = "Modifier";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += new EventHandler(this.btnModify_Click); // Liaison avec la méthode
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(173, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 71);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += new EventHandler(this.btnCancel_Click); // Liaison avec la méthode
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 125);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 71);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new EventHandler(this.btnAdd_Click); // Liaison avec la méthode
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(173, 125);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 71);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new EventHandler(this.btnDelete_Click); // Liaison avec la méthode
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 337);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnModify);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnDelete);
            Name = "Form3";
            Text = "Form3";
            Load += new EventHandler(this.Form3_Load); // Liaison avec la méthode
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDelete;
        private Button btnModify;
        private Button btnCancel;
        private Button btnAdd;

        private void Form3_Load(object sender, EventArgs e)
        {
            // Initialize form, load data, etc.
        }
    }
}
