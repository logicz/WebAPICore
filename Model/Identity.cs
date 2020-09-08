namespace DiscountAPICore.Model
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class Identity
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
    }
}