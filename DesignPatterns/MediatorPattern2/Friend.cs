namespace MediatorPattern2
{
    public class Friend
    {
        protected IMediator mediator;
        private string name;
        private string status;

        public string Name { get; internal set; }
        public string Status { get; set; }

        public Friend(IMediator mediator) => this.mediator = mediator;
    }
}