namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    {
        //propriedade nova
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        //construtor que herda atributos da superclasse.
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //função sobrescrita que veia da superclasse
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
