﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class Firma
    {
        private string naziv;
        private string adresa { get; set; }
        private string grad { get; set; }
        private List<Namjestaj> namjestaj;
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
            }
        }
        public List<Namjestaj>Namjestaj
        {
            get
            {
                return namjestaj;
            }
            set
            {
                namjestaj = value;
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
                adresa = value;
            }
        }
        public Firma(string naziv, string adresa, string grad)
        {
            this.naziv = naziv;
            this.adresa = adresa;
            this.grad = grad;
            namjestaj = new List<Namjestaj>();
        }
        public void dodajNamjestaj(Namjestaj n)
        {
            namjestaj.Add(n);
        }
    }
}
