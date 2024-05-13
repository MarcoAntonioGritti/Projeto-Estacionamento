using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento
{
    public class Estacionamento 
    {

        List<Veiculo> listVeiculos = new List<Veiculo>();


        private int valorincial;
        private int valorporhora;
        public int ValorInicial{get;set;}
        public int ValorPorHora{get;set;}

        public void iniciarEstacionamento(){
            Console.WriteLine("Seja bem vindo ao sistema de Estacionamento!");

            
            Console.WriteLine("Digite o valor inicial:");
            ValorInicial = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor por hora:");
            ValorPorHora = Convert.ToInt32(Console.ReadLine());
            
        }

        public void menu(){
            
            Console.WriteLine("Digite sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículo");
            Console.WriteLine("4 - Encerrar");
            
            string op = Console.ReadLine();

            switch(op){
                case "1":
                    cadastrarVeiculo(listVeiculos);
                    break;
                case "2":
                    removerVeiculo(listVeiculos);
                    break;
                case "3":
                    listarVeiculos(listVeiculos);
                    break;
                case "4":
                    Console.WriteLine("Fim Programa!");
                    break;
                default:
                    Console.WriteLine("Está opção não é valida!");
                    menu(); 
                    break;
            }

        }

        public void cadastrarVeiculo(List<Veiculo> listVeiculo){
            Console.WriteLine("Digite a placa do carro para estacionar:");
            string placa = Console.ReadLine().ToUpper().Trim();

            Veiculo v = new Veiculo(placa);
            listVeiculo.Add(v);

            Console.WriteLine("Clique em uma tecla para continuar:");
            string tecla = Console.ReadLine().ToUpper().Trim();

            menu();
            
        }

        public void removerVeiculo(List<Veiculo> listVeiculo){
            Console.WriteLine("Digite a placa do veiculo para remover:");
            string placaRemove = Console.ReadLine().ToUpper().Trim();
            Veiculo veiculoParaRemover = listVeiculo.FirstOrDefault(veiculo => veiculo.Placa == placaRemove);

            if (veiculoParaRemover != null)
            {
                Console.WriteLine("Digite a quantidade de horas permaneceu estacionado:");
                int hora = Convert.ToInt32(Console.ReadLine());

                int ValorEstacionameto = ValorInicial + (ValorPorHora * hora);
                listVeiculo.Remove(veiculoParaRemover);

                Console.WriteLine("O veículo {0} foi removido e o preço total é de R${1}",placaRemove,ValorEstacionameto);
            }
            else
            {
                Console.WriteLine("Placa não encontrada.");
            }
            menu(); 
        }

        public void listarVeiculos(List<Veiculo> listVeiculo){
            foreach(var i in listVeiculo){
                Console.WriteLine($"{i.Placa}");
            }
            menu(); 
        }
        

    }
}