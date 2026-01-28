using MediatR;
using Todo.Features.Todos.DTOs;
using Todo.Features.Todos.Queries.Todo;
using Todo.Features.Todos.Queries.TodoList;

namespace TodoApp.GraphQL
{
    public class Query
    {
        /*private readonly IMediator _mediator;
        public Query(IMediator mediator) => _mediator = mediator;*/

        // Get all todos
        [UseFiltering]  // optional: enable client-side filtering
        [UseSorting]    // optional: enable sorting
        public async Task<IEnumerable<TodoDto>> GetTodos([Service] IMediator mediator) =>
            await mediator.Send(new GetTodoListQuery());

        // Get todo by Id
        public async Task<TodoDto?> GetTodoById(Guid id, [Service] IMediator mediator) =>
            await mediator.Send(new GetTodoByIdQuery(id));
    }
}
