using System;
using System.IO;

namespace LoggerApplication
{
    public class Starter
    {
        private Random _randomNum = new ();
        private int _value;
        private Result _result = new ();
        private Logger _logger = Logger.GetInstance();
        private Actions _action;
        public Starter()
        {
            _action = new Actions(_logger);
        }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                _value = _randomNum.Next(0, 3);
                switch (_value)
                {
                    case 0:
                        _result = _action.CreateInfoLog();
                        break;
                    case 1:
                        _result = _action.CreateWarningLog();
                        break;
                    case 2:
                        _result = _action.CreateErrorLog();
                        break;
                }

                if (!_result.Status)
                {
                    _logger.AddInfo(LogTypes.Error, $"Action failed by a reason: {_result.Msg}");
                }
            }

            File.WriteAllText("log.txt", string.Join(" ", _logger.GetLogArray));
        }
    }
}
