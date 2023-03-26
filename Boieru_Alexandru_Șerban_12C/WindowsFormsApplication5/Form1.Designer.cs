namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.magazin_Electrocasnice_si_ElectroniceDataSet = new WindowsFormsApplication5.Magazin_Electrocasnice_si_ElectroniceDataSet();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new WindowsFormsApplication5.Magazin_Electrocasnice_si_ElectroniceDataSetTableAdapters.ClientiTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication5.Magazin_Electrocasnice_si_ElectroniceDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.magazin_Electrocasnice_si_ElectroniceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(203, 162);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // magazin_Electrocasnice_si_ElectroniceDataSet
            // 
            this.magazin_Electrocasnice_si_ElectroniceDataSet.DataSetName = "Magazin_Electrocasnice_si_ElectroniceDataSet";
            this.magazin_Electrocasnice_si_ElectroniceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.magazin_Electrocasnice_si_ElectroniceDataSet;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AngajatiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientiTableAdapter = this.clientiTableAdapter;
            this.tableAdapterManager.Detalii_facturiTableAdapter = null;
            this.tableAdapterManager.FacturiTableAdapter = null;
            this.tableAdapterManager.ProduseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication5.Magazin_Electrocasnice_si_ElectroniceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 446);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazin_Electrocasnice_si_ElectroniceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Magazin_Electrocasnice_si_ElectroniceDataSet magazin_Electrocasnice_si_ElectroniceDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private Magazin_Electrocasnice_si_ElectroniceDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private Magazin_Electrocasnice_si_ElectroniceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

