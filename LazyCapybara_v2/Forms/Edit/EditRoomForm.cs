using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LazyCapybara_v2.Forms.Edit
{
    public partial class EditRoomForm : Form
    {
        private readonly Room room;

        public EditRoomForm(Room room)
        {
            InitializeComponent();
            this.room = room;
            Tenant? tenant = room.CurrentTenants?.First();

            if (room != null && tenant != null)
            {
                TextBox_FirstName.Text = tenant.FirstName;
                TextBox_LastName.Text = tenant.LastName;
                TextBox_Email.Text = tenant.Email;
                TextBox_PhoneNumber.Text = tenant.PhoneNumber;
                TextBox_PaymentDay.Text = tenant.PaymantDay.ToString();
                TextBox_ShareRoom.Text = (room.CurrentTenants.Count > 1 ? "Divide quarto" : "Não divide quarto");
                TextBox_LastMetering.Text = room.EnergyMetering?.First().ToString();
            }
        }
    }
}
