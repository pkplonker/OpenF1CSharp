### Features

- C# Client Library for OpenAI;
- 1:1 Mapping with available data;
- Easy builder pattern query construction
- Data objects for each query

#### Utilises
- [Openf1](https://github.com/br-g/openf1)
- [NewtonSoftJson](https://www.newtonsoft.com/json)
# OpenF1CSharp

```csharp

var rawData = await openF1Reader.Query(new CarQuery()
    .Filter(nameof(CarData.DriverNumber), 55)
    .Filter(nameof(CarData.SessionKey), 9159)
    .Filter(nameof(CarData.Speed), 315, ComparisonOperator.GreaterThanOrEqual)
    .Filter(nameof(CarData.Date), new DateTime(2023, 9, 15, 13, 35, 41), ComparisonOperator.GreaterThanOrEqual)
    .GenerateQuery());
List<LapData> lapData = JsonConvert.DeserializeObject<List<LapData>>(rawData);
```
