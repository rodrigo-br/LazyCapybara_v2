namespace LazyCapybara_v2.Forms.Edit
{
    using Domain.Models;

    public partial class SelectRoomForm : Form
    {
        private readonly ICollection<Room> rooms;
        Room selectedRoom;

        public SelectRoomForm(ICollection<Room> rooms)
        {
            this.rooms = rooms;
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                string roomName = selectedRadioButton.Text;
                int roomIndex;
                if (int.TryParse(roomName.LastOrDefault().ToString(), out roomIndex))
                {
                    selectedRoom = rooms.ElementAt(roomIndex - 1);
                    Tenant tenant = selectedRoom.CurrentTenants.First();
                    Label_SelectedRoomInfo.Text = $"Inquilino: {tenant.FirstName} {tenant.LastName}\n" +
                        $"Email: {tenant.Email}\n" +
                        $"Telefone: {tenant.PhoneNumber}\n" +
                        $"Data de pagamento: {tenant.PaymantDay}\n" +
                        $"Divide quarto: {(selectedRoom.CurrentTenants.Count > 1 ? "Sim" : "Não")}";
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro interno.\n" +
                        "Por favor contate o administrador.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_ConfirmSelectedRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Confirma intenção de editar o quarto {selectedRoom.Id.ToString()}?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EditRoomForm editRoomForm = new EditRoomForm(selectedRoom);
                editRoomForm.Show();
            }
        }
    }
}
