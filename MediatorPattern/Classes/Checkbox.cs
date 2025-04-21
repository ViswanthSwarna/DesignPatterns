

using MediatorPattern.Interfaces;

namespace MediatorPattern.Classes
{
    public class Checkbox : IComponent
    {
        private IMediator mediator;
        private bool value;
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetValue(bool value)
        {
            this.value = value;
            if (mediator != null)
                mediator.OnChangeCheckBox(value);
        }


    }
}
