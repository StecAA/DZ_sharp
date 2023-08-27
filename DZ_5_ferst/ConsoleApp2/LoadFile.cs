using System.IO;

namespace ConsoleApp2
{
    internal static class LoadFile
    {

        public static double Load(string fileName)
        {
            FileStream _fileBufer = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader _binReader = new BinaryReader(_fileBufer);
            double min = double.MaxValue;
            double _bufDouble;
            for (int counter = 0; counter < _fileBufer.Length / sizeof(double); counter++)
            {
                _bufDouble = _binReader.ReadDouble();
                if (_bufDouble < min) min = _bufDouble;
            }
            _binReader.Close();
            _fileBufer.Close();
            return min;
        }
    }
}