# Exercise
- Create a data tests project for UserGroup.Data
  - Add a test that verifies that you can successfully add `Event`s to a to-be-defined `DbContext` object.
- Add reference the following Nuget packages to the `Usergroup.Data` project: `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.Design` & `Microsoft.EntityFrameworkCore.SqlLite`.
- Install the dotnet tool `dotnet-ef` globally
- Create new class called DbContext that derives from Microsoft.EntityFrameworkCore.DbContext
- Add constructor as follows:
    ```
    public DbContext()
        : base(new DbContextOptionsBuilder<DbContext>().UseSqlite("Data Source=main.db").Options)
    {}
    ```
- Add a public property to the `DbContext` class for `Events` of type `DbSet<Event>`
- Create a Userests that you can retrieve the events count

