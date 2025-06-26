namespace MyPortfolio.Contracts.Validation;

public interface IValidator<in T>
{
	void Validate(T obj);
}
