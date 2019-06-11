﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LetUsBringYourHomeStyle.Models
{
    public class RegistrovaniKorisnik:SistemskiKorisnik, IObserver
    {
        [ScaffoldColumn(false)]
        public int RegistrovaniKorisnikID { get; set; }
        [Required]
        public string ime;
        [Required]
        public string prezime;
        [Required]
        public string idPopust;
        [Required]
        public DateTime datumRodjenja;
        [Required]
        public string adresa;
        [Required]
        public string grad;
        [Required]
        public homeStyle homes;
        [Required]
        public string stanje;



        public RegistrovaniKorisnik(string ime, string prezime, string idPopust, DateTime datumRodjenja, string adresa, string grad, homeStyle homes)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.idPopust = idPopust;
            this.datumRodjenja = datumRodjenja;
            this.adresa = adresa;
            this.grad = grad;

            this.homes = homes;
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;

            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;

            }
        }
        public string IdPopust
        {
            get
            {
                return idPopust;
            }
            set
            {
                idPopust
 = value;

            }
        }
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                datumRodjenja = value;

            }
        }
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                adresa
 = value;

            }
        }
        public string Grad
        {
            get
            {
                return grad;
            }
            set
            {
                grad
 = value;

            }
        }
        public homeStyle Homes
        {
            get
            {
                return homes;
            }
            set
            {
                homes = value;

            }
        }

        public RegistrovaniKorisnik(homeStyle subjekt, string ime, string prezime, string idPopust, DateTime datum, string adresa, string grad)
        {
            this.homes = subjekt;
            this.ime = ime;
            this.prezime = prezime;
            this.idPopust = idPopust;
            this.datumRodjenja = datum;
            this.adresa = adresa;
            this.grad = grad;
            subjekt.Obavijesti += Azuriraj; 
            
 }
        public void Azuriraj(string subjektStanje)
        {
            stanje = subjektStanje;
            Console.WriteLine(ime + "-" + stanje);
        }



    }
}
