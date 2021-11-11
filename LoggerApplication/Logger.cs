using System;

namespace LoggerApplication
{
    public class Logger
    {
        private string _log;
        private string[] _logArray = new string[1000];

        private static Logger instance;

        private Logger()
        {
        }

        public string[] GetLogArray => _logArray;

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void AddInfo(LogTypes logType, string msg)
        {
            _log = $"{DateTime.Now.ToLongTimeString()}: {logType}: {msg}\n";
            Console.Write(_log);
            for (int i = 0; i < _logArray.Length; i++)
            {
                if (_logArray[i] == null)
                {
                    _logArray[i] = _log;
                    break;
                }
            }
        }
    }
}
