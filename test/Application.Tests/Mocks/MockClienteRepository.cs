﻿using Domain;
using Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests.Mocks
{
    public static class MockClienteRepository
    {
        public static Mock<IClienteRepository> GetClienteRepository()
        {
            var mock = new Mock<IClienteRepository>();
            var clientes = new List<Cliente> 
            {
                new Cliente
                {
                    Id = 1,
                    NomeCompleto = "Xande",
                    Idade = 22,
                    CPF = "09841937905",
                },
                new Cliente
                {
                    Id = 2,
                    NomeCompleto = "Gabe",
                    Idade = 18,
                    CPF = "123"
                },
                new Cliente
                {
                    Id = 3,
                    NomeCompleto = "Ferna",
                    Idade = 30,
                    CPF = "1234",
                }
            };

            mock.Setup(x => x.Get(It.IsAny<int>())).Returns((int id)  =>
            {
                return clientes.First(x => x.Id == id);
            });

            mock.Setup(x => x.Create(It.IsAny<Cliente>())).Returns((Cliente cliente) =>
            {
                clientes.Add(cliente);
                return cliente;
            });

            mock.Setup(x => x.GetAll()).Returns(clientes);
            





            return mock;
        }
    }
}