using System;

namespace CsTrainings.CS6
{
    public class ReadOnlyProperties
    {
        public ReadOnlyProperties(Guid id)
        {
            ReadOnly = id;
        }

        public Guid ReadOnly { get; }
        public string WithInitializer { get; } = "Value";
        public int InitializerFromMethod { get; } = GetDefault();
        public string Property { get; set; } = "DefaultValue";

        private static int GetDefault()
        {
            return 1;
        }
    }
}