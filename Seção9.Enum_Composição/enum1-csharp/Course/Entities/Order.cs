using System;
using Course.Entities.Enums;

namespace Course.Entities { 
    class Order { //classe pedido 

        public int Id { get; set; }
        public DateTime Moment { get; set; } //Tipo DateTime
        public OrderStatus Status { get; set; } //OrderStatus == Tipo Enum 

        public override string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
