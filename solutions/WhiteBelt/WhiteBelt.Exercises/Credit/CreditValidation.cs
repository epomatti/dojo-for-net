namespace WhiteBelt.Exercises.Credit
{
    public class CreditValidation
    {

        private int credit;

        public CreditValidation(int credit)
        {
            this.credit = credit;
        }

        public void ValidateOrder(int orderValue)
        {
            if (orderValue < credit)
            {
                throw new InsuficientCreditException($"Insuficient credit: {credit}");
            }
        }
    }
}