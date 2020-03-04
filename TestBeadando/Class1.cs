using System;

namespace TestBeadando
{
    class Eloadas
    {
        private bool[,] foglalasok;

        public bool[,] Foglalasok { get => foglalasok; set => foglalasok = value; }

        public Eloadas(int sor, int hely)
        {
            if (sor <= 0 || hely <= 0)
            {
                throw new ArgumentException("valami elromlott");
            }
            this.Foglalasok = new bool[sor, hely];
        }

        public bool Foglal()
        {
            bool lefoglalt = true;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false && lefoglalt)
                    {
                        lefoglalt = false;
                        foglalasok[i, j] = true;
                        break;
                    }
                    if (!lefoglalt) break;
                }
            }
            return !lefoglalt ? true : false;
        }

        public int SzabadHelyek
        {
            get
            {
                int count = 0;
                foreach (var item in this.Foglalasok)
                {
                    if (item == false)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public bool Teli()
        {
            return this.SzabadHelyek == 0 ? true : false;
        }

        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam < 1 || helySzam < 1)
                throw new ArgumentException("valami elromlott");
            return this.Foglalasok[sorSzam - 1, helySzam - 1];
        }
    }
}
