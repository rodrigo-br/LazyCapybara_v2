namespace LazyCapybara_v2.Forms.Edit
{
    partial class SelectRoomForm
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
            Label_Title = new Label();
            GroupBox_SelectRooms = new GroupBox();
            RadioButton_Room6 = new RadioButton();
            RadioButton_Room5 = new RadioButton();
            RadioButton_Room4 = new RadioButton();
            RadioButton_Room3 = new RadioButton();
            RadioButton_Room2 = new RadioButton();
            RadioButton_Room1 = new RadioButton();
            Label_SelectedRoomInfo = new Label();
            Button_ConfirmSelectedRoom = new Button();
            GroupBox_SelectRooms.SuspendLayout();
            SuspendLayout();
            // 
            // Label_Title
            // 
            Label_Title.AutoSize = true;
            Label_Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Title.Location = new Point(66, 23);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(406, 21);
            Label_Title.TabIndex = 0;
            Label_Title.Text = "Selecione o quarto que você deseja efetuar a editação";
            // 
            // GroupBox_SelectRooms
            // 
            GroupBox_SelectRooms.Controls.Add(RadioButton_Room6);
            GroupBox_SelectRooms.Controls.Add(RadioButton_Room5);
            GroupBox_SelectRooms.Controls.Add(RadioButton_Room4);
            GroupBox_SelectRooms.Controls.Add(RadioButton_Room3);
            GroupBox_SelectRooms.Controls.Add(RadioButton_Room2);
            GroupBox_SelectRooms.Controls.Add(RadioButton_Room1);
            GroupBox_SelectRooms.Location = new Point(50, 92);
            GroupBox_SelectRooms.Name = "GroupBox_SelectRooms";
            GroupBox_SelectRooms.Size = new Size(146, 272);
            GroupBox_SelectRooms.TabIndex = 1;
            GroupBox_SelectRooms.TabStop = false;
            // 
            // RadioButton_Room6
            // 
            RadioButton_Room6.AutoSize = true;
            RadioButton_Room6.Location = new Point(11, 234);
            RadioButton_Room6.Name = "RadioButton_Room6";
            RadioButton_Room6.Size = new Size(71, 19);
            RadioButton_Room6.TabIndex = 5;
            RadioButton_Room6.TabStop = true;
            RadioButton_Room6.Text = "Quarto 6";
            RadioButton_Room6.UseVisualStyleBackColor = true;
            RadioButton_Room6.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RadioButton_Room5
            // 
            RadioButton_Room5.AutoSize = true;
            RadioButton_Room5.Location = new Point(12, 187);
            RadioButton_Room5.Name = "RadioButton_Room5";
            RadioButton_Room5.Size = new Size(71, 19);
            RadioButton_Room5.TabIndex = 4;
            RadioButton_Room5.TabStop = true;
            RadioButton_Room5.Text = "Quarto 5";
            RadioButton_Room5.UseVisualStyleBackColor = true;
            RadioButton_Room5.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RadioButton_Room4
            // 
            RadioButton_Room4.AutoSize = true;
            RadioButton_Room4.Location = new Point(12, 144);
            RadioButton_Room4.Name = "RadioButton_Room4";
            RadioButton_Room4.Size = new Size(71, 19);
            RadioButton_Room4.TabIndex = 3;
            RadioButton_Room4.TabStop = true;
            RadioButton_Room4.Text = "Quarto 4";
            RadioButton_Room4.UseVisualStyleBackColor = true;
            RadioButton_Room4.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RadioButton_Room3
            // 
            RadioButton_Room3.AutoSize = true;
            RadioButton_Room3.Location = new Point(14, 101);
            RadioButton_Room3.Name = "RadioButton_Room3";
            RadioButton_Room3.Size = new Size(71, 19);
            RadioButton_Room3.TabIndex = 2;
            RadioButton_Room3.TabStop = true;
            RadioButton_Room3.Text = "Quarto 3";
            RadioButton_Room3.UseVisualStyleBackColor = true;
            RadioButton_Room3.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RadioButton_Room2
            // 
            RadioButton_Room2.AutoSize = true;
            RadioButton_Room2.Location = new Point(14, 62);
            RadioButton_Room2.Name = "RadioButton_Room2";
            RadioButton_Room2.Size = new Size(71, 19);
            RadioButton_Room2.TabIndex = 1;
            RadioButton_Room2.TabStop = true;
            RadioButton_Room2.Text = "Quarto 2";
            RadioButton_Room2.UseVisualStyleBackColor = true;
            RadioButton_Room2.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // RadioButton_Room1
            // 
            RadioButton_Room1.AutoSize = true;
            RadioButton_Room1.Location = new Point(16, 21);
            RadioButton_Room1.Name = "RadioButton_Room1";
            RadioButton_Room1.Size = new Size(71, 19);
            RadioButton_Room1.TabIndex = 0;
            RadioButton_Room1.TabStop = true;
            RadioButton_Room1.Text = "Quarto 1";
            RadioButton_Room1.UseVisualStyleBackColor = true;
            RadioButton_Room1.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // Label_SelectedRoomInfo
            // 
            Label_SelectedRoomInfo.AutoSize = true;
            Label_SelectedRoomInfo.Location = new Point(255, 113);
            Label_SelectedRoomInfo.Name = "Label_SelectedRoomInfo";
            Label_SelectedRoomInfo.Size = new Size(38, 15);
            Label_SelectedRoomInfo.TabIndex = 2;
            Label_SelectedRoomInfo.Text = "label1";
            // 
            // Button_ConfirmSelectedRoom
            // 
            Button_ConfirmSelectedRoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_ConfirmSelectedRoom.Location = new Point(428, 395);
            Button_ConfirmSelectedRoom.Name = "Button_ConfirmSelectedRoom";
            Button_ConfirmSelectedRoom.Size = new Size(112, 43);
            Button_ConfirmSelectedRoom.TabIndex = 3;
            Button_ConfirmSelectedRoom.Text = "Confirmar seleção";
            Button_ConfirmSelectedRoom.UseVisualStyleBackColor = true;
            Button_ConfirmSelectedRoom.Click += Button_ConfirmSelectedRoom_Click;
            // 
            // SelectRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(Button_ConfirmSelectedRoom);
            Controls.Add(Label_SelectedRoomInfo);
            Controls.Add(GroupBox_SelectRooms);
            Controls.Add(Label_Title);
            Name = "SelectRoomForm";
            Text = "Editar";
            Click += RadioButton_CheckedChanged;
            GroupBox_SelectRooms.ResumeLayout(false);
            GroupBox_SelectRooms.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Title;
        private GroupBox GroupBox_SelectRooms;
        private RadioButton RadioButton_Room2;
        private RadioButton RadioButton_Room1;
        private RadioButton RadioButton_Room6;
        private RadioButton RadioButton_Room5;
        private RadioButton RadioButton_Room4;
        private RadioButton RadioButton_Room3;
        private Label Label_SelectedRoomInfo;
        private Button Button_ConfirmSelectedRoom;
    }
}