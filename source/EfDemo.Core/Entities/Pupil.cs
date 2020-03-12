using FluentNHibernate.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDemo.Core.Entities
{
    public class Pupil
    {
       
        public int Id { get; set; }
        public string LastName { get; set; }
       
        public string FirstName { get; set; }
       
        public DateTime BirthDate { get; set; }
      
        public SchoolClass SchoolClass { get; set; }

        public int Age { get => (int)DateTime.Now.Subtract(BirthDate).TotalDays / 365; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, BirthDate: {BirthDate.ToShortDateString()}, SchoolClass: {SchoolClass?.Name}";
    }
}
