using CsvHelper;

using System.Collections;
using System.Globalization;

namespace Csv_Library
{
    public class CsvEnumerable<T> : IEnumerable<T>
    {
        const string defaultPath = "csv\\test-csv-records.csv";

        private readonly List<T> _collection = new();

        public CsvEnumerable(string path = defaultPath)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            {
                while (csv.Read())
                {
                    _collection.Add(csv.GetRecord<T>());
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
