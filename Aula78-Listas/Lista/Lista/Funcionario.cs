﻿using System;
using System.Globalization;

namespace Lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Salário: R${Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
