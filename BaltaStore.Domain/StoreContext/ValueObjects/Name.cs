using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(
                new ValidationContract()
                    .Requires()
                    .HasMinLen(FirstName, 3, "FirstName", "O primeiro nome deve conter pelo menos 3 caracteres")
                    .HasMaxLen(FirstName, 40, "FirstName", "O primeiro nome deve conter no máximo 40 caracteres")
                    .HasMinLen(LastName, 3, "LastName", "O último nome deve conter pelo menos 3 caracteres")
                    .HasMaxLen(LastName, 40, "LastName", "O último nome deve conter no máximo 40 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
