using System.Collections.Generic;
using System.Numerics;

public class QuantumCircuit
{
    public List<QuantumGate> Gates { get; set; }
    public int QubitCount { get; private set; }

    public QuantumCircuit(int qubitCount)
    {
        QubitCount = qubitCount;
        Gates = new List<QuantumGate>();
    }

    public void AddGate(QuantumGate gate)
    {
        if (gate.QubitCount <= QubitCount)
        {
            Gates.Add(gate);
        }
        else
        {
            throw new System.Exception("Gate requires more qubits than available.");
        }
    }

    // Other methods for circuit operations
}
