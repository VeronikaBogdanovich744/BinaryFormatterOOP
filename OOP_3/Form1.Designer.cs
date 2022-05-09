
namespace OOP_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnimalList = new System.Windows.Forms.ListBox();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.chooseAnimal = new System.Windows.Forms.ComboBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbAge = new System.Windows.Forms.TextBox();
            this.txtbColor = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.btnShowInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimalList
            // 
            this.AnimalList.FormattingEnabled = true;
            this.AnimalList.ItemHeight = 16;
            this.AnimalList.Location = new System.Drawing.Point(12, 12);
            this.AnimalList.Name = "AnimalList";
            this.AnimalList.Size = new System.Drawing.Size(263, 420);
            this.AnimalList.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(296, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(116, 30);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(296, 61);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 30);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // chooseAnimal
            // 
            this.chooseAnimal.FormattingEnabled = true;
            this.chooseAnimal.Location = new System.Drawing.Point(458, 18);
            this.chooseAnimal.Name = "chooseAnimal";
            this.chooseAnimal.Size = new System.Drawing.Size(305, 24);
            this.chooseAnimal.TabIndex = 3;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(663, 61);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 22);
            this.txtbName.TabIndex = 4;
            // 
            // txtbAge
            // 
            this.txtbAge.Location = new System.Drawing.Point(663, 104);
            this.txtbAge.Name = "txtbAge";
            this.txtbAge.Size = new System.Drawing.Size(100, 22);
            this.txtbAge.TabIndex = 5;
            // 
            // txtbColor
            // 
            this.txtbColor.Location = new System.Drawing.Point(663, 151);
            this.txtbColor.Name = "txtbColor";
            this.txtbColor.Size = new System.Drawing.Size(100, 22);
            this.txtbColor.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(596, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(600, 156);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(41, 17);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Color";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(608, 109);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 17);
            this.labelAge.TabIndex = 9;
            this.labelAge.Text = "Age";
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(296, 351);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(116, 30);
            this.Serialize.TabIndex = 10;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Deserialize
            // 
            this.Deserialize.Location = new System.Drawing.Point(296, 402);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(116, 30);
            this.Deserialize.TabIndex = 11;
            this.Deserialize.Text = "Deserialize";
            this.Deserialize.UseVisualStyleBackColor = true;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // btnShowInformation
            // 
            this.btnShowInformation.Location = new System.Drawing.Point(458, 61);
            this.btnShowInformation.Name = "btnShowInformation";
            this.btnShowInformation.Size = new System.Drawing.Size(102, 116);
            this.btnShowInformation.TabIndex = 12;
            this.btnShowInformation.Text = "Show information";
            this.btnShowInformation.UseVisualStyleBackColor = true;
            this.btnShowInformation.Click += new System.EventHandler(this.ShowInformation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowInformation);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtbColor);
            this.Controls.Add(this.txtbAge);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.chooseAnimal);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.AnimalList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AnimalList;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox chooseAnimal;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbAge;
        private System.Windows.Forms.TextBox txtbColor;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.Button btnShowInformation;
    }
}

