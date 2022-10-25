namespace _03_Prototype.Abstract
{
    public abstract class Person
    {
        public abstract Person Clone();

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}