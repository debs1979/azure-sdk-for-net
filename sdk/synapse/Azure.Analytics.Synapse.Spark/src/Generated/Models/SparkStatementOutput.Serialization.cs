// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkStatementOutput
    {
        internal static SparkStatementOutput DeserializeSparkStatementOutput(JsonElement element)
        {
            string status = default;
            int executionCount = default;
            object data = default;
            string ename = default;
            string evalue = default;
            IReadOnlyList<string> traceback = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("execution_count"))
                {
                    executionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    data = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("ename"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evalue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evalue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("traceback"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    traceback = array;
                    continue;
                }
            }
            return new SparkStatementOutput(status, executionCount, data, ename, evalue, traceback);
        }
    }
}
