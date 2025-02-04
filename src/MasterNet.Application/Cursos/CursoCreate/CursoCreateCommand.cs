using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;
using SQLitePCL;

namespace MasterNet.Application.Cursos.CursoCreate;

public class CursoCreateCommand
{
  public record CursoCreateCommandRequest(CursoCreateRequest cursoCreateRequest): IRequest<Guid>;

   
    internal class CursoCreateCommandHandler :
    IRequestHandler<CursoCreateCommandRequest, Guid>
    {
    private readonly MasterNetDbContext _context;

        public CursoCreateCommandHandler(MasterNetDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CursoCreateCommandRequest request, CancellationToken cancellationToken)
        {
            var curso = new Curso
            {
                Id = Guid.NewGuid(),
                Titulo = request.cursoCreateRequest.Titulo,
                Descripcion = request.cursoCreateRequest.Descripcion,
                FechaPublicacion = DateTime.Now
            };
            
            _context.Add(curso);
            await _context.SaveChangesAsync();

            return curso.Id;
        }
    }
}