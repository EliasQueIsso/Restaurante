using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    class Comanda
    {
        private int id;
        private double valorConsumo;
        private double valorEstacionamento;
        private double valorCouvert;
        private double valorDescontoPromocional;
        private double valorTotal;

        public void lancarGastos(double ValorConsumo, double ValorEstacionamento, double ValorCouvert)
        {
            valorDescontoPromocional = 0;
            valorTotal = 0;
        }
        public bool verificarPromocao()
        {
            if (valorTotal > 100)
            {
                valorDescontoPromocional = valorConsumo * 0.1;
                return true;
            }
            return false;
        }
        public string listarComanda()
        {
            id++;
            return "Comanda: " + id +
                   "\nConsumo: " + valorConsumo +
                   "\nEstacionamento: " + valorEstacionamento +
                   "\nCouvert: " + valorCouvert +
                   "\nDesconto: " + valorDescontoPromocional +
                   "\nTotal: " + valorTotal;
        }
        public Comanda()
        {
            id = 0;
            valorConsumo = 0;
            valorEstacionamento = 0;
            valorCouvert = 0;
            valorDescontoPromocional = 0;
            valorTotal = 0;
        }
        public Comanda(int Id, double ValorConsumo, double ValorEstacionamento, double ValorCouvert, double ValorDescontoPromocional, double ValorTotal)
        {
            id=Id;
            valorConsumo=ValorConsumo;
            valorEstacionamento = ValorEstacionamento;  
            valorCouvert = ValorCouvert;
            valorDescontoPromocional=ValorDescontoPromocional;
            valorTotal = ValorTotal;
        }
        public Comanda(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id=id;
        }
        public double getValorConsumo()
        {
            return valorConsumo;
        }
        public void setValorConsumo(double valorConsumo)
        {
            this.valorConsumo = valorConsumo;
        }
        public double getValorEstacionamento()
        {
            return valorEstacionamento;
        }
        public void setValorEstacionamento(double valorEstacionamento)
        {
            this.valorEstacionamento = valorEstacionamento;
        }
        public double getValorCouvert()
        {
            return valorCouvert;
        }
        public void setValorCouvert(double valorCouvert)
        {
            this.valorCouvert = valorCouvert;
        }
        public double getValorDescontoPromocional()
        {
            return valorDescontoPromocional;
        }
        public void setValorDescontoPromocional(double valorDescontoPromocional)
        {
            this.valorDescontoPromocional = valorDescontoPromocional;
        }
        public double getValorTotal()
        {
            return valorTotal;
        }
        public void setValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }
    }
}