using System;

namespace PLCTester
{
    public class StructField
    {
        public string Name { get; set; }
        public FieldDataType DataType { get; set; }
        public int Length { get; set; } // Solo per String
        public int Offset { get; set; } // Calcolato automaticamente

        public StructField()
        {
            Name = "";
            DataType = FieldDataType.Int;
            Length = 0;
            Offset = 0;
        }

        public StructField(string name, FieldDataType dataType, int length = 0)
        {
            Name = name;
            DataType = dataType;
            Length = length;
            Offset = 0;
        }

        public int GetSize()
        {
            switch (DataType)
            {
                case FieldDataType.Bool:
                    return 1;
                case FieldDataType.Byte:
                    return 1;
                case FieldDataType.Int:
                    return 2;
                case FieldDataType.DInt:
                    return 4;
                case FieldDataType.Real:
                    return 4;
                case FieldDataType.String:
                    return Length + 2;
                default:
                    return 0;
            }
        }

        public override string ToString()
        {
            if (DataType == FieldDataType.String)
                return $"{Name} (String[{Length}])";
            else
                return $"{Name} ({DataType})";
        }
    }

    public enum FieldDataType
    {
        Bool,
        Byte,
        Int,
        DInt,
        Real,
        String
    }
}