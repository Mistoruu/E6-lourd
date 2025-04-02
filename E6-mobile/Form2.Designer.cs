namespace E6_Mobile
{
    partial class Form2
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
            NomDesTables = new CheckedListBox();
            button1 = new Button();
            AffichageDeLaTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AffichageDeLaTable).BeginInit();
            SuspendLayout();
            // 
            // NomDesTables
            // 
            NomDesTables.FormattingEnabled = true;
            NomDesTables.Location = new Point(12, 12);
            NomDesTables.Name = "NomDesTables";
            NomDesTables.Size = new Size(150, 114);
            NomDesTables.TabIndex = 0;
            NomDesTables.SelectedIndexChanged += NomDesTables_SelectedIndexChanged;  // Lier l'événement
            // 
            // button1
            // 
            button1.Location = new Point(12, 132);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 1;
            button1.Text = "Gérer";
            button1.UseVisualStyleBackColor = true;
            // 
            // AffichageDeLaTable
            // 
            AffichageDeLaTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AffichageDeLaTable.Location = new Point(189, 12);
            AffichageDeLaTable.Name = "AffichageDeLaTable";
            AffichageDeLaTable.RowHeadersWidth = 51;
            AffichageDeLaTable.Size = new Size(475, 298);
            AffichageDeLaTable.TabIndex = 2;
            AffichageDeLaTable.CellContentClick += affichageDeLaTable_CellContentClick;

            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 344);
            Controls.Add(AffichageDeLaTable);
            Controls.Add(button1);
            Controls.Add(NomDesTables);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)AffichageDeLaTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox NomDesTables;
        private Button button1;
        private DataGridView AffichageDeLaTable;  // Assurez-vous d'avoir ce nom ici

        // Ajout de la méthode manquante pour éviter l'erreur
       
    }
}
