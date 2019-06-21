using System.Collections.Generic;
using MongoDB.Driver;

namespace LearnInc.Common.Repository
{
	public class TestStore: ITestStore
	{
		private IMongoDatabase _db;

		protected IMongoCollection<TestDataModel> TestsCollection
		{
			get { return _db.GetCollection<TestDataModel>("tests"); }
		}

		public IEnumerable<TestDataModel> Tests
		{
			get { return TestsCollection.Find(test => true).ToList(); }
		}

		public TestStore()
		{
			// move to separate source
			string connectionString = "mongodb://localhost:27017/TestDb";

			MongoUrlBuilder connection = new MongoUrlBuilder(connectionString);
			MongoClient client = new MongoClient(connectionString);

			this._db = client.GetDatabase(connection.DatabaseName);
		}
	}
}
