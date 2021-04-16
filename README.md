# IEntityTypeConfiguration_ConfigureIssue

Solution contains 2 equal console application (which I have never run though, compile only).

The only difference is that IEntityTypeConfiguration_ConfigureIssue project has User model with parametrized constructor and other has not. Both of them have

user.HasIndex(x => x.Name);
in their Configure()

The dotnet ef migrations add Initial produces different migrations in each console project. Ok one with migrationBuilder.CreateIndex() and other without.
