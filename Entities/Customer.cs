namespace Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        

        public Customer(int id, string fname, string lname, string city, string country,string phone)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.City = city;
            this.Country = country;
            this.Phone = phone;
           
        }
    }
}