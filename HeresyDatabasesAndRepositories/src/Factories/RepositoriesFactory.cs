using System;
using System.Collections.Generic;

namespace HereticalSolutions.Repositories.Factories
{
	public static partial class RepositoriesFactory
	{
		public static DictionaryObjectRepository BuildDictionaryObjectRepository()
		{
			return new DictionaryObjectRepository(
				BuildDictionaryRepository<Type, object>());
		}
		
		public static DictionaryRepository<TKey, TValue> BuildDictionaryRepository<TKey, TValue>()
		{
			return new DictionaryRepository<TKey, TValue>(
				new Dictionary<TKey, TValue>());
		}
		
		public static DictionaryRepository<TKey, TValue> CloneDictionaryRepository<TKey, TValue>(
			)
		{
			return new DictionaryRepository<TKey, TValue>(
				new Dictionary<TKey, TValue>());
		}
	}
}