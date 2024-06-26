﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarselecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_limparcombobox_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_resetarelementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Aviao");
            cb_transportes.Items.Add("Navio");
            cb_transportes.Items.Add("Onibus");
            cb_transportes.Items.Add("Trem"); 
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_novotransporte.Text = cb_transportes.Text;
        }

        private void btn_addnovotransporte_Click(object sender, EventArgs e)
        {
            if(tb_novotransporte.Text != "")
            {
                if (cb_transportes.FindString(tb_novotransporte.Text) < 0)
                {
                    cb_transportes.Items.Add(tb_novotransporte.Text);
                }
                else
                {
                    MessageBox.Show("Esse elemento ja existe.");
                }
                
            }
        }
    }
}
