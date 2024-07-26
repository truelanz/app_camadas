using BusinessLogicLayer;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        ModelUser modelUser = new ModelUser();
        private int code;

        public Form1()
        {
            InitializeComponent();
        }

        //Fill Grid
        public void FillGrid()
        {
            try
            {
                DataAccessConnection connection = new DataAccessConnection(ConnectionData.StringConnection);
                BusinessLogicUser businessLogicUser = new BusinessLogicUser(connection);
                dataUser.DataSource = businessLogicUser.list();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Clear()
        {
            textName.Text = string.Empty;
            textAge.Text = string.Empty;
            comboSex.SelectedIndex = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccessConnection connection = new DataAccessConnection(ConnectionData.StringConnection);
            BusinessLogicUser businessLogicUser = new BusinessLogicUser(connection);
            FillGrid();
            comboSex.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //CELLS
        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lineNumber = e.RowIndex;

            if (lineNumber >= 0)
            {
                this.code = Convert.ToInt16(dataUser.Rows[lineNumber].Cells[0].Value);
            }
        }

        //ADD BUTTOM
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessConnection connection = new DataAccessConnection(ConnectionData.StringConnection);
                BusinessLogicUser businessLogicUser = new BusinessLogicUser(connection);

                modelUser.user_name = textName.Text;
                modelUser.age = textAge.Text;
                modelUser.sex = comboSex.SelectedItem.ToString();

                bool result = businessLogicUser.AddTo(modelUser);
                if (result == false)
                    MessageBox.Show("erro: Houve um erro na inserção dos dados", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Dados inseridos", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGrid();
                    Clear();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //TEXT INSERT SEX
        private void textSex_TextChanged(object sender, EventArgs e)
        {

        }

        //SEX BUTTON
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //UPDATE BUTTOM
        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (this.code <= 0)
                MessageBox.Show("Selecione a linha para atualizar", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    DataAccessConnection connection = new DataAccessConnection(ConnectionData.StringConnection);
                    BusinessLogicUser businessLogicUser = new BusinessLogicUser(connection);

                    modelUser.user_name = textName.Text;
                    modelUser.age = textAge.Text;
                    modelUser.sex = comboSex.SelectedItem.ToString();
                    modelUser.id = this.code;

                    bool result = businessLogicUser.Update(modelUser);

                    if (result == false)
                        MessageBox.Show("Não foi possível atualizar", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Dados atualizados", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                        Clear();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            if (this.code <= 0)
                MessageBox.Show("Selecione a linha para remover", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    DataAccessConnection connection = new DataAccessConnection(ConnectionData.StringConnection);
                    BusinessLogicUser businessLogicUser = new BusinessLogicUser(connection);

                    var confirm = MessageBox.Show("Está certo disso?", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (confirm == DialogResult.Yes)
                    {
                        businessLogicUser.Delete(this.code);
                        MessageBox.Show("Usuário removido", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                        Clear();
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FillGrid();
                }
            }
        }
    }
}
