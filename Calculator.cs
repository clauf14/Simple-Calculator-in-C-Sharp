using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDemo
{
    class Calculator
    {
        private double rezultat = 0;

        public Calculator() { }
        public Calculator(double rezultat) 
        {
            this.rezultat = rezultat;
        }

        public double Aduna(double x)
        {
            return rezultat = OperatiiCalculator.Adunare(rezultat, x);
        }

        public double Scade(double x)
        {
            rezultat = OperatiiCalculator.Scadere(rezultat, x);
            return rezultat;
        }

        public double Imparte(double x)
        {
            rezultat = OperatiiCalculator.Impartire(rezultat, x);
            return rezultat;
        }

        public double Inmulteste(double x)
        {
            rezultat = OperatiiCalculator.Inmultire(rezultat, x);
            return rezultat;
        }

        public double SchimbaSemn()
        {
            rezultat = OperatiiCalculator.ChangeNumberSign(rezultat);
            return rezultat;
        }

        public double Radical()
        {
            rezultat = OperatiiCalculator.Sqrt(rezultat);
            return rezultat;
        }

        public double RidicareLaPutere()
        {
            rezultat = OperatiiCalculator.ToPower2(rezultat);
            return rezultat;
        }

        public double UnuImpartit()
        {
            rezultat = OperatiiCalculator.UnuImpartitLa(rezultat);
            return rezultat;
        }

        public void Resetare()
        {
            rezultat = 0;
        }

        

        public double Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }
    }
}
