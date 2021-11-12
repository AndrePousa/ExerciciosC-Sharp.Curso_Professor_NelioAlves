namespace Course.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //virtual == libera a função para que ela possa ser sobrescrita pelas subclasses.
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
