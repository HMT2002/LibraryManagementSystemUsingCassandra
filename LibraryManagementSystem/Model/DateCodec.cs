using Cassandra;
using Cassandra.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class DateCodec: TypeSerializer<DateTime>
    {
        private static readonly TypeSerializer<LocalDate> serializer =
     TypeSerializer.PrimitiveLocalDateSerializer;

        public override ColumnTypeCode CqlType
        {
            get { return ColumnTypeCode.Date; }
        }

        public DateCodec() { }

        public override DateTime Deserialize(ushort protocolVersion, byte[] buffer,
             int offset, int length, IColumnInfo typeInfo)
        {
            var result = serializer.Deserialize(protocolVersion, buffer,
                    offset, length, typeInfo);
            return new DateTime(result.Year, result.Month, result.Day);
        }

        public override byte[] Serialize(ushort protocolVersion, DateTime value)
        {
            return serializer.Serialize(protocolVersion,
                new LocalDate(value.Year, value.Month, value.Day));
        }
    }
}
