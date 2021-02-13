using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureApp.Application.Exceptions
{
    public class ValidationException: Exception
    {

        public ValidationException(): this("Validation error occured")
        {
                
        }

        public ValidationException(String Message): base(Message)
        {

        }

        public ValidationException(Exception ex) : base(ex.ToString())
        {

        }
    }
}
