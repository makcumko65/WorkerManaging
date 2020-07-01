using MediatR;

namespace Domain.Common
{
    public abstract class QueryBase<TResult> : IRequest<TResult> where TResult : class
    {

    }
}
