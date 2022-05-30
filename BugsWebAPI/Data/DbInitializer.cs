using BugsWebAPI.Models;
using System.Linq;

namespace BugsWebAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BugsContext context)
        {
            context.Database.EnsureCreated();

            if (context.UserModels.Any())
            {
                return;
            }
            else
            {
                var users = new UserModel[]
                {
                    new UserModel { Name = "Oliver",   Surname = "Queen"},
                    new UserModel { Name = "Bruce",   Surname = "Lee"},
                    new UserModel { Name = "Jackie",   Surname = "Chang"},
                    new UserModel { Name = "Bruce",   Surname = "Wayne"},
                    new UserModel { Name = "Barry",   Surname = "Allen"},
                };

                foreach (UserModel u in users)
                {
                    context.UserModels.Add(u);
                }
                context.SaveChanges();
            }

            if (context.ProjectModels.Any())
            {
                return;
            }
            else
            {
                var projects = new ProjectModel[]
                {
                    new ProjectModel { Name = "Project1",   Description = "This is the Project Number 1"},
                    new ProjectModel { Name = "Project2",   Description = "This is the Project Number 2"},
                    new ProjectModel { Name = "Project3",   Description = "This is the Project Number 3"},
                    new ProjectModel { Name = "Project4",   Description = "This is the Project Number 4"},
                    new ProjectModel { Name = "Project5",   Description = "This is the Project Number 5"},
                };

                foreach (ProjectModel p in projects)
                {
                    context.ProjectModels.Add(p);
                }
                context.SaveChanges();
            }

        }
    }
}
