using RocketTip.Business.ServiceCenter.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RocketTip.Business.ServiceCenter
{
	public class ServiceManager
	{
		private readonly HttpRequestHelper httpRequestHelper;

		public ServiceManager()
		{
			httpRequestHelper = new HttpRequestHelper();
		}
	}
}
