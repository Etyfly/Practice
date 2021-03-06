using System.Numerics;
using task_1;

namespace task_4
{
    public interface IIntegrable
    {
        public delegate Fraction Function(Fraction x);

        public Fraction Integrate(Function func, Fraction left, Fraction right, Fraction eps, out BigInteger n);
        public string IntegrateMethod { set; get; }
    }
}