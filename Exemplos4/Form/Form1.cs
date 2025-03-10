using System;
using System.Windows.Forms;
using Exemplos4.Crud;
using Exemplos4.Models;

namespace Exemplos4.WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly CrudService _crudService;
        private int usuarioPage = 1;
        private int maquinaPage = 1;
        private int softwarePage = 1;
        private const int pageSize = 2;

        public Form1(CrudService crudService)
        {
            InitializeComponent();
            _crudService = crudService;
            LoadDataOnStartup();
        }

        private void LoadDataOnStartup()
        {
            LoadUsuarios();
            LoadMaquinas();
            LoadSoftwares();
        }

        private void LoadUsuarios()
        {
            var usuarios = _crudService.ObterUsuariosPaginado(usuarioPage, pageSize);
            dataGridViewUsuarios.DataSource = usuarios;
            lblUsuarioPage.Text = $"Página: {usuarioPage}";
        }

        private void LoadMaquinas()
        {
            var maquinas = _crudService.ObterMaquinasPaginado(maquinaPage, pageSize);
            dataGridViewMaquinas.DataSource = maquinas;
            lblMaquinaPage.Text = $"Página: {maquinaPage}";
        }

        private void LoadSoftwares()
        {
            var softwares = _crudService.ObterSoftwaresPaginado(softwarePage, pageSize);
            dataGridViewSoftwares.DataSource = softwares;
            lblSoftwarePage.Text = $"Página: {softwarePage}";
        }

        // Eventos de navegação para Usuários
        private void btnUsuarioPrev_Click(object sender, EventArgs e)
        {
            if (usuarioPage > 1)
            {
                usuarioPage--;
                LoadUsuarios();
            }
        }

        private void btnUsuarioNext_Click(object sender, EventArgs e)
        {
            usuarioPage++;
            LoadUsuarios();
        }

        // Eventos de navegação para Máquinas
        private void btnMaquinaPrev_Click(object sender, EventArgs e)
        {
            if (maquinaPage > 1)
            {
                maquinaPage--;
                LoadMaquinas();
            }
        }

        private void btnMaquinaNext_Click(object sender, EventArgs e)
        {
            maquinaPage++;
            LoadMaquinas();
        }

        // Eventos de navegação para Softwares
        private void btnSoftwarePrev_Click(object sender, EventArgs e)
        {
            if (softwarePage > 1)
            {
                softwarePage--;
                LoadSoftwares();
            }
        }

        private void btnSoftwareNext_Click(object sender, EventArgs e)
        {
            softwarePage++;
            LoadSoftwares();
        }
    }
}