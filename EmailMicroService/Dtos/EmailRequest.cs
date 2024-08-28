namespace EmailService.Dtos
{
    public class EmailRequest
    {
        #region Fields of the email
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        #endregion

        #region Configuration fields
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }
        public string DisplayName { get; set; }
        #endregion
    }
}
