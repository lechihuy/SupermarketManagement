using CoreBusiness;

namespace UseCases.UseCaseInterface
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}