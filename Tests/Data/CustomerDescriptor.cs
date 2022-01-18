namespace Tests.Data
{
    public interface ICustomerDescriptor
    {
        string Name { get; }
        bool IsVip { get; }
        string Write();
    }
    public class CustomerDescriptor : ICustomerDescriptor
    {
        public string Name { get; }
        public bool IsVip { get; }

        public CustomerDescriptor(string name, bool isVip)
        {
            Name = name;
            IsVip = isVip;
        }

        public string Write()
        {
            return Name;
        }
    }
}
