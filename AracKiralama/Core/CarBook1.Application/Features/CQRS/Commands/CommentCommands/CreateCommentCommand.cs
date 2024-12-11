using MediatR;

namespace CarBook1.Application.Features.CQRS.Commands.CommentCommands
{
    public class CreateCommentCommand : IRequest
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogID { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}
