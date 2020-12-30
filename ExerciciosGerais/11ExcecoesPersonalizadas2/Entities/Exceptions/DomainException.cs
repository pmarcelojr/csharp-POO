using System;

namespace _11ExcecoesPersonalizadas2.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}