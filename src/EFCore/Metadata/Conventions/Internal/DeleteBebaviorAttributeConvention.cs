using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal
{
    /// <summary>
    /// xxx
    /// </summary>
    public class DeleteBebaviorAttributeConvention : IForeignKeyAddedConvention, IPropertyNullabilityChangedConvention
    {
        /// <summary>
        /// xxxxx
        /// </summary>
        /// <param name="relationshipBuilder">xxxx</param>
        /// <returns>xxxx</returns>
        public InternalRelationshipBuilder Apply(InternalRelationshipBuilder relationshipBuilder)
        {
            var db = DeleteBehavior.Cascade;
            relationshipBuilder.DeleteBehavior(db, ConfigurationSource.Convention);

            return relationshipBuilder;
        }

        /// <summary>
        /// xxxxxxxx
        /// </summary>
        /// <param name="propertyBuilder">xxxxx</param>
        /// <returns>xxxxx</returns>
        public bool Apply(InternalPropertyBuilder propertyBuilder)
        {
            foreach (var foreignKey in propertyBuilder.Metadata.GetContainingForeignKeys())
            {
                Apply(foreignKey.Builder);
            }

            return true;
        }
    }
}
