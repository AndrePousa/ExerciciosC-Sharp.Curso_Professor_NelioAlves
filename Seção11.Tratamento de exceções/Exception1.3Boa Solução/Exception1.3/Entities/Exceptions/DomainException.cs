﻿using System;

namespace Exception1._3.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }       
    }  
}
