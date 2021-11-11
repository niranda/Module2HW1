namespace LoggerApplication
{
    public class Actions
    {
        private Result _currentResult = new ();
        private Logger _logger;

        public Actions(Logger logger)
        {
            _logger = logger;
        }

        public Result CreateInfoLog()
        {
            _logger.AddInfo(LogTypes.Info, "Start method: CreateInfoLog");
            _currentResult.Status = true;
            return _currentResult;
        }

        public Result CreateWarningLog()
        {
            _logger.AddInfo(LogTypes.Warning, "Skipped logic in method: CreateWarningLog");
            _currentResult.Status = true;
            return _currentResult;
        }

        public Result CreateErrorLog()
        {
            _currentResult.Status = false;
            _currentResult.Msg = "I broke a logic";
            return _currentResult;
        }
    }
}
