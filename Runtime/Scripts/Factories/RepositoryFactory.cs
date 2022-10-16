using System.Collections.Generic;

namespace HereticalSolutions.Repositories.Factories
{
	public static class RepositoryFactory
	{
		public static DictionaryRepository<TKey, TValue> BuildDictionaryRepository<TKey, TValue>()
		{
			return new DictionaryRepository<TKey, TValue>(
				new Dictionary<TKey, TValue>());
		}
	}
}