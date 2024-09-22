namespace ClinicDesctop
{
    partial class font1
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
            listViewClients = new ListView();
            columnHeaderClientId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            columnHeaderBirthday = new ColumnHeader();
            columnHeaderDocument = new ColumnHeader();
            btnUpdate = new Button();
            TitleClient = new TextBox();
            listViewPets = new ListView();
            columnHeaderPetId = new ColumnHeader();
            columnHeaderPetClientId = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            columnHeaderBreed = new ColumnHeader();
            columnHeaderPetBirthday = new ColumnHeader();
            TitlePets = new TextBox();
            btnUpdatePet = new Button();
            listViewConsultation = new ListView();
            columnHeaderConsultationId = new ColumnHeader();
            columnHeaderConsClientId = new ColumnHeader();
            columnHeaderConsPetId = new ColumnHeader();
            columnHeaderDatatime = new ColumnHeader();
            columnHeaderDescription = new ColumnHeader();
            TitleConsultation = new TextBox();
            btnUpdateCons = new Button();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderClientId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic, columnHeaderBirthday, columnHeaderDocument });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 41);
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(967, 346);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnHeaderClientId
            // 
            columnHeaderClientId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Фамилия";
            columnHeaderSurName.TextAlign = HorizontalAlignment.Center;
            columnHeaderSurName.Width = 200;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.TextAlign = HorizontalAlignment.Center;
            columnHeaderFirstName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.TextAlign = HorizontalAlignment.Center;
            columnHeaderPatronymic.Width = 200;
            // 
            // columnHeaderBirthday
            // 
            columnHeaderBirthday.Text = "Дата рождения";
            columnHeaderBirthday.TextAlign = HorizontalAlignment.Center;
            columnHeaderBirthday.Width = 100;
            // 
            // columnHeaderDocument
            // 
            columnHeaderDocument.Text = "Связанный документ";
            columnHeaderDocument.TextAlign = HorizontalAlignment.Center;
            columnHeaderDocument.Width = 200;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(199, 393);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 59);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Показать всех клиентов";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // TitleClient
            // 
            TitleClient.Location = new Point(12, 12);
            TitleClient.Name = "TitleClient";
            TitleClient.Size = new Size(967, 23);
            TitleClient.TabIndex = 3;
            TitleClient.Text = "Таблица клиентов";
            TitleClient.TextAlign = HorizontalAlignment.Center;
            // 
            // listViewPets
            // 
            listViewPets.Columns.AddRange(new ColumnHeader[] { columnHeaderPetId, columnHeaderPetClientId, columnHeaderName, columnHeaderType, columnHeaderBreed, columnHeaderPetBirthday });
            listViewPets.FullRowSelect = true;
            listViewPets.GridLines = true;
            listViewPets.Location = new Point(12, 507);
            listViewPets.Name = "listViewPets";
            listViewPets.Size = new Size(967, 346);
            listViewPets.TabIndex = 4;
            listViewPets.UseCompatibleStateImageBehavior = false;
            listViewPets.View = View.Details;
            // 
            // columnHeaderPetId
            // 
            columnHeaderPetId.Text = "#";
            // 
            // columnHeaderPetClientId
            // 
            columnHeaderPetClientId.Text = "Номер клиента";
            columnHeaderPetClientId.TextAlign = HorizontalAlignment.Center;
            columnHeaderPetClientId.Width = 100;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Кличка";
            columnHeaderName.TextAlign = HorizontalAlignment.Center;
            columnHeaderName.Width = 200;
            // 
            // columnHeaderType
            // 
            columnHeaderType.Text = "Вид животного";
            columnHeaderType.TextAlign = HorizontalAlignment.Center;
            columnHeaderType.Width = 200;
            // 
            // columnHeaderBreed
            // 
            columnHeaderBreed.Text = "Порода";
            columnHeaderBreed.TextAlign = HorizontalAlignment.Center;
            columnHeaderBreed.Width = 200;
            // 
            // columnHeaderPetBirthday
            // 
            columnHeaderPetBirthday.Text = "Дата рождения";
            columnHeaderPetBirthday.TextAlign = HorizontalAlignment.Center;
            columnHeaderPetBirthday.Width = 100;
            // 
            // TitlePets
            // 
            TitlePets.Location = new Point(12, 478);
            TitlePets.Name = "TitlePets";
            TitlePets.Size = new Size(967, 23);
            TitlePets.TabIndex = 5;
            TitlePets.Text = "Таблица домашних животных";
            TitlePets.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdatePet
            // 
            btnUpdatePet.Location = new Point(199, 859);
            btnUpdatePet.Name = "btnUpdatePet";
            btnUpdatePet.Size = new Size(143, 59);
            btnUpdatePet.TabIndex = 6;
            btnUpdatePet.Text = "Показать всех животных";
            btnUpdatePet.UseVisualStyleBackColor = true;
            btnUpdatePet.Click += btnUpdatePet_Click;
            // 
            // listViewConsultation
            // 
            listViewConsultation.Columns.AddRange(new ColumnHeader[] { columnHeaderConsultationId, columnHeaderConsClientId, columnHeaderConsPetId, columnHeaderDatatime, columnHeaderDescription });
            listViewConsultation.FullRowSelect = true;
            listViewConsultation.GridLines = true;
            listViewConsultation.Location = new Point(985, 41);
            listViewConsultation.Name = "listViewConsultation";
            listViewConsultation.Size = new Size(527, 346);
            listViewConsultation.TabIndex = 7;
            listViewConsultation.UseCompatibleStateImageBehavior = false;
            listViewConsultation.View = View.Details;
            // 
            // columnHeaderConsultationId
            // 
            columnHeaderConsultationId.Text = "#";
            // 
            // columnHeaderConsClientId
            // 
            columnHeaderConsClientId.Text = "Номер клиента";
            columnHeaderConsClientId.TextAlign = HorizontalAlignment.Center;
            columnHeaderConsClientId.Width = 100;
            // 
            // columnHeaderConsPetId
            // 
            columnHeaderConsPetId.Text = "Номер животного";
            columnHeaderConsPetId.TextAlign = HorizontalAlignment.Center;
            columnHeaderConsPetId.Width = 120;
            // 
            // columnHeaderDatatime
            // 
            columnHeaderDatatime.Text = "Дата консультации";
            columnHeaderDatatime.TextAlign = HorizontalAlignment.Center;
            columnHeaderDatatime.Width = 120;
            // 
            // columnHeaderDescription
            // 
            columnHeaderDescription.Text = "Описание";
            columnHeaderDescription.TextAlign = HorizontalAlignment.Center;
            columnHeaderDescription.Width = 120;
            // 
            // TitleConsultation
            // 
            TitleConsultation.Location = new Point(985, 12);
            TitleConsultation.Name = "TitleConsultation";
            TitleConsultation.Size = new Size(527, 23);
            TitleConsultation.TabIndex = 8;
            TitleConsultation.Text = "Таблица консультаций";
            TitleConsultation.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdateCons
            // 
            btnUpdateCons.Location = new Point(1072, 393);
            btnUpdateCons.Name = "btnUpdateCons";
            btnUpdateCons.Size = new Size(151, 59);
            btnUpdateCons.TabIndex = 9;
            btnUpdateCons.Text = "Показать все консультации";
            btnUpdateCons.UseVisualStyleBackColor = true;
            btnUpdateCons.Click += btnUpdateCons_Click;
            // 
            // font1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 960);
            Controls.Add(btnUpdateCons);
            Controls.Add(TitleConsultation);
            Controls.Add(listViewConsultation);
            Controls.Add(btnUpdatePet);
            Controls.Add(TitlePets);
            Controls.Add(listViewPets);
            Controls.Add(TitleClient);
            Controls.Add(btnUpdate);
            Controls.Add(listViewClients);
            Name = "font1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Clinic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClients;
        private Button btnUpdate;
        private ColumnHeader columnHeaderClientId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private TextBox TitleClient;
        private ColumnHeader columnHeaderBirthday;
        private ColumnHeader columnHeaderDocument;
        private ListView listViewPets;
        private ColumnHeader columnHeaderPetId;
        private TextBox TitlePets;
        private ColumnHeader columnHeaderPetClientId;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderType;
        private ColumnHeader columnHeaderBreed;
        private ColumnHeader columnHeaderPetBirthday;
        private Button btnUpdatePet;
        private ListView listViewConsultation;
        private TextBox TitleConsultation;
        private ColumnHeader columnHeaderConsultationId;
        private ColumnHeader columnHeaderConsClientId;
        private ColumnHeader columnHeaderConsPetId;
        private ColumnHeader columnHeaderDatatime;
        private ColumnHeader columnHeaderDescription;
        private Button btnUpdateCons;
    }
}
