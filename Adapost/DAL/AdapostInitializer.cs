using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Adapost.Models;

// adaugam date in DB in cazul in care nu se introduc altele
namespace Adapost.DAL
{
    public class AdapostInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AdapostContext>
    {
        protected override void Seed(AdapostContext context)
        {
            var angajati = new List<Angajati>
        {
            new Angajati {Nume="Coroian", Prenume="Mircea", NrTel="0740786425", Adresa="Str. Mihai nr 6"},
            new Angajati {Nume="Costescu", Prenume="Petrut", NrTel="0740986425", Adresa="Str. Con nr 8"},
        };
            angajati.ForEach(s => context.Angajati.Add(s));
            context.SaveChanges();

            var voluntari = new List<Voluntari>
        {
            new Voluntari {Nume="Capus", Prenume="Mircea", NrTel="0740786425", Adresa="Str. Mihai nr 6", Ocupatie="inginer"},
            new Voluntari {Nume="Cristof", Prenume="Miriam", NrTel="0740986425", Adresa="Str. Con nr 8", Ocupatie="economist",},
        };
            voluntari.ForEach(s => context.Vountari.Add(s));
            context.SaveChanges();

            var veterinari = new List<Veterinari>
        {
            new Veterinari {Nume="Marcus", Prenume="Florea",},
            new Veterinari {Nume="Aldea", Prenume="Maria",},
        };
            veterinari.ForEach(s => context.Veterinari.Add(s));
            context.SaveChanges();

            var animal = new List<Animal>
        {
            new Animal {TipAnimal="P", DataNastere=DateTime.Parse("2001-09-01"), Rasa="metis",  },
            new Animal {TipAnimal="C", DataNastere=DateTime.Parse("2001-01-11"), Rasa="metis",  },
        };
            animal.ForEach(s => context.Animal.Add(s));
            context.SaveChanges();

        }
    }
}