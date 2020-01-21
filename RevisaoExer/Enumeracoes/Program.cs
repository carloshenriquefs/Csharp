using System;
using Enumeracoes.Entidades;
using Enumeracoes.Entidades.Enums;
namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);


        }
    }
}
