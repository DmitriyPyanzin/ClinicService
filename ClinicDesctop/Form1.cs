using ClinicServiceNamespace;

namespace ClinicDesctop
{
    public partial class font1 : Form
    {
        public font1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Clinic clinic = new Clinic("http://localhost:5246/", new HttpClient());
            ICollection<Client> clients = clinic.ClientGetAllAsync().Result;

            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Birthday.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Document
                });
                listViewClients.Items.Add(item);
            }
        }

        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            Clinic clinic = new Clinic("http://localhost:5246/", new HttpClient());
            ICollection<Pet> pets = clinic.PetGetAllAsync().Result;

            listViewPets.Items.Clear();
            foreach (Pet pet in pets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pet.PetId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.ClientId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Name
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Type
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Breed
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Birthday.ToString()
                });
                listViewPets.Items.Add(item);
            }
        }

        private void btnUpdateCons_Click(object sender, EventArgs e)
        {
            Clinic clinic = new Clinic("http://localhost:5246/", new HttpClient());
            ICollection<Consultation> consultations = clinic.ConsultationGetAllAsync().Result;

            listViewConsultation.Items.Clear();
            foreach (Consultation consultation in consultations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = consultation.ConsultationId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ClientId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.PetId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ConsultationDate.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.Description
                });
                listViewConsultation.Items.Add(item);
            }
        }
    }
}
