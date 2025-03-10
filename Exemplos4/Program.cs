﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Exemplos4.Crud;
using Exemplos4.WinFormsApp;

namespace Exemplos4
{
    internal static class Program
    {
        [STAThread] // Necessário para aplicações Windows Forms
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa o CRUD para interagir com os dados
            CrudService crudService = new CrudService();

            // Abre o formulário principal e passa a instância do CRUD
            Application.Run(new Form1(crudService));
        }
    }
}
