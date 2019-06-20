using MongoDB.Bson.Serialization.Attributes;

namespace LearnInc.Common.Repository
{
	public class TestDataModel
	{
		[BsonId]
		public int TestId { get; set; }

		[BsonElement("testText")]
		public string TestText { get; set; }
	}
}
