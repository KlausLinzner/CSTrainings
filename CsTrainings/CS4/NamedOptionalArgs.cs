namespace CsTrainings.CS4
{
    public class NamedOptionalArgs
    {
        public void Drive(int persons = 1, bool fast = true, bool safe = false)
        {
            //Do stuff
        }

        public void Use()
        {
            Drive();
            Drive(safe: true);
        }
    }
}