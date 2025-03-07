﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Conn_Banco.Exercicio.Crud;


public class Program
{
    public static void Main(string[] args)
    {
        var crud = new Crud();
        
        crud.InserirUsuario(4, "Ana Souza", "senha321", 1004, "Gestora de TI");
        crud.InserirUsuario(5, "Ricardo Lima", "senha654", 1005, "Analista de Sistemas");
        crud.InserirUsuario(6, "Fernanda Pereira", "senha987", 1006, "Gerente de Projetos");

    
        crud.InserirMaquina(4, "Servidor", 4000, 2000, 64, 1, 4); 
        crud.InserirMaquina(5, "Laptop", 3000, 1000, 16, 1, 5);  
        crud.InserirMaquina(6, "Estação de Trabalho", 3600, 1500, 32, 1, 6); 

     
        crud.InserirSoftware(4, "Windows Server 2022", 100, 8, 4); 
        crud.InserirSoftware(5, "Ubuntu Server", 50, 4, 5); 
        crud.InserirSoftware(6, "Windows 10", 30, 4, 6); 

        

       
        crud.ListarUsuarios();

      
        crud.ListarMaquinas();
   
        crud.ListarSoftwares();

        Console.WriteLine("Operações concluídas.");
    }
}