using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace models
{
    public class Cilinder : Cirkel
    {
        /* Cilinder
         * -----------------------------------------------------
         * +H : double
         * +Omschrijving : string
         * -----------------------------------------------------
         * +Cilinder()
         * +Cilinder(x: double, y: double, r: double, h: double)
         * +Oppervlakte() : double
         * +Volume() : double
         * +ToonGegevens() : string
         */

        public double _h;
        public string _omschrijving;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        // Property Omschrijving
        // Dit geeft als returnwaarde de waarde.
        // <klassenaam>:coord= (< X >,< Y >) straal<R>, hoogte<H>
        public string Omschrijving
        {
            get { return $"{this.GetType().Name}:coord(<{X}>, <{Y}>)"; }
        }

        public Cilinder(double x, double y, double h, double r) : base(x, y, r)
        {
            H = h;
        }

        public Cilinder() : this(0, 0, 0, 0) { }

        // Methode Oppervlakte()
        // Berekent de oppervlakte van de cilinder.
        // Formule = 2 * π* r² + 2 * π* r * h.
        // Maak in de formule gebruik van de oppervlakte en de omtrek die in de klasse Cirkel is aangemaakt
        public double OppervlakteCilinder()
        {
            double oppervlakte = 2 * Math.PI * Math.Pow(R, 2) * Math.PI * R * H;
            return oppervlakte;
        }

        // Methode Volume()
        // Berekent het volume van de cilinder.
        // Formule = π* r² * h
        // Maak gebruik van de oppervlakte van de cirkel die in de klasse Cirkel is aangemaakt

        public double Volume()
        {
            double volume = Math.PI * Math.Pow(R, 2) * H;
            return Math.Round(volume, 2);
        }

        // Methode ToonGegevens()
        // Geeft de tekstuele voorstelling van het object als volgt:
        // <klassenaam>:coord=(<X>,<Y>) straal <R>, hoogte<H>
        // Oppervlakte: <Oppervlakte>
        // Volume: <Volume>
        // Maak gebruik van de property Omschrijving!
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $"straal <{R}>, hoogte<{H}>\nOmtrek: {Omtrek()}\nOppervlakte: {Oppervlakte()}\nVolume: {Volume()}";
        }
    }
}
