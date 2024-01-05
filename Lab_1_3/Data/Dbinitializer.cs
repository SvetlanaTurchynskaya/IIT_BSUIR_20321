namespace Lab_1.Data
{
    public static class Dbinitializer
    {
        public static void Populate(WebApplication app) // метод, который запишет данные в бд
        { 
        using var scope = app.Services.CreateScope(); // из scope мы можем получить контекст бд
            using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.EnsureDeleted(); // чтобы не внесли оно будет уничтожаться при следующем запуске
            context.Database.EnsureCreated();
        }
    }
}
