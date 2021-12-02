using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_2
{
    public class Port
    {
        string name;
        string adress;
        Pirce nPirce;
        double costTechnique = 10;
        double costService = 15;
        double timeService = 60; // время обслуживание в минутах


        public Port()
        {
            name = "Name port";
            adress = "Adress port";
        }

        public Port(string _name, string _adress, long _nPirce, long _nWorkers)
        {
            name = _name;
            adress = _adress;
            nPirce.setPirce(_nPirce);

        }
    }

    class Pirce : Port
    {
        long nPirce;
        long nWorkers;
        long nTechnique;

        public Pirce()
        {
            nPirce = 1;
            nTechnique = 5;
        }

        public Pirce(long _nPirce)
        {
            nPirce = _nPirce;
            nTechnique = nPirce * 5;
        }

        public void setPirce(long _nPirce)
        {
            nPirce = _nPirce;
            nTechnique = nPirce * 15;
        }

        public void setWorkers(long _nWorkers)
        {
            if (nPirce > 0)
                if (_nWorkers / nPirce <= 15)
                {
                    nWorkers = _nWorkers;
                }
                else
                {
                    MessageBox.Show("Ошибка! Рабочих больше чем рабочиз мест!");
                }
            else
                MessageBox.Show("Ошибка! Нету пирсов.");
        }
    }

    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
