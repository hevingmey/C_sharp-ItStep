
// dotnet add package Microsoft.Extensions.Logging
// dotnet add package Microsoft.Extensions.Logging.Console
 
using Microsoft.Extensions.Logging;

class Program
{
    static void Main()
    {
        // Створюємо фабрику логгерів
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            // Встановлюємо мінімальний рівень логування
            // Усе, що нижче Information (Debug, Trace), ігнорується
            builder.SetMinimumLevel(LogLevel.Information);

            // Додаємо вивід логів у консоль
            builder.AddConsole();
        });

        // Створюємо логгер, прив’язаний до класу Program
        ILogger logger = loggerFactory.CreateLogger<Program>();

        // Запис інформаційного повідомлення
        logger.LogInformation("Приложение запущено");

        // Запис попередження
        logger.LogWarning("Это предупреждение");

        // Запис повідомлення про помилку
        logger.LogError("Ошибка!");
    }
}