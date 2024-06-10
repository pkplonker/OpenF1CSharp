namespace OpenF1CSharp
{
	public interface IBaseQuery
	{
		
	}
	public abstract class BaseQuery<T>
	{
		protected readonly QueryBuilder<T> QueryBuilder;
		private readonly string DefaultQuery;

		protected BaseQuery(string baseQuery)
		{
			DefaultQuery = baseQuery;
			QueryBuilder = new QueryBuilder<T>(DefaultQuery);
		}

		public void Reset()
		{
			QueryBuilder.Reset(DefaultQuery);
		}

		public string GenerateQuery() => QueryBuilder.Build();

		public BaseQuery<T> Filter<TValue>(string propertyName, TValue value, ComparisonOperator op = ComparisonOperator.Equal)
		{
			QueryBuilder.Filter(propertyName, value, op);
			return this;
		}
	}
}