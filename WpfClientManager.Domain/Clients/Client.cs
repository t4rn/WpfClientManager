using System;

namespace WpfClientManager.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMarried { get; set; }
    }
}
