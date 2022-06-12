using System;
using WinFormMVP.Model.Interface;

namespace WinFormMVP.Model
{
    public class CirculoModel : ICirculoModel
    {
        public CirculoModel() { }
        public double GetArea(double raio)
        {
            return Math.PI * raio * raio;
        }
    }
}
