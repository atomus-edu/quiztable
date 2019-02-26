#include <iostream>
using namespace std;

// Stay, you don't always know where you stand
// Till you know that you won't run away
// There's something inside me that feels
// Like breathing in sulfur

class Element
{
		int atomicNumber;// 16
		//float atomicWeight;// 32.066
		string symbol;// Pb
		string name;// Sulfur
		int group;// 6
		int period;// 3
		int row;// 3
	public:
		Element();
		Element(int atomicNumber,/*float atomicWeight*/, string symbol, string name, int group, int period, int row)
		{
			this.atomicNumber = atomicNumber;
			//this.atomicWeight = atomicWeight;
			this.symbol = symbol;
			this.name = name;
			this.group = group;
			this.period = period;
			this.row = row;
		}

		int GetAtomicNumber()
		{
			return atomicNumber;
		}
		// float GetAtomicWeight()
		// {
		// 	return atomicWeight;
		// }
		string GetSymbol()
		{
			return symbol;
		}
		string GetName()
		{
			return name;
		}
		int GetGroup()
		{
			return group;
		}
		int GetPeriod()
		{
			return period;
		}
		int GetRow()
		{
			return row;
		}
}