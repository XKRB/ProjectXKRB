namespace API.General.Classes;

public class Logger
{
    /// <summary>
    /// Levels of log importance
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Informative logs
        /// </summary>
        Info,
        /// <summary>
        /// Logs that may require attention
        /// </summary>
        Warning,
        /// <summary>
        /// Important logs from errors
        /// </summary>
        Error
    }

    /// <summary>
    /// Determines if logs output to console
    /// </summary>
    public static bool LogOnConsole = true;

    /// <summary>
    /// Determines if logs output to txt file
    /// </summary>
    public static bool LogOnTxtFile = true;

    /// <summary>
    /// Logs information
    /// </summary>
    /// <param name="logInformation"></param>
    public static void LogError(LogInformation logInformation)
    {
        string path = "./Logs/error_log_" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";

        Log(logInformation, path, ConsoleColor.Red);
    }

    /// <summary>
    /// Logs error from an exception
    /// </summary>
    /// <param name="action"></param>
    /// <param name="exception"></param>
    public static void LogUnexpectedError(string action, Exception exception)
    {
        LogInformation information = new LogInformation("Unexpected Error", string.Format("Unexpected error occured while {0}.", action), ExceptionInfo(exception));
        LogError(information);
    }

    /// <summary>
    /// Logs warning
    /// </summary>
    /// <param name="logInformation"></param>
    public static void LogWarning(LogInformation logInformation)
    {
        string path = "./Logs/warning_log_" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";

        Log(logInformation, path, ConsoleColor.Yellow);
    }

    /// <summary>
    /// Logs any data into a file
    /// </summary>
    /// <param name="logInformation"></param>
    /// <param name="path"></param>
    /// <param name="color"></param>
    private static void Log(LogInformation logInformation, string path, ConsoleColor color)
    {
        ConsoleColor originalColor = Console.ForegroundColor;

        Console.ForegroundColor = color;

        using (StreamWriter sw = File.AppendText(path))
        {
            CreateHeader(sw, logInformation.Name, logInformation.Description);

            foreach (string line in logInformation.Information)
            {
                if (LogOnTxtFile)
                {
                    sw.WriteLine(line);
                }

                if (LogOnConsole)
                {
                    Console.WriteLine(line);
                }
            }

            if (LogOnTxtFile)
            {
                sw.WriteLine(CreateSeparator());
            }

            if (LogOnConsole)
            {
                Console.WriteLine(CreateSeparator());
            }
        }

        Console.ForegroundColor = originalColor;
    }

    /// <summary>
    /// Logs simple information
    /// </summary>
    /// <param name="logInformation"></param>
    public static void LogInformation(LogInformation logInformation)
    {
        string path = "./Logs/info_log_" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";

        Log(logInformation, path, ConsoleColor.White);

    }

    /// <summary>
    /// Logs data in a particular log level
    /// </summary>
    /// <param name="logInformation"></param>
    /// <param name="level"></param>
    public static void Log(LogInformation logInformation, LogLevel level)
    {
        if (level == LogLevel.Error)
        {
            LogError(logInformation);
        }

        if (level == LogLevel.Warning)
        {
            LogWarning(logInformation);
        }

        if (level == LogLevel.Info)
        {
            LogInformation(logInformation);
        }
    }

    /// <summary>
    /// Created the header of the log
    /// </summary>
    /// <param name="sw"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    private static void CreateHeader(StreamWriter sw, string name, string description)
    {
        string dateRow = DateTime.Now.ToString("dd.MM.yyyy - HH:mm:ss.fffffff");
        string nameRow = "Name: " + name;
        string descriptionRow = "Description: " + description;

        if (LogOnTxtFile)
        {
            sw.WriteLine(dateRow);
            sw.WriteLine(nameRow);
            sw.WriteLine(descriptionRow);
        }

        if (LogOnConsole)
        {
            Console.WriteLine(dateRow);
            Console.WriteLine(nameRow);
            Console.WriteLine(descriptionRow);
        }
    }

    /// <summary>
    /// Simple separator
    /// </summary>
    /// <returns></returns>
    private static string CreateSeparator() => "----------------------------------------------------------------";

    /// <summary>
    /// Obtains the information to log from an exception
    /// </summary>
    /// <param name="exception"></param>
    /// <returns></returns>
    public static string[] ExceptionInfo(Exception exception)
    {
        List<string> exceptionInfo = new List<string>
            {
                "Exception information:",
                "Exception message: " + exception.Message
            };

        Exception current = exception;
        string indent = "";

        while (current.InnerException != null)
        {
            indent += "    ";
            exceptionInfo.Add(indent + "Internal exception message: " + current.InnerException.Message);
            current = current.InnerException;
        }

        exceptionInfo.Add("Stack Trace:");
        exceptionInfo.Add(exception.StackTrace);

        return exceptionInfo.ToArray();
    }

    /// <summary>
    /// Text when some configuration value was not found
    /// </summary>
    /// <param name="keyValue"></param>
    /// <returns></returns>
    public static string MissingConfigurationValueInfo(string keyValue) => string.Format("Environment variable or secret {0} was not found", keyValue);
}

