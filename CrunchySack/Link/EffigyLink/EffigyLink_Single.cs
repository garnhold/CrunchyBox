namespace Crunchy.Sack
{

    public class EffigyLink_Single : EffigyLink
    {
        private EffigySource_Single single_source;
        private EffigyDestination_Single single_destination;

        protected override void UpdateInternal()
        {
            single_source.Update(delegate(object old_value, object new_value) {
                single_destination.Update(this, old_value, new_value);
            });
        }

        public EffigyLink_Single(CmlExecution execution, EffigySource_Single s, EffigyDestination_Single d, EffigyClassInfo c) : base(execution, s, d, c)
        {
            single_source = s;
            single_destination = d;
        }
    }
}