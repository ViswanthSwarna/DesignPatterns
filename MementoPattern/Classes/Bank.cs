

namespace MementoPattern.Classes
{
    public class Bank
    {
        private string Name;
        private string AccountNumber;
        private string PanCard;
        private string PhoneNumber;
        private string EmailId;

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetAccountNumber(string accountNumber)
        {
            AccountNumber = accountNumber;

        }

        public void SetPanCard(string panCard)
        {
            PanCard = panCard;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public void SetEmailId(string emailId)
        {
            EmailId = emailId;
        }
        public void CreateAccount()
        {
            Console.WriteLine($"name: {Name},account number: {AccountNumber},pan card: {PanCard},phone number: {PhoneNumber}, emailId: {EmailId}");
        }

        public Memento CreateSnapshot() 
        {
            return new Memento(Name,AccountNumber,PanCard,PhoneNumber,EmailId);
        }

        public void RestoreSnapshot(Memento memento)
        {
            this.Name = memento.GetName();
            this.AccountNumber = memento.GetAccountNumber();
            this.PanCard = memento.GetPanCard();
            this.PhoneNumber = memento.GetPhoneNumber();
            this.EmailId = memento.GetEmailId();
        }

        
    }

    public class Memento
    {
        private string Name;
        private string AccountNumber;
        private string PanCard;
        private string PhoneNumber;
        private string EmailId;

        public Memento(string Name, string AccountNumber, string PanCard, string PhoneNumber,
                      string EmailId)
        {
            this.Name = Name;
            this.AccountNumber = AccountNumber;
            this.PanCard = PanCard;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetAccountNumber()
        {
            return AccountNumber;

        }

        public string GetPanCard()
        {
            return PanCard;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public string GetEmailId()
        {
            return EmailId;
        }
    }
}
