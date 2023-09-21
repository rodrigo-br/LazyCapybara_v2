using System.Drawing.Text;

namespace LazyCapybara_v2
{
    using Forms.Edit;
    using Domain.Model;
    public partial class Lazy_CapybaraForm : Form
    {
        List<Room> rooms = new List<Room>();

        public Lazy_CapybaraForm()
        {
            rooms.Add(MockRoom(1, "Jeferson"));
            rooms.Add(MockRoom(2, "Lucas"));
            rooms.Add(MockRoom(3, "Camilla"));
            rooms.Add(MockRoom(4, "Larissinha"));
            rooms.Add(MockRoom(5, "Rozineide"));
            rooms.Add(MockRoom(6, "Cabrón"));
            InitializeComponent();
            Label_Title.Text = "Casa 06";
            Label_EnergyBill.Text = "Valor da conta de luz";
            Label_WaterBill.Text = "Valor da conta de água";
            Label_EnergyMeters.Text = "Medidores";
            Label_Room1.Text = "Quarto 1";
            Label_Room2.Text = "Quarto 2";
            Label_Room3.Text = "Quarto 3";
            Label_Room4.Text = "Quarto 4";
            Label_Room5.Text = "Quarto 5";
            Label_Room6.Text = "Quarto 6";
            Label_InfoRoom1.Text = MountRoomDescriptionString(rooms[0]);
            Label_InfoRoom2.Text = MountRoomDescriptionString(rooms[1]);
            Label_InfoRoom3.Text = MountRoomDescriptionString(rooms[2]);
            Label_InfoRoom4.Text = MountRoomDescriptionString(rooms[3]);
            Label_InfoRoom5.Text = MountRoomDescriptionString(rooms[4]);
            Label_InfoRoom6.Text = MountRoomDescriptionString(rooms[5]);
            MaskedTextBox_EnergyBill.TextMaskFormat = MaskFormat.IncludePrompt;
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei em Calcular");
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei em Salvar");
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Esta opção serve para alterar dados sobre um quarto específico.\n" +
                "Apenas utilize se as informações mostradas sobre determinado quarto precisarem ser atualizadas.\n" +
                "Se houver alguma informação incorreta ou algum outro erro, contate o administrador.\n" +
                "Deseja prosseguir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                SelectRoomForm selectRoomForm = new SelectRoomForm(rooms);
                selectRoomForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não aceitou continuar.");
            }
        }

        private string MountRoomDescriptionString(Room room)
        {
            Tenant tenant = room.CurrentTenants.First();
            return $"{tenant.FirstName} {tenant.LastName}, {(room.CurrentTenants.Count > 1 ? "divide" : "solo")}, entrada {tenant.CheckIn}, última leitura 1503,36";
        }

        private Room MockRoom(int id, string name)
        {
            return new Room
            {
                Id = id,
                Price = 850.0M,
                HasEnergyMeter = true,
                EnergyMetering = null,
                LastCheckOut = DateOnly.FromDateTime(DateTime.Now),
                TenantsHistory = null,
                CurrentTenants = new List<Tenant>
                {
                    new Tenant
                    {
                        Id = Guid.NewGuid(),
                        FirstName = name,
                        LastName = "do caminhão",
                        PhoneNumber = "11 967130402",
                        Email = "jefersoncaminhao@gmail.com",
                        PaymantDay = 15,
                        CheckIn = DateOnly.FromDateTime(DateTime.Now),
                        CheckOut = null
                    }
                },
            };
        }
    }
}