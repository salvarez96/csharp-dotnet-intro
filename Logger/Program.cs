ILogger ConsoleLogger = new ConsoleLogger();
ILogger FileLogger = new FileLogger();
ILogger HybridLogger = new HybridLogger();

ConsoleLogger.Log("Message in console");
FileLogger.Log("Message in file");
HybridLogger.Log("Message in console and file");
