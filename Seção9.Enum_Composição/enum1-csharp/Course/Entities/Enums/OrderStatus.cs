namespace Course.Entities.Enums {
    enum OrderStatus : int { //OrderStatus está herdado do tipo int 
        //Atribuindo valores 
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
