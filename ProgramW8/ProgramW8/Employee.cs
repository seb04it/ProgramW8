
namespace ProgramW8
{
    public class Employee
    {
        //Konstruktor poniżej do Testów
        public Employee(string name)
        {
            this.Name = name;
            this.Surname = "-";
            this.Surname = "-";
        }

        //Konstruktor poniżej do programu ProgramW8
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }


        private List<int> score = new List<int>();
        public int Result { get { return this.score.Sum(); } }
        public void AddPoints(int points)
        {
            this.score.Add(points);
        }
    }
}
