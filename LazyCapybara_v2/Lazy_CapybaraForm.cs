namespace LazyCapybara_v2
{
    using Forms.Edit;
    using Domain.Models;
    using Domain.Services;
    using LazyCapybaraLibrary.Services;
    using LazyCapybara_v2.Security.Dto;

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
            rooms.Add(MockRoom(6, "Cabr�n"));
            rooms[0].Validate();
            rooms[1].Validate();
            rooms[2].Validate();
            rooms[3].Validate();
            rooms[4].Validate();
            rooms[5].Validate();
            var roomService = new RoomService(new ClassValidationsService());
            var newRoom = roomService.CreateRoom(1, 500.0M, true);
            newRoom.EnergyMetering.Push(100.0M);
            newRoom.CurrentTenants = rooms[0].CurrentTenants;
            roomService.UpdateRoom(rooms[0], newRoom);
            var mapper = Program.GetYourMapper();
            var roomdto = mapper.Map<RoomDto>(rooms[0]);
            var tenantdto = mapper.Map<TenantDto>(rooms[0].CurrentTenants.FirstOrDefault());
            InitializeComponent();
            Label_Title.Text = "Casa 06";
            Label_EnergyBill.Text = "Valor da conta de luz";
            Label_WaterBill.Text = "Valor da conta de �gua";
            Label_EnergyMeters.Text = "Medidores";
            Label_Room1.Text = "Quarto 1";
            Label_Room2.Text = "Quarto 2";
            Label_Room3.Text = "Quarto 3";
            Label_Room4.Text = "Quarto 4";
            Label_Room5.Text = "Quarto 5";
            Label_Room6.Text = "Quarto 6";
            rooms[0].EnergyMetering.Push(1500.0M);
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
            DialogResult choice = MessageBox.Show("Esta op��o serve para alterar dados sobre um quarto espec�fico.\n" +
                "Apenas utilize se as informa��es mostradas sobre determinado quarto precisarem ser atualizadas.\n" +
                "Se houver alguma informa��o incorreta ou algum outro erro, contate o administrador.\n" +
                "Deseja prosseguir?", "Aten��o!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                SelectRoomForm selectRoomForm = new SelectRoomForm(rooms);
                selectRoomForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("N�o aceitou continuar.");
            }
        }

        private string MountRoomDescriptionString(Room room)
        {
            Tenant tenant = room.CurrentTenants.FirstOrDefault();
            return $"{tenant.FirstName} {tenant.LastName}, {(room.CurrentTenants.Count > 1 ? "divide" : "solo")}, entrada {tenant.CheckIn}, �ltima leitura {room.EnergyMetering.FirstOrDefault()}";
        }

        private Room MockRoom(int id, string name)
        {
            var room = new RoomService(new ClassValidationsService()).CreateRoom(id, 450, false);
            room.CurrentTenants.Push(new TenantService(new ClassValidationsService()).CreateNewTenant(name, "dos caminh�es", "1196751251", "larissinhadejesus@gmail.com", 15, null));
            return room;
        }
    }
}