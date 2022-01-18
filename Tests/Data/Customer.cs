namespace Tests.Data
{
    public interface ICustomer
    {
        ICustomerDescriptor Descriptor { get; }
        string Write();
    }

    public class Customer : ICustomer
    {
        public ICustomerDescriptor Descriptor { get; }

        public Customer(ICustomerDescriptor descriptor)
        {
            Descriptor = descriptor;
        }

        public string Write()
        {
            return Descriptor.Write();
        }
    }
}
