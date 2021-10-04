using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Valor enumerodo sendo convertido para string
            string txt = OrderStatus.PendingPayment.ToString();

            //Um valor string convertido para um Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
