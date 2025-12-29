using System.Text.Json;

namespace Unikey
{
	public class Settings
	{
		public Size		Size	{get;set;}	= new Size(574, 200);
		public float	Opacity	{get;set;}	= 0.62F;
		public int		Margin	{get;set;}	= 0;

		private string ToJson()
		{
			JsonSerializerOptions options = new JsonSerializerOptions{WriteIndented=true};
			string json = JsonSerializer.Serialize(this, options);
			return json;
		}

		private void FromJson(string json)
		{
			var other = JsonSerializer.Deserialize<Settings>(json);

			this.Margin		= other.Margin;
			this.Opacity	= other.Opacity;
			this.Size		= other.Size;
		}

		public void Save(string fileName)
		{
			string json = this.ToJson();

			using (StreamWriter writer = new StreamWriter(fileName))
			{
				writer.Write(json);
			}
		}

		public void Load(string fileName)
		{
			try
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					string json = reader.ReadToEnd();
					this.FromJson(json);
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
