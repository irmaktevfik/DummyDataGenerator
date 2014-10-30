using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerator
{
    public class DataGenerator
    {
        public static IExportType GenerateSQLData(List<Dictionary<string, string>> selectedData, int amount, string tableName, bool includeDropCreate, bool includeGuid, bool includeInt)
        {
            return new SQLDataGenerator(selectedData, tableName, amount, includeDropCreate, includeGuid, includeInt) as IExportType;
        }

        public static IExportType GenerateJsonData(List<Dictionary<string, string>> selectedData, int amount)
        {
            return new JSONDataGenerator(selectedData, amount) as IExportType;
        }

        private class SQLDataGenerator : baseClass, IExportType
        {
            public string FileData
            {
                get
                {
                    return fileData;
                }
            }

            private string TableName;
            private string insertIntoString;

            bool includeLocalGuid;
            bool includeLocalInt;

            public SQLDataGenerator(List<Dictionary<string, string>> selectedData, string tableName, int amount, bool includeDropCreate, bool includeGuid, bool includeInt)
            {
                includeLocalGuid = includeGuid;
                includeLocalInt = includeInt;
                TableName = tableName;
                selectedInternalData = selectedData;
                dataAmount = amount;
                PrepareScript(includeDropCreate);
            }

            private void PrepareScript(bool includeDropCreate)
            {
                var distinctSelectedItemKeys = selectedInternalData.SelectMany(p => p).Select(p => p.Key).Distinct();
                if (distinctSelectedItemKeys.Any())
                {
                    itemsKeysArray = distinctSelectedItemKeys.ToArray();
                    if (includeDropCreate)
                        CreateDropCreateScript();
                }
                GenerateInsertLines();
            }

            private void CreateDropCreateScript()
            {
                insertIntoString = "CREATE TABLE [" + TableName + "](";

                if (includeLocalGuid)
                    insertIntoString += "[Id] [UNIQUEIDENTIFIER]," + Environment.NewLine;
                else if (includeLocalInt)
                    insertIntoString += "[Id] [INT]," + Environment.NewLine;

                foreach (var item in itemsKeysArray)
                    insertIntoString += "[" + item + "] VARCHAR(" + selectedInternalData.Where(p => p.Keys.Contains(item)).OrderByDescending(p => p.Values.First().Length).First().Values.First().Length + ") NULL," + Environment.NewLine;
                insertIntoString = insertIntoString.TrimEnd(',') + ")" + Environment.NewLine;

                fileData = insertIntoString;
            }

            private void GenerateInsertLines()
            {
                string insertSqlLine;

                for (int i = 0; i < dataAmount; i++)
                {
                    insertSqlLine = "INSERT INTO " + TableName + "(";

                    if (includeLocalGuid || includeLocalInt)
                        insertSqlLine += "[Id],";

                    foreach (var columnItems in itemsKeysArray)
                        insertSqlLine += "[" + columnItems + "],";
                    insertSqlLine = insertSqlLine.TrimEnd(',') + ")" + Environment.NewLine;

                    insertSqlLine += "VALUES (";

                    if (includeLocalGuid)
                        insertSqlLine += "'" + Guid.NewGuid().ToString() + "',";
                    if (includeLocalInt)
                        insertSqlLine += "'" + (i + 1) + "',";

                    foreach (var innerItemsKey in itemsKeysArray)
                    {
                        var selectData = selectedInternalData.Where(p => p.Keys.Contains(innerItemsKey)).OrderBy(p => Guid.NewGuid()).First().Values;
                        insertSqlLine += "'" + selectData.First().ToString() + "',";
                    }
                    fileData += insertSqlLine.TrimEnd(',') + ")" + Environment.NewLine;
                }

            }
        }

        private class JSONDataGenerator : baseClass, IExportType
        {
            public string FileData
            {
                get
                {
                    return fileData;
                }

            }

            public JSONDataGenerator(List<Dictionary<string, string>> selectedData, int amount)
            {
                selectedInternalData = selectedData;
                dataAmount = amount;
                PrepareScript();
            }

            private void PrepareScript()
            {
                var distinctSelectedItemKeys = selectedInternalData.SelectMany(p => p).Select(p => p.Key).Distinct();
                if (distinctSelectedItemKeys.Any())
                {
                    List<dynamic> dynamicObjects = new List<dynamic>();
                    itemsKeysArray = distinctSelectedItemKeys.ToArray();
                    for (int i = 0; i < dataAmount; i++)
                    {
                        var obj = new System.Dynamic.ExpandoObject() as IDictionary<string,object>;
                        foreach (var columnItems in itemsKeysArray)
                            obj.Add(columnItems.ToString(), selectedInternalData.Where(p => p.Keys.Contains(columnItems)).OrderBy(p => Guid.NewGuid()).First().Values);
                        dynamicObjects.Add(obj);
                    }

                    fileData = Newtonsoft.Json.JsonConvert.SerializeObject(dynamicObjects);
                }
            }
        }

        private class baseClass
        {
            public string[] itemsKeysArray;
            public List<Dictionary<string, string>> selectedInternalData;
            public string fileData;
            public int dataAmount;

        }
    }




}
