namespace Int.Util
{
    using System;
    using System.Collections.Generic;

    public delegate string NotifyError<T1, T2, T3>(T1 parameter1, T2 parameter2, T3 parameter3);

    /// <summary>
    /// Defines the contract for notifying errors to subscribers.
    /// </summary>
    public interface INotifyError
    {
        event NotifyError<object, NotificationType, string> OnNotifyError;
    }

    [Serializable]
    public enum NotificationType
    {
        Information = 0,
        Warning = 1,
        UIValidationError = 2,
        BusinessError = 3,
        InternalError = 4
    }
}
