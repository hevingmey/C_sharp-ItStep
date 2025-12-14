namespace Lesson_5.NewDirectory1;



    class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }
    }

    class NotEnoughMoneyInATMException : Exception
    {
        public NotEnoughMoneyInATMException(string message) : base(message) { }
    }
