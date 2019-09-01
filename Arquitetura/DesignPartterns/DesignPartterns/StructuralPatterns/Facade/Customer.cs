namespace DesignPartterns.Facade
{
    public class Customer
    {
        /// <summary>
        /// Customer class
        /// </summary>
        private string _name;

        // Constructor
        public Customer(string name)
        {
            this._name = name;
        }

        // Gets the name
        public string Name
        {
            get { return _name; }
        }
    }
}