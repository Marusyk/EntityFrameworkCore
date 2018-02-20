using System;

namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    /// xxx
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class DeleteBebaviorAttribute : Attribute
    {
        /// <inheritdoc />
        public DeleteBebaviorAttribute(DeleteBehavior behavior)
        {
            Behavior = behavior;
        }

        /// <summary>
        /// xx
        /// </summary>
        public DeleteBehavior Behavior { get; }
    }
}
