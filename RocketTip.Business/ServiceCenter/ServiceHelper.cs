using Newtonsoft.Json;
using RocketTip.Business.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketTip.Business.ServiceCenter
{
	public class ServiceHelper
	{
		private static string _serviceUrl = Constants.BASE_URL;

		public static string ServiceUrl
		{
			get
			{
				return _serviceUrl;
			}
			set
			{
				_serviceUrl = value;
			}
		}

		public static T GetResponse<T>(string response, ref bool authenticated)
		{
			T data = default(T);
			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Ignore
			};
			try
			{
				if (!response.Contains("401 (Unauthorized)"))
				{
					data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(response, settings);
					authenticated = true;
				}
				else
				{
					authenticated = false;
				}
			}
			catch (Exception ex)
			{
				//Crashes.TrackError(ex);
			}
			return data;
		}
	}
}
