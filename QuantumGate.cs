using System.Numerics;

public class QuantumGate
{
    public Complex[,] Matrix { get; set; }
    public string Name { get; set; }
    public int QubitCount { get; set; }

    public QuantumGate(Complex[,] matrix, string name, int qubitCount)
    {
        Matrix = matrix;
        Name = name;
        QubitCount = qubitCount;
    }

    // Other methods for gate operations
}
