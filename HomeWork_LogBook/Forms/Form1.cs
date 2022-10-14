﻿using HomeWork_LogBook.Repository;
using HomeWork_LogBook.UserControls;

namespace HomeWork_LogBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Dersin adi


        private void btn_pen_Click(object sender, EventArgs e)
        {
            txtBox_Dersin_adi.Enabled = true;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;

            


            btn_cancel.Click += Btn_cancel_Click;
            btn_save.Click += Btn_save_Click;
        }

        private void Btn_save_Click(object? sender, EventArgs e)
        {
            txtBox_Dersin_adi.Enabled = false;
            btn_save.Enabled = false;
            btn_cancel.Enabled=false;
        }
        private void Btn_cancel_Click(object? sender, EventArgs e)
        {
            txtBox_Dersin_adi.Text = string.Empty;
            txtBox_Dersin_adi.Enabled = false;

            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
        }



        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            var students = FakeDepo.GetStudents();

            for (int i = students.Count - 1; i >= 0; i--)
            {
                Uc_Student uc = new(students[i]);
                uc.Dock = DockStyle.Top;

                


                panel2.Controls.Add(uc);
            }
        }






    }
}