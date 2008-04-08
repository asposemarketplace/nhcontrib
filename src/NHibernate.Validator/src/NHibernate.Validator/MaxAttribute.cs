using System;

namespace NHibernate.Validator
{
	/// <summary>
	/// Max restriction on a numeric annotated element
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	[ValidatorClass(typeof(MaxValidator))]
	public class MaxAttribute : Attribute, IHasMessage
	{
		private string message = "{validator.max}";
		private long value;

		public MaxAttribute()
		{
		}

		public MaxAttribute(long max, string message)
		{
			this.message = message;
			this.value = max;
		}

		public MaxAttribute(long max)
		{
			this.value = max;
		}

		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		public long Value
		{
			get { return value; }
			set { this.value = value; }
		}
	}
}