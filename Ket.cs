using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace QuantumModel
{
    public class Ket
    {
        protected Complex[] k;

        public int Dimension{get ;}


        public String Label { get; set; } = "X";

        public Ket(int dimension)
        {
            Dimension = dimension;
            k = new Complex[dimension];
            for (int i = 0; i < dimension; i++)
            {
                k[i] = new Complex(0.0, 0.0);
            }
        }

        public Ket(int dimension, string label) : this(dimension)
        {
            Label = label;
        }

        public Ket(Complex[] array)
        {
            k = array;
            Dimension = array.Length;
        }

        public Ket(Complex[] array, string label)
        {
            Label = label;
            k = array;
            Dimension = array.Length;
        }

        public Complex this[int i]
        {
            get => k[i];
            set => k[i] = value;
        }

        public static Ket operator +(Ket k1, Ket k2)
        {
            var ans = new Ket(k1.Dimension);

            for (int i = 0; i < k1.Dimension; i++)
            {
                ans[i] = k1[i] + k2[i];
            }

            return ans;
        }

        public static Ket operator *(double scalar, Ket k2)
        {
            var ans = new Ket(k2.Dimension);

            for (int i = 0; i < k2.Dimension; i++)
            {
                ans[i] = k2[i] * scalar;
            }

            return ans;
        }

        public override bool Equals(object obj)
        {
            Ket o = (Ket)obj;

            for (int i = 0; i < this.Dimension; i++)
            {
                if (k[i] != o.k[i])
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return 3;
        }

        public string Lbl(string Label)
        {
            return "|" + Label + ">";
        }

        public override string ToString()
        {
                string ans = "|";
                foreach (var item in k)
                {
                    if (item.Imaginary == 0)
                        ans += item.Real + "|\n|";
                    else
                        ans += item.Real + " + " + item.Imaginary + "i" + "|\n|";
                }
                return ans.TrimEnd('|');
        }


    }
}
