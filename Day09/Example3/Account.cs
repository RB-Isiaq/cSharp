namespace Example3
{
    public class Account
    {
        private string? code;
        private string? type;

        public string Type 
        {
            set 
            {
            
                type = value;
            }
            get 
            {
                return type;
            }
        }

        public string Code 
        {
            get 
            {
                return code;
            }
            set 
            {
                code = value;
            } 
        }
    }
}