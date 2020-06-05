﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BeautyCare_teste
{
    public partial class telahome : Form
    {
        Thread mt;
        public telahome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_horario);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void novo_horario()
        {
            Application.Run(new telaagendamentodehorario());
        }

        private void Form2_Load(object sender, EventArgs e)
        {            
            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1);
            datatoolStripStatusLabel1.Text = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horatoolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_cliente);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_colaborador);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_agendamento);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void consulta_agendamento()
        {
            Application.Run(new telaconsultaagendamentos());
        }

        private void novo_colaborador()
        {
            Application.Run(new telaperfilcolaborador());
        }

        private void novo_cliente()
        {
            Application.Run(new telaperfilcliente());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_cliente);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void consulta_cliente()
        {
            Application.Run(new telaconsultaclientes());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_colaborador);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void consulta_colaborador()
        {
            Application.Run(new consultacolaboradores());
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_horario);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_cliente);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(novo_colaborador);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void agendamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_agendamento);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_cliente);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            mt = new Thread(consulta_colaborador);
            mt.SetApartmentState(ApartmentState.STA);
            mt.Start();
        }
    }
}
