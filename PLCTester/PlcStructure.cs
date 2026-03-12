using System;
using System.Collections.Generic;
using System.Linq;

namespace PLCTester
{
    public class PlcStructure
    {
        public string Name { get; set; }
        public List<StructField> Fields { get; set; }

        public int? ManualStructSize { get; set; } // Dimensione manuale se diversa da quella calcolata
        public PlcStructure()
        {
            Name = "Struct";
            Fields = new List<StructField>();
        }

        public PlcStructure(string name)
        {
            Name = name;
            Fields = new List<StructField>();
        }

        public void AddField(StructField field)
        {
            if (Fields.Count > 0)
            {
                var lastField = Fields.Last();
                field.Offset = lastField.Offset + lastField.GetSize();

                // Allineamento per Word (Int, DInt, Real su offset pari)
                if ((field.DataType == FieldDataType.Int ||
                     field.DataType == FieldDataType.DInt ||
                     field.DataType == FieldDataType.Real) &&
                    field.Offset % 2 != 0)
                {
                    field.Offset++;
                }
            }
            else
            {
                field.Offset = 0;
            }

            Fields.Add(field);
        }

        public void RemoveField(int index)
        {
            if (index >= 0 && index < Fields.Count)
            {
                Fields.RemoveAt(index);
                RecalculateOffsets();
            }
        }

        public void RecalculateOffsets()
        {
            for (int i = 0; i < Fields.Count; i++)
            {
                if (i == 0)
                {
                    Fields[i].Offset = 0;
                }
                else
                {
                    var prevField = Fields[i - 1];
                    Fields[i].Offset = prevField.Offset + prevField.GetSize();

                    // Allineamento
                    if ((Fields[i].DataType == FieldDataType.Int ||
                         Fields[i].DataType == FieldDataType.DInt ||
                         Fields[i].DataType == FieldDataType.Real) &&
                        Fields[i].Offset % 2 != 0)
                    {
                        Fields[i].Offset++;
                    }
                }
            }
        }

        public int GetTotalSize()
        {
            if (Fields.Count == 0)
                return 0;

            var lastField = Fields.Last();
            return lastField.Offset + lastField.GetSize();
        }

        public int GetActualSize()
        {
            // Se hai impostato una dimensione manuale, usa quella
            if (ManualStructSize.HasValue && ManualStructSize.Value > 0)
                return ManualStructSize.Value;

            // Altrimenti usa quella calcolata
            return GetTotalSize();
        }

        public override string ToString()
        {
            return $"{Name} ({Fields.Count} campi, {GetTotalSize()} byte)";
        }
    }
}