﻿using NTier101_Live.BLL;
using NTier101_Live.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live.PL
{
    public partial class frmUser : Form
    {
        public SqlCommand command;
        private datUserBLL datUserBLL=new datUserBLL();

        public string Mode; // IUD gibi karakteri içerecek
        public int UserID; // U/D işlemleri için


        public frmUser()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            FormInit();

            ShowRecords();

        }

        public void FormInit()
        {
            Mode = "";

            tboxUserName.Clear();
            tboxUserPassw.Clear();
            tboxAd.Clear();
            tboxSoyad.Clear();
            tboxTCKimlik.Clear();
            tboxMudurlukID.Clear();

            groupBox1.Enabled = false;

        }

        public void ShowRecords()
        {
            // DataGrid i dolduracak

            DBOperation conn = new DBOperation();

            command= new SqlCommand("SELECT * FROM datUser",conn.Connection);

            DataTable dataTable = new DataTable();  

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();  

            bindingSource.DataSource = dataTable;

            dgrdUser.DataSource = bindingSource;


        }

        private void btonNew_Click(object sender, EventArgs e)
        {
            Mode = "I"; // Insert Mode

            groupBox1.Enabled = true;

            tboxUserName.Focus();
        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            FillComponents();
        }

        private void btonDelete_Click(object sender, EventArgs e)
        {
            Mode = "D"; // Delete Mode

            UserID = Convert.ToInt32(dgrdUser.CurrentRow.Cells[0].Value);

            IUD();
        }

        private void bonSave_Click(object sender, EventArgs e)
        {
            IUD();
        }


        public void IUD()
        {
            // Mode parametresine göre ilgili diğer metotlara gönderecek olan metot...

            datUser datUser = new datUser();

            switch (Mode)
            {
                case "I":
                    datUser = datUserBLL.insertUser(tboxUserName.Text, tboxUserPassw.Text, tboxAd.Text, tboxSoyad.Text, tboxTCKimlik.Text, Convert.ToInt32(tboxMudurlukID.Text));

                    MessageBox.Show("Yeni kayıt işlemi basarılı...");
                    break;

                case "U":
                    datUser = datUserBLL.updateUser(UserID,tboxUserName.Text, tboxUserPassw.Text, tboxAd.Text, tboxSoyad.Text, tboxTCKimlik.Text, Convert.ToInt32(tboxMudurlukID.Text));

                    MessageBox.Show("Kayıt güncelleme işlemi basarılı...");
                    break;

                case "D":
                    datUser=datUserBLL.deleteUser(UserID);

                    MessageBox.Show("Kayıt silme işlemi basarılı...");

                    break;

                default:
                    break;
            }

            FormInit();

            ShowRecords();



        }

        public void FillComponents()
        {
            // DG üzerindeki bilgileri ekrandaki componentlere taşıma
            Mode = "U"; // Update Mod
            groupBox1.Enabled = true;

            UserID = Convert.ToInt32(dgrdUser.CurrentRow.Cells[0].Value); // hangi kayıt üzerinde duruyorum acaba

            datUser datUser = new datUser();

            datUser= datUserBLL.getUser(UserID);

            // Okuduğum bilgileri dolduruyorum.

            tboxUserName.Text= datUser.UserName;
            tboxUserPassw.Text = datUser.UserPassw;
            tboxAd.Text = datUser.Ad;
            tboxSoyad.Text = datUser.Soyad;
            tboxTCKimlik.Text= datUser.TCKimlik;
            tboxMudurlukID.Text=datUser.MudurlukID.ToString();


        }
    }
}
