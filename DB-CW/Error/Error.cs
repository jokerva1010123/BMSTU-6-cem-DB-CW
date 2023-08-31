using System;

namespace Error
{
    #region UserException
    [Serializable]
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string information = "\nПользователь не найден!\n") : base(information) { }
        public UserNotFoundException(Exception inner, string information = "\nПользователь не найден!\n") : base(information, inner) { }
    }
    [Serializable]
    public class WrongLoginException : Exception
    {
        public WrongLoginException(string information = "\nЛогин или пароль не правильно!\n") : base(information) { }
        public WrongLoginException(Exception inner, string information = "Логин или пароль не правильно!\n") : base(information, inner) { }
    }
    [Serializable]
    public class UserExistsException : Exception
    {
        public UserExistsException(string information = "\nЛогин уже существует\n") : base(information) { }
        public UserExistsException(Exception inner, string information = "\nЛогин уже существует\n") : base(information, inner) { }
    }
    #endregion
    #region DataBaseException
    [Serializable]
    public class DataBaseConnectException : Exception
    {
        public DataBaseConnectException(string information = "Не получилось подключиться к Базе данных!\n") : base(information) { }
        public DataBaseConnectException(Exception inner, string information = "Не получилось подключиться к Базе данных!\n") : base(information, inner) { }
    }
    [Serializable]
    public class DataBaseRunErrorException : Exception
    {
        public DataBaseRunErrorException(string information = "Ошибка в БД\n") : base(information) { }
        public DataBaseRunErrorException(Exception inner, string information = "Ошибка в БД\n") : base(information, inner) { }
    }
    #endregion
}
