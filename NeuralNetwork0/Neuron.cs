using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork0
{
    public class Neuron
    {
        public bool guess;
        public float[] weight;
        public Form1 form;
        public Neuron(int N)
        {
            weight = new float[N];            
        }

        public void SaveWeight()
        {
            StreamWriter save = new StreamWriter($"Weight.txt");
            for (int i = 0; i < weight.Length; i++)
            {
                save.WriteLine(weight[i]);
            }
            save.Close();
        }

        public void LoadWeight()
        {
            StreamReader load = new StreamReader($"Weight.txt");
            for (int i = 0; i < weight.Length; i++)
            {
                weight[i] = Convert.ToSingle(load.ReadLine());
            }
            load.Close();
        }

        public void ChangeWeight(float Alpha, int[] X)
        {
            int length = X.Length;
            for (int i = 0; i < length; i++)        
            {
                if (X[i] == 1)                      
                {
                    if (guess)
                        weight[i] -= Alpha;
                    else
                        weight[i] += Alpha;
                }
            }
        }

        public void Check(int[] X)
        {
            float s = 0;
            int length = X.Length;
            for (int i = 0; i < length; i++)
            {
                if (X[i] == 1) 
                {
                    s += weight[i];
                }
            }
            guess = s >= 0;
        }

    }
}
