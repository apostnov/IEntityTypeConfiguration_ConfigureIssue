using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEntityTypeConfiguration_ConfigureIssue
{
    public class User : IEntityTypeConfiguration<User>
    {
        public User(string name)
        {
            Name = name;
        }
        
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public void Configure(EntityTypeBuilder<User> user)
        {
            user.HasIndex(x => x.Name);
        }
    }
}
