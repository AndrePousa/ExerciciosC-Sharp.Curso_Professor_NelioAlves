using Course.Entities.Enums;
using System.Collections.Generic;

namespace Course.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //Tipo WorkerLevel que é o Enum
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Composição == propriedade Department que é do tipo Department. 

        //Tipo Lista, um trabalhador tem varios contratos, representação de varios contratos. 
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); //Instanciação da Lista para obrigar que não seja nula.

        public Worker()
        {
        }

        //Sempre que tenho uma associação para muitos, não incluo a lista no construtor. 
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Recebe um contrato como parametro de entrada. 
        public void AddContract(HourContract contract) //Adicionar um contrato.
        {
            Contracts.Add(contract); // adiciona o contrato que chegou como algumento. 
        }

        public void RemoveContract(HourContract contract) //Remover contrato. 
        {
            Contracts.Remove(contract);
        }

        //Cada contrato representa um objeto
        //Objeto trabalhador está associado com os tres objetos HourContract.
        //Objetos associados entre si. 
        //As variaveis são organizadas em forma de objetos. 
        public double Income(int year, int month) //Operação de ganho $.
        {
            double sum = BaseSalary;
            //Percorrendo a lista de contratos.
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); //TotalValue retorna o valor do contrato. 
                }
            }
            return sum;
        }
    }
}
