using DataAccessLayer;

public class Customer
{
    private readonly IRepository _repository;

    public Customer(IRepository repository)
    {
        _repository = repository;
    }

    public void Save()
    {
        _repository.Save();
    }
}

public class Supplier
{
    private readonly IRepository _repository;

    public Supplier(IRepository repository)
    {
        _repository = repository;
    }

    public void Save()
    {
        _repository.Save();
    }
}
