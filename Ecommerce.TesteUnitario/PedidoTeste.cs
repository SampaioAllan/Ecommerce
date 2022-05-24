using Xunit;
using System;
using Ecommerce.Lib.Models;

namespace Ecommerce.TesteUnitario
{
    public class PedidoTeste
    {
        [Fact]
        public void TestandoSePedidoSalvaClienteCorretamente()
        {
            //Arrange - Preparando
            var clienteTeste = new Cliente("Allan", "email@teste.com", "teste123", "11122233344", "Rua do teste");
            var pedidoTeste = new Pedido(clienteTeste, "Encaminhado para a unidade de Distribuição", DateTime.Now.AddDays(-2));

            // Act
            var clientePronto = pedidoTeste.GetCliente();

            //Assert
            Assert.Equal(clienteTeste, clientePronto);

        }
        [Fact]
        public void TestandoSePedidoSalvaStatusCorretamente()
        {
            //Arrange - Preparando
            var clienteTeste = new Cliente("Allan", "email@teste.com", "teste123", "11122233344", "Rua do teste");
            var statusTeste = "Encaminhado para a unidade de Distribuição";
            var pedidoTeste = new Pedido(clienteTeste, statusTeste, DateTime.Now.AddDays(-2));

            // Act
            var statusPronto = pedidoTeste.GetStatus();

            //Assert
            Assert.Equal(statusTeste, statusPronto);

        }
        [Fact]
        public void TestandoSePedidoSalvaDataCorretamente()
        {
            //Arrange - Preparando
            var clienteTeste = new Cliente("Allan", "email@teste.com", "teste123", "11122233344", "Rua do teste");
            var statusTeste = "Encaminhado para a unidade de Distribuição";
            var dataTeste = DateTime.Now.AddDays(-2);
            var pedidoTeste = new Pedido(clienteTeste, statusTeste, dataTeste);

            // Act
            var dataPronta = pedidoTeste.GetData();

            //Assert
            Assert.Equal(dataTeste, dataPronta);

        }
        
        
    }
}