using System;
using System.Windows.Media;
using Caliburn.Micro;
using Zombicide.Business.Exception;
using Zombicide.Business.Information;
using Action = System.Action;
using ILog = Common.Logging.ILog;
using LogManager = Common.Logging.LogManager;

namespace Zombicide.Extensions
{
    public static class ScreenExtensions
    {
        private static readonly Lazy<ILog> _logger = new Lazy<ILog>(() => LogManager.GetLogger("Zombicide"));
        private static readonly Lazy<IWindowManager> _windowManager = new Lazy<IWindowManager>(() => IoC.Get<IWindowManager>());

        public static ILog Logger => _logger.Value;
        public static IWindowManager WindowManager => _windowManager.Value;

        public static void SafeExecute(this Screen @this, Action method, Action @finally = null)
        {
            try
            {
                method();
            }
            catch (Exception e)
            {
                HandleException(e);
            }
            finally
            {
                @finally?.Invoke();
            }
        }

        private static void HandleNotImplementedException(NotImplementedException e)
        {
            Logger.Error(e);
            var exceptionVm = IoC.Get<InformationViewModel>();
            if (exceptionVm != null)
            {
                exceptionVm.Initialize(e.Message);
                WindowManager.ShowDialog(exceptionVm);
            }
        }

        public static void HandleException(Exception e)
        {
            Execute.BeginOnUIThread(() =>
            {
                Logger.Error(e);

                var notImplementedException = e as NotImplementedException;
                if (notImplementedException != null)
                {
                    HandleNotImplementedException(notImplementedException);
                    return;
                }

                var exceptionVm = IoC.Get<ExceptionViewModel>();

                if (exceptionVm != null)
                {
                    exceptionVm.Initialize(e);
                    WindowManager.ShowDialog(exceptionVm);
                }
            });

        }
    }

}