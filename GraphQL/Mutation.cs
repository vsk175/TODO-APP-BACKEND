using MediatR;
using Todo.Features.Todos.Commands.AddTodo;
using Todo.Features.Todos.Commands.DeleteTodo;
using Todo.Features.Todos.Commands.UpdateTodo;
using Todo.Features.Todos.DTOs;

namespace TodoApp.GraphQL
{
    public class Mutation
    {
        /*private readonly IMediator _mediator;
        public Mutation(IMediator mediator) => _mediator = mediator;*/

        public async Task<TodoDto> AddTodo(CreateTodoDto dto, [Service] IMediator mediator) =>
            await mediator.Send(new AddTodoItemCommand(dto));

        public async Task<TodoDto?> UpdateTodo(Guid id, string title, [Service] IMediator mediator) =>
            await mediator.Send(new UpdateTodoItemCommand(id, title));

        public async Task<bool> DeleteTodo(Guid id, [Service] IMediator mediator) =>
            await mediator.Send(new DeleteTodoItemCommand(id));
    }
}
