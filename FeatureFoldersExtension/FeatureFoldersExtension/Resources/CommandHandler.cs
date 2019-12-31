using MediatR;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("_PROJECT_NAME_.Feature.Tests")]
namespace _NAMESPACE_
{
    internal class CommandHandler : IRequestHandler<Command, Unit>
    {
        private readonly IRepository _repository;

        public CommandHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}