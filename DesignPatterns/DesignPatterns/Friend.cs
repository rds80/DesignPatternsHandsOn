namespace MediatorPattern
{
    public abstract class Friend
    {
        protected readonly IMediator mediator;
        public string Name { get; set; }
        public Friend(IMediator mediator) => this.mediator = mediator;

    }
}